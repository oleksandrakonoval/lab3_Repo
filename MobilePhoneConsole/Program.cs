using SimCorp.IMS.MobilePhoneLibrary.MobilePhone;
using System;

namespace SimCorp.IMS.MobilePhoneConsole {
    class Program {

        static void Main(string[] args) {
            SimCorpMobile MyMobile = new SimCorpMobile();
            Console.WriteLine();
            Console.WriteLine("_____________________________________________");
            MyMobile.ConfigureMobile();
            Console.ReadKey();
        }
    }
}
