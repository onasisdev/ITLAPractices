﻿using System.Runtime.Loader;

Console.WriteLine("Bienvenido a mi lista de Contactes");


//names, lastnames, addresses, telephones, emails, ages, bestfriend
bool runing = true;
List<int> ids = new List<int>();
Dictionary<int, string> names = new Dictionary<int, string>();
Dictionary<int, string> lastnames = new Dictionary<int, string>();
Dictionary<int, string> addresses = new Dictionary<int, string>();
Dictionary<int, string> telephones = new Dictionary<int, string>();
Dictionary<int, string> emails = new Dictionary<int, string>();
Dictionary<int, int> ages = new Dictionary<int, int>();
Dictionary<int, bool> bestFriends = new Dictionary<int, bool>();
string getName = string.Empty;
string getLastName = string.Empty;
bool contactFound = false;

try 
{
   
    while (runing)
    {
        Console.WriteLine(@"1. Agregar Contacto     2. Ver Contactos    3. Buscar Contactos     4. Modificar Contacto   5. Eliminar Contacto    6. Salir");
        Console.WriteLine("Digite el número de la opción deseada");

        int typeOption = Convert.ToInt32(Console.ReadLine());
        

        switch (typeOption)
        {
            case 1:
                {
                    AddContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
                }
                break;
            case 2: //extract this to a method
                {
                    ViewContacts(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
                }
                break;
            case 3: //search
                {
                    SearchContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends, getName, getLastName, contactFound);
                }

                break;
            case 4: //modify
                {
                    ViewContacts(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
                    ModifyContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends, getName, getLastName, contactFound);
                }
                break;

            case 5: //delete
                {
                    ViewContacts(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
                    DeleteContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends, getName, getLastName, contactFound);
                }
                break;
            case 6:
                runing = false;
                break;
            default:
                Console.WriteLine("Tu eres o te haces el idiota?");
                break;
        }
    }
}

catch (FormatException)
{
    Console.WriteLine("El valor que ha ingresado no esta en el formato correcto.");
}

static void AddContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("Digite el nombre de la persona");
    string name = Console.ReadLine();
    Console.WriteLine("Digite el apellido de la persona");
    string lastname = Console.ReadLine();
    Console.WriteLine("Digite la dirección");
    string address = Console.ReadLine();
    Console.WriteLine("Digite el telefono de la persona");
    string phone = Console.ReadLine();
    Console.WriteLine("Digite el email de la persona");
    string email = Console.ReadLine();
    Console.WriteLine("Digite la edad de la persona en números");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Especifique si es mejor amigo: 1. Si, 2. No");

    bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

    var id = ids.Count + 1;
    ids.Add(id);
    names.Add(id, name);
    lastnames.Add(id, lastname);
    addresses.Add(id, address);
    telephones.Add(id, phone);
    emails.Add(id, email);
    ages.Add(id, age);
    bestFriends.Add(id, isBestFriend);
}

static void ViewContacts(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine($"Nombre          Apellido            Dirección           Telefono            Email           Edad            Es Mejor Amigo?");
    Console.WriteLine($"____________________________________________________________________________________________________________________________");
    
    foreach (var id in ids)
    {
        var isBestFriend = bestFriends[id];

        string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";
        Console.WriteLine($"{names[id]}         {lastnames[id]}         {addresses[id]}         {telephones[id]}            {emails[id]}            {ages[id]}          {isBestFriendStr}");
    }
}

static void SearchContact(List<int> ids ,Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends, string getName, string getLastName, bool contactFound)
{

    Console.WriteLine("Ingrese el nombre del contacto que desea buscar: ");
    getName = Console.ReadLine().ToLower();

    Console.WriteLine("Ingrese el apellido del contacto que desea buscar: ");
    getLastName = Console.ReadLine().ToLower();


    foreach (var id in ids)
    {

        if (names[id].ToLower().Contains(getName) && lastnames[id].ToLower().Contains(getLastName))
        {
            
            Console.WriteLine($"""
                            Datos del contacto:
                            Nombre: {names[id]}
                            Apellido: {lastnames[id]}
                            Dirección: {addresses[id]}
                            Teléfono: {telephones[id]}
                            Email: {emails[id]}
                            Edad: {ages[id]}
                            Es mejor amigo?: {bestFriends[id]}
                            """);

            contactFound = true;
            break;
        }
    }

    if (!contactFound)
    {
        Console.WriteLine("No existe un contacto con ese nombre y apellido.");
    }
}

static void ModifyContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends, string getName, string getLastName, bool contactFound)
{
    Console.WriteLine("Ingrese el nombre del contacto en el cual desea modificar algún dato:");
    getName = Console.ReadLine().ToLower();

    Console.WriteLine("Ingrese el apellido del contacto en el cual desea modificar algún dato:");
    getLastName = Console.ReadLine().ToLower();


    foreach (var id in ids)
    {
        if (names[id].ToLower().Contains(getName) && lastnames[id].ToLower().Contains(getLastName))
        {
            contactFound = true;

            Console.WriteLine("""
                    Ingrese lo que desea modificar del contacto, las opciones son:
                    1.Nombre  2.Apellido  3.Dirección  4.Teléfono  5.Email  6.Edad  7.Es mejor amigo?
                    """);
            int selectOptionToModifyContact = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nuevo valor: ");
            var newValue = Console.ReadLine();

            Console.WriteLine("Contacto modificado satisfactoriamente.");


            switch (selectOptionToModifyContact)
            {
                case 1:

                    names[id] = newValue;

                    break;

                case 2:

                    lastnames[id] = newValue;

                    break;

                case 3:

                    addresses[id] = newValue;

                    break;

                case 4:

                    telephones[id] = newValue;

                    break;

                case 5:

                    emails[id] = newValue;

                    break;

                case 6:

                    ages[id] = Convert.ToInt32(newValue);

                    break;

                case 7:

                    bestFriends[id] = Convert.ToBoolean(newValue);

                    break;
            }
        }
    }

    if (!contactFound)
    {
        Console.WriteLine("No existe un contacto con ese nombre y apellido.");
    }

}

static void DeleteContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends, string getName, string getLastName, bool contactFound)
{
    Console.WriteLine("Ingrese el nombre del contacto que desea eliminar:");
    getName = Console.ReadLine().ToLower();

    Console.WriteLine("Ingrese el apellido del contacto que desea eliminar:");
    getLastName = Console.ReadLine().ToLower();


    foreach (var id in ids)
    {
        if (names[id].ToLower().Contains(getName) && lastnames[id].ToLower().Contains(getLastName))
        {

            names.Remove(id);
            lastnames.Remove(id);
            addresses.Remove(id);
            telephones.Remove(id);
            emails.Remove(id);
            ages.Remove(id);
            bestFriends.Remove(id);

            ids.Remove(id);

            Console.WriteLine("Contacto eliminado satisfactoriamente.");

            contactFound = true;
            break;
        }
    }

    if (!contactFound)
    {
        Console.WriteLine("No existe un contacto con ese nombre y apellido.");
    }

}