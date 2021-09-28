using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class _0901_18_335_MELISSA_ALDANA_MDI : Form
    {
        Controlador cn = new Controlador();
        
        public _0901_18_335_MELISSA_ALDANA_MDI()
        {
            InitializeComponent();
        }

      




        private void button2_Click(object sender, EventArgs e)
        {
            var frmEA = new MDI();
            frmEA.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable data = cn.llenarTblClientess("");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
           
            if (cn.ingreso(codigo, nombre, apellido, telefono))
            {
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                MessageBox.Show("Error de ingreso");
            }
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";

        }
    }
}
