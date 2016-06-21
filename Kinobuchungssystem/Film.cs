using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinobuchungssystem
{
    public class Film
    {
        private int filmNummer;
        private string name;
        private int dauer;
        private int altersfreigabe;
        private string produzent;
        private string genre;
        private string beschreibung;

        public Film(string name, int dauer, int altersfreigabe, string produzent, string genre, string beschreibung)
        {
            Name = name;
            Dauer = dauer;
            Altersfreigabe = altersfreigabe;
            Produzent = produzent;
            Genre = genre;
            Beschreibung = beschreibung;

        }
        public void verwaltenFilm()
        {

        }
        private string Name { get; set; }
        private int Dauer { get; set; }
        private int Altersfreigabe { get; set; }
        private string Produzent { get; set; }
        private string Genre { get; set; }
        private string Beschreibung { get; set; }
    }
}
