using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1Task2
{
    class TaxFreeBuilder : IFormBuilder
    {
        TaxFreeForm _form = new TaxFreeForm();
 
         public IFormBuilder BuidName(string name)
         {
            _form.Name = "ФИО: " + name + "\n";
             return this;
         }
 
         public IFormBuilder BuidNumberPassport(string number)
         {
             _form.PassporNumber = "Номер заграничного паспорта: " + number + "\n";
             return this;
         }
 
         public IFormBuilder BuidAdress(string adress)
         {
             _form.Adress = "Адрес получателя: " + adress + "\n";
             return this;
         }
 
         public IFormBuilder BuidIndex(string index)
         {
             _form.Index = "Индекс получателя: " + index + "\n";
             return this;
         }
 
         public IFormBuilder BuidCountry(string country)
         {
             _form.Country = "Страна получателя: " + country + "\n";
             return this;
         }
 
         public IFormBuilder BuidEmail(string email)
         {
            _form.Email = "Email: " + email;
             return this;
         }
 
 
         public TaxFreeForm GetTaxForm()
         {
             return _form;
         }
    }
}
