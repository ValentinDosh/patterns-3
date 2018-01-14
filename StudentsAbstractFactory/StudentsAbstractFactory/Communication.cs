using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAbstractFactory
{
    class Communication : EveningTime
    {
        public override void Do()
        {
            Console.WriteLine("повышает свои навыки владения русским языком.");
        }
    }
}
