using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace AGEVI
{
    public partial class frmPrincipal : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public frmPrincipal()
        {
            InitializeComponent();
            player.URL = "mlove.mp3";
        }

        private void bibliotecToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmCalendario_load(object sender, EventArgs e)
        {
            var frmCalendario = new frmCalendario();
            frmCalendario.Show();
        }

        private void juegosMóbilesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmJuegosMobiles_load(object sender, EventArgs e)
        {
            var frmJuegosMobiles = new frmJuegosMobiles();
            frmJuegosMobiles.Show();
        }
    }
}
