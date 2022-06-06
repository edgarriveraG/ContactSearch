using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp_dotnet
{
    public class Program
    {
        private static string name = "";
        private static string email = "";
        private static double number = 0;
        private static string address = "";
        private static double id;
        private static Contact c = new Contact();
        public static List<Object> contacts;
        private static bool band = false;
        private static Contact p1 = new Contact(1,"Edgar", "edgar@mail.com",1111234567,"calle 1 #100");
        private static Contact p2 = new Contact(2, "Daniel", "daniel@mail.com", 2221234567, "calle 2 #200");
        private static Contact p3 = new Contact(3, "Dulce", "dulce@mail.com", 3331234567, "calle 3 #300");
        private static Contact p4 = new Contact(4, "Aurora", "aurora@mail.com", 4441234567, "calle 4 #400");
        private static Contact p5 = new Contact(5, "Lorena", "lore@mail.com", 5551234567, "calle 5 #500");
        private static Contact p6 = new Contact(6, "Victor", "victor@mail.com", 6661234567, "calle 6 #600");
        private static Contact p7 = new Contact(7, "Cesar", "cesar@mail.com", 7771234567, "calle 7 #700");
        private static Contact p8 = new Contact(8, "Jorge", "jorge@mail.com", 8881234567, "calle 8 #800");
        private static Contact p9 = new Contact(9, "Ana", "ana@mail.com", 9991234567, "calle 9 #900");
        private static Contact p10 = new Contact(10, "Laura", "laura@mail.com", 9993456789, "calle 10 #1000");

        public static void Main(string[] args)
        {
            InitializeContacts();
            while (!band)
            {
                Menu();
            }
        }

        public static void InitializeContacts()
        {
            contacts = new List<Object>();
            Object o1 = p1;
            contacts.Add(o1);
            Object o2 = p2;
            contacts.Add(o2);
            Object o3 = p3;
            contacts.Add(o3);
            Object o4 = p4;
            contacts.Add(o4);
            Object o5 = p5;
            contacts.Add(o5);
            Object o6 = p6;
            contacts.Add(o6);
            Object o7 = p7;
            contacts.Add(o7);
            Object o8 = p8;
            contacts.Add(o8);
            Object o9 = p9;
            contacts.Add(o9);
            Object o10 = p10;
            contacts.Add(o10);
            //while (contacts.Count < 10)
            //{
            //    
            //    contacts.Add(o);
            //}
        }

        public static void Menu()
        {
            double op = 0;
            Console.WriteLine("¿Desea Buscar a alguien?");
            Console.WriteLine("Seleccione una opción: \n 0.-Salir \n 1.- Agregar Contacto \n 2.- Por número \n 3.- Por nombre \n 4.- Por email \n 5.- Ver Todos");
            op = StringIsNumber();
            switch (op)
            {
                case 0: 
                    Console.WriteLine("Salir");
                    band = true;
                    return;
                case 1:
                    Console.WriteLine("Agregando a...");
                    AddContact();
                    return;
                case 2:
                    Console.WriteLine("Por el número...");
                    c.SearchByNumber(StringIsNumber(), contacts);
                    return;
                case 3: 
                    Console.WriteLine("Por nombre de: ");
                    c.SearchByName(Console.ReadLine(), contacts);
                    return;
                case 4: 
                    Console.WriteLine("Por el correo...");
                    c.SearchByEmail(Console.ReadLine(), contacts);
                    return;
                case 5:
                    Console.WriteLine("Mostrando toda la información");
                    c.ViewAll(contacts);
                    return;
                default:
                    break;
            }
        }

        private static double StringIsNumber()
        {
            string str = Console.ReadLine();
            double result = 0;
            if (str.Length == 10)
            {
                try
                {
                    result = double.Parse(str);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    result = StringIsNumber();
                }
                finally
                {
                    Console.WriteLine("Procediendo al siguiente paso");
                }
            }
            else if (str.Length > 1 && (str.Length < 10 || str.Length > 10 ))
            {
                Console.WriteLine("Por favor de un número válido");
                StringIsNumber();
            }
            else if (str.Length == 1)
            {
                try
                {
                    result = double.Parse(str);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    result = StringIsNumber();
                }
                finally
                {
                    Console.WriteLine("Procediendo al siguiente paso");
                }
            }
            return result;
        }

        private static void AddContact()
        {
            Console.WriteLine("Agregaremos un nuevo usuario");
            Console.WriteLine("indique su nombre:");
            name = Console.ReadLine();
            Console.WriteLine("indique su correo electronico:");
            email = Console.ReadLine();
            Console.WriteLine("indique su numero telefonico (solo 10 numeros):");
            number = StringIsNumber();
            Console.WriteLine("indique su direccion:");
            address = Console.ReadLine();
            id = new Random().Next(20);
            Contact p = new Contact(id, name, email, number, address);
            object o = new object(); //practice of boxing
            o = p;
            c.AddContactToList(contacts, o);
        }
    }
}
