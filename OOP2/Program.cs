using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Gerçek Müşteri - Tüzel Müşteri
            //Bunlar birbirlerinin yerine asla kullanılamazlar
            //SOLID -> L

            IndividualCustomer individualCustomer = new IndividualCustomer();
            individualCustomer.Id = 1;
            individualCustomer.CustomerNumber = "123456";
            individualCustomer.CustomerName = "Merve";
            individualCustomer.CustomerSurname = "KÜÇÜKDOĞRU";
            individualCustomer.IdentityNumber = "444444444444";


            CorporateCustomer corporateCustomer = new CorporateCustomer();
            corporateCustomer.Id = 2;
            corporateCustomer.CustomerNumber = "987654";
            corporateCustomer.CompanyName = "Merve Teknoloji";
            corporateCustomer.TaxNumber = "5555555";


            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}
