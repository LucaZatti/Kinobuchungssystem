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
        public VerwaltenForm()
        {
            InitializeComponent();
            // disable buttons and textboxes
            btn_saveBenutzer.Enabled = false;
            btn_suchenBenutzer.Enabled = false;
            btn_suchenFilm.Enabled = false;
            btn_saveFilm.Enabled = false;
            tb_nachname.Enabled = false;
            tb_telefonnummerBenutzer.Enabled = false;
            tb_vorname.Enabled = false;
            tb_altersfreigabeFilm.Enabled = false;
            tb_beschreibungFilm.Enabled = false;
            tb_dauerFilm.Enabled = false;
            tb_nameFilm.Enabled = false;
            tb_produzentFilm.Enabled = false;
            tb_genreFilm.Enabled = false;
        }

        private void btn_suchenBenutzer_Click(object sender, EventArgs e)
        {
            // enable buttons and textboxes
            btn_saveBenutzer.Enabled = true;
            tb_nachname.Enabled = true;
            tb_telefonnummerBenutzer.Enabled = true;
            tb_vorname.Enabled = true;
            string eingabe = btn_suchenBenutzer.Text;
        }

        private void btn_zurueck_Click(object sender, EventArgs e)
        {
            // create new instance of class NavigationForm
            NavigationForm navigationForm = new NavigationForm();
            this.Hide();
            // close current form and open new one
            navigationForm.Closed += (s, args) => this.Close();
            navigationForm.Show();
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

        private void btn_suchenFilm_Click(object sender, EventArgs e)
        {
            tb_altersfreigabeFilm.Enabled = true;
            tb_beschreibungFilm.Enabled = true;
            tb_dauerFilm.Enabled = true;
            tb_genreFilm.Enabled = true;
            tb_nameFilm.Enabled = true;
            tb_produzentFilm.Enabled = true;
            btn_saveFilm.Enabled = true;
            string eingabe = btn_suchenFilm.Text;

        }

        private void tb_suchenFilm_TextChanged(object sender, EventArgs e)
        {
            // check textbox if text is entered
            btn_suchenFilm.Enabled = !string.IsNullOrWhiteSpace(this.tb_suchenFilm.Text);
        }
    }
}
