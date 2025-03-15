using System.Reflection.Metadata;

namespace FifthTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Fraccion fraction = new Fraccion();
                fraction.OperacionSeleccionada();
               
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No es posible dividir entre 0.");

            }
            catch (FormatException)
            {
                Console.WriteLine("El formato ingresado no es válido.");
            }
        }
    }

    public class Fraccion
    {
        public decimal UserFirstFractionAndNumerator { get; set; }
        public decimal UserFirstFractionAndDenominator { get; set; }
        public decimal UserSecondFractionAndNumerator { get; set; }
        public decimal UserSecondFractionAndDenominator { get; set; }
        public decimal FractionCalc { get; set; }
        public int SelectedOperation { get; set; }

        public Fraccion()
        {
            this.UserFirstFractionAndNumerator = 0;
            this.UserFirstFractionAndDenominator = 0;
            this.UserSecondFractionAndNumerator = 0; 
            this.UserSecondFractionAndDenominator = 0;
            this.FractionCalc = 0;
        }

        public void OperacionSeleccionada()
        {
            Console.WriteLine("""
                Por favor seleccione la operación que desee realizar de fracciones:
                1.Suma 2.Resta 3.Multiplicación 4.División
                """);


            SelectedOperation = Convert.ToInt32(Console.ReadLine());

            switch (SelectedOperation)
            {
                case 1:
                    PreguntasParaHacerOperacionesFraccionarias();
                    Console.WriteLine($"""
                    El resultado de la operación es:
                    {SumarFracciones(UserFirstFractionAndNumerator, UserFirstFractionAndDenominator, UserSecondFractionAndNumerator, UserSecondFractionAndDenominator, FractionCalc)}
                    """);
                    
                    break;

                case 2:
                    PreguntasParaHacerOperacionesFraccionarias();
                    Console.WriteLine($"""
                    El resultado de la operación es:
                    {RestarFracciones(UserFirstFractionAndNumerator, UserFirstFractionAndDenominator, UserSecondFractionAndNumerator, UserSecondFractionAndDenominator, FractionCalc)}
                    """);

                    break;

                case 3:
                    PreguntasParaHacerOperacionesFraccionarias();
                    Console.WriteLine($"""
                    El resultado de la operación es:
                    {MultiplicarFracciones(UserFirstFractionAndNumerator, UserFirstFractionAndDenominator, UserSecondFractionAndNumerator, UserSecondFractionAndDenominator, FractionCalc)}
                    """);

                    break;

                case 4:
                    PreguntasParaHacerOperacionesFraccionarias();
                    Console.WriteLine($"""
                    El resultado de la operación es:
                    {DividirFracciones(UserFirstFractionAndNumerator, UserFirstFractionAndDenominator, UserSecondFractionAndNumerator, UserSecondFractionAndDenominator, FractionCalc)}
                    """);

                    break;
            }
        }

        public void PreguntasParaHacerOperacionesFraccionarias()
        {
            Console.WriteLine("Por favor ingrese el numerador de la primera fracción: ");
            UserFirstFractionAndNumerator = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Por favor ingrese el denominador de la primera fracción: ");
            UserFirstFractionAndDenominator = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Por favor ingrese el numerador de la segunda fracción: ");
            UserSecondFractionAndNumerator = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Por favor ingrese el denominador de la segunda fracción: ");
            UserSecondFractionAndDenominator = Convert.ToDecimal(Console.ReadLine());  
        }

        public static decimal SumarFracciones(decimal userFirstFractionAndNumerator, decimal userFirstFractionAndDenominator, decimal userSecondFractionAndNumerator, decimal userSecondFractionAndDenominator, decimal fractionCalc)
        {
            fractionCalc = (userFirstFractionAndNumerator / userFirstFractionAndDenominator) + (userSecondFractionAndNumerator / userSecondFractionAndDenominator);

            return fractionCalc;   
        }

        public static decimal RestarFracciones(decimal userFirstFractionAndNumerator, decimal userFirstFractionAndDenominator, decimal userSecondFractionAndNumerator, decimal userSecondFractionAndDenominator, decimal fractionCalc)
        {
            fractionCalc = (userFirstFractionAndNumerator / userFirstFractionAndDenominator) - (userSecondFractionAndNumerator / userSecondFractionAndDenominator);

            return fractionCalc;
        }

        public static decimal MultiplicarFracciones(decimal userFirstFractionAndNumerator, decimal userFirstFractionAndDenominator, decimal userSecondFractionAndNumerator, decimal userSecondFractionAndDenominator, decimal fractionCalc)
        {
            fractionCalc = (userFirstFractionAndNumerator / userFirstFractionAndDenominator) * (userSecondFractionAndNumerator / userSecondFractionAndDenominator);

            return fractionCalc;
        }

        public static decimal DividirFracciones(decimal userFirstFractionAndNumerator, decimal userFirstFractionAndDenominator, decimal userSecondFractionAndNumerator, decimal userSecondFractionAndDenominator, decimal fractionCalc)
        {
            fractionCalc = (userFirstFractionAndNumerator / userFirstFractionAndDenominator) / (userSecondFractionAndNumerator / userSecondFractionAndDenominator);

            return fractionCalc;
        }
    }   
}
