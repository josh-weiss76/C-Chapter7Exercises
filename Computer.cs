using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Technology
{
    public class Computer
    {
        public string OperatingSystem { get; set; }
        public int DiskStorageSize { get; set; }
        public int RAMSize { get; set; }
        public string Screen { get; } = "Method to visually display input/output";
        public Computer ()
        {

        }

        public Computer (string operatingSystem)
        {
            OperatingSystem = operatingSystem;
        }

        public Computer (string operatingSystem, int diskStorageSize)
        {
            OperatingSystem = operatingSystem;
            DiskStorageSize = diskStorageSize;
        }
        public Computer(string operatingSystem, int diskStorageSize, int ramSize)
        {
            OperatingSystem = operatingSystem;
            DiskStorageSize = diskStorageSize;
            RAMSize = ramSize;
        }

        public void TypeOfOperatingSystem ()
        {
            Console.WriteLine("What is the operating system of your device? ");
            string operatingSystem = Console.ReadLine();
            OperatingSystem = operatingSystem;
        }

        public void AmountOfDiskStorage ()
        {
            Console.WriteLine("How many gigs does your system have in disk storage? ");
            int diskSize = int.Parse(Console.ReadLine());
            DiskStorageSize = diskSize;
        }
        public void AmountOfRAM ()
        {
            Console.WriteLine("How much RAM is installed in your system? ");
            int ramAmount = int.Parse(Console.ReadLine());
            RAMSize = ramAmount;
        }

        public void StorageLeft (int storageUsed)
        {
            DiskStorageSize -= storageUsed;
        }

    }
}
