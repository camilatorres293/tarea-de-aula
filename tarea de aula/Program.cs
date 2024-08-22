using System;

class ProgramaDescuentos

{

    static void Main()

    {

        Console.Write("por favor ingrese su nombre : ");

        string nombre = Console.ReadLine();

        Console.Write("Por favor ingres su edad: ");

        int edad = int.Parse(Console.ReadLine());

        string[] categorias = { "Bebidas", "Golosinas", "Dulces" };

        double[,] precios = { { 25, 24, 10, 18, 30 }, { 15, 12, 10, 20, 8 }, { 5, 3, 12, 7, 4 } };

        Console.WriteLine("por favor selecione sus categorias (1. Bebidas, 2. Snacks, 3. Dulces): ");

        int cat = int.Parse(Console.ReadLine()) - 1;

        Console.WriteLine("Has el favor de ingresar el Producto (1- 5): ");

        int prod = int.Parse(Console.ReadLine()) - 1;

        Console.WriteLine("por favor as su selección de tamaño (1. Normal, 2. Mediano, 3. Grande): ");

        int tamano = int.Parse(Console.ReadLine());

        double precio = precios[cat, prod] * (tamano == 2 ? 1.25 : (tamano == 3 ? 1.25 * 1.3 : 1));

        Console.Write("Ingrese  su  cantidad: ");

        int cantidad = int.Parse(Console.ReadLine());

        double subtotal = precio * cantidad;

        subtotal = edad >= 60 ?
            subtotal * 0.7 : subtotal;
        subtotal = cat != 2 ?
            subtotal * 1.15 : subtotal;
        Console.WriteLine($"Total a pagar : L{subtotal}");
    }
}
