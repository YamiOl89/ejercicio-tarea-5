//  calcular el área de un círculo, recibiendo como parámetro el radio.

double a = 0, r = 3.5; ;
Console.WriteLine(" Vcalcular la radio de un circulo :) ");

Console.WriteLine(" Ingrese el are a de un circulo ");

r = int.Parse(Console.ReadLine());
a = r * r * 3.1415;
Console.WriteLine(" el area del circulo es  : " + a);

Console.ReadKey();