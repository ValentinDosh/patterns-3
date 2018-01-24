using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAbstractFactory
{
     abstract class StudentFactory
    {
        public abstract Achievement CreateAchivement();
        public abstract Activity CreateActivity();
        public abstract EveningTime CreateEveningTime();
    }
}
