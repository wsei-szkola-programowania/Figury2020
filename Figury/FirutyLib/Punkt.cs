using System;

namespace FirutyLib
{
    public class Punkt
    {
        #region stan -> pola, właściwości
        double x;
        double y;
        #endregion

        #region konstrukcja -> konstruktory
        Punkt() // konstruktor bezparametrowy, domyślny
        {
            x = y = 0;            
        }

        Punkt( double x, double y )
        {
            this.x = x;
            this.y = y;
        }
        #endregion


        #region zachowanie -> właściwości, metody

        void Przesun(double dx, double dy)
        {
            x = x + dx; // x += dx
            y = y + dy; // y += dy
        }

        #endregion
    }
}
