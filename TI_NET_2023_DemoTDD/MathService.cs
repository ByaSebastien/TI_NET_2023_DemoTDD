using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_DemoTDD
{
    public class MathService : IMathService
    {
        public int Addition(int nb1, int nb2)
        {
            if((long)nb1 + (long)nb2 > int.MaxValue || (long)nb1 + (long)nb2 < int.MinValue)
            {
                throw new OutOfRangeMathException();
            }
            return nb1 + nb2;
        }

        public int Soustraction(int nb1, int nb2)
        {
            throw new NotImplementedException();
        }

        public int Multiplication(int nb1, int nb2)
        {
            throw new NotImplementedException();
        }

        public int Division(int nb1, int nb2)
        {
            throw new NotImplementedException();
        }

        public int Puissance(int nb1, int exposant)
        {
            throw new NotImplementedException();
        }

        public double Racine(int nb1, int racine)
        {
            throw new NotImplementedException();
        }

        public bool isEven(int nb)
        {
            throw new NotImplementedException();
        }

    }
}
