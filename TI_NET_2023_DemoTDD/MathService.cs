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

        public float Addition(float nb1, float nb2)
        {
            if (nb1 > 0 && nb2 > float.MaxValue - nb1)
                throw new OutOfRangeMathException();

            if (nb1 < 0 && nb2 < float.MinValue - nb1)
                throw new OutOfRangeMathException();

            return nb1 + nb2;
        }

        public int Soustraction(int nb1, int nb2)
        {
            if((long)nb1 - (long)nb2 < int.MinValue ||  (long)nb1 - (long) nb2 > int.MaxValue)
            {
                throw new OutOfRangeMathException();
            }
            return nb1 - nb2;
        }

        public int Multiplication(int nb1, int nb2)
        {
            if((long)nb1 * (long)nb2 > int.MaxValue || (long)nb1 * (long)nb2 < int.MinValue)
            {
                throw new OutOfRangeMathException();
            }
            return nb1 * nb2;
        }

        public int Division(int nb1, int nb2)
        {
            if(nb2 == 0)
            {
                throw new DividedByZeroMathException();
            }
            return nb1 / nb2;
        }

        public bool IsEven(int nb)
        {
            return nb % 2 == 0;
        }

    }
}
