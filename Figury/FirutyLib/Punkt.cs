using System;

namespace FirutyLib
{
    public class Punkt : IEquatable<Punkt>
    {
        #region stan -> pola, właściwości
        public double x;
        public double y;
        #endregion

        #region konstrukcja -> konstruktory
        public Punkt() // konstruktor bezparametrowy, domyślny
        {
            x = y = 0;            
        }

        public Punkt( double x, double y )
        {
            this.x = x;
            this.y = y;
        }

        #endregion


        #region zachowanie -> właściwości, metody

        public void Przesun(double dx, double dy)
        {
            x = x + dx; // x += dx
            y = y + dy; // y += dy
        }

        public override string ToString()
        {
            return $"Punkt({x}, {y})";
        }

        public override bool Equals(object obj)
        {
            if (obj is Punkt)
                return this.Equals((Punkt)obj);
            else
                return false;
        }

        public bool Equals(Punkt other)
        {
            if (other == null) return false;

            if (this.x == other.x && this.y == other.y)
                return true;
            else
                return false;
        }

        #endregion
    }
}
