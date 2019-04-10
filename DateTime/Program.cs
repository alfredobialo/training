using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DateTimeDemo
{
    // Datetime / TimeSpan
    class Program
    {

        
        static void Main(string[] args)
        {

            var states = new List<string>
            {
                "Abia",
                "Adamawa",
                "Akwa",
                "Anambra",
                "Bauchi ",
                "Bayelsa",
                "Benue  ",
                "Borno  ",
                "Cross  ",
                "Delta  ",
                "Ebonyi ",
                "Edo    ",
                "Ekiti  ",
                "Enugu  ",
                "Gombe  ",
                "Imo    ",
                "Jigawa ",
                "Kaduna ",
                "Kano   "
            };

            var abcd   = "rtfcfhgfgygh";

            var someStates  = states
                                .Skip(3)
                                .Where( x => x.StartsWith("E"))
                                .Take(5);
                 //LINQ               


           
                              
            foreach(string s in someStates)
            {
                WriteLine(s.Trim());
            }


            var today = DateTime.Today;
            WriteLine(today);


            DateTime nowUtc = DateTime.UtcNow;
            DateTime now = DateTime.UtcNow;
            WriteLine($"Now : {now}, UTC Now : {nowUtc}");

            DateTime dateOfBirth = new DateTime(1993, 06, 05);

            var age = DateTime.Today.Subtract(dateOfBirth).TotalDays;
            WriteLine(age/365);
            //dateOfBirth.Month = 7;

            //1 Month
            var durationInDays = 7; // Week

            DateTime subscriptionDate = DateTime.Now, expiresOn = subscriptionDate.AddDays(durationInDays);
            string msg = $"Welcomne to MTN Data Plan for {durationInDays}";
            SendSmsSubscription(msg, expiresOn);

            ReadKey();
        }
        static void oldMain(string[] args)
        {
            DateTime today = DateTime.Today;
            WriteLine(today);


            DateTime nowUtc = DateTime.UtcNow;
            DateTime now = DateTime.UtcNow;
            WriteLine($"Now : {now}, UTC Now : {nowUtc}");

            DateTime dateOfBirth = new DateTime(1993, 06, 05);

            double age = DateTime.Today.Subtract(dateOfBirth).TotalDays;
            WriteLine(age/365);
            //dateOfBirth.Month = 7;

            //1 Month
            int durationInDays = 7; // Week

            DateTime subscriptionDate = DateTime.Now, expiresOn = subscriptionDate.AddDays(durationInDays);
            string msg = $"Welcomne to MTN Data Plan for {durationInDays}";
            SendSmsSubscription(msg, expiresOn);

            ReadKey();
        }
        private static void SendSmsSubscription(string msg, DateTime expiresOn)
        {
            WriteLine(msg);
            // Send expiration to database
        }
    }
}
