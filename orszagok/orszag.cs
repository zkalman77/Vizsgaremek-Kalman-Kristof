using System;

namespace Orszagok_Dolgozat
{
    public class Orszag
    {
        public string Nev { get; set; }
        public string Fovaros { get; set; }
        public int Lakossag { get; set; }

        public Orszag(string nev, string fovaros, int lakossag)
        {
            Nev = nev;
            Fovaros = fovaros;
            Lakossag = lakossag;
        }
    }
}