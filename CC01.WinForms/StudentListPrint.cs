using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.WinForms
{
    public class StudentListPrint
    {
        public string Identified { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public byte[] Picture { get; set; }
        public string SchoolName { get; set; }
        public string SchoolEmail { get; set; }
        public string SchoolPhoneNumber { get; set; }
        public string SchoolPostalCode { get; set; }
        public byte[] SchoolLogo { get; set; }

        public StudentListPrint(string identified, string lastName, string firstName, byte[] picture,
            string schoolName, string schoolEmail,
            string schoolPhoneNumber, string schoolPostalCode, byte[] schoolLogo)
        {
            this.Identified = identified;
            LastName = lastName;
            Picture = picture;
            FirstName = firstName;
            SchoolName = schoolName;
            SchoolEmail = schoolEmail;
            SchoolPhoneNumber = schoolPhoneNumber;
            SchoolPostalCode = schoolPostalCode;
            SchoolLogo = schoolLogo;
        }
    }
}
