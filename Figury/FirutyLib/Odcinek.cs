using System;
using System.Collections.Generic;
using System.Text;

namespace FirutyLib
{
    public class Odcinek : Figura, IEquatable<Odcinek>, IMierzalna1D
    {
        // dane, stan
        public Punkt Poczatek { get; set; }  //automatic property
        public Punkt Koniec   { get; set; }

        // konstruktory
        public Odcinek()
        {
            Poczatek = new Punkt(0, 0);
            Koniec = new Punkt(0, 1);
        }

        public Odcinek(Punkt a, Punkt b)
        {
            Poczatek = a;
            Koniec = b;
        }

        // zachowanie

        public override string ToString()
        {
            return $"Odcinek({Poczatek}, {Koniec})";
        }

        public double DlugoscJakoFunkcja()
        {
            //throw new NotImplementedException();
            return Math.Round(Math.Sqrt(Math.Pow(Poczatek.X - Koniec.X, 2) + Math.Pow(Poczatek.Y - Koniec.Y, 2)), 4);
        }

        //public double Dlugosc
        //{
        //    get
        //    {
        //        return Math.Sqrt(Math.Pow(Poczatek.X - Koniec.X, 2) + Math.Pow(Poczatek.Y - Koniec.Y, 2));
        //    }
        //}

        public double Dlugosc => 
            Math.Round(Math.Sqrt(Math.Pow(Poczatek.X - Koniec.X, 2) + Math.Pow(Poczatek.Y - Koniec.Y, 2)), 4);

        // Dwa odcinki są takie same, jeśli mają takie same początki i końce (z dokładności do kolejności)
        public bool Equals(Odcinek other)
        {
            if (other is null) return false;

            if (
                this.Poczatek.Equals(other.Poczatek) && this.Koniec.Equals(other.Koniec)
                ||
                this.Poczatek.Equals(other.Koniec) && this.Koniec.Equals(other.Poczatek)
               )
            {
                return true;
            }

            return false;
        }

        public override void Przesun(double dx, double dy)
        {
            Poczatek.Przesun(dx, dy);
            Koniec.Przesun(dx, dy);
        }

        public void Skaluj(double wsp)
        {
            if( wsp <= 0 )
                throw new ArgumentException("współczynnik skalowania musi być dodatni");

            throw new NotImplementedException("do opracowania");
        }
    }
}
