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
    public partial class Mantenimiento : Form
    {
        Controlador cn = new Controlador();
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmEA = new MDI();
            frmEA.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable data = cn.llenarTblFacturaa("");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigoFac = txtFact.Text;
            string codigoCliente = txtCliente.Text;
            string nombre_fac = txtFactura.Text;
            string fecha = txtFecha.Text;
            string descrip = txtDescrip.Text;
            string monto = txtMonto.Text;




            if (cn.ingresoFac(codigoFac, codigoCliente, nombre_fac, fecha, descrip, monto))
            {
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                MessageBox.Show("Error de ingreso");
            }
            txtFact.Text = "";
            txtCliente.Text = "";
            txtFactura.Text = "";
            txtFecha.Text = "";
            txtDescrip.Text = "";
            txtMonto.Text = "";
        }
    }
}
