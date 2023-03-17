//calcule el promedio de una lista de números, recibiendo como parámetro una lista de enteros

Console.WriteLine("Ingrese una lista de numeros separados para calcular");
string input = Console.ReadLine();
var numero = input.Split(' ').Select(int.Parse);
double average =numero.Average();
Console.WriteLine($" El promedio de los numeros que ingreso es :){average}");
Console.ReadKey();