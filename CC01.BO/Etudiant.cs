using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    [Serializable]
    public class Etudiant
    {
        public string Identified { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string BornOn { get; set; }
        public string At { get; set; }
        public long Contact { get; set; }
        public string Email { get; set; }
        public byte[] Picture { get; set; }

        public Etudiant()
        {
        }

        public Etudiant(string identified, string last_name, string first_name, string born_on, string at, long contact, string email, byte[] picture)
        {
            Identified = identified;
            LastName = last_name;
            FirstName = first_name;
            BornOn = born_on;
            At = at;
            Contact = contact;
            Email = email;
            Picture = picture;
        }

        public override bool Equals(object obj)
        {
            return obj is Etudiant etudiant &&
                   Identified == etudiant.Identified;
        }

        public override int GetHashCode()
        {
            return 145730772 + EqualityComparer<string>.Default.GetHashCode(Identified);
        }
    }
}
