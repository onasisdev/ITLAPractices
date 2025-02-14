try
{
    Console.WriteLine("Ingrese un número para determinar si es par o impar:");
    int userNum = Convert.ToInt32(Console.ReadLine());

    var evenOrOddNumberCalc = userNum % 2;

    if (evenOrOddNumberCalc == 0)
    {
        Console.WriteLine("Es par.");
    }
    else
    {
        Console.WriteLine("Es impar.");
    }
}

catch (FormatException)
{
    Console.WriteLine("Ingresa solo números enteros por favor."); 
}

Console.WriteLine("Presiona una tecla para salir.");

Console.ReadKey();




