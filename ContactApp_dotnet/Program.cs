using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp_dotnet
{
    public class Program
    {
        private static string name = "";
        private static string email = "";
        //private static double number = 0;
        private static string address = "";
        private static double id;
        private static ContactRepository _contactRepository = new ContactRepository();
        public static List<Object> contacts;
        private static bool band = false;
        private static double result = 0;
        private static double option = 0;
        //private static ITextProcessors textProcessors;

        //Test Contacts
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

        //RegularExpresions
        
        private static string regexTel = @"(^[0-9]{10}$)";
        private static string regexEmail = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
        private static string regexMenu = @"(^[0-5]{1}$)";

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
            
            Console.WriteLine("¿Desea Buscar a alguien?");
            Console.WriteLine("Seleccione una opción: \n 0.-Salir \n 1.- Agregar Contacto \n 2.- Por número \n 3.- Por nombre \n 4.- Por email \n 5.- Ver Todos");
            ProcessTextInput();
            switch (option)
            {
                case Enum.Exit: 
                    Console.WriteLine("Salir");
                    band = true;
                    return;
                case Enum.AddContact:
                    Console.WriteLine("Agregando a...");
                    AddContact();
                    return;
                case 2:
                    Console.WriteLine("Por el número...");
                    ProcessTextInput();
                    _contactRepository.SearchByNumber(result, contacts);
                    return;
                case 3: 
                    Console.WriteLine("Por nombre de: ");
                    _contactRepository.SearchByName(Console.ReadLine(), contacts);
                    return;
                case 4: 
                    Console.WriteLine("Por el correo...");
                    ProcessTextInput();
                    _contactRepository.SearchByEmail(email, contacts);
                    return;
                case 5:
                    Console.WriteLine("Mostrando toda la información");
                    _contactRepository.ViewAll(contacts);
                    return;
                default:
                    break;
            }
        }

        private static void ProcessTextInput()
        {
            string stringToProcess = Console.ReadLine();
            Regex regularExpression;
            if(StringIsNumber(stringToProcess))
            {
                if(stringToProcess.Length == 1)
                {
                    regularExpression = new Regex(regexMenu);
                    if(regularExpression.IsMatch(stringToProcess))
                    {
                        option = result;
                    }
                    else
                    {
                        Console.WriteLine("Opcion no valida");
                        ProcessTextInput();
                    }
                }
                else
                {
                    regularExpression= new Regex(regexTel);
                    if (regularExpression.IsMatch(stringToProcess))
                    {
                        Console.WriteLine("Telefono procesado");
                    }
                    else
                    {
                        Console.WriteLine("Telefono no valido");
                        ProcessTextInput();
                    }
                }
            }
            else
            {
                if(StringIsMail(stringToProcess))
                {
                    Console.WriteLine("Correo procesado");
                }
                else
                {
                    Console.WriteLine("Escriba un texto valido");
                }
            }

        }

        private static bool StringIsNumber(string parameter) 
        {
            bool flag = false;
            try
            {
                result = double.Parse(parameter);
                flag = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                flag = false;
            }
            finally
            {
                Console.WriteLine("Procediendo a lo siguiente");
            }
            return flag;

        }

        private static bool StringIsMail(string textToProcess)
        {
            Regex regularExpression = new Regex(regexEmail);
            
            if (regularExpression.IsMatch(textToProcess))
            {
                email = textToProcess;
                return true;
            }
            else
            {
                Console.WriteLine("Por favor ponga un correo electrónico");
                return false;
            }
        }

        private static void AddContact()
        {
            Console.WriteLine("Agregaremos un nuevo usuario");
            Console.WriteLine("indique su nombre:");
            name = Console.ReadLine();
            Console.WriteLine("indique su correo electronico:");
            ProcessTextInput();
            Console.WriteLine("indique su numero telefonico (solo 10 numeros):");
            ProcessTextInput();
            Console.WriteLine("indique su direccion:");
            address = Console.ReadLine();
            id = contacts.Count+1;
            Contact p = new Contact(id, name, email, result, address);
            object o = new object(); //practice of boxing
            o = p;
            _contactRepository.AddContactToList(contacts, o);
        }
    }
}
