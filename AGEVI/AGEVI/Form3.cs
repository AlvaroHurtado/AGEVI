using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGEVI
{
    public partial class frmCalendario : Form
    {
        public frmCalendario()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnFechas_Click(object sender, EventArgs e)
        {
            DateTime inicio = mntCalendar.SelectionStart;
            DateTime final = mntCalendar.SelectionEnd;

            lblFechaInicial.Text = inicio.ToString();
            lblFechaFinal.Text = final.ToString();
        }
    }
}
