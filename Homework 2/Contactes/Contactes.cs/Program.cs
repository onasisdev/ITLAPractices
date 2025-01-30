using System;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

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


while (runing)
{
    Console.WriteLine(@"1. Agregar Contacto     2. Ver Contactos    3. Buscar Contactos     4. Modificar Contacto   5. Eliminar Contacto    6. Salir");
    Console.WriteLine("Ingrese el número de la opción deseada");

    int typeOption = Convert.ToInt32(Console.ReadLine());

    switch (typeOption)
    {
        case 1:
            {
                //Console.WriteLine("Ingrese el nombre de la persona");
                //string name = Console.ReadLine();
                //Console.WriteLine("Ingrese el apellido de la persona");
                //string lastname = Console.ReadLine();
                //Console.WriteLine("Ingrese la dirección");
                //string address = Console.ReadLine();
                //Console.WriteLine("Ingrese el telefono de la persona");
                //string phone = Console.ReadLine();
                //Console.WriteLine("Ingrese el email de la persona");
                //string email = Console.ReadLine();
                //Console.WriteLine("Ingrese la edad de la persona en números");
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
                Console.WriteLine("Ingrese el nombre del contacto que desea buscar:");
                var nombreContacto = Console.ReadLine();


                foreach (var id in ids)
                {
                    var getName = names[id];
                    var getLastname = lastnames[id];
                    var getAdress = addresses[id];
                    var getTelephone = telephones[id];
                    var getEmail = emails[id];
                    var getAge = ages[id];
                    var getBestFriend = bestFriends[id];


                    if (nombreContacto == getName) {

                        Console.WriteLine($"Datos del contacto: \n " +
                            $"Nombre: {getName}\n" +
                            $"Apellido: {getLastname}\n" +
                            $"Dirección: {getAdress}\n" +
                            $"Teléfono: {getTelephone}\n" +
                            $"Email: {getEmail}\n" +
                            $"Edad: {getAge}\n" +
                            $"Es mejor amigo? {getBestFriend}\n");
                    }  
                }
            }


            break;
        case 4: //modify

            {
                Console.WriteLine("Ingrese el nombre del contacto que desea modificar:");
                var nombreContacto_m = Console.ReadLine();


                foreach (var id in ids)
                {

                    var getName_m = names[id];
                    var getLastname_m = lastnames[id];
                    var getAdress_m = addresses[id];
                    var getTelephone_m = telephones[id];
                    var getEmail_m = emails[id];
                    var getAge_m = ages[id];
                    var getBestFriend_m = bestFriends[id];


                    if (nombreContacto_m == names[id])
                    {
                        Console.WriteLine("Ingrese lo que desea modificar:");
                        var elemento_modificar = Console.ReadLine();
                        Console.WriteLine("Agregue el nuevo valor:");
                        var nuevo_valor = Console.ReadLine();

                        if (elemento_modificar == "Nombre" && nombreContacto_m == names[id])
                        {
                            names[id] = nuevo_valor;

                        }

                        if (elemento_modificar == "Apellido" && nombreContacto_m == names[id])
                        {
                            lastnames[id] = nuevo_valor;
                        }

                        if (elemento_modificar == "Direccion" && nombreContacto_m == names[id])
                        {
                            addresses[id] = nuevo_valor;
                        }

                        if (elemento_modificar == "Telefono" && nombreContacto_m == names[id])
                        {
                            telephones[id] = nuevo_valor;
                        }

                        if (elemento_modificar == "Email" && nombreContacto_m == names[id])
                        {
                            emails[id] = nuevo_valor;
                        }

                        if (elemento_modificar == "Edad" && nombreContacto_m == names[id])
                        {
                            ages[id] = int.Parse(nuevo_valor);

                        }

                        if (elemento_modificar == "Mejor Amigo" && nombreContacto_m == names[id])
                        {
                            bestFriends[id] = bool.Parse(nuevo_valor);
                        }
                    } 
                }


                break;
            }
        case 5: //delete
            {
                Console.WriteLine("Ingrese el nombre del contacto que desea eliminar: ");
                var nombreContacto_d = Console.ReadLine();


                foreach (var id in ids)
                {
                    var getName_d = names[id];
                    var getLastname_d = lastnames[id];
                    var getAdress_d = addresses[id];
                    var getTelephone_d = telephones[id];
                    var getEmail_d = emails[id];
                    var getAge_d = ages[id];
                    var getBestFriend_d = bestFriends[id];
                    

                    if (nombreContacto_d == names[id])
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
                break;
            }
            
    
        case 6:
            runing = false;
            break;
        default:
            Console.WriteLine("Tu eres o te haces el idiota?");
            break;
    }
}


static void AddContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("Ingrese el nombre de la persona");
    string name = Console.ReadLine();
    Console.WriteLine("Ingrese el apellido de la persona");
    string lastname = Console.ReadLine();
    Console.WriteLine("Ingrese la dirección");
    string address = Console.ReadLine();
    Console.WriteLine("Ingrese el telefono de la persona");
    string phone = Console.ReadLine();
    Console.WriteLine("Ingrese el email de la persona");
    string email = Console.ReadLine();
    Console.WriteLine("Ingrese la edad de la persona en números");
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