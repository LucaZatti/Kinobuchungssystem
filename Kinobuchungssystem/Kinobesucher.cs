using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinobuchungssystem
{
    public class Kinobesucher
    {
        private int telefonnummer;
        private string vorname;
        private string nachname;

        public Kinobesucher(int telefonnummer, string vorname, string nachname)
        {
            Telefonnummer = telefonnummer;
            Vorname = vorname;
            Nachname = nachname;
        }

        public void verwaltenKinobesucher()
        {

        }
        public int Telefonnummer { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
    }
}
