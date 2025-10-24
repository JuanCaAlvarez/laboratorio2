using System;
// See https://aka.ms/new-console-template for more information
//PASO 1: LECTURA DE DATOS
Console.WriteLine("Digite la edad de la persona");
int edad = int.Parse(Console.ReadLine());

//PASO 2: PROCESO
string mje = "";
if (edad >= 18)
    //Console.WriteLine("Es mayor de dedad.");
    mje = "Es mayor de edad";
else
    Console.WriteLine("Es menor de edad.");

//PASO 3: RESULTADOS
Console.WriteLine(mje);
