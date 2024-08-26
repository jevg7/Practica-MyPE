using System;
   public class Program
   {
     public static void Main(string[] args)
      {
      string cadena;
      cadena = "Esta es una cadena";

      Console.WriteLine("Tamaño de Tipos de Datos");
      Console.WriteLine();
      Console.WriteLine("Tamaño del tipo de datos bool es: {0}",sizeof(bool));
      Console.WriteLine("Tamaño del tipo de dato byte es: {0}, rango: {1:#,##0}", sizeof(byte), Math.Pow(2,8));
      Console.WriteLine("Tamaño del tipo de dato sbyte es: {0}, rango: {1:#,##0}", sizeof(sbyte), Math.Pow(2,8));
      Console.WriteLine("Tamaño del tipo de dato string es: {0}", cadena.Length);
      Console.WriteLine("Tamaño del tipo de dato short es: {0}, rango: {1:#,##0}", sizeof(short), Math.Pow(2, 16));
      Console.WriteLine("Tamaño del tipo de dato ushort es: {0}, rango: {1:#,##0}", sizeof(ushort), Math.Pow(2, 16));
      Console.WriteLine("Tamaño del tipo de dato int es: {0}, rango: {1:#,##0}", sizeof(int), Math.Pow(2, 32));
      Console.WriteLine("Tamaño del tipo de dato uint es: {0}, rango: {1:#,##0}", sizeof(uint), Math.Pow(2, 32));
      Console.WriteLine("Tamaño del tipo de dato long es: {0}, rango: {1:#,##0}", sizeof(long), Math.Pow(2, 64));
      Console.WriteLine("Tamaño del tipo de dato ulong es: {0}, rango: {1:#,##0}", sizeof(ulong), Math.Pow(2, 64));
      Console.WriteLine("Tamaño del tipo de dato float es: {0}, rango: {1:#,##0}", sizeof(float), Math.Pow(2, 32));
      Console.WriteLine("Tamaño del tipo de dato double es: {0}, rango: {1:#,##0}", sizeof(double), Math.Pow(2, 64));
      Console.WriteLine("Tamaño del tipo de dato decimal es: {0}, rango: {1:#,##0}", sizeof(decimal), Math.Pow(2, 128));
   }



   }

