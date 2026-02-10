using System;

class Program
{
    static void Main(string[] args)
    {
        string nombre = "Luisa";
        int edad = 16;
        double altura = 1.60;
        char genero = 'F';
        bool estudiante = true;

        Console.WriteLine("----- DATOS PERSONALES -----");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Altura: {altura}");
        Console.WriteLine($"Genero: {genero}");
        Console.WriteLine($"Es estudiante: {estudiante}");
    }
}
