using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // перед запуском создать файл log.txt на диске D
            LogMessage sw = LogMessage.GetWriter();
            sw.Write("Helo");
            sw.Write("How are you?");
            LogMessage sw2 = LogMessage.GetWriter();
            // запись в тот же файл
            sw2.Write("I am Ok");
        }
    }
}
