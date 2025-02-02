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
                Console.WriteLine("Por favor ingrese el nombre del contacto que desea buscar:");
                var getUserContactNameForTheSearchMethod = Console.ReadLine();


                foreach (var id in ids)
                {
                    var userContactName = names[id];
                    var userLastname = lastnames[id];
                    var userAdress = addresses[id];
                    var userTelephone = telephones[id];
                    var userEmail = emails[id];
                    var userAge = ages[id];
                    var userBestFriend = bestFriends[id];


                    if (getUserContactNameForTheSearchMethod == names[id])
                    {

                        Console.WriteLine($"Datos del contacto: \n " +
                            $"Nombre: {userContactName}\n" +
                            $"Apellido: {userLastname}\n" +
                            $"Dirección: {userAdress}\n" +
                            $"Teléfono: {userTelephone}\n" +
                            $"Email: {userEmail}\n" +
                            $"Edad: {userAge}\n" +
                            $"¿Es mejor amigo? {userBestFriend}\n");
                    }  
                }
            }


            break;
        case 4: //modify

            {
                Console.WriteLine("Por favor ingrese el nombre del contacto que desea modificar:");
                var getUserContactNameForTheModifyMethod = Console.ReadLine();


                foreach (var id in ids)
                {

                    var getUserContactNameToAddNewValue = names[id];
                    var getUserLastNameToAddNewValue = lastnames[id];
                    var getUserAdressToAddNewValue = addresses[id];
                    var getUserTelephoneToAddNewValue = telephones[id];
                    var getUserEmailToAddNewValue = emails[id];
                    var getUserAgeToAddNewValue = ages[id];
                    var getUserfriendToAddNewValue = bestFriends[id];


                    if (getUserContactNameForTheModifyMethod == names[id])
                    {
                        Console.WriteLine("Por favor ingrese un número en base a lo que desee modificar del contacto. \n " +
                            "Opciones: 1. Nombre, 2. Apellido, 3. Direccion, 4. Telefono, 5. Email, 6. Edad, 7. Mejor Amigo.");
                        var modify_element = Console.ReadLine();
                        Console.WriteLine("Por favor agregue el nuevo valor:");
                        var new_value = Console.ReadLine();

                        if (modify_element == "1" && getUserContactNameForTheModifyMethod == names[id])
                        {
                            names[id] = new_value;

                        }

                        if (modify_element == "2" && getUserContactNameForTheModifyMethod == names[id])
                        {
                            lastnames[id] = new_value;
                        }

                        if (modify_element == "3" && getUserContactNameForTheModifyMethod == names[id])
                        {
                            addresses[id] = new_value;
                        }

                        if (modify_element == "4" && getUserContactNameForTheModifyMethod == names[id])
                        {
                            telephones[id] = new_value;
                        }

                        if (modify_element == "5" && getUserContactNameForTheModifyMethod == names[id])
                        {
                            emails[id] = new_value;
                        }

                        if (modify_element == "6" && getUserContactNameForTheModifyMethod == names[id])
                        {
                            ages[id] = int.Parse(new_value);

                        }

                        if (modify_element == "7" && getUserContactNameForTheModifyMethod == names[id])
                        {
                            bestFriends[id] = bool.Parse(new_value);
                        }
                    } 
                }


                break;
            }
        case 5: //delete
            {
                Console.WriteLine("Por favor ingrese el nombre del contacto que desea eliminar: ");
                var getUserContactNameForTheDeleteMethod = Console.ReadLine();


                foreach (var id in ids)
                {
                    var getUserContactNameToDeleteContact = names[id];
                    var getUserLastNameToDeleteContact = lastnames[id];
                    var getUserAdressToDeleteContact = addresses[id];
                    var getUserTelephoneToDeleteContact = telephones[id];
                    var getUserEmailToDeleteContact = emails[id];
                    var getUserAgeToDeleteContact = ages[id];
                    var getUserfriendToDeleteContact = bestFriends[id];


                    if (getUserContactNameForTheDeleteMethod == names[id])
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