using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop lenovo = new Laptop("Lenovo", true, "Windows 10");
            Console.WriteLine(lenovo.OperatingSystem);
            lenovo.AmountOfDiskStorage();
            Console.WriteLine(lenovo.DiskStorageSize);
            lenovo.DiskDrive();
            Console.WriteLine(lenovo.HasDiskDrive);
            Console.WriteLine("The "+ lenovo.Manufacturer + "laptop has " + lenovo.DiskStorageSize +" gigs of hard disk space");
            lenovo.StorageLeft(500);
            Console.WriteLine(lenovo.DiskStorageSize);
        }
    }
}
