using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;



namespace SecondTask
{
public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cuenta account = new Cuenta(0, 0, 0, 0);
                account.HacerIngreso();
                account.HacerTransferencia();
                account.Reintegro();
                account.MostrarValores();
            }
            catch (FormatException)
            {
                Console.WriteLine("El formato que ha ingresado no es válido.");
            }
         

            Console.ReadKey();
        }

        public class Cuenta
        {
            public decimal Enter { get; set; }
            public decimal Withdrawal { get; set; }
            public decimal Transference { get; set; }
            public int WishToMakeWithdrawalOrTransference{ get; set; }

            public Cuenta(decimal enter, decimal withdrawal, decimal transference, int wishToMakeWithdrawalOrTransference)
            {
                this.Enter = enter;
                this.Withdrawal = withdrawal;
                this.Transference = transference;
                this.WishToMakeWithdrawalOrTransference = wishToMakeWithdrawalOrTransference;

            }

            public void HacerIngreso()
            {
                Console.WriteLine("Por favor digite la cantidad que desea ingresar a su cuenta.");
                Enter = Convert.ToDecimal(Console.ReadLine());

                if (Enter == 0)
                {
                    Console.WriteLine("Debe digitar una cantidad mayor que 0 para poder ingresar dinero a su cuenta.");
                }
            }

            public void HacerTransferencia()
            {
                Console.WriteLine("¿Desea hacer una transferencia? 1.Sí 2.No");
                WishToMakeWithdrawalOrTransference = Convert.ToInt32(Console.ReadLine());

                if (WishToMakeWithdrawalOrTransference == 1)
                {
                    Console.WriteLine("Por favor ingrese la cantidad que desea transferir:");
                    Transference = Convert.ToDecimal(Console.ReadLine());
                } 
                else if (WishToMakeWithdrawalOrTransference > 2 || WishToMakeWithdrawalOrTransference == 0)
                {
                    Console.WriteLine("Debe seleccionar la opción 1 si desea hacer una transferencia.");
                }
            }
            public void Reintegro()
            {
                Console.WriteLine("¿Desea realizar un reintegro a su cuenta? 1.Sí 2.No");
                WishToMakeWithdrawalOrTransference = Convert.ToInt32(Console.ReadLine());

                if (WishToMakeWithdrawalOrTransference == 1)
                {
                    Console.WriteLine("Por favor ingrese la cantidad que desea reintegrar:");
                    Withdrawal = Convert.ToDecimal(Console.ReadLine());
                }
                else if (WishToMakeWithdrawalOrTransference > 2 || WishToMakeWithdrawalOrTransference == 0)
                {
                    Console.WriteLine("Debe seleccionar la opción 1 si desea hacer un reintegro.");
                }
            }

            public void MostrarValores()
            {
                Console.WriteLine($"""
                    Dinero total ingresado:{Enter} 
                    Dinero total transferido: {Transference} 
                    Dinero total reintegrado: {Withdrawal}
                    """
                );
            }
        }
    }
} 
