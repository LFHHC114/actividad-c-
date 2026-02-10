using System;

class Program
{
    static void Main(string[] args)
    {
        int numero1 = 20;
        int numero2 = 5;

        int suma = numero1 + numero2;
        int resta = numero1 - numero2;
        int multiplicacion = numero1 * numero2;
        int division = numero1 / numero2;

        numero1 += 3;

        Console.WriteLine("----- OPERADORES -----");
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Multiplicacion: {multiplicacion}");
        Console.WriteLine($"Division: {division}");
        Console.WriteLine($"Nuevo valor de numero1: {numero1}");
    }
}
