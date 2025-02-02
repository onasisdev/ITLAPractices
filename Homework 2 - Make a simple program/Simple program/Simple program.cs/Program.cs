Console.WriteLine("Ingrese un número para determinar si es par o impar:");
var userNum = Console.ReadLine();

var evenOrOddNumberCalc = Convert.ToInt32(userNum) % 2;

if (evenOrOddNumberCalc == 0) {
    Console.WriteLine("Es par.");
} else {
    Console.WriteLine("Es impar.");
}
