using System;
using System.Collections.Generic;
using System.Text;

namespace FirutyLib
{
    /// <summary>
    /// Figura Kwadrat reprezentowana punktem na przecięciu przekątnych i długością boku.
    /// Odpowiednie boki kwadratu są równoległoe do osi układu
    /// </summary>
    public class Kwadrat : Figura, IMierzalna2D
    {
        public Punkt Srodek { get; set; }

        private double bok;
        public double Bok 
        { 
            get => bok;
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("bok nie może być ujemny");
                }
                bok = Math.Round(value, 4);
            } 
        }

        public Kwadrat(Punkt srodek, double bok = 1)
        {
            Srodek = srodek;
            Bok = bok;
        }

        public Kwadrat() : this(new Punkt(0, 0), 1)
        { }

        public override string ToString() => $"Kwadrat({Srodek}, {Bok})";

        public override void Przesun(double dx, double dy)
        {
            Srodek.Przesun(dx, dy);
        }

        public void Skaluj(double wsp)
        {
            if( wsp <= 0 )
                throw new ArgumentException("współczynnik skalowania musi być dodatni");

            Bok *= wsp;
        }

        virtual public double Obwod => Math.Round(4 * Bok, 4);

        public double Pole => Math.Round(Bok * Bok, 4);

        public double Dlugosc => Obwod;
    }
}
