using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1Task2
{
    class TaxFreeForm
    {
        public string PassporNumber { get; set; }
         public string Name { get; set; }
         public string Adress { get; set; }
        public string Index { get; set; }
         public string Country { get; set; }
         public string Email { get; set; }
         
         public void GetForm()
         {
             Console.WriteLine(PassporNumber + Name + Adress + Index + Country + Email);
        }
}
}
