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
        public Customer(string firstName, string lastName) : 
            ()
        {
            FirstName = firstName;
            LastName = lastName;
           
        }

       
        void MakeNewPurchaseOrder()
        {
            purchMsg = "Making new Purchase Order";
        }

        public int Return10()
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

        public BankCustomer(string firstName, string lastName) : base(firstName, lastName)
        {
           
        }

        public string PurchaseMsg => purchMsg;

        public void DoSomething()
        {
            base.Return10();
            this.Return10();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
