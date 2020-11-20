using CC01.BLL;
using CC01.BO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CC01
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "y";
            do
            {
                Console.Clear();
            Console.WriteLine("----------------------------Create a New student----------------------------");
            
            Console.Write("Enter Lastname\t:");
            string lastname = Console.ReadLine();
            Console.Write("Enter Firstname\t:");
            string firstname = Console.ReadLine();
            Console.Write("Born on\t:");
            string bornOn = Console.ReadLine();
            Console.Write("At\t:");
            string at = Console.ReadLine();
            Console.Write("Enter Identified\t:");
            string identified = Console.ReadLine();
            Console.Write("Enter Contact\t:");
            long contact = long.Parse(Console.ReadLine());
            Console.Write("Enter Email\t:");
            string email = Console.ReadLine();

            Etudiant etudiant = new Etudiant(lastname, firstname, bornOn, at, identified,contact,email,null);
            EtudiantBLO etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
            etudiantBLO.CreateEtudiant(etudiant);

            IEnumerable<Etudiant> etudiants = etudiantBLO.GetAllEtudiants();
            foreach (Etudiant p in etudiants)
            {
                Console.WriteLine($"{p.LastName}\t{p.FirstName}\t{p.BornOn}\t{p.At}\t{p.Identified}\t{p.Contact}\t{p.Email}");
            }

            Console.Write("Create another student?[y/n]:");
            choice = Console.ReadLine();
        }
            while (choice.ToLower() != "n");
            Console.WriteLine("Program end !");

            Console.ReadKey();
        
}
    }
}
