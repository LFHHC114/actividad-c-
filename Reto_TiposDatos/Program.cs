using System;

class Program
{
    static void Main(string[] args)
    {
        string nombre = "Luisa Hurtado";
        int edad = 16;
        double promedio = 4.6;
        const string institucion = "SENA";
        bool aprobado = true;

        Console.WriteLine("----- INFORMACION DEL ESTUDIANTE -----");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Promedio: {promedio}");
        Console.WriteLine($"Institucion: {institucion}");
        Console.WriteLine($"¿Aprobo el curso?: {aprobado}");
    }
}
