using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAbstractFactory
{
    class Party : EveningTime
    {
        public override void Do()
        {
            Console.WriteLine("употребляет алкоголь и курит сигареты с друзьями.");
        }
    }
}
