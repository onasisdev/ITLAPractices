﻿namespace Tarea6
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Mi Agenda Perrón");
            Console.WriteLine("Bienvenido a tu lista de contactes");

            try
            {
                Contactes contactes = new Contactes();
                contactes.FunctionsBasedOnUserSelection();
            }

            catch (FormatException)
            {
                Console.WriteLine("El formato que ha ingresado es inválido");
            }
        }
    }

    public class Contactes
    {
        public Dictionary<int, string> names = new Dictionary<int, string>();
        public Dictionary<int, string> phones = new Dictionary<int, string>();
        public Dictionary<int, string> emails = new Dictionary<int, string>();
        public List<string> addresses = new List<string>();
        public List<int> ids = new List<int>();


    public void FunctionsBasedOnUserSelection()
        {
            bool running = true;

            while (running)
            {
                Console.Write("1. Agregar Contacto      ");
                Console.Write("2. Ver Contactos     ");
                Console.Write("3. Buscar Contactos      ");
                Console.Write("4. Modificar Contacto        ");
                Console.Write("5. Eliminar Contacto     ");
                Console.WriteLine("6. Salir");
                Console.Write("Elige una opción: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddContact(ref names, ref phones, ref emails, ref addresses, ref ids);
                        break;
                    case 2:
                        ViewContacts(ref names, ref phones, ref emails, ref addresses, ref ids);
                        break;
                    case 4:
                        EditContact(ref names, ref phones, ref emails, ref addresses, ref ids);
                        break;
                    case 5:
                        DeleteContact(ref names, ref phones, ref emails, ref addresses, ref ids);
                        break;
                    case 3: //esto es intencional, no importa el orden en que pongan los cases, pero, traten de ser siempre lo mas ordenados posible
                        SearchContact(ref names, ref phones, ref emails, ref addresses, ref ids);
                        break;
                    case 6:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }
        public void AddContact(ref Dictionary<int, string> names, ref Dictionary<int, string> phones, ref Dictionary<int, string> emails, ref List<string> addresses, ref List<int> ids)
        {
            Console.WriteLine("Vamos a agregar ese contacte que te trae loco.");

            int id = ids.Count() + 1;
            ids.Add(id);
            Console.Write("Digite el Nombre: ");
            var name = Console.ReadLine();
            names.Add(id, name);
            Console.Write("Digite el Teléfono: ");
            var telefono = Console.ReadLine();
            phones.Add(id, telefono);

            Console.Write("Digite el Email: ");
            var email = Console.ReadLine();
            emails.Add(id, email);
            Console.Write("Digite la dirección: ");
            var address = Console.ReadLine();
            addresses.Add(address);
            Console.WriteLine();
        }

        public void ViewContacts(ref Dictionary<int, string> names, ref Dictionary<int, string> phones, ref Dictionary<int, string> emails, ref List<string> addresses, ref List<int> ids)
        {
            Console.WriteLine("Id           Nombre          Telefono            Email           Dirección");
            Console.WriteLine("___________________________________________________________________________");

            foreach (var id in ids)
            {
                Console.WriteLine($"{id}    {names[id]}      {phones[id]}      {emails[id]}     {addresses[id - 1]}");
            }
        }

        public void EditContact(ref Dictionary<int, string> names, ref Dictionary<int, string> phones, ref Dictionary<int, string> emails, ref List<string> addresses, ref List<int> ids)
        {
            ViewContacts(ref names, ref phones, ref emails, ref addresses, ref ids);
            Console.WriteLine("Digite un  Id de Contacto Para Editar");
            int idSeleccionado = Convert.ToInt32(Console.ReadLine());
            var nombreSeleccionado = names[idSeleccionado];
            var telefonoSeleccionado = phones[idSeleccionado];
            var emailSeleccionado = emails[idSeleccionado];
            string direccionSeleccionada = addresses[idSeleccionado - 1];

            Console.Write($"El nombre es: {nombreSeleccionado}, Digite el Nuevo Nombre: ");
            var name = Console.ReadLine();
            names.Remove(idSeleccionado);
            names.Add(idSeleccionado, name);

            Console.Write($"El Teléfono es: {telefonoSeleccionado}, Digite el Nuevo Teléfono: ");
            var telefono = Console.ReadLine();
            phones.Remove(idSeleccionado);
            phones.Add(idSeleccionado, telefono);

            Console.Write($"El Email es: {emailSeleccionado}, Digite el Nuevo Email: ");
            var email = Console.ReadLine();
            emails.Remove(idSeleccionado);
            emails.Add(idSeleccionado, email);

            Console.Write($"La dirección es: {direccionSeleccionada}, Digite la nueva dirección: ");
            var address = Console.ReadLine();
            addresses.RemoveAt(idSeleccionado - 1);
            addresses.Add(address);
        }

        public void DeleteContact(ref Dictionary<int, string> names, ref Dictionary<int, string> phones, ref Dictionary<int, string> emails, ref List<string> addresses, ref List<int> ids)
        {
            ViewContacts(ref names, ref phones, ref emails, ref addresses, ref ids);
            Console.WriteLine("Digite un Id de Contacto Para Eliminar");
            int idSeleccionado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seguro que desea eliminar? 1. Si, 2. No");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                var nombreSeleccionado = names[idSeleccionado];
                var telefonoSeleccionado = phones[idSeleccionado];
                var emailSeleccionado = emails[idSeleccionado];
                string direccionSeleccionada = addresses[idSeleccionado - 1];

                names.Remove(idSeleccionado);
                phones.Remove(idSeleccionado);
                emails.Remove(idSeleccionado);
                addresses.RemoveAt(idSeleccionado - 1);
                ids.RemoveAt(idSeleccionado - 1);
            }
        }

        public void SearchContact(ref Dictionary<int, string> names, ref Dictionary<int, string> phones, ref Dictionary<int, string> emails, ref List<string> addresses, ref List<int> ids)
        {
            ViewContacts(ref names, ref phones, ref emails, ref addresses, ref ids);
            Console.WriteLine("Digite un Id de Contacto Para Mostrar");
            int idSeleccionado = Convert.ToInt32(Console.ReadLine());
            var nombreSeleccionado = names[idSeleccionado];
            var telefonoSeleccionado = phones[idSeleccionado];
            var emailSeleccionado = emails[idSeleccionado];
            string direccionSeleccionada = addresses[idSeleccionado - 1];

            Console.Write($"El nombre es: {nombreSeleccionado}");
            Console.Write($"El Teléfono es: {telefonoSeleccionado}");
            Console.Write($"El Email es: {emailSeleccionado}");
            Console.Write($"La dirección es: {direccionSeleccionada}");
        }
    }
}