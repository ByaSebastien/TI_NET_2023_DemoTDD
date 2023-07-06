using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_DemoTDD
{
    public interface IMathService
    {
        int Addition(int nb1, int nb2);
        int Soustraction(int nb1, int nb2);
        int Multiplication(int nb1, int nb2);
        int Division(int nb1, int nb2);
        int Puissance(int nb1, int exposant);
        double Racine(int nb1, int racine);
        bool isEven(int nb);
    }
}
