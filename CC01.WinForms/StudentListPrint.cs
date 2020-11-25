using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.WinForms
{
    public class StudentListPrint
    {
        public string BornOn { get; set; }
        public string Identified { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public byte[] Picture { get; set; }

        public StudentListPrint(string bornOn,string identified, string lastName, string firstName, byte[] picture)
        {
            BornOn = bornOn;
            Identified = identified;
            LastName = lastName;
            FirstName = firstName;
            Picture = picture;

        }

    }
}
