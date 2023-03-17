//calcule la suma de los primeros n números naturales, recibiendo como parámetro el número n
 static int CalcularSumaN(int n)
{ 
int suma = 0;

for (int i = 1; i <= n; i++)
{

    suma += i;
}
return suma;
     }
Console.WriteLine("Ingrese un numero entero");
int n=int.Parse(Console.ReadLine());
int suma = CalcularSumaN(n);
Console.WriteLine("La suma es:   " + n +  + suma);
