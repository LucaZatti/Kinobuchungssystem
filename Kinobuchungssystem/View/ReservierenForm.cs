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
        Daten daten;
        public ReservierenForm(Daten daten)
        {
            InitializeComponent();
            this.daten = daten;
            btn_Reservieren.Enabled = false;
            btn_Suchen.Enabled = false;
            cb_FreiePlaetze.Enabled = false;
        }

        //Press Button Suchen
        private void btn_Suchen_Click(object sender, EventArgs e)
        {
            cb_FreiePlaetze.Enabled = true;
            // get input text 
            this.daten.searchVorstellung(Int32.Parse(tb_Vorstellung.Text));
        }

        private void btn_Reservieren_Click(object sender, EventArgs e)
        {
            // get input text
            this.daten.createKinobesucher(tb_Telefonnummer.Text, tb_Nachname.Text, tb_Vorname.Text);
        }

        // Press button zurück
        private void btn_zurück_Click(object sender, EventArgs e)
        {
            // create new instance of class NavigationForm
            NavigationForm navigationForm = new NavigationForm(this.daten);
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

        private void tb_Vorstellung_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_AnzahlPlaetze.Text) || string.IsNullOrEmpty(tb_Vorstellung.Text))
            {
                btn_Suchen.Enabled = false;
            }
            else
            {
                btn_Suchen.Enabled = true;
            }
        }

        private void tb_AnzahlPlaetze_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_AnzahlPlaetze.Text) || string.IsNullOrEmpty(tb_Vorstellung.Text))
            {
                btn_Suchen.Enabled = false;
            }
            else
            {
                btn_Suchen.Enabled = true;
            }
        }
    }
}
