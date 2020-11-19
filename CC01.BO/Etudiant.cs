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
        public string Last_name { get; set; }
        public string First_name { get; set; }
        public DateTime Born_on { get; set; }
        public long Contact { get; set; }
        public string Email {get;set;}

        public Etudiant()// constucteur vide important pour la sérialisation
        {

        }
        public Etudiant(string identified,string last_name,string first_name, DateTime born_on,long contact,string email)
        {
            Identified=identified;
            Last_name=last_name;
            First_name=first_name;
            Born_on=born_on;
            Contact=contact;
            Email=email;
        }
        public override bool Equals(object obj)
        {
            return obj is Etudiant etudiant &&
                Identified==etudiant.Identified;
        }

        public override int GetHashCode()
        {
            return -1304721846+IEqualityComparer<string>.Default.GetHashcode(Identified);
        }
    }
}
