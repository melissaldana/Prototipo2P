using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmEA = new _0901_18_335_MELISSA_ALDANA_MDI();
            this.Hide();
            frmEA.Show();

        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmEA = new Mantenimiento();
            this.Hide();
            frmEA.Show();
        }
    }
}
