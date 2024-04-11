// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int numero1 = 0; 
int numero2 = 0;
int suma = 0;

Console.WriteLine("ingrese el primer numero");
numero1=int.Parse(Console.ReadLine());

Console.WriteLine("ingrese el segundo numero");
numero2 = int.Parse(Console.ReadLine());

suma = numero1 + numero2;
Console.WriteLine("el resultado de la suma es " +suma);
Console.ReadKey();