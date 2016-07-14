using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinobuchungssystem
{
    public class Platz
    {
        private string platznummer;
        private bool besetzt;
        private string telefonnummer;
        //Erstellt den Platz
        public Platz(string platznummer, bool besetzt, string kinobesuchertelefonnummer)
        {
            this.platznummer = platznummer;
            this.besetzt = besetzt;
            telefonnummer = kinobesuchertelefonnummer;
        }
        //Reserviert den Platz
        public void reservierenPlatz(string telenr)
        {
            besetzt = true;
            telefonnummer = telenr;
        }

        public void verwaltenPlatz(string platznummer, bool besetzt, string kinobesuchertelefonnummer)
        {

        }
        public string Platznummer { get; set; }
        public bool Besetzt { get; set; }
        public string Telefonnummer { get; set; }
    }
}
