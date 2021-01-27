using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class NeedCreditManager : ICreditManager
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Hazırlandı.");
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}
