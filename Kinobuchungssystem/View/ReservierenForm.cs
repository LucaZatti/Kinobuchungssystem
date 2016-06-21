using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinobuchungssystem.View
{
    public partial class ReservierenForm : Form
    {
        public ReservierenForm()
        {
            InitializeComponent();
            btn_Reservieren.Enabled = false;
            btn_Suchen.Enabled = false;
        }

        //Press Button Suchen
        private void btn_Suchen_Click(object sender, EventArgs e)
        {
            // get input text 
            string vorstellung = tb_Vorstellung.Text;
            int anzahlPlaetze = int.Parse(tb_AnzahlPlaetze.Text);

            MessageBox.Show(vorstellung + anzahlPlaetze);
        }

        private void btn_Reservieren_Click(object sender, EventArgs e)
        {
            // get input text
            string vorname = tb_Vorname.Text;
            string nachname = tb_Nachname.Text;
            int telefonnummer = int.Parse(tb_Telefonnummer.Text);

            MessageBox.Show(vorname + " " + nachname + " " + telefonnummer);

            
        }

        // Press button zurück
        private void btn_zurück_Click(object sender, EventArgs e)
        {
            // create new instance of class NavigationForm
            NavigationForm navigationForm = new NavigationForm();
            this.Hide();
            // close current form and open new one
            navigationForm.Closed += (s, args) => this.Close();
            navigationForm.Show();
        }

        // check input from user, if input is just nummeric
        private void tb_AnzahlPlaetze_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        // check input from user, if input is just nummeric
        private void tb_Telefonnummer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
