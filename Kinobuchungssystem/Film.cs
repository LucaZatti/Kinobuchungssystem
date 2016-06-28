using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinobuchungssystem
{
    public class Film
    {
        public string Name { get; set; }
        public int Dauer { get; set; }
        public int Altersfreigabe { get; set; }
        public string Produzent { get; set; }
        public string Genre { get; set; }
        public string Beschreibung { get; set; }

        public Film(/*string name, int dauer, int altersfreigabe, string produzent, string genre, string beschreibung*/)
        {
            //Name = name;
            //Dauer = dauer;
            //Altersfreigabe = altersfreigabe;
            //Produzent = produzent;
            //Genre = genre;
            //Beschreibung = beschreibung;

        }
        public void verwaltenFilm()
        {

        }
    }
}
