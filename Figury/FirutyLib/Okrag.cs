using System;
using System.Collections.Generic;
using System.Text;

namespace FirutyLib
{
    public class Okrag : Figura, IEquatable<Okrag>
    {
        public Punkt Srodek { get; set; }

        private double r;
        public double Promien 
        { 
            get => r;
            set
            {
                if( value < 0 )
                {
                    throw new InvalidOperationException("promień nie może być ujemny");
                }
                r = Math.Round(value, 4);
            } 
        }

        // konstruktory

        public Okrag( Punkt srodek, double promien = 1)
        {
            Srodek = srodek;
            Promien = promien;
        }

        public Okrag() : this(new Punkt(0, 0), 1) { }

        // zachowanie

        public override string ToString() => $"Okrag({Srodek}, {Promien})";

        public bool Equals(Okrag other)
        {
            if (other is null) return false;

            return (this.Srodek.Equals(other.Srodek) && this.Promien.Equals(other.Promien));
        }

        public override void Przesun(double dx, double dy)
        {
            Srodek.Przesun(dx, dy);
        }

        public double Dlugosc => Math.Round( 2 * Math.PI * Promien, 4);
    }
}
