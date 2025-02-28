using System.Runtime.Loader;

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
                    //Console.WriteLine("Digite el nombre de la persona");
                    //string name = Console.ReadLine();
                    //Console.WriteLine("Digite el apellido de la persona");
                    //string lastname = Console.ReadLine();
                    //Console.WriteLine("Digite la dirección");
                    //string address = Console.ReadLine();
                    //Console.WriteLine("Digite el telefono de la persona");
                    //string phone = Console.ReadLine();
                    //Console.WriteLine("Digite el email de la persona");
                    //string email = Console.ReadLine();
                    //Console.WriteLine("Digite la edad de la persona en números");
                    //int age = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("Especifique si es mejor amigo: 1. Si, 2. No");
                    ////var temp = Convert.ToInt32(Console.ReadLine());
                    ////bool isBestFriend;
                    ////if (temp == 1)
                    ////{ isBestFriend = true; }
                    ////else
                    ////{ isBestFriend = false; }
                    //bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

                    //var id = ids.Count + 1;
                    //ids.Add(id);
                    //names.Add(id, name);
                    //lastnames.Add(id, lastname);
                    //addresses.Add(id, address);
                    //telephones.Add(id, phone);
                    //emails.Add(id, email);
                    //ages.Add(id, age);
                    //bestFriends.Add(id, isBestFriend);

                    AddContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);

                }
                break;
            case 2: //extract this to a method
                {
                    Console.WriteLine($"Nombre          Apellido            Dirección           Telefono            Email           Edad            Es Mejor Amigo?");
                    Console.WriteLine($"____________________________________________________________________________________________________________________________");
                    foreach (var id in ids)
                    {
                        var isBestFriend = bestFriends[id];

                        //string isBestFriendStr;

                        //if (isBestFriend == true)
                        //{
                        //    isBestFriendStr = "Si";
                        //}
                        //else {
                        //    isBestFriendStr = "No";
                        //}

                        string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";
                        Console.WriteLine($"{names[id]}         {lastnames[id]}         {addresses[id]}         {telephones[id]}            {emails[id]}            {ages[id]}          {isBestFriendStr}");
                    }

                }
                break;
            case 3: //search
                {
                    Console.WriteLine("Ingrese el nombre del contacto que desea buscar: ");
                    var getName = Console.ReadLine();

                    Console.WriteLine("Ingrese el apellido del contacto que desea buscar: ");
                    var getLastName = Console.ReadLine();

                    foreach (var id in ids)
                    {

                        if (getName == names[id] && getLastName == lastnames[id])
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
                        }
                    }
                }

                break;
            case 4: //modify
                {
                    Console.WriteLine("Ingrese el nombre del contacto en el cual desea modificar algún dato:");
                    var getNameForTheModifyMethod = Console.ReadLine();

                    Console.WriteLine("Ingrese el apellido del contacto en el cual desea modificar algún dato:");
                    var getLastNameForTheModifyMethod = Console.ReadLine();


                    foreach (var id in ids)
                    {
                        if (!getNameForTheModifyMethod.Contains(names[id]) || !getLastNameForTheModifyMethod.Contains(lastnames[id]))
                        {
                            Console.WriteLine("""
                            Si el programa le permite ingresar un nuevo valor, significa que ha ingresado el nombre y apellido correctamente.
                            De lo contrario, los ha ingresado incorrectamente.
                            """);
                        }

                        if (getNameForTheModifyMethod == names[id] && getLastNameForTheModifyMethod == lastnames[id])
                        {
                            Console.WriteLine("""
                    Ingrese lo que desea modificar del contacto, las opciones son:
                    1.Nombre  2.Apellido  3.Dirección  4.Teléfono  5.Email  6.Edad  7.Es mejor amigo?
                    """);
                            int selectOptionToModifyContact = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Ingrese el nuevo valor: ");
                            var newValue = Console.ReadLine();


                            switch (selectOptionToModifyContact)
                            {
                                case 1:

                                    if (getNameForTheModifyMethod == names[id] && getLastNameForTheModifyMethod == lastnames[id])
                                    {
                                        names[id] = newValue;
                                    }

                                    break;

                                case 2:

                                    if (getNameForTheModifyMethod == names[id] && getLastNameForTheModifyMethod == lastnames[id])
                                    {
                                        lastnames[id] = newValue;
                                    }

                                    break;

                                case 3:

                                    if (getNameForTheModifyMethod == names[id] && getLastNameForTheModifyMethod == lastnames[id])
                                    {
                                        addresses[id] = newValue;
                                    }

                                    break;

                                case 4:

                                    if (getNameForTheModifyMethod == names[id] && getLastNameForTheModifyMethod == lastnames[id])
                                    {
                                        telephones[id] = newValue;
                                    }

                                    break;

                                case 5:

                                    if (getNameForTheModifyMethod == names[id] && getLastNameForTheModifyMethod == lastnames[id])
                                    {
                                        emails[id] = newValue;
                                    }

                                    break;

                                case 6:

                                    if (getNameForTheModifyMethod == names[id] && getLastNameForTheModifyMethod == lastnames[id])
                                    {
                                        ages[id] = Convert.ToInt32(newValue);
                                    }

                                    break;

                                case 7:
                                    if (getNameForTheModifyMethod == names[id] && getLastNameForTheModifyMethod == lastnames[id])
                                    {
                                        bestFriends[id] = Convert.ToBoolean(newValue);
                                    }

                                    break;
                            }
                        }
                    }
                }
                break;

            case 5: //delete
                {
                    Console.WriteLine("Ingrese el nombre del contacto que desea eliminar:");
                    var getNameForTheDeleteMethod = Console.ReadLine();

                    Console.WriteLine("Ingrese el apellido del contacto que desea eliminar:");
                    var getLastNameForTheDeleteMethod = Console.ReadLine();


                    foreach (var id in ids)
                    {
                        if (getNameForTheDeleteMethod == names[id] && getLastNameForTheDeleteMethod == lastnames[id])
                        {
                            names[id] = string.Empty;
                            lastnames[id] = string.Empty;
                            addresses[id] = string.Empty;
                            telephones[id] = string.Empty;
                            emails[id] = string.Empty;
                            ages[id] = default;
                            bestFriends[id] = default;
                        }
                    }
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