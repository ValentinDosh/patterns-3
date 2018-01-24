using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // создан 1 факториал
            FactorialPool pool = new FactorialPool(3);

            Factorial f1 = pool.GetFactorial();
            Factorial f2 = pool.GetFactorial();
            Factorial f3 = pool.GetFactorial();

            Factorial f4 = pool.GetFactorial();

            // освободим первый обьект и еще раз попробуем создать факториал
            pool.ReleaseFactorial(f1);
            pool.createFactorial();
            f1 = pool.GetFactorial();

        }
    }
}
