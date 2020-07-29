using System;
using FirutyLib;

namespace ConsoleAppTestFigury
{
    class Program
    {
        static void Main(string[] args)
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

        }
    }
}
