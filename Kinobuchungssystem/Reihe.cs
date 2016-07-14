using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinobuchungssystem
{
    public class Reihe
    {
        private string reihennummer;
        private string anzahlPlaetze;
        private Platz[] plaetze;
        //Konstruktor der das Objekt erstellt
        public Reihe(int nummer)
        {
            plaetze = new Platz[5];
            Reihennummer = nummer.ToString();
            fillReihe();
        }
        //Erstellt Plätze für die Reihe
        public void fillReihe()
        {
            for (int i = 0; i < plaetze.Length; i++)
            {
                if (Plaetze == null)
                {
                    int x = i + 1;
                    plaetze[i] = new Platz((x).ToString(), false, null);
                }
            }
        }
        //Suche nach einem bestimmten Platz in der Reihe
        public Platz searchPlatz(int platznummer)
        {
            for (int i = 0; i < plaetze.Length; i++)
            {
                if (plaetze[i].Platznummer.Equals(platznummer))
                {
                    return plaetze[i];
                }
            }
            return null;
        }
        //Gibt alle Plätze aus
        public Platz[] givePlatz()
        {
            return plaetze;
        }
        public string Reihennummer { get; set; }
        public int AnzahlPlaetze { get; set; }
        public Platz[] Plaetze { get; set; }
    }
}
