using ItemCostingPlatform.Auth;
using ItemCostPlatform.Core.Sales;
using crm.core;
//using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace ItemCostingPlatform
{
    
    class Program
    {
       // [STAThread]
        static void Main(string[] args)
        {


            BankCustomer bc = new BankCustomer("John","Doe");
            int a = 60; int b = 40;

            Console.WriteLine($"Before Call : a ={a}, b ={b}");
            int c = BankCustomer.Add(ref a, ref b);

            Console.WriteLine($"After Call: a ={a}, b ={b}, c ={c}");

            BankCustomer.Add(a, b, out int d);

            Console.WriteLine(d);
            Console.ReadLine();

            bc.DoSomething();
            Console.ReadLine();
            Console.WriteLine(bc.FullName);
            Console.WriteLine(new BankCustomer().PurchaseMsg);
            Customer a1 = new Customer {
                FirstName = "Segun",
                LastName = "Arinze",
                Age = 50,

            };
            SalesTransaction st = new SalesTransaction(a1);
            SalesTransaction st2 = new SalesTransaction(new Customer {
                FirstName ="Alfred",
                LastName ="Obialo",

            });


            new SalesTransaction(new Customer {
                FirstName ="Alfred",
                LastName ="Obialo",

            }).PostInvoice("INV-0001",DateTime.Today.AddHours(-3));

           // CreateFile($"{a.FirstName} {a.LastName}");

            UserIdentity user1 = new UserIdentity();
            
            user1.CompanyInfo.Name = "New Company";
            Console.WriteLine(user1.CompanyInfo.Name);
            Console.WriteLine("Hello Dll");
            ReadLine();
        }



        //public static void CreateFile(string fileContent)
        //{
        //    Open a dialog for selecting the file

        //   SaveFileDialog saveFile = new SaveFileDialog();
        //    saveFile.DefaultExt = ".txt";
        //    saveFile.Title = "Choose where to create your new File";
        //    saveFile.Filter = "Text Files";
        //    if (saveFile.ShowDialog() == DialogResult.OK)
        //    {
        //        StreamWriter writer = File.CreateText(saveFile.FileName);
        //        writer.WriteLine(fileContent);
        //        writer.Close();

        //    }
      
        //}
        public string GetName(Person person)
        {
            return person.FullName;
        }
    }
}
