using System;
using System.Collections.Generic;
using System.Text;

namespace FirutyLib
{
    public enum Kolor
    {
        czarny = 1, bialy = 2, czerwony = 4, zielony, niebieski
    }


    abstract public class Figura
    {
        public Kolor kolor { get; set; }

        public Figura(Kolor k)
        {
            kolor = k;
        }

        public Figura()
        {
            kolor = Kolor.czarny;
        }

        abstract public void Przesun(double dx, double dy);

    }
}
