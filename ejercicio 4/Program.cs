//determine si un número es par o impar, recibiendo como parámetro el número
Console.WriteLine("Escriba un numero entero positivo para determinar si es par o impar");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0) 
{ 
    Console.WriteLine($" {num } es par ");

 }

else
{
Console.WriteLine($" {num} es impar ");


}
