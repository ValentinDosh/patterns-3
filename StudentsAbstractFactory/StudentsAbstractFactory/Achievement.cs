using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAbstractFactory
{
    // успеваемость
    abstract class Achievement
    {
        // средний бал студента
       public abstract int Mark { get; }
    }
}
