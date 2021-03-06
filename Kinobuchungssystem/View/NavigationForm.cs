﻿/**
 *  Author: Luca Zatti
 *  Date: 07.06.16 
 *  Version: 1
 *  Description: This class handles the NavigationForm. 
 *  In this form you can choose between Vertwalten and Reservieren.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;
using Kinobuchungssystem.View;

namespace Kinobuchungssystem
{
    public partial class NavigationForm : Form
    {
        Daten daten;
        public NavigationForm(Daten daten)
        {
            InitializeComponent();
            this.daten = daten;
        }

        private void NavigationForm_btn_verwalten_Click(object sender, EventArgs e)
        {
            VerwaltenForm verwaltenForm = new VerwaltenForm(this.daten);
            this.Hide(); 
            // close current form and open new one
            verwaltenForm.Closed += (s, args) => this.Close();
            verwaltenForm.Show();
        }

        private void NavigationForm_btn_reservieren_Click(object sender, EventArgs e)
        {
            // create new instance of class NavigationForm
            ReservierenForm reservierenForm = new ReservierenForm(this.daten);
            this.Hide();
            // close current form and open new one
            reservierenForm.Closed += (s, args) => this.Close();
            reservierenForm.Show();
        }

        private void btn_neu_Click(object sender, EventArgs e)
        {
            // create new instance of class NavigationForm
            NeuForm neuForm = new NeuForm(this.daten);
            this.Hide();
            // close current form and open new one
            neuForm.Closed += (s, args) => this.Close();
            neuForm.Show();
        }
    }
}
