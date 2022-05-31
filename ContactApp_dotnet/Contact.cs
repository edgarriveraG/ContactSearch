using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp_dotnet
{
    public class Contact
    {
        int id;
        string name = "";
        string email = "";
        int phone;
        string address = "";

        public void AddContact(List<Object> o, Object c)
        {
            o.Add(c);
        }

        public Contact()
        {

        }
        public Contact(int i, string n, string e, int p, string a)
        {
            id = i;
            name = n;
            email = e;
            phone = p;
            address = a != null ? a : this.address;
        }

        public void SearchByNumber(int num, List<object> list)
        {
            //
        }

        public void SearchByName(string name, List<object> list)
        {
            //
        }

        public void SearchByEmail(string mail, List<object> list)
        {
            //
        }
    }
}
