using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liste_forms
{
    public partial class Form1 : Form
    {

        List<Vozilo> VoziloList = new List<Vozilo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {

            try
            {
                if(txtMarka.Text == "" ||
                    txtModel.Text == "" ||
                    cmboVrsta.Text == "")
                {
                    MessageBox.Show("Pogresan unos. Molimo pokusajte ponovo.", "Pogresan unos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMarka.Clear();
                    txtModel.Clear();
                }
                else
                {
                    Vozilo vozilo = new Vozilo(txtMarka.Text, txtModel.Text, cmboVrsta.Text);
                    VoziloList.Add(vozilo);
                    txtMarka.Clear();
                    txtModel.Clear();
                }
            }
            catch(NullReferenceException exception)
            {
                MessageBox.Show("Pogresan unos. Molimo pokusajte ponovo.", "Pogresan unos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMarka.Clear();
                txtModel.Clear();
            }

        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            foreach(Vozilo v in VoziloList)
            {
                txtIspis.AppendText(v.ToString());
            }
        }

        private void cmboVrsta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnObradi_Click(object sender, EventArgs e)
        {
            foreach(Vozilo v in VoziloList)
            {
                if(v.Vrsta == "Avion")
                {
                    v.VoziPo = "Zrak";
                }
                else if(v.Vrsta == "Automobil")
                {
                    v.VoziPo = "Cesta";
                }
                else if(v.Vrsta == "Brod")
                {
                    v.VoziPo = "Voda";
                }
            }
        }
    }
}
