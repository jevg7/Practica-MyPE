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

      Console.WriteLine("Bienvenido a la tienda");
      Console.WriteLine();
      Console.WriteLine("Ingrese el nombre del producto: ");
      Name = Console.ReadLine();
      Console.WriteLine("Ingrese el codigo del producto:");
      ProdCode=int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese el precio del producto:");
      ProdPrice=float.Parse(Console.ReadLine());
      Console.WriteLine("Categorias de Producto");
      Console.WriteLine();
      Console.WriteLine("Si la categoría del producto es A y su precio es mayor a 100.0, se aplica un 10%\r\nadicional al descuento ingresado");
      Console.WriteLine();
      Console.WriteLine("Si la categoría del producto es A y su precio es mayor a 100.0, se aplica un 10%\r\nadicional al descuento ingresado");
      Console.WriteLine();

      do
      {
         Console.WriteLine("Ingrese la categoria:");
         ProdCategory = char.Parse(Console.ReadLine());

      } while (ProdCategory != 'A' && ProdCategory != 'B' && ProdCategory != 'a' && ProdCategory != 'b');

      Console.WriteLine("Ingrese el descuento que desea aplicar:");
      ProdDiscount=float.Parse(Console.ReadLine());

      
      if (ProdCategory == 'A' || ProdCategory == 'a' && ProdPrice >100) {
      
      
      
      
      
      
      
      }













      }
   }

