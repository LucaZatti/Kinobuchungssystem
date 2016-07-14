using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinobuchungssystem
{
    public class Film
    {
        private string name;
        private int dauer;
        private int altersfreigabe;
        private string produzent;
        private string genre;
        private string beschreibung;
        //Erstellt einen Film
        public Film(string name, int dauer, int altersfreigabe, string produzent, string genre, string beschreibung)
        {
            Name = name;
            Dauer = dauer;
            Altersfreigabe = altersfreigabe;
            Produzent = produzent;
            Genre = genre;
            Beschreibung = beschreibung;

        }
        //Ändert die Daten
        public void verwaltenFilm(string name, int dauer, int altersfreigabe, string produzent, string genre, string beschreibung)
        {
            if (name != null)
            {
                Name = name;
            }
            if (dauer != 0)
            {
                Dauer = dauer;
            }
            if (altersfreigabe != 0)
            {
                Altersfreigabe = altersfreigabe;
            }
            if (produzent != null)
            {
                Produzent = produzent;
            }
            if (genre != null)
            {
                Genre = genre;
            }
            if (beschreibung != null)
            {
                Beschreibung = beschreibung;
            }   
        }

        //Properties
        public string Name { get; set; }
        public int Dauer { get; set; }
        public int Altersfreigabe { get; set; }
        public string Produzent { get; set; }
        public string Genre { get; set; }
        public string Beschreibung { get; set; }
    }
}
