using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Отличник
            Student student1 = new Student(new GoodStudentFactory());
            student1.DisplayInfo();
            student1.Do();
            Console.WriteLine();

            // средний
            Student student2 = new Student(new NormalStudentFactory());
            student2.DisplayInfo();
            student2.Do();
            Console.WriteLine();

            // Отсталый
            Student student3 = new Student(new BadStudentFactory());
            student3.DisplayInfo();
            student3.Do();
            Console.WriteLine();

            // Иностранец
            Student student4= new Student(new ForeignStudentFactory());
            student4.DisplayInfo();
            student4.Do();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
