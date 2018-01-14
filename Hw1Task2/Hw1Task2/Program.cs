using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormBuilder builder = new TaxFreeBuilder();
            TaxFreeForm form1 = builder.BuidNumberPassport("12345678").BuidName("Дощечко " +
"Валентин Виктоович").BuidAdress("Минск, Бельского 24-35").BuidIndex("220018").

 BuidCountry("Беларусь").BuidEmail("Chikitan@gmail.com").GetTaxForm();
            
            form1.GetForm();
        }
    }
}
