using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAbstractFactory
{
    class BadStudentFactory : StudentFactory
    {
        public override Achievement CreateAchivement()
        {
            return new BadAchivement();
        }

        public override Activity CreateActivity()
        {
            return new BadActivity();
        }

        public override EveningTime CreateEveningTime()
        {
            return new Party();
        }
    }
}
