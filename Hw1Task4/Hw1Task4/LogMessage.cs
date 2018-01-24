using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1Task4
{
    class LogMessage
    {
        private static LogMessage writer;

        private StreamWriter st;

        private LogMessage() { }

        public static LogMessage GetWriter()
        {
            if (writer == null)
            {
                writer = new LogMessage();
            }
            return writer;
        }

        // метод для записи в файл
        public void Write(string str)
        {
            using (st = new StreamWriter(@"D:\log.txt", true))
            {
                st.WriteLine(str);
            }

        }
    }
}
