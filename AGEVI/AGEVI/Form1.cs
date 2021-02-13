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
    public partial class frmSesion : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public frmSesion()
        {
            InitializeComponent();
            player.URL = "";
        }

        private void btnOlvide_Click(object sender, EventArgs e)
        {
            player.controls.play();



        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();

            this.Hide();
        }





    }
}
