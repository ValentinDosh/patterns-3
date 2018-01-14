using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1Task2
{
    interface IFormBuilder
    {
        IFormBuilder BuidNumberPassport(string s);
         IFormBuilder BuidName(string s);
         IFormBuilder BuidAdress(string s);
         IFormBuilder BuidIndex(string s);
         IFormBuilder BuidCountry(string s);
         IFormBuilder BuidEmail(string s);
 
         TaxFreeForm GetTaxForm();
    }
}
