using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp_dotnet_business.Model;

public class Contact
{
    public double Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public double Phone { get; set; }
    public string Address { get; set; }

    public Contact(double id, string name, string email, double phone, string address = null)
    {
        Id = id;
        Name = name;
        Email = email;
        Phone = phone;
        Address = address != null ? address : this.Address;
    }
}
