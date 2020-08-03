using System;
using System.Collections.Generic;
using System.Text;


namespace FirutyLib
{
    public class Lamana
    {
        //Punkt[] punkty; // tablica punktów - niewygodne
        private List<Punkt> punkty;
        public IReadOnlyList<Punkt> Punkty => punkty.AsReadOnly();

        public Lamana()
        {
            punkty = new List<Punkt>();
            punkty.Add(new Punkt(0, 0));
            punkty.Add(new Punkt(1, 1));
        }

        public Lamana( Punkt[] ciagPunktow )
        {
            if( ciagPunktow.Length < 2 )
            {
                throw new InvalidOperationException("za mało punktów");
            }

            punkty = new List<Punkt>();
            foreach( var p in ciagPunktow )
            {
                punkty.Add(p);
            }
        }

        public void DodajNaKoniec( Punkt p ) => punkty.Add(p);

        public void DodajNaPozycji(int indeks, Punkt p) => punkty.Insert(indeks, p);

        public void UsunWszystkie(Punkt p) => punkty.RemoveAll( x => x.Equals(p) );

        public void UsunZPozycji(int indeks) => punkty.RemoveAt(indeks);

        public int LiczbaPunktów => punkty.Count;

        public override string ToString()
        {
            string napis ="Łamana(";
            foreach( Punkt p in punkty)
            {
                napis += p.ToString();
                napis += "; ";
            }
            napis += ")";
            return napis;
        }
    }
}
