using crm.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemCostPlatform.Core.Sales
{

    public class SalesTransaction
    {
        public SalesTransaction(Customer billTo)
        {
            BillTo = billTo;
        }
        public Customer BillTo { get; internal set; }
        public string[] Items { get; set; }

        public void PostInvoice(string invoiceNumber, DateTime date)
        {
            // Do the Logic here
            //Console.WriteLine($"{date}");
        }
    }
}
