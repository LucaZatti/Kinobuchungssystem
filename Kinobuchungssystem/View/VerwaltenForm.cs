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
            tb_filmAltersfreigabe.Enabled = true;
            tb_filmBeschreibung.Enabled = true;
            tb_filmDauer.Enabled = true;
            tb_filmGenre.Enabled = true;
            tb_filmName.Enabled = true;
            tb_filmProduzent.Enabled = true;
            btn_filmSave.Enabled = true;
            film.Name = btn_filmSuchen.Text;
            lb_film.Items.Add(film.Name);
            tb_filmSuchen.Text = "";
        }

        private void tb_suchenFilm_TextChanged(object sender, EventArgs e)
        {
            // check textbox if text is entered
            btn_filmSuchen.Enabled = !string.IsNullOrWhiteSpace(this.tb_filmSuchen.Text);
        }

        private void btn_saveFilm_Click(object sender, EventArgs e)
        {
            film.Altersfreigabe = Int32.Parse(tb_filmAltersfreigabe.Text);
            film.Beschreibung = tb_filmBeschreibung.Text;
            film.Dauer = Int32.Parse(tb_filmDauer.Text);
            film.Genre = tb_filmGenre.Text;
            film.Name = tb_filmName.Text;
            film.Produzent = tb_filmProduzent.Text;

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
