// See https://aka.ms/new-console-template for more information

//Paso 1: Ingrese las 3 notas
Console.WriteLine("Ingrese la primera nota");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la segunda nota");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la tercera nota");
int n3 = int.Parse(Console.ReadLine());

// Paso 2: Proceso - Hallar el promedio de las 3 notas
int promedio = (n1 + n2 + n3)/3;

//Paso 3: Resultado del promedio
Console.WriteLine("Promedio: " + promedio);

//PASO 4: Evaluar la condicion de aprobado y desaprobado si es >=11 o no
string mje = "";
if (promedio >= 11)
    //Console.WriteLine("Es mayor de dedad.");
    mje = "Aprobado.";
else
    Console.WriteLine("Desaprobado.");

//PASO 4: RESULTADOS DE APROBACION O NO
Console.WriteLine(mje);