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
        Vorstellung vorstellung = new Vorstellung();
        Film film = new Film();
        Kinobesucher kinobesucher = new Kinobesucher();

        public VerwaltenForm()
        {
            InitializeComponent();
            
           
            // disable buttons and textboxes
            // buttons and textboxes tab film
            btn_suchenFilm.Enabled = false;
            btn_saveFilm.Enabled = false;
            tb_altersfreigabeFilm.Enabled = false;
            tb_beschreibungFilm.Enabled = false;
            tb_dauerFilm.Enabled = false;
            tb_nameFilm.Enabled = false;
            tb_produzentFilm.Enabled = false;
            tb_genreFilm.Enabled = false;
            // end
            // buttons and textboxes tab vorstellung
            btn_saveVorstellung.Enabled = false;
            btn_suchenVorstellung.Enabled = false;
            tb_datumVorstellung.Enabled = false;
            tb_filmVorstellung.Enabled = false;
            tb_kinosaalVorstellung.Enabled = false;
            tb_vorstellungsnummer.Enabled = false;
            tb_zeitVorstellung.Enabled = false;
            // end 
            // buttons and textboxes tab benutzer
            btn_saveBenutzer.Enabled = false;
            btn_suchenBenutzer.Enabled = false;
            tb_nachname.Enabled = false;
            tb_telefonnummerBenutzer.Enabled = false;
            tb_vorname.Enabled = false;
            // end
        }

        //--------------------------------------------------------------------------------------------------------------------------
        // handles everything int tab benutzer
        private void btn_suchenBenutzer_Click(object sender, EventArgs e)
        {
            // enable buttons and textboxes
            btn_saveBenutzer.Enabled = true;
            tb_nachname.Enabled = true;
            tb_telefonnummerBenutzer.Enabled = true;
            tb_vorname.Enabled = true;
            string eingabe = btn_suchenBenutzer.Text;
        }

        private void tb_suchenBenutzer_TextChanged(object sender, EventArgs e)
        {
            // check textbox if text is entered
            btn_suchenBenutzer.Enabled = !string.IsNullOrWhiteSpace(this.tb_suchenBenutzer.Text);
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
            kinobesucher.Vorname = tb_vorname.Text;
            kinobesucher.Nachname = tb_nachname.Text;
            kinobesucher.Telefonnummer = Int32.Parse(tb_telefonnummerBenutzer.Text);
        }

        //--------------------------------------------------------------------------------------------------------------------------
        // handles everything in tab film
        private void btn_suchenFilm_Click(object sender, EventArgs e)
        {
            tb_altersfreigabeFilm.Enabled = true;
            tb_beschreibungFilm.Enabled = true;
            tb_dauerFilm.Enabled = true;
            tb_genreFilm.Enabled = true;
            tb_nameFilm.Enabled = true;
            tb_produzentFilm.Enabled = true;
            btn_saveFilm.Enabled = true;
            film.Name = btn_suchenFilm.Text;
            lb_film.Items.Add(film.Name);
            tb_suchenFilm.Text = "";
        }

        private void tb_suchenFilm_TextChanged(object sender, EventArgs e)
        {
            // check textbox if text is entered
            btn_suchenFilm.Enabled = !string.IsNullOrWhiteSpace(this.tb_suchenFilm.Text);
        }

        private void btn_saveFilm_Click(object sender, EventArgs e)
        {
            film.Altersfreigabe = Int32.Parse(tb_altersfreigabeFilm.Text);
            film.Beschreibung = tb_beschreibungFilm.Text;
            film.Dauer = Int32.Parse(tb_dauerFilm.Text);
            film.Genre = tb_genreFilm.Text;
            film.Name = tb_nameFilm.Text;
            film.Produzent = tb_produzentFilm.Text;

            // clear all textboxes in form
            tb_altersfreigabeFilm.Text = "";
            tb_beschreibungFilm.Text = "";
            tb_dauerFilm.Text = "";
            tb_genreFilm.Text = "";
            tb_nameFilm.Text = "";
            tb_produzentFilm.Text = "";
        }

        //--------------------------------------------------------------------------------------------------------------------------
        // handles everything in tab vorstellung
        private void btn_suchenVorstellung_Click(object sender, EventArgs e)
        {
            tb_datumVorstellung.Enabled = true;
            tb_filmVorstellung.Enabled = true;
            tb_kinosaalVorstellung.Enabled = true;
            tb_vorstellungsnummer.Enabled = true;
            tb_zeitVorstellung.Enabled = true;

            vorstellung.Filmname = tb_suchenVorstellung.Text;
            lb_vorstellung.Items.Add(vorstellung.Filmname);
        }

        private void tb_suchenVorstellung_TextChanged(object sender, EventArgs e)
        {
            // check textbox if text is entered
            btn_suchenVorstellung.Enabled = !string.IsNullOrWhiteSpace(this.tb_suchenVorstellung.Text);
        }

        private void btn_saveVorstellung_Click(object sender, EventArgs e)
        {
            // fill properties with new data
            vorstellung.Datum = tb_datumVorstellung.Text;
            vorstellung.Filmname = tb_filmVorstellung.Text;
            vorstellung.Saalnummer = Int32.Parse(tb_kinosaalVorstellung.Text);
            vorstellung.Vorstellungsnummer = Int32.Parse(tb_vorstellungsnummer.Text);
            vorstellung.Zeit = tb_zeitVorstellung.Text;
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
            NavigationForm navigationForm = new NavigationForm();
            this.Hide();
            // close current form and open new one
            navigationForm.Closed += (s, args) => this.Close();
            navigationForm.Show();
        }
    }
}
