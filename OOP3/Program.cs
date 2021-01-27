using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager needCreditManager = new NeedCreditManager();         
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager housingCreditManager = new HousingCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggerServices = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };
            
            
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(needCreditManager, loggerServices);

            List<ICreditManager> credits = new List<ICreditManager>() { needCreditManager, vehicleCreditManager};

            //applicationManager.MakeCreditPriorInformation(credits);
        }
    }
}
