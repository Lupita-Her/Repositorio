using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Repositorio
{
    public partial class test : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        private List<(string nombre, decimal precio)> productosSeleccionados = new List<(string, decimal)>(); // Lista para almacenar productos seleccionados
        public test()
        {
            InitializeComponent();
            // printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }
        private void CargarMarcas()
        {
            try
            {
                // Consulta para obtener todas las marcas de la tabla tbProductos
                string query = "SELECT DISTINCT marca FROM tbProductos";

                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.db_CRUMARConnectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dtMarcas = new DataTable();
                    adapter.Fill(dtMarcas);

                    // Llenar el ComboBox con las marcas disponibles
                    cbMarca.DataSource = dtMarcas;
                    cbMarca.DisplayMember = "marca";  // Mostramos la columna "marca"
                    cbMarca.SelectedIndex = -1; // Sin selección inicial
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las marcas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void test_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar datos en el DataGridView
                this.tbProductosTableAdapter.Fill(this.db_CRUMARDataSet1.tbProductos);

                // Deshabilitar edición en el DataGridView
                dgvProducts.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                // Cargar las marcas disponibles en el ComboBox
                CargarMarcas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las marcas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FiltrarProductos()
        {
            try
            {
                string query = string.Empty;
                DateTime fechaActual = DateTime.Now;

                if (cbCaducidad.SelectedItem.ToString() == "Próximos a caducar")
                {
                    // Filtrar productos cuya fecha de caducidad esté dentro de los próximos 7 días
                    query = "SELECT codigoBarras, nombre, marca, precioVenta, fechaCaducidad " +
                           "FROM tbProductos WHERE fechaCaducidad > @fechaActual";
                }
                else if (cbCaducidad.SelectedItem.ToString() == "Caducados") // Cambié la opción a "Caducados"
                {
                    // Filtrar productos cuya fecha de caducidad ya haya pasado
                    query = "SELECT codigoBarras, nombre, marca, precioVenta, fechaCaducidad " +
                            "FROM tbProductos WHERE fechaCaducidad < @fechaActual"; // Cambié la condición para los productos caducados
                }

                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.db_CRUMARConnectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@fechaActual", fechaActual);
                    adapter.SelectCommand.Parameters.AddWithValue("@fechaLimite", fechaActual.AddDays(7)); // Próximos 7 días

                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "tbProductos");

                    // Asignar los resultados al DataGridView
                    dgvProducts.DataSource = ds;
                    dgvProducts.DataMember = "tbProductos";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Aplicar el filtro seleccionado en el ComboBox y actualizar el DataGridView
                FiltrarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aplicar el filtro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechas_Click(object sender, EventArgs e)
        {
            try
            {
                // Mostrar las fechas de caducidad de todos los productos en el DataGridView
                string query = "SELECT codigoBarras, nombre, marca, precioVenta, fechaCaducidad FROM tbProductos";

                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.db_CRUMARConnectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "tbProductos");

                    // Asignar los resultados al DataGridView
                    dgvProducts.DataSource = ds;
                    dgvProducts.DataMember = "tbProductos";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las fechas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si se ha seleccionado una marca
                if (cbMarca.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, selecciona una marca", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Filtrar los productos por la marca seleccionada
                FiltrarProductosPorMarca();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FiltrarProductosPorMarca()
        {
            try
            {
                // Usamos Text para obtener el valor de la marca seleccionada
                string marcaSeleccionada = cbMarca.Text;

                string query = "SELECT codigoBarras, nombre, marca, existencia FROM tbProductos WHERE marca = @marca";

                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.db_CRUMARConnectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@marca", marcaSeleccionada);

                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "tbProductos");

                    // Depuración: imprimir las columnas recuperadas
                    foreach (DataColumn col in ds.Tables["tbProductos"].Columns)
                    {
                        Console.WriteLine($"Columna recuperada: {col.ColumnName}");
                    }

                    // Configurar el DataGridView
                    dgvProducts.AutoGenerateColumns = true;
                    dgvProducts.DataSource = ds;
                    dgvProducts.DataMember = "tbProductos";

                    // Llamar al método para aplicar colores según la existencia
                    ColorearStock();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ColorearStock()
        {
            try
            {
                // Recorrer cada fila del DataGridView y aplicar el color según la existencia
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    // Verificar si la celda 'existencia' tiene un valor válido
                    if (row.Cells["existencia"].Value != DBNull.Value && row.Cells["existencia"].Value != null)
                    {
                        int existencia = Convert.ToInt32(row.Cells["existencia"].Value);

                        // Aplicar colores según la existencia
                        if (existencia == 0)
                        {
                            // Color rojo para productos agotados
                            row.DefaultCellStyle.BackColor = Color.Red;
                        }
                        else if (existencia < 5)
                        {
                            // Color naranja para productos con pocas existencias
                            row.DefaultCellStyle.BackColor = Color.Orange;
                        }
                        else
                        {
                            // Color verde para productos con más de 5 existencias
                            row.DefaultCellStyle.BackColor = Color.Green;
                        }
                    }
                    else
                    {
                        // Si la celda 'existencia' está vacía, aplicar un color gris para indicar que hay un problema
                        row.DefaultCellStyle.BackColor = Color.Gray;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aplicar los colores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si se ha seleccionado una marca
                if (cbMarca.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, selecciona una marca", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Filtrar los productos por la marca seleccionada
                FiltrarProductosPorMarca();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtProductos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cbOptions.Text))
                {
                    MessageBox.Show("Por favor, seleccione un criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtProductos.Text))
                {
                    this.tbProductosTableAdapter.Fill(this.db_CRUMARDataSet1.tbProductos);
                    return;
                }

                using (SqlConnection cadena = new SqlConnection(Properties.Settings.Default.db_CRUMARConnectionString))
                {
                    string query = $"SELECT codigoBarras, nombre, marca, precioVenta FROM tbProductos WHERE {cbOptions.Text} LIKE @searchText";

                    SqlDataAdapter adap = new SqlDataAdapter(query, cadena);
                    adap.SelectCommand.Parameters.AddWithValue("@searchText", $"%{txtProductos.Text}%");

                    DataSet ds = new DataSet();
                    adap.Fill(ds, "tbProductos");

                    dgvProducts.DataSource = ds;
                    dgvProducts.DataMember = "tbProductos";

                    if (ds.Tables["tbProductos"].Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron productos que coincidan con la búsqueda.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay una fila seleccionada
                if (dgvProducts.CurrentRow == null || dgvProducts.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecciona al menos un producto para imprimir las etiquetas.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvProducts.CurrentRow;

                // Validar el nombre de la columna y obtener los valores
                if (selectedRow.Cells["nombre"] != null && selectedRow.Cells["precioVenta"] != null)
                {
                    string nombre = selectedRow.Cells["nombre"].Value?.ToString() ?? "Sin Nombre";
                    string precioTexto = selectedRow.Cells["precioVenta"].Value?.ToString() ?? "0";

                    if (decimal.TryParse(precioTexto, out decimal precio))
                    {
                        MessageBox.Show($"Producto seleccionado:\nNombre: {nombre}\nPrecio: {precio:C2}",
                            "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El precio no tiene un formato válido.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la columna especificada. Verifica el nombre de la columna en el DataGridView.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}