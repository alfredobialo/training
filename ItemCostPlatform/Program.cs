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
            Console.WriteLine(bc.FullName);
            Console.WriteLine(new BankCustomer().PurchaseMsg);
            Customer a = new Customer {
                FirstName = "Segun",
                LastName = "Arinze",
                Age = 50,

            };
            SalesTransaction st = new SalesTransaction(a);
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
