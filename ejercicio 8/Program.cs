//calcule el factorial de un número, recibiendo como parámetro el número
int fac = 1;
Console.WriteLine("Ingrese el numero que desea calcular ");
int num= Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++) 
{
    fac = fac * i;


}
Console.WriteLine("El factorial del numero ingresado es :" + fac);
Console.ReadKey();