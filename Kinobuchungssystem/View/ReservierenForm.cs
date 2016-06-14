using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinobuchungssystem.View
{
    public partial class ReservierenForm : Form
    {
        public ReservierenForm()
        {
            InitializeComponent();
        }

        private void btn_Suchen_Click(object sender, EventArgs e)
        {
            string vorstellung = tb_Vorstellung.Text;
            int anzahlPlaetze = int.Parse(tb_AnzahlPlaetze.Text);

            MessageBox.Show(vorstellung + anzahlPlaetze);
        }

        private void btn_Reservieren_Click(object sender, EventArgs e)
        {
            string vorname = tb_Vorname.Text;
            string nachname = tb_Nachname.Text;
            int telefonnummer = int.Parse(tb_Telefonnummer.Text);

            MessageBox.Show(vorname + " " + nachname + " " + telefonnummer);
        }

        private void tb_AnzahlPlaetze_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_Telefonnummer_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
