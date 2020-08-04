using System;
using System.Collections.Generic;
using System.Text;


namespace FirutyLib
{
    public class Lamana : Figura, IMierzalna1D
    {
        //Punkt[] punkty; // tablica punktów - niewygodne
        private List<Punkt> punkty;
        public IReadOnlyList<Punkt> Punkty => punkty.AsReadOnly();

        public Lamana()
        {
            punkty = new List<Punkt>();
            punkty.Add(new Punkt(0, 0));
            punkty.Add(new Punkt(1, 1));
            kolor = Kolor.zielony;
        }

        public Lamana( params Punkt[] ciagPunktow )
        {
            kolor = Kolor.zielony;
            if ( ciagPunktow.Length < 2 )
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

        public double Dlugosc
        {
            get
            {
                List<Odcinek> odcinki = new List<Odcinek>();
                Punkt poczatek = punkty[0];
                Punkt koniec = punkty[1];
                odcinki.Add(new Odcinek(poczatek, koniec));
                for(int i=1; i < punkty.Count-1; i++)
                {
                    poczatek = punkty[i];
                    koniec = punkty[i + 1];
                    odcinki.Add(new Odcinek(poczatek, koniec));
                }
                double suma = 0;
                foreach(var odc in odcinki)
                {
                    suma += odc.Dlugosc;
                }
                return suma;
            }
        }

        public override string ToString()
        {
            string napis ="Łamana(";
            //foreach (Punkt p in punkty)
            //{
            //    napis += p.ToString();
            //    napis += "; ";
            //}
            napis += string.Join("; ", punkty);
            napis += ")";
            return napis;
        }

        public override void Przesun(double dx, double dy)
        {
            foreach( var p in punkty )
            {
                p.Przesun(dx, dy);
            }
        }

        public void Skaluj(double wsp)
        {
            throw new NotImplementedException();
        }
    }
}
