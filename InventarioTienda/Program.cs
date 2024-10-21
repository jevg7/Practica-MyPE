using System;
using System.IO;
using PersonalStandartProduct;

namespace PersonalStandartProduct
{
    public class Program
    {
        private const string Inventario = "Inventario.txt";

        public static void Main()
        {
            Console.Writeline("Bienvenido al sistema de inventario");
            Console.Writeline("1. Mostrar productos");
            Console.Writeline("2. Agregar producto");
            Console.Writeline("3. Actualizar producto");
            Console.Writeline("4. Eliminar producto");
            Console.Writeline("5. Salir");

            do
            {
                Console.Writeline("Seleccione una opción:");
                int option = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        showProduct();
                        break;
                    case "2":
                        AddProduct();
                        break;
                    case "3":
                        UpdateProduct();
                        break;
                    case "4":
                        DeleteProduct();
                        break;
                    case "5":
                        Console.Writeline("Gracias por usar el sistema de inventario");
                        break;
                    default:
                        Console.Writeline("Opción no válida");
                        break;
                }
            } while (opcion != "5");

        }

        public static void showProduct()
        {
            if (File.Exist(Inventario))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(Inventario, FileMode.Open)))
                {
                    List<Product> products = new List<Product>();
                    try
                    {
                        while (true)
                        {
                            Product product = new Product();
                            product.id = reader.ReadDouble();
                            product.name = reader.ReadString();
                            product.price = reader.ReadDouble();
                            product.quantity = reader.ReadDouble();
                            products.Add(product);
                        }

                    }
                    catch (EndOfStreamException)
                    {
                        reader.Close();
                    }
                }
            }
            else
            {
                Console.Writeline("No hay productos en el inventario");
            }
        }
        public static void AddProduct()
        {
            Console.Writeline("Ingrese el ID del producto:");
            double id = Console.ReadLine();
            Console.Writeline("Ingrese el nombre del producto:");
            string name = Console.ReadLine();
            Console.Writeline("Ingrese el precio del producto:");
            double price = Console.ReadLine();
            Console.Writeline("Ingrese la cantidad del producto:");
            double quantity = Console.ReadLine();

            Product product = new Product();
            product.id = id;
            product.name = name;
            product.price = price;
            product.quantity = quantity;

            using (BinaryWriter writer = new BinaryWriter(File.Open(Inventario, FileMode.Append)))
            {
                writer.Write(product.id);
                writer.Write(product.name);
                writer.Write(product.price);
                writer.Write(product.quantity);
            }
        }

        public static void UpdateProduct()
        {
            Console.Writeline("Ingrese el ID del producto a actualizar:");
            double id = Console.ReadLine();

            using (BinaryReader reader = new BinaryReader(File.Open(Inventario, FileMode.Open)))
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open("temp.txt", FileMode.Create)))
                {
                    try
                    {
                        while (true)
                        {
                            Product product = new Product();
                            product.id = reader.ReadDouble();
                            product.name = reader.ReadString();
                            product.price = reader.ReadDouble();
                            product.quantity = reader.ReadDouble();

                            if (product.id == id)
                            {
                                Console.Writeline("Ingrese el nuevo nombre del producto:");
                                product.name = Console.ReadLine();
                                Console.Writeline("Ingrese el nuevo precio del producto:");
                                product.price = Console.ReadLine();
                                Console.Writeline("Ingrese la nueva cantidad del producto:");
                                product.quantity = Console.ReadLine();
                            }

                            writer.Write(product.id);
                            writer.Write(product.name);
                            writer.Write(product.price);
                            writer.Write(product.quantity);
                        }
                    }
                    catch (EndOfStreamException)
                    {
                        reader.Close();
                        writer.Close();
                    }
                }
            }
        }

        public static void DeleteProduct()
        {
            Console.Writeline("Ingrese el ID del producto a eliminar:");
            double id = Console.ReadLine();

            using (BinaryReader reader = new BinaryReader(File.Open(Inventario, FileMode.Open)))
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open("temp.txt", FileMode.Create)))
                {
                    try
                    {
                        while (true)
                        {
                            Product product = new Product();
                            product.id = reader.ReadDouble();
                            product.name = reader.ReadString();
                            product.price = reader.ReadDouble();
                            product.quantity = reader.ReadDouble();

                            if (product.id != id)
                            {
                                writer.Write(product.id);
                                writer.Write(product.name);
                                writer.Write(product.price);
                                writer.Write(product.quantity);
                            }
                        }
                    }
                    catch (EndOfStreamException)
                    {
                        reader.Close();
                        writer.Close();
                    }
                }
            }

            File.Delete(Inventario);
            File.Move("temp.txt", Inventario);
        }
    }
}








