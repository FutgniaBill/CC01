using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ecole
{
	public string Name { get; set; }
	public string PostalCode { get; set; }
	public string PhoneNumber { get; set; }
	public string email { get; set; }
	public byte Logo { get; set; }

	public Ecole()
	{

	}
    public Ecole(string name, string postalCode, string phoneNumber, string email, byte logo)
    {
        Name = name;
        PostalCode = postalCode;
        PhoneNumber = phoneNumber;
        Logo = logo;
        Email = email;
    }
    public override bool Equals(object obj)
    {
        return obj is Ecole ecole &&
            Name == ecole.Name;
    }

    public override int GetHashCode()
    {
        return -1304721846 + IEqualityComparer<string>.Default.GetHashcode(Name);
    }
}
