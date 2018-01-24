using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAbstractFactory
{
    class GoodStudentFactory : StudentFactory
    {
        public override Achievement CreateAchivement()
        {
            return new GoodAchivment();
        }

        public override Activity CreateActivity()
        {
            return new GoodActivity();
        }

        public override EveningTime CreateEveningTime()
        {
            return new Working();
        }
    }
}
