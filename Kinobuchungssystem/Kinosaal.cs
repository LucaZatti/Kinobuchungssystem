using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinobuchungssystem
{
    public class Kinosaal
    {
        private string kinosaalNummer;
        private int anzahlReihen;
        private int anzahlPlaetze;
        private Reihe[] reihen;
        private bool besetzt;
        //Konstruktor der den Kinosaal erstellt
        public Kinosaal(int nummer)
        {
            reihen = new Reihe[5];
            KinosaalNummer = nummer.ToString();
            makeReihen();
        }
        //Methode die reihen erstellt
        public void makeReihen()
        {
            for (int i = 0; i < reihen.Length; i++)
            {
                if (reihen[i] == null)
                {
                    int x = i + 1;
                    reihen[i] = new Reihe(x);
                }
            }
        }
        //Gibt einen bestimmten Platz zurück in einer der Reihen
        public Platz[] givePlatz(int nummer)
        {
            Platz[] temp = null;
            for (int i = 0; i < reihen.Length; i++)
            {
                if (reihen[i].Reihennummer.Equals(nummer))
                {
                    temp = reihen[i].givePlatz();
                }
                else
                {
                    temp = null;
                }
            }
            return temp;
        }
        //Suche nach einer Reihe
        public Reihe searchReihe(int reihennummer)
        {
            for (int i = 0; i < reihen.Length; i++)
            {
                if (reihen[i].Reihennummer.Equals(reihennummer))
                {
                    return reihen[i];
                }
            }
            return null;
        }
        public string KinosaalNummer { get; set; }
        public int AnzahlReihen { get; set; }
        public int AnzahlPlaetze { get; set; }
        public Reihe[] Reihen { get; set; }
        public bool Besetzt { get; set; }
    }
}
