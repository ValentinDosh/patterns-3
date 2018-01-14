using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hw1_Task1
{
    class Factorial
    {
        public int Number { get; private set; }
        public BigInteger Result { get; private set; }
        public bool IsInUse { get; set; }

        public Factorial()
        {
            Console.WriteLine("Trying To Create...");
            Thread.Sleep(2000);

            Random forFactorial = new Random();
            Number = forFactorial.Next(100, 10000);
            Result = Calculation(Number);
            Console.WriteLine("Factorial created...");
        }

        private BigInteger Calculation(int number)
        {
            BigInteger sum = number;
            while (number > 1)
            {
                number--;
                sum *= number;
            }
            return sum;
        }
    }
}
