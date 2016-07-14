/**
 *  Author: Luca Zatti
 *  Date: 21.06.16 
 *  Version: 1
 *  Description: This class handles the Verwalten Form. In this Form, you can change settings or datas from the user, Films or
 *  Vorstellungen
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinobuchungssystem
{
    public partial class VerwaltenForm : Form
    {
        // create instance of class
        Daten daten;
        public VerwaltenForm(Daten daten)
        {
            InitializeComponent();
            this.daten = daten;
            // disable buttons and textboxes
            // buttons and textboxes tab film
            btn_filmSuchen.Enabled = false;
            btn_filmSave.Enabled = false;
            tb_filmAltersfreigabe.Enabled = false;
            tb_filmBeschreibung.Enabled = false;
            tb_filmDauer.Enabled = false;
            tb_filmName.Enabled = false;
            tb_filmProduzent.Enabled = false;
            tb_filmGenre.Enabled = false;
            // end
            // buttons and textboxes tab vorstellung
            btn_vorstellungSave.Enabled = false;
            btn_vorstellungSuchen.Enabled = false;
            tb_vorstellungDatum.Enabled = false;
            tb_vorstellungFilm.Enabled = false;
            tb_vorstellungKinosaal.Enabled = false;
            tb_vorstellungsnummer.Enabled = false;
            tb_vorstellungZeit.Enabled = false;
            // end 
            // buttons and textboxes tab benutzer
            btn_benutzerSave.Enabled = false;
            btn_benutzerSuchen.Enabled = false;
            tb_benutzerNachname.Enabled = false;
            tb_benutzerTelefonnummerBenutzer.Enabled = false;
            tb_benutzerVorname.Enabled = false;
            // end
        }

        //--------------------------------------------------------------------------------------------------------------------------
        // handles everything int tab benutzer
        private void btn_suchenBenutzer_Click(object sender, EventArgs e)
        {
            // enable buttons and textboxes
            btn_benutzerSave.Enabled = true;
            tb_benutzerNachname.Enabled = true;
            tb_benutzerTelefonnummerBenutzer.Enabled = true;
            tb_benutzerVorname.Enabled = true;
            string eingabe = btn_benutzerSuchen.Text;

            this.daten.searchKinobesucher(tb_benutzerSuchen.Text);
        }

        private void tb_suchenBenutzer_TextChanged(object sender, EventArgs e)
        {
            // check textbox if text is entered
            btn_benutzerSuchen.Enabled = !string.IsNullOrWhiteSpace(this.tb_benutzerSuchen.Text);
        }

        private void tb_telefonnummer_KeyPress(object sender, KeyPressEventArgs e)
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
        
        private void btn_saveBenutzer_Click(object sender, EventArgs e)
        {
            Kinobesucher besucher = new Kinobesucher(tb_benutzerTelefonnummerBenutzer.Text, tb_benutzerNachname.Text, tb_benutzerVorname.Text);
            besucher.verwaltenKinobesucher(tb_benutzerTelefonnummerBenutzer.Text, tb_benutzerNachname.Text, tb_benutzerVorname.Text);
        }

        //--------------------------------------------------------------------------------------------------------------------------
        // handles everything in tab film
        private void btn_suchenFilm_Click(object sender, EventArgs e)
        {
            tb_filmAltersfreigabe.Enabled = true;
            tb_filmBeschreibung.Enabled = true;
            tb_filmDauer.Enabled = true;
            tb_filmGenre.Enabled = true;
            tb_filmName.Enabled = true;
            tb_filmProduzent.Enabled = true;
            btn_filmSave.Enabled = true;
            tb_filmSuchen.Text = "";

            this.daten.searchFilm(tb_filmSuchen.Text);
        }

        private void tb_suchenFilm_TextChanged(object sender, EventArgs e)
        {
            // check textbox if text is entered
            btn_filmSuchen.Enabled = !string.IsNullOrWhiteSpace(this.tb_filmSuchen.Text);
        }

        private void btn_saveFilm_Click(object sender, EventArgs e)
        {

            // clear all textboxes in form
            tb_filmAltersfreigabe.Text = "";
            tb_filmBeschreibung.Text = "";
            tb_filmDauer.Text = "";
            tb_filmGenre.Text = "";
            tb_filmName.Text = "";
            tb_filmProduzent.Text = "";
        }

        //--------------------------------------------------------------------------------------------------------------------------
        // handles everything in tab vorstellung
        private void btn_suchenVorstellung_Click(object sender, EventArgs e)
        {
            tb_vorstellungDatum.Enabled = true;
            tb_vorstellungFilm.Enabled = true;
            tb_vorstellungKinosaal.Enabled = true;
            tb_vorstellungsnummer.Enabled = true;
            tb_vorstellungZeit.Enabled = true;

            this.daten.searchVorstellung(Int32.Parse(tb_filmSuchen.Text));
        }

        private void tb_suchenVorstellung_TextChanged(object sender, EventArgs e)
        {
            // check textbox if text is entered
            btn_vorstellungSuchen.Enabled = !string.IsNullOrWhiteSpace(this.tb_vorstellungSuchen.Text);
        }

        private void btn_saveVorstellung_Click(object sender, EventArgs e)
        {
            // fill properties with new data
            Vorstellung vorstellung = new Kinobuchungssystem.Vorstellung(tb_vorstellungsnummer.Text, tb_vorstellungKinosaal.Text, tb_vorstellungFilm.Text, tb_vorstellungDatum.Text, tb_vorstellungZeit.Text);
            vorstellung.verwaltenFilm(Int32.Parse(tb_vorstellungsnummer.Text), Int32.Parse(tb_vorstellungZeit.Text), tb_vorstellungKinosaal.Text, tb_vorstellungFilm.Text);
        }

        private void tb_vorstellungsnummer_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_kinosaalVorstellung_KeyPress(object sender, KeyPressEventArgs e)
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

        //--------------------------------------------------------------------------------------------------------------------------
        // buttons in this form
        private void btn_zurueck_Click(object sender, EventArgs e)
        {
            // create new instance of class NavigationForm
            NavigationForm navigationForm = new NavigationForm(this.daten);
            this.Hide();
            // close current form and open new one
            navigationForm.Closed += (s, args) => this.Close();
            navigationForm.Show();
        }
    }
}
