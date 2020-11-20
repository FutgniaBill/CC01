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

        public StudentListPrint(string identified, string lastName, string firstName)
        {
            Identified = identified;
            LastName = lastName;
            FirstName = firstName;
        }

    }
}
