using System;

class Program
{
    static void Main(string[] args)
    {
        string producto = "Celular";
        double precio = 1200.50;
        int cantidad = 2;

        Console.WriteLine("----- FACTURA -----");
        Console.WriteLine($"Producto: {producto}");
        Console.WriteLine($"Precio unitario: {precio}");
        Console.WriteLine($"Cantidad: {cantidad}");
        Console.WriteLine($"Total a pagar: {precio * cantidad}");
    }
}
