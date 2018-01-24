using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAbstractFactory
{
    // аактивность студнета
    abstract class Activity
    {
        // работа на уроке
        public abstract string WorkAtTheLesson { get; }
    }
}
