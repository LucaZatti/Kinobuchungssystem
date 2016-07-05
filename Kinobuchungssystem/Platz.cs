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
        private string besetzt;
        private string telefonnummer;

        public Platz(string platznummer, string besetzt, string kinobesuchertelefonnummer)
        {
            Platznummer = platznummer;
            Besetzt = besetzt;
            Telefonnummer = kinobesuchertelefonnummer;
        }

        public void findenPlatz()
        {

        }

        public void reservierenPlatz()
        {

        }

        public void verwaltenPlatz()
        {

        }
        public string Platznummer { get; set; }
        public string Besetzt { get; set; }
        public string Telefonnummer { get; set; }
    }
}