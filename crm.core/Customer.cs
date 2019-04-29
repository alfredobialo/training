using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crm.core
{

    // Customer Inherits from the person class
    public class Customer : Person
    {

        protected string purchMsg = "";
        public Customer()
        {
             MakeNewPurchaseOrder();
        }
        public Customer(string firstName, string lastName) :this()

        {
            FirstName = firstName;
            LastName = lastName;
           
        }

       
        void MakeNewPurchaseOrder()
        {
            purchMsg = "Making new Purchase Order";
        }

        public virtual int Return10()
        {
            return 10;
        }
     }



    public class BankCustomer : Customer
    {
        public BankCustomer()
        {
          purchMsg = "blsshdkbjsadhfsd";

        }


        void DoNothing( string data)
        {
            if(data == "1")
                return;
            Console.Write(data);
        }
        public static int Add(ref int x , ref int y)
        {
            x += 10;
            y *= 2;
            return x + y;
        }
        public static void Add( int a,  int b, out int c)
        {
            c = a + b;
        }
        public BankCustomer(string firstName, string lastName) : base(firstName, lastName)
        {
           
        }

        public string PurchaseMsg => purchMsg;

        public void DoSomething()
        {
            Console.WriteLine("base.Return10() =" + base.Return10());
            Console.WriteLine("this.Return10() = " + this.Return10());
        }
        public override int Return10()
        {
            return 110;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
