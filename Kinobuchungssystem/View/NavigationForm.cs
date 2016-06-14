/**
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
        public NavigationForm()
        {
            InitializeComponent();
        }

        private void NavigationForm_btn_verwalten_Click(object sender, EventArgs e)
        {

        }

        private void NavigationForm_btn_reservieren_Click(object sender, EventArgs e)
        {
            // create new instance of class NavigationForm
            ReservierenForm reservierenForm = new ReservierenForm();
            this.Hide();
            // close current form and open new one
            reservierenForm.Closed += (s, args) => this.Close();
            reservierenForm.Show();
        }
    }
}
