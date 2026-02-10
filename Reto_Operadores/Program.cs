using System;

class Program
{
    static void Main(string[] args)
    {
        double precioProducto = 100000;
        double descuento = 0.15;

        double valorDescuento = precioProducto * descuento;
        double precioFinal = precioProducto - valorDescuento;

        Console.WriteLine("----- CALCULO DE DESCUENTO -----");
        Console.WriteLine($"Precio original: {precioProducto}");
        Console.WriteLine($"Descuento aplicado: {valorDescuento}");
        Console.WriteLine($"Precio final a pagar: {precioFinal}");
    }
}
