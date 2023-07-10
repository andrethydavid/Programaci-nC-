// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, david!");

// porgrama que calcula el area de un rectangulo
var ladoA = 1.1;  //declaracionde valores, variable de forma implicita 
var ladoB = 1.1 ; //bulioanos
var resultado = 1.1;

Console.WriteLine("calcula el area de un rectangulo");
Console.WriteLine("Ingrese el valor del lado A");
ladoA = Convert.ToDouble(Console.ReadLine()); // touble para valores bulianos 

Console.WriteLine("ingrese el valor del lado B");
ladoB = Convert.ToDouble(Console.ReadLine());


resultado = ladoA * ladoB;
Console.WriteLine("El lado A es:" +ladoA +"El lado B es:" +ladoB +"El resultado es" +resultado);
