using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Laptop : Computer
    {
        public string Manufacturer { get; set; }
        public bool HasDiskDrive { get; set; } = true;

        public Laptop ()
        {

        }
        
        public Laptop (string manufacturer)
        {
            Manufacturer = manufacturer;
        }

        public Laptop (string manufacturer, bool hasDiskDrive, string operatingSystem) : base(operatingSystem)
        {
            Manufacturer = manufacturer;
            HasDiskDrive = hasDiskDrive;
        }
        public Laptop (string manufacturer, string operatingSystem, int diskStorageSize, int ramSize) : base(operatingSystem, diskStorageSize, ramSize)
        {
            Manufacturer = manufacturer;
        }

        public void DiskDrive()
        {
            Console.WriteLine("Does your laptop have a disk drive? y/n: ");
            string userInput = Console.ReadLine();
            string normalizedInput = userInput.ToLower();
            bool hasDiskDriveInstalled = true;
            if (normalizedInput != "y")
            {
                hasDiskDriveInstalled = false;
            }
            HasDiskDrive = hasDiskDriveInstalled;
        }
    }
}
