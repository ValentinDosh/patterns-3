using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAbstractFactory
{
    class NormalStudentFactory : StudentFactory
    {
        public override Achievement CreateAchivement()
        {
            return new NormalAchivement();
        }

        public override Activity CreateActivity()
        {
            return new NormalActivity();
        }

        public override EveningTime CreateEveningTime()
        {
            return new Relax();
        }
    }
}
