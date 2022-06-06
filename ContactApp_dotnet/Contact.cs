using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp_dotnet
{
    public class Contact
    {
        public double Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double Phone { get; set; }
        public string Address { get; set; }

        public Contact()
        {

        }
        public Contact(double i, string n, string e, double p, string a)
        {
            Id = i;
            Name = n;
            Email = e;
            Phone = p;
            Address = a != null ? a : this.Address;
        }

        public void AddContactToList(List<object> list, Object contact)
        {
            list.Add(contact);
        }

        public void SearchByNumber(double num, List<object> list)
        {
            list.ForEach(o =>
            {
                Contact contact = new Contact();
                contact = (Contact)o;
                if (contact.Phone == num)
                {
                    Console.WriteLine("Mostrando información del contacto con ID: " + contact.Id);
                    Console.WriteLine("Nombre: " + contact.Name);
                    Console.WriteLine("Correo: " + contact.Email);
                    Console.WriteLine("Telefono: " + contact.Phone);
                    Console.WriteLine("Direccion: " + contact.Address);
                    Console.WriteLine("\n");
                    return;
                }
            });
        }

        public void SearchByName(string name, List<object> list)
        {
            list.ForEach(o => 
            {
                Contact contact = new Contact();
                contact = (Contact)o;
                if (contact.Name == name)
                {
                    Console.WriteLine("Mostrando información del contacto con ID: " + contact.Id);
                    Console.WriteLine("Nombre: " + contact.Name);
                    Console.WriteLine("Correo: " + contact.Email);
                    Console.WriteLine("Telefono: " + contact.Phone);
                    Console.WriteLine("Direccion: " + contact.Address);
                    Console.WriteLine("\n");
                    return ;
                }
            });
        }

        public void SearchByEmail(string mail, List<object> list)
        {
            list.ForEach(o =>
            {
                Contact contact = new Contact();
                contact = (Contact)o;
                if (contact.Email == mail)
                {
                    Console.WriteLine("Mostrando información del contacto con ID: " + contact.Id);
                    Console.WriteLine("Nombre: " + contact.Name);
                    Console.WriteLine("Correo: " + contact.Email);
                    Console.WriteLine("Telefono: " + contact.Phone);
                    Console.WriteLine("Direccion: " + contact.Address);
                    Console.WriteLine("\n");
                    return;
                }
            });
        }

        public void ViewAll(List<Object> list)
        {
            list.ForEach(o =>
            {
                Contact contact = new Contact();
                contact = (Contact)o;
                Console.WriteLine("Mostrando información del contacto con ID: " + contact.Id);
                Console.WriteLine("Nombre: " + contact.Name);
                Console.WriteLine("Correo: " + contact.Email);
                Console.WriteLine("Telefono: " + contact.Phone);
                Console.WriteLine("Direccion: " + contact.Address);
                Console.WriteLine("\n");
            });
        }
    }
}
