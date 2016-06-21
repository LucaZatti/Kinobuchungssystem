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
        }

        private void btn_suchenBenutzer_Click(object sender, EventArgs e)
        {
            string eingabe = btn_suchenBenutzer.Text;

        }
    }
}
