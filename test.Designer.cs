namespace Repositorio
{
    partial class test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.cbCaducidad = new System.Windows.Forms.ComboBox();
            this.btnFechas = new System.Windows.Forms.Button();
            this.cbOptions = new System.Windows.Forms.ComboBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.codigoBarrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCaducidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_CRUMARDataSet1 = new Repositorio.db_CRUMARDataSet1();
            this.tbProductosTableAdapter = new Repositorio.db_CRUMARDataSet1TableAdapters.tbProductosTableAdapter();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.Categoria = new System.Windows.Forms.Label();
            this.Productos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_CRUMARDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Producto";
            // 
            // txtProductos
            // 
            this.txtProductos.Location = new System.Drawing.Point(35, 84);
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(236, 26);
            this.txtProductos.TabIndex = 4;
            this.txtProductos.TextChanged += new System.EventHandler(this.txtProductos_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.cbMarca);
            this.panel1.Controls.Add(this.btnFiltro);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Controls.Add(this.btnFechas);
            this.panel1.Controls.Add(this.cbCaducidad);
            this.panel1.Location = new System.Drawing.Point(12, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 68);
            this.panel1.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::Repositorio.Properties.Resources.Search1;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(963, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(34, 39);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Próximos a caducar",
            "Caducados"});
            this.cbMarca.Location = new System.Drawing.Point(808, 23);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(140, 28);
            this.cbMarca.TabIndex = 13;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Image = global::Repositorio.Properties.Resources.Warehouse;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(645, 8);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(131, 50);
            this.btnStock.TabIndex = 1;
            this.btnStock.Text = "Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.Color.White;
            this.btnFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFiltro.FlatAppearance.BorderSize = 0;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnFiltro.ForeColor = System.Drawing.Color.White;
            this.btnFiltro.Image = global::Repositorio.Properties.Resources.Filtro;
            this.btnFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltro.Location = new System.Drawing.Point(463, 8);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(34, 43);
            this.btnFiltro.TabIndex = 12;
            this.btnFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbCaducidad
            // 
            this.cbCaducidad.FormattingEnabled = true;
            this.cbCaducidad.Items.AddRange(new object[] {
            "Próximos a caducar",
            "Caducados"});
            this.cbCaducidad.Location = new System.Drawing.Point(280, 29);
            this.cbCaducidad.Name = "cbCaducidad";
            this.cbCaducidad.Size = new System.Drawing.Size(162, 28);
            this.cbCaducidad.TabIndex = 12;
            // 
            // btnFechas
            // 
            this.btnFechas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(196)))));
            this.btnFechas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFechas.FlatAppearance.BorderSize = 0;
            this.btnFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechas.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechas.ForeColor = System.Drawing.Color.White;
            this.btnFechas.Image = global::Repositorio.Properties.Resources.Calendar2;
            this.btnFechas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechas.Location = new System.Drawing.Point(3, 14);
            this.btnFechas.Name = "btnFechas";
            this.btnFechas.Size = new System.Drawing.Size(271, 51);
            this.btnFechas.TabIndex = 0;
            this.btnFechas.Text = "Caducidades";
            this.btnFechas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechas.UseVisualStyleBackColor = false;
            this.btnFechas.Click += new System.EventHandler(this.btnFechas_Click);
            // 
            // cbOptions
            // 
            this.cbOptions.FormattingEnabled = true;
            this.cbOptions.Items.AddRange(new object[] {
            "nombre",
            "codigoBarras",
            "marca",
            "precioVenta"});
            this.cbOptions.Location = new System.Drawing.Point(296, 82);
            this.cbOptions.Name = "cbOptions";
            this.cbOptions.Size = new System.Drawing.Size(317, 28);
            this.cbOptions.TabIndex = 10;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoBarrasDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.existenciaDataGridViewTextBoxColumn,
            this.precioVentaDataGridViewTextBoxColumn,
            this.fechaCaducidadDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.tbProductosBindingSource;
            this.dgvProducts.Location = new System.Drawing.Point(2, 298);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1265, 227);
            this.dgvProducts.TabIndex = 11;
            // 
            // codigoBarrasDataGridViewTextBoxColumn
            // 
            this.codigoBarrasDataGridViewTextBoxColumn.DataPropertyName = "codigoBarras";
            this.codigoBarrasDataGridViewTextBoxColumn.HeaderText = "codigoBarras";
            this.codigoBarrasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codigoBarrasDataGridViewTextBoxColumn.Name = "codigoBarrasDataGridViewTextBoxColumn";
            this.codigoBarrasDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "marca";
            this.marcaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.Width = 150;
            // 
            // existenciaDataGridViewTextBoxColumn
            // 
            this.existenciaDataGridViewTextBoxColumn.DataPropertyName = "existencia";
            this.existenciaDataGridViewTextBoxColumn.HeaderText = "existencia";
            this.existenciaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.existenciaDataGridViewTextBoxColumn.Name = "existenciaDataGridViewTextBoxColumn";
            this.existenciaDataGridViewTextBoxColumn.Width = 150;
            // 
            // precioVentaDataGridViewTextBoxColumn
            // 
            this.precioVentaDataGridViewTextBoxColumn.DataPropertyName = "precioVenta";
            this.precioVentaDataGridViewTextBoxColumn.HeaderText = "precioVenta";
            this.precioVentaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.precioVentaDataGridViewTextBoxColumn.Name = "precioVentaDataGridViewTextBoxColumn";
            this.precioVentaDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaCaducidadDataGridViewTextBoxColumn
            // 
            this.fechaCaducidadDataGridViewTextBoxColumn.DataPropertyName = "fechaCaducidad";
            this.fechaCaducidadDataGridViewTextBoxColumn.HeaderText = "fechaCaducidad";
            this.fechaCaducidadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaCaducidadDataGridViewTextBoxColumn.Name = "fechaCaducidadDataGridViewTextBoxColumn";
            this.fechaCaducidadDataGridViewTextBoxColumn.Width = 150;
            // 
            // tbProductosBindingSource
            // 
            this.tbProductosBindingSource.DataMember = "tbProductos";
            this.tbProductosBindingSource.DataSource = this.db_CRUMARDataSet1;
            // 
            // db_CRUMARDataSet1
            // 
            this.db_CRUMARDataSet1.DataSetName = "db_CRUMARDataSet1";
            this.db_CRUMARDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbProductosTableAdapter
            // 
            this.tbProductosTableAdapter.ClearBeforeFill = true;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Black;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::Repositorio.Properties.Resources.Price_Tag_USD;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(1022, 68);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(278, 53);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Imprimir Precios";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.Color.White;
            this.btnF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnF.FlatAppearance.BorderSize = 0;
            this.btnF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnF.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnF.ForeColor = System.Drawing.Color.White;
            this.btnF.Image = global::Repositorio.Properties.Resources.Filtro;
            this.btnF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnF.Location = new System.Drawing.Point(521, 24);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(37, 32);
            this.btnF.TabIndex = 12;
            this.btnF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnF.UseVisualStyleBackColor = false;
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Categoria.ForeColor = System.Drawing.Color.White;
            this.Categoria.Location = new System.Drawing.Point(291, 56);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(122, 25);
            this.Categoria.TabIndex = 12;
            this.Categoria.Text = "Categoria";
            // 
            // Productos
            // 
            this.Productos.AutoSize = true;
            this.Productos.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productos.ForeColor = System.Drawing.Color.White;
            this.Productos.Location = new System.Drawing.Point(606, 26);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(149, 34);
            this.Productos.TabIndex = 13;
            this.Productos.Text = "Productos";
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1367, 1131);
            this.Controls.Add(this.Productos);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.cbOptions);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtProductos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "test";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_CRUMARDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechas;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbOptions;
        private System.Windows.Forms.DataGridView dgvProducts;
        private db_CRUMARDataSet1 db_CRUMARDataSet1;
        private System.Windows.Forms.BindingSource tbProductosBindingSource;
        private db_CRUMARDataSet1TableAdapters.tbProductosTableAdapter tbProductosTableAdapter;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.ComboBox cbCaducidad;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCaducidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.Label Productos;
    }
}