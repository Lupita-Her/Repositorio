using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repositorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }
        accesoBD objBD = new accesoBD();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 15; // Adjust the value to change the roundness of the corners

            // Create a rounded rectangle path using the form's size and radius
            path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90); // Top-right corner
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90); // Bottom-left corner

            // Create a region with the rounded rectangle path and apply it to the form
            this.Region = new Region(path);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = objBD.autenticarUsuario(tbUsuario.Text, tbPass.Text);
                if (res)
                {
                    //Mostrar el menu Principal
                    Menu miForm = new Menu();
                    this.Hide();
                    miForm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Verificar Usuario y Contraseña", "Mensaje del Sistema", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    tbUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

       
    }
}
