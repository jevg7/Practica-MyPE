using System;

   public class GestionLibros
{
   public static void Main(string[] args)
   {
      string title, autor;
      int pageNum, publicationYear;
      float price;
      char isAvailable;

      Console.WriteLine("Bienvenido al sistema de gestion de la biblioteca: ");
      Console.WriteLine("Presione cualquier tecla para continuar: ");
      Console.ReadKey();
      Console.Clear();

      do
      {
         Console.WriteLine("Ingrese el titulo del libro: ");
         title = Console.ReadLine();
         if (string.IsNullOrEmpty(title))
         {
            Console.WriteLine("El titulo no puede estar vacio, por favor ingrese un titulo valido: ");
            Console.ReadKey();
            Console.Clear();
         }
      } while (string.IsNullOrEmpty(title));

      do
      {
         Console.WriteLine("Ingrese el autor del libro: ");
         autor = Console.ReadLine();
         if (string.IsNullOrEmpty(autor))
         {
            Console.WriteLine("El autor no puede estar vacio, por favor ingrese un autor valido: ");
            Console.ReadKey();
            Console.Clear();
         }
      } while (string.IsNullOrEmpty(autor));

      do
      {
         Console.WriteLine("Ingrese el numero de paginas del libro: ");
         pageNum = int.Parse(Console.ReadLine());


         if (pageNum <= 0)
         {
            Console.WriteLine("El numero de paginas no puede ser menor o igual a 0, por favor ingrese un numero de paginas valido: ");
            Console.ReadKey();
            Console.Clear();
         }
      } while (pageNum <= 0);

      do
      {
         Console.WriteLine("Ingrese el año de publicacion del libro: ");
         publicationYear = int.Parse(Console.ReadLine());
         if (publicationYear <= 0 || publicationYear > 2024)
         {
            Console.WriteLine("Año de publicacion invalido por favor ingrese un año de publicacion valido: ");
            Console.ReadKey();
            Console.Clear();
         }
      } while (publicationYear <= 0 || publicationYear > 2024);

      do
      {
         Console.WriteLine("Ingrese el precio del libro: ");
         price = float.Parse(Console.ReadLine());
         if (price <= 0)
         {
            Console.WriteLine("El precio no puede ser menor o igual a 0, por favor ingrese un precio valido: ");
            Console.ReadKey();
            Console.Clear();
         }
      } while (price <= 0);

      do
      {
         Console.WriteLine("Ingrese si el libro esta disponible: (S/N)");
         isAvailable = char.Parse(Console.ReadLine());

         if (isAvailable != 'S' && isAvailable != 'N' && isAvailable != 's' && isAvailable != 'n')
         {
            Console.WriteLine("Ingrese solo S o N: ");
            Console.ReadKey();
            Console.Clear();
         }
      } while (isAvailable != 'S' && isAvailable != 'N' && isAvailable != 's' && isAvailable != 'n');
      
      Console.Clear();

      Console.WriteLine("El libro ingresado es: {0}", title) ;
      Console.WriteLine("El autor del libro es: {0}", autor);
      Console.WriteLine("El libro tiene: {0}", pageNum,"paginas");
      Console.WriteLine("El libro fue publicado en el año: {0}", publicationYear);
      Console.WriteLine("El precio del libro es: {0}", price);
      Console.WriteLine("¿El libro esta disponible?");
      if (isAvailable == 'S' || isAvailable == 's')
      {
         Console.WriteLine("Si");
      }
      else
      {
         Console.WriteLine("No");
      }

   }
}