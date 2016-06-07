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
        public StartForm()
        {
            InitializeComponent();
        }

        private void firstView_btn_Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavigationForm form2 = new NavigationForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
