using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public string Manufacturer { get; set; }
        public bool HeadphoneJack { get; set; } = false;

        public SmartPhone()
        {

        }

        public SmartPhone(string manufacturer)
        {
            Manufacturer = manufacturer;
        }

        public SmartPhone(string manufacturer, bool headphoneJack, string operatingSystem) : base(operatingSystem)
        {
            Manufacturer = manufacturer;
            HeadphoneJack = headphoneJack;
        }

        public SmartPhone(string manufacturer, string operatingSystem, int diskStorageSize) : base(operatingSystem, diskStorageSize)
        {
            Manufacturer = manufacturer;
        }

        public bool HasHeadphoneJack()
        {
            Console.WriteLine("Does your smartphone have a headphone jack? y/n: ");
            string userInput = Console.ReadLine();
            string normalizedInput = userInput.ToLower();
            bool hasDiskDriveInstalled = false;
            if (normalizedInput != "n")
            {
                hasDiskDriveInstalled = true;
            }
            return hasDiskDriveInstalled;
        }
    }

}
