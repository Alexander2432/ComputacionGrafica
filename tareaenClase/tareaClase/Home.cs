using System;
using System.Windows.Forms;

namespace tareaClase
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void proyeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProyeccion frm = new FrmProyeccion();
            frm.Show();
        }
    }
}
