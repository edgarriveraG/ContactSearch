using Model;

namespace ContactApp_dotnet_business;

public class ContactRepository
{
    private IEnumerable<Contact> _contactList{ get; set; }

    public void AddContactToList(Contact contact)
    {
        try
        {
            _contactList.Add(contact);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + "\n" + "Intente de nuevo");
        }
        finally
        {
            Console.WriteLine("Proceso de agregar terminado");
        }
    }

    public Contact SearchByPhone(double phone)
    {
        _contactList.ForEach(contact =>
        {
            if (contact.Phone == phone)
            {
                // Console.WriteLine("Mostrando información del contacto con ID: " + contact.Id);
                // Console.WriteLine("Nombre: " + contact.Name);
                // Console.WriteLine("Correo: " + contact.Email);
                // Console.WriteLine("Telefono: " + contact.Phone);
                // Console.WriteLine("Direccion: " + contact.Address);
                // Console.WriteLine("\n");
                return contact;
            }
        });
    }

    public Contact SearchByName(string name)
    {
        _contactList.ForEach(contact => 
        {
            if (contact.Name == name)
            {
                // Console.WriteLine("Mostrando información del contacto con ID: " + contact.Id);
                // Console.WriteLine("Nombre: " + contact.Name);
                // Console.WriteLine("Correo: " + contact.Email);
                // Console.WriteLine("Telefono: " + contact.Phone);
                // Console.WriteLine("Direccion: " + contact.Address);
                // Console.WriteLine("\n");
                return contact;
            }
        });
    }

    public Contact SearchByEmail(string email)
    {
        _contactList.ForEach(contact =>
        {
            if (contact.Email == email)
            {
                // Console.WriteLine("Mostrando información del contacto con ID: " + contact.Id);
                // Console.WriteLine("Nombre: " + contact.Name);
                // Console.WriteLine("Correo: " + contact.Email);
                // Console.WriteLine("Telefono: " + contact.Phone);
                // Console.WriteLine("Direccion: " + contact.Address);
                // Console.WriteLine("\n");
                return contact;
            }
        });
    }

    public IEnumerable<Contact> ViewAll()
    {
        // _contactList.ForEach(contact =>
        // {
        //     Console.WriteLine("Mostrando información del contacto con ID: " + contact.Id);
        //     Console.WriteLine("Nombre: " + contact.Name);
        //     Console.WriteLine("Correo: " + contact.Email);
        //     Console.WriteLine("Telefono: " + contact.Phone);
        //     Console.WriteLine("Direccion: " + contact.Address);
        //     Console.WriteLine("\n");
        // });
        return _contactList;
    }
}
