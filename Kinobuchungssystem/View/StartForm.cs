/**
 *  Author: Luca Zatti
 *  Date: 07.06.16 
 *  Version: 1
 *  Description: This class handles the first Form. It introduces the user, how he has to use this programm 
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
    public partial class StartForm : Form
    {
        Daten daten = new Daten();
        public StartForm()
        {
            InitializeComponent();
        }

        //Press Button Next
        private void firstView_btn_Next_Click(object sender, EventArgs e)
        {
            // create new instance of class NavigationForm
            NavigationForm navigationForm = new NavigationForm(daten);
            this.Hide();
            // close current form and open new one
            navigationForm.Closed += (s, args) => this.Close();
            navigationForm.Show();
        }
    }
}
