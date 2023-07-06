using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_DemoTDD
{
    public class MathException : Exception
    {
        public MathException() : base("Math Exception")
        {
        }

        public MathException(string? message) : base(message)
        {
        }
    }

    public class OutOfRangeMathException : MathException
    {
        public OutOfRangeMathException() : base("La capacité d'un entier a été dépassé")
        {
        }

        public OutOfRangeMathException(string? message) : base(message)
        {
        }
    }
}
