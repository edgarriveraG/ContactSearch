using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp_dotnet
{
    public class Contact
    {
        double id;
        string name = "";
        string email = "";
        double phone;
        string address = "";

        public Contact()
        {

        }
        public Contact(double i, string n, string e, double p, string a)
        {
            id = i;
            name = n;
            email = e;
            phone = p;
            address = a != null ? a : this.address;
        }

        public void SearchByNumber(double num, List<object> list)
        {
            list.ForEach(o =>
            {
                Contact c = new Contact();
                c = (Contact)o;
                if (c.phone == num)
                {
                    Console.WriteLine(c);
                    return;
                }
            });
        }

        public void SearchByName(string name, List<object> list)
        {
            list.ForEach(o => 
            {
                Contact c = new Contact();
                c = (Contact)o;
                if (c.name == name)
                {
                    Console.WriteLine(c);
                    return ;
                }
            });
        }

        public void SearchByEmail(string mail, List<object> list)
        {
            list.ForEach(o =>
            {
                Contact c = new Contact();
                c = (Contact)o;
                if (c.email == mail)
                {
                    Console.WriteLine(c);
                    return;
                }
            });
        }
    }
}
