using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crm.core
{
   public class Person
   {
        private float height;
        private string firstName ;
        private string lastName;
        private int age =10;


        public int Age { get => age; set  => age =value; }
        public float Height { get => height; set => height = value; }
        public string FirstName
        {
            get
            {
                if (firstName == null)
                    firstName = "N/A";
                return firstName;
            }
            set
            {
                
                firstName = value;
            }
        }
        public string LastName { get; set; } 

        


   }

   
}



