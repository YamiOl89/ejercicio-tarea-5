// calcule el perímetro de un rectángulo, recibiendo como parámetros el ancho y la alturaint   ancho , alto ;

int ancho, alto; 
Console.WriteLine ( " Calcularemos el perimetro de un rectangulo :) " );

Console.WriteLine ( " Ingrese el ancho del recto  " );
ancho=int.Parse(Console.ReadLine());

Console.WriteLine ( "Ingrese alto del recto " );
alto=int.Parse(Console.ReadLine());


Console.WriteLine ( "perímetro es: "  + ( ancho+alto ));

Console.ReadKey();  