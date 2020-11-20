using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    [Serializable]
    public class Ecole
    {
        public string Name { get; set; }
        public string PostalCode { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }

        public Ecole()
        {
        }

        public Ecole(string name, string postalCode, long phoneNumber, string email, string logo)
        {
            Name = name;
            PostalCode = postalCode;
            PhoneNumber = phoneNumber;
            Email = email;
            Logo = logo;
        }


    }
}
