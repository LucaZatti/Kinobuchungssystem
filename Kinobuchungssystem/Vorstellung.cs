using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinobuchungssystem
{
    public class Vorstellung
    {
        private string vorstellungsnummer;
        private string saalnummer;
        private string filmname;
        private string datum;
        private string von;
        private string bis;
        private int dauer;
        //Konstruktor der das Objekt erstellt
        public Vorstellung(string nummervorstellung, string saalnummer, string filmname, string datum, string start)
        {
            Vorstellungsnummer = nummervorstellung;
            Saalnummer = saalnummer;
            Filmname = filmname;
            Datum = datum;
            Von = start;
            Bis = bis;
            makeDauer();

        }
        //Generiert die Dauer der Vorstellung
        public void makeDauer()
        {

        }
        //Setzt den Saal als besetzt
        public void setSaalBesetzt(Kinosaal saal)
        {
            saal.Besetzt = true;
        }

        public void verwaltenFilm(int vorstellungsnummer, int dauer, string saalnummer, string filmName)
        {
            if (vorstellungsnummer != 0)
            {
                Vorstellungsnummer = vorstellungsnummer.ToString();
            }
            if (dauer != 0)
            {
                Dauer = dauer;
            }
            if (saalnummer != "0")
            {
                Saalnummer = saalnummer;
            }
            if (filmName != null)
            {
                Filmname = filmName;
            }
        }

        //Properties
        public string Vorstellungsnummer { get; set; }
        public string Saalnummer { get; set; }
        public string Filmname { get; set; }
        public string Datum { get; set; }
        public string Von { get; set; }
        public string Bis { get; set; }
        public int Dauer { get; set; }
    }
}
