using System;
using System.Windows.Forms;

namespace AGEVI
{
    public partial class frmJuegosConsolas : Form
    {
        public frmJuegosConsolas()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void frm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lstFecha.Items.Add(cmbFechaPublicacion.SelectedItem);
            
            if (this.txtVJ.Text !="")
            {
                lstVJ.Items.Add(this.txtVJ.Text);
            }
            else
            {
                MessageBox.Show("Por favor agrege un videojuego.");
                this.txtVJ.Focus();
            }
            if (chc1r .Checked == true)
            {
                lstGenero.Items.Add(chc1r.Text);
            }
            if (chc2D .Checked == true)
            {
                lstGenero.Items.Add(chc2D.Text);
            }
            if (chc3D .Checked == true)
            {
                lstGenero.Items.Add(chc3D.Text);
            }
            if (chc3r.Checked == true)
            {
                lstGenero.Items.Add(chc3r.Text);
            }
            if (chcAnime .Checked == true)
            {
                lstGenero.Items.Add(chcAnime.Text);
            }
            if (chcHorror.Checked == true)
            {
                lstGenero.Items.Add(chcHorror.Text);
            }
            if (chcMA.Checked == true)
            {
                lstGenero.Items.Add(chcMA.Text);
            }
            if (chcMMO.Checked == true)
            {
                lstGenero.Items.Add(chcMMO.Text);
            }
            if (chcMP.Checked == true)
            {
                lstGenero.Items.Add(chcMP.Text);
            }
            if (chcRPG.Checked == true)
            {
                lstGenero.Items.Add(chcRPG.Text);
            }
            if (chcShoot.Checked == true)
            {
                lstGenero.Items.Add(chcShoot.Text);
            }
            if (chcSim.Checked == true)
            {
                lstGenero.Items.Add(chcSim.Text);
            }
            if (chcSport.Checked == true)
            {
                lstGenero.Items.Add(chcSport.Text);
            }
            if (chcSV.Checked == true)
            {
                lstGenero.Items.Add(chcSV.Text);
            }
            if (chcVR.Checked == true)
            {
                lstGenero.Items.Add(chcVR.Text);
            }
      
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
