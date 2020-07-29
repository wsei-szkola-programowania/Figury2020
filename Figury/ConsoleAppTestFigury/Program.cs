using System;
using FirutyLib;

namespace ConsoleAppTestFigury
{
    class Program
    {

        static void Main()
        {
            Punkt a = new Punkt(1, 2);
            Punkt b = new Punkt(3, 4);
            Odcinek o = new Odcinek(a, b);
            Console.WriteLine( o );
            Console.WriteLine( o.DlugoscJakoFunkcja() );
            Console.WriteLine( o.Dlugosc );

            Odcinek o1 = new Odcinek(b, a);
            Console.WriteLine( o == o1 ); // false
            Console.WriteLine( o.Equals(o1) ); // true, bo zdefiniowane Equals
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("Hello World!");
            Punkt a = new Punkt();
            Console.WriteLine( a.ToString() );
            a.Przesun(dx: +1, dy: -1);
            Console.WriteLine( a );
            Punkt b = a;
            Console.WriteLine(a == b);
            b.Przesun(-1, 1);
            Console.WriteLine(a == b);
            Console.WriteLine( b );
            Punkt c = new Punkt(0, 0);
            Console.WriteLine(b == c); // referencyjne równa się
            Console.WriteLine( b.Equals(c) ); // równość Equals
            a.X = 10.54238658; //wykonanie `set`
            a.Y = -1.2345;
            Console.WriteLine( a );
        }
    }
}
