using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAbstractFactory
{
    class Student
    {
        private Achievement achivement;
        private Activity activity;
        private EveningTime eveningTime;

        public Student(StudentFactory factory)
        {
            achivement = factory.CreateAchivement();
            activity = factory.CreateActivity();
            eveningTime = factory.CreateEveningTime();
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Средний бал этого студента: {0}", achivement.Mark);
            Console.WriteLine("На уроке этот студент {0}", activity.WorkAtTheLesson);
        }

        public void Do()
        {
            Console.Write("Сейчас вечер и этот студент ");
            eveningTime.Do();
        }
    }
}
