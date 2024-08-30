using System;

public class Program
{
    public static void Main(string[] args)
    {

        string Name;
        int ProdCode;
        float ProdPrice;
        char ProdCategory;
        float ProdDiscount;
        bool IsProductAvailable;

        Console.WriteLine("Bienvenido a la tienda");
        Console.WriteLine();
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Ingrese el nombre del producto: ");
        Name = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Ingrese el codigo del producto:");
        ProdCode = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Ingrese el precio del producto:");
        ProdPrice = float.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("¿El producto esta disponible? (True=Si || False=No");
        IsProductAvailable = bool.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Categorias de Producto");
        Console.WriteLine();
        Console.WriteLine("Si la categoría del producto es A y su precio es mayor a 100.0, se aplica un 10%\r\nadicional al descuento ingresado");
        Console.WriteLine();
        Console.WriteLine("Si la categoría del producto es B y su precio es menor o igual a 50.0, se aplica un 5%\r\nadicional al descuento ingresado.");
        Console.WriteLine();

        do
        {
            Console.WriteLine("Ingrese la categoria:");
            ProdCategory = char.Parse(Console.ReadLine());

        } while (ProdCategory != 'A' && ProdCategory != 'B' && ProdCategory != 'a' && ProdCategory != 'b');

        Console.WriteLine("Ingrese el descuento que desea aplicar:");
        ProdDiscount = float.Parse(Console.ReadLine());

        Console.Clear();


        if (ProdCategory == 'A' || ProdCategory == 'a' && ProdPrice > 100)
        {

            ProdDiscount = (ProdDiscount / 100) + 0.10f;

        }
        else if (ProdCategory == 'B' || ProdCategory == 'b' && ProdPrice <= 50)
        {

            ProdDiscount = (ProdDiscount / 100) + 0.05f;

        }
        else
        {
            ProdDiscount = ProdDiscount / 100;
        }

        ProdPrice = ProdPrice - (ProdPrice * ProdDiscount);


        Console.WriteLine("Nombre del producto: {0}", Name);
        Console.WriteLine();
        Console.ReadKey();
        Console.WriteLine("Codigo del producto: {0}", ProdCode);
        Console.WriteLine();
        Console.ReadKey();
        Console.WriteLine("Precio del producto: {0}", ProdPrice);
        Console.WriteLine();
        Console.ReadKey();
        Console.WriteLine("Categoria del producto: {0}", ProdCategory);
        Console.WriteLine();
        Console.ReadKey();
        Console.WriteLine("¿El producto esta disponible? {0}", IsProductAvailable);
        Console.WriteLine();
        Console.ReadKey();
        Console.WriteLine("Descuento aplicado: {0}", ProdDiscount);
        Console.WriteLine();
        Console.ReadKey();
        Console.WriteLine("Precio final del producto: {0}", ProdPrice);





    }

}

