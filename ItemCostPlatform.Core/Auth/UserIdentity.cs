using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemCostingPlatform.Auth
{
    public class UserIdentity
    {
        public string  Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string  EmailAddress { get; set; }
        //public Address ContactAddress { get; set; } Not Relevant we can get this from user's company info

        public UserCompany CompanyInfo { get; internal set; }

        public UserIdentity()
        {
            // Instantiate  Company info
            CompanyInfo = new UserCompany();
        }

        public UserIdentity(string id,
            string firstName, 
            string lastName,
            string emailAddress) : this(id, firstName, lastName)
        {
            EmailAddress = emailAddress;
        }
        public UserIdentity(string id, 
            string firstName, string lastName) :  this()
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id ?? Guid.NewGuid().ToString();
        }

        public string FullName2
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
         }
        public string FullName => $"{FirstName ?? "" } {LastName ?? ""}"; 
    }
}
