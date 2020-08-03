using System;
using System.Collections.Generic;
using System.Text;

namespace FirutyLib
{
    public interface IMierzalna
    {
        void Skaluj(double wsp);
    }

    public interface IMierzalna1D : IMierzalna
    {
        double Dlugosc { get; }
    }

    public interface IMierzalna2D : IMierzalna1D
    {
        double Obwod { get; }
        double Pole { get; }
    }
}
