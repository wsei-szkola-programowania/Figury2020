using System;
using System.Collections.Generic;
using System.Text;

namespace FirutyLib
{
    public class Prostokat : Kwadrat
    {
        private double drugiBok;
        public double DrugiBok
        {
            get => drugiBok;
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("bok nie może być ujemny");
                }
                drugiBok = Math.Round(value, 4);
            }
        }

        public Prostokat(Punkt srodek, double pierwszyBok = 1, double drugiBok = 1) : base(srodek, pierwszyBok)
        {
            DrugiBok = drugiBok;
            kolor = Kolor.czerwony;
        }

        public Prostokat() //: base()
        {
            DrugiBok = 1;
        }

        public override string ToString() => $"Prostokat({Srodek}, {Bok}, {DrugiBok})";

        public override double Obwod => Math.Round( 2*Bok + 2*DrugiBok, 4);

        public new double Pole => Math.Round(Bok * DrugiBok, 4);

        public new void Skaluj(double wsp)
        {
            if (wsp <= 0)
                throw new ArgumentException("współczynnik nie może być ujemny");

            Bok *= wsp;
            DrugiBok *= wsp;
        }
    }
}
