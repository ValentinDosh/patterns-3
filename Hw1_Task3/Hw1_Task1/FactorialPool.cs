using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1_Task1
{
    class FactorialPool
    {
        private readonly int maxSize;
        private readonly IList<Factorial> factorials;

        public FactorialPool(int maxSize)
        {
            factorials = new List<Factorial> { new Factorial() };
            this.maxSize = maxSize;
        }

        public Factorial GetFactorial()
        {
            // запрос 
            var factorial = factorials.FirstOrDefault(c => !c.IsInUse) ?? createFactorial();
            if (factorial != null)
                factorial.IsInUse = true;
            return factorial;
        }

        // метод который определяет занят ли обьект
        public void ReleaseFactorial(Factorial factorial)
        {
            if (!factorials.Contains(factorial))
            {
                throw new InvalidOperationException("Connection" + "does not belong the connection pool");
            }

            factorial.IsInUse = false;
        }


        public Factorial createFactorial()
        {
            if (factorials.Count < maxSize)
            {
                var factorial = new Factorial();
                factorials.Add(factorial);
                return factorial;
            }
            else
            {
                // если есть не не занятый факториал удаляем его создаем новый

                foreach (var factoria in factorials)
                {
                    if (!factoria.IsInUse)
                    {
                        Console.WriteLine("У нас есть не используемый факториал в пуле, удвляем его и создаем новый");
                        factorials.Remove(factoria);
                        var FactorialNew = new Factorial();
                        factorials.Add(FactorialNew);
                        return FactorialNew;
                    }

                }
                Console.WriteLine("Пул переполнен ожидайте осовобождения");
            }
            return null;
        }
    }
}
