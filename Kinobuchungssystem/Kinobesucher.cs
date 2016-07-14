using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinobuchungssystem
{
    public class Kinobesucher
    {
        private string telefonnummer;
        private string vorname;
        private string nachname;
        //Erstellt den Kinobesucher
        public Kinobesucher(string telefonnummer, string nachname, string vorname)
        {
            Telefonnummer = telefonnummer;
            Vorname = vorname;
            Nachname = nachname;
        }
        //Verwaltet den Kinobesucher
        public void verwaltenKinobesucher(string telefonnummer, string vname, string nname)
        {
            if (telefonnummer != null)
            {
                Telefonnummer = telefonnummer;
            }
            if (vname != null)
            {
                Vorname = vname;
            }
            if (nname != null)
            {
                Nachname = nname;
            }
        }
        //Properties
        public string Telefonnummer { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
    }
}
