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

        public static void Main(string[] args)
        {
            AddContact();
            while (!band)
            {
                Menu();
            }
        }

        public static void AddContact()
        {
            contacts = new List<Object>();
            while (contacts.Count < 10)
            {
                Console.WriteLine("Agregaremos un nuevo usuario");
                Console.WriteLine("Indique su nombre:");
                name = Console.ReadLine();
                Console.WriteLine("Indique su correo electronico:");
                email = Console.ReadLine();
                Console.WriteLine("Indique su numero telefonico (Solo 10 numeros):");
                number = StringIsNumber();
                Console.WriteLine("Indique su direccion:");
                address = Console.ReadLine();
                id = new Random().Next(20);
                Contact p = new Contact(id, name, email, number, address);
                Object o = new Object(); //Practice of Boxing
                o = p;
                contacts.Add(o);
            }
        }
        public static void Menu()
        {
            double op = 0;
            Console.WriteLine("¿Desea Buscar a alguien?");
            Console.WriteLine("Seleccione una opción: \n 0.-Salir \n 1.- Por número \n 2.- Por nombre \n 3.- Por email");
            op = StringIsNumber();
            switch (op)
            {
                case 0: 
                    Console.WriteLine("Salir");
                    band = true;
                    return;
                case 1:
                    Console.WriteLine("Por el número...");
                    c.SearchByNumber(StringIsNumber(), contacts);
                    return;
                case 2: 
                    Console.WriteLine("Por nombre de: ");
                    c.SearchByName(Console.ReadLine(), contacts);
                    return;
                case 3: 
                    Console.WriteLine("Por el correo...");
                    c.SearchByEmail(Console.ReadLine(), contacts);
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

    }
}
