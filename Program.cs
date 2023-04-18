// See https://aka.ms/new-console-template for more information 
Console.WriteLine("Hola, el siguiente programa solicitará los siguientes signos de mayor, menor o igual y los números par y impar");
Console.WriteLine("Insertar el primer número"); 
var primernumero = Console.ReadLine();
int Numero1 = int.Parse(primernumero);
Console.WriteLine("Insertar el segundo número"); 
var segundonumero = Console.ReadLine();
int Numero2 = int.Parse(segundonumero);
if (Numero1 > Numero2)
{
    Console.WriteLine(" El " + Numero1 + " > " + Numero2);
}
else if (Numero1 < Numero2)
{
    Console.WriteLine(" El " + Numero1 + " < " + Numero2);
}
else
{
    Console.WriteLine(" El " + Numero1 + " = " + Numero2);
}
if (Numero2 % 2 == 1)
{
    Console.WriteLine(" El " + Numero2 + " impar ");
}
else
{
    Console.WriteLine(" El " + Numero2 + " par ");
}