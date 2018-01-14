using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAbstractFactory
{
    class Relax : EveningTime
    {
        public override void Do()
        {
            Console.WriteLine("смотрит сериал.");
        }
    }
}
