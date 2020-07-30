using System;
using System.Collections.Generic;
using System.Text;

namespace FirutyLib
{
    public class Kolo : Okrag, IEquatable<Kolo>
    {

        // nie dziedziczone są konstruktory
        public Kolo(Punkt srodek, double promien) : base(srodek, promien)
        {

        }

        public Kolo() : base() { }

        // dodatkowe zachowanie
        public double Obwod => Dlugosc;

        public double Pole => Math.Round( Math.PI * Math.Pow(Promien,2) , 4);

        public override string ToString() => $"Kolo({Srodek}, {Promien})";

        public bool Equals(Kolo other)
        {
            if (other is null || !(other is Kolo))
                return false;

            return (this.Srodek.Equals(other.Srodek) && this.Promien.Equals(other.Promien));
        }
        
    }
}
