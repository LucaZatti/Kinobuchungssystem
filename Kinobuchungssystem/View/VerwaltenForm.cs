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
            btn_save.Enabled = false;
            tb_nachname.Enabled = false;
            tb_telefonnummer.Enabled = false;
            tb_vorname.Enabled = false;
        }

        private void btn_suchenBenutzer_Click(object sender, EventArgs e)
        {
            // enable buttons and textboxes
            btn_save.Enabled = true;
            tb_nachname.Enabled = true;
            tb_telefonnummer.Enabled = true;
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
    }
}
