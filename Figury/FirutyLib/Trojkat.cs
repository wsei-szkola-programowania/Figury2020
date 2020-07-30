using System;
using System.Collections.Generic;
using System.Text;

namespace FirutyLib
{
    public class Trojkat
    {
        // dane -> stan
        public Punkt A { get; set; }
        public Punkt B { get; set; }
        public Punkt C { get; set; }

        private Odcinek bok1;
        private Odcinek bok2;
        private Odcinek bok3;


        // konstruktory
        public Trojkat(Punkt a, Punkt b, Punkt c)
        {
            A = a;
            B = b;
            C = c;
            bok1 = new Odcinek(A, B);
            bok2 = new Odcinek(B, C);
            bok3 = new Odcinek(C, A);
        }

        public Trojkat() : this(new Punkt(0, 0), new Punkt(0, 1), new Punkt(1, 0)) // łańcuchowanie konstruktorów
        {

        }

        // metody -> zachowanie

        public override string ToString() => $"Trojkat({A}, {B}, {C})";
        //{
        //    return $"Trojkat({A}, {B}, {C})";
        //}

        public double Obwod
        {
            get
            {
                return bok1.Dlugosc + bok2.Dlugosc + bok3.Dlugosc;
            }
        }

        public bool JestProstokatny
        {
            get
            {
                // z Pitagorasa, ale można z iloczynu skalarnego
                double a = bok1.Dlugosc;
                double b = bok2.Dlugosc;
                double c = bok3.Dlugosc;
                if (
                     Math.Round(a * a + b * b - c * c, 4) == 0      // a * a + b * b == c * c 
                    ||
                     Math.Round(a * a + c * c - b * b, 4) == 0
                    ||
                     Math.Round(b * b + c * c - a * a, 4) == 0
                   )
                    return true;

                return false;
            }
        }
    }
}
