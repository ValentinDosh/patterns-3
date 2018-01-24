using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAbstractFactory
{
    class Working : EveningTime
    {
        public override void Do()
        {
            Console.WriteLine("читает дополнительный материал по теме урока.");
        }
    }
}
