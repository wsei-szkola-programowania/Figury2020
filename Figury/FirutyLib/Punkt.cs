using System;

namespace FirutyLib
{
    /// <summary>
    /// Punkt na płaszczyźnie w wariancie mutable
    /// reprezentowany przez liczbę rzeczywistą zaokrągloną do 2 miejsc po przecinku
    /// </summary>
    public class Punkt : Figura, IEquatable<Punkt>
    {
        #region stan -> pola, właściwości
        private double x;
        public double X // read-write do x
        {
            get
            {
                return x;
            }
            set
            {
                x =  Math.Round(value, 2);
            }
        }


        private double y;
        public double Y
        {
            get => y;
            set => y = Math.Round(value, 2);
        }

        #endregion

        #region konstrukcja -> konstruktory
        public Punkt() // konstruktor bezparametrowy, domyślny
        {
            x = y = 0;            
        }

        public Punkt( double x, double y )
        {
            this.X = x;
            this.Y = y;
        }

        #endregion


        #region zachowanie -> właściwości, metody

        override public void Przesun(double dx, double dy)
        {
            X = x + dx; // x += dx
            Y = y + dy; // y += dy
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

        public override int GetHashCode()
        {
            int hashCode = 1502939027;
            hashCode = hashCode * -1521134295 + x.GetHashCode();
            hashCode = hashCode * -1521134295 + y.GetHashCode();
            return hashCode;
        }

        #endregion
    }
}
