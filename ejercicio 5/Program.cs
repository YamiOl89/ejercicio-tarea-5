//convertir una cadena a mayúsculas, recibiendo como parámetro la cadena
Console.WriteLine("Ingrese la cadena de texto que desea convertir ");
string cadena = Console.ReadLine();
string cadenaMayuscula = ConvertirMayusculas(cadena);
Console.WriteLine("Su cadena en mayusculas es : " + cadenaMayuscula);
 string ConvertirMayusculas(string texto)
{
    return texto.ToUpper();
}