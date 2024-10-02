using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms.controllers
{
    public class Product
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}, Brand: {Brand}, Model: {Model}, Price: {Price:C}, Quantity: {Quantity}";
        }
    }
    public class Monitor : Product
    {
        public double Diagonal { get; set; }
        public string Resolution { get; set; }
        public string Color { get; set; }
        public override string ToString()
        {
            return base.ToString() + $", Diagonal: {Diagonal} inches, Resolution: {Resolution}, Color: {Color}";
        }
    }

    public class Processor : Product
    {
        public int NumberOfCores { get; set; }
        public double Speed { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Cores: {NumberOfCores}, Speed: {Speed} GHz";
        }

    }

    public class RAM : Product
    {
        public int MemoryAmount { get; set; }
        public override string ToString()
        {
            return base.ToString() + $", Memory: {MemoryAmount} GB";
        }
    }
    public class Winchester : Product
    {
        public string Type { get; set; } // SSD or HDD
        public int StorageCapacity { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Type: {Type}, Storage Capacity: {StorageCapacity} GB";
        }
    }




    internal class Shop
    {

        public static string MyShop()
        {
            Console.WriteLine("Enter the device type (M - Monitor, C - Processor, R - RAM, H - Winchester) or press Enter to exit:");
            string productInput = Console.ReadLine();
            var validOperations = new List<string> { "M", "C", "R", "H" };

            if (!validOperations.Contains(productInput.ToUpper()))
            {
                throw new ArgumentException($"Invalid operation: {productInput}");
            }

            Product product;

            switch (productInput.ToUpper())
            {
                case "M":
                    product = CreateMonitor();
                    break;
                case "C":
                    product = CreateProcessor();
                    break;
                case "R":
                    product = CreateRAM();
                    break;
                case "H":
                    product = CreateWinchester();
                    break;
                default:
                    throw new InvalidOperationException("This should not happen."); 
            }


            return $"Product is {product.ToString()}";
        }

        static Monitor CreateMonitor()
        {
            var monitor = new Monitor();
            Console.Write("Enter Name: ");
            monitor.Name = Console.ReadLine();
            Console.Write("Enter Brand: ");
            monitor.Brand = Console.ReadLine();
            Console.Write("Enter Model: ");
            monitor.Model = Console.ReadLine();
            Console.Write("Enter Price: ");
            monitor.Price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            monitor.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter Diagonal (in inches): ");
            monitor.Diagonal = double.Parse(Console.ReadLine());
            Console.Write("Enter Resolution: ");
            monitor.Resolution = Console.ReadLine();
            Console.Write("Enter Color: ");
            monitor.Color = Console.ReadLine();

            return monitor;
        }

        static Processor CreateProcessor()
        {
            var processor = new Processor();
            Console.Write("Enter Name: ");
            processor.Name = Console.ReadLine();
            Console.Write("Enter Brand: ");
            processor.Brand = Console.ReadLine();
            Console.Write("Enter Model: ");
            processor.Model = Console.ReadLine();
            Console.Write("Enter Price: ");
            processor.Price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            processor.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter Number of Cores: ");
            processor.NumberOfCores = int.Parse(Console.ReadLine());
            Console.Write("Enter Speed (in GHz): ");
            processor.Speed = double.Parse(Console.ReadLine());

            return processor;
        }

        static RAM CreateRAM()
        {
            var ram = new RAM();
            Console.Write("Enter Name: ");
            ram.Name = Console.ReadLine();
            Console.Write("Enter Brand: ");
            ram.Brand = Console.ReadLine();
            Console.Write("Enter Model: ");
            ram.Model = Console.ReadLine();
            Console.Write("Enter Price: ");
            ram.Price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            ram.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter Memory Amount (in GB): ");
            ram.MemoryAmount = int.Parse(Console.ReadLine());

            return ram;
        }

        static Winchester CreateWinchester()
        {
            var winchester = new Winchester();
            Console.Write("Enter Name: ");
            winchester.Name = Console.ReadLine();
            Console.Write("Enter Brand: ");
            winchester.Brand = Console.ReadLine();
            Console.Write("Enter Model: ");
            winchester.Model = Console.ReadLine();
            Console.Write("Enter Price: ");
            winchester.Price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            winchester.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter Type (SSD/HDD): ");
            winchester.Type = Console.ReadLine();
            Console.Write("Enter Storage Capacity (in GB): ");
            winchester.StorageCapacity = int.Parse(Console.ReadLine());

            return winchester;
        }

    }
}
