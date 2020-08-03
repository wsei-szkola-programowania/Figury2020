using System;
using FirutyLib;

namespace ConsoleAppTestFigury
{
    class Program
    {
        static void Main()
        {
            // testowanie łamanej
            Lamana l1 = new Lamana();
            Console.WriteLine(l1);
            Punkt[] tab = new Punkt[4];
            tab[0] = new Punkt(-1, -1);
            tab[1] = new Punkt(0, 5);
            tab[2] = new Punkt(1, 3);
            tab[3] = new Punkt(3, 3);
            Lamana l2 = new Lamana(tab);
            Console.WriteLine(l2);
            l2.DodajNaKoniec(new Punkt(10, 10));
            l2.DodajNaPozycji(0, new Punkt(0, 0));
            Console.WriteLine(l2);
        }

        static void Main5()
        {
            Kolo k = new Kolo();
            Console.WriteLine(k);
        }

        static void Main4()
        {
            Okrag o = new Okrag();
            Console.WriteLine(o);

            Okrag o1 = new Okrag(new Punkt(1, 1), 3);
            Console.WriteLine(o1);

            Okrag o2 = new Okrag(new Punkt(-1, -1));
            Console.WriteLine(o2);
            o2.Srodek = new Punkt(0, 0);
            Console.WriteLine(o2);
            o2.Promien = -10; //???

            //Okrag o3 = new Okrag(new Punkt(0, 0), -5); // exception
        }

        static void Main3()
        {
            Trojkat t = new Trojkat();
            Console.WriteLine( t );
            Console.WriteLine( $"Trójkąt jest prostokątny: {t.JestProstokatny}");

            Trojkat t1;
            t1 = new Trojkat(new Punkt(0, 1), new Punkt(1, 1), new Punkt(-1, 1));
            Console.WriteLine( t1 );
            Console.WriteLine($"Trójkąt jest prostokątny: {t1.JestProstokatny}");
        }


        static void Main2()
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
