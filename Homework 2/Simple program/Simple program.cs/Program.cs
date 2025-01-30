Console.WriteLine("Ingrese un número para determinar si es par o impar:");
var num = Console.ReadLine();

var calc = Convert.ToInt32(num) % 2;

if (calc == 0) {
    Console.WriteLine("Es par.");
} else {
    Console.WriteLine("Es impar.");
}
