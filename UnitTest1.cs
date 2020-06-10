using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;
using System;

namespace TechnologyTest
{
    [TestClass]
    public class UnitTest1
    {
        Laptop testLaptop;
        Computer testComputer;
        SmartPhone testSmartPhone;
        [TestInitialize]
        public void CreateComputerObject()
        {
            testComputer = new Computer("Windows 10", 1000, 8);
            testLaptop = new Laptop("Lenovo", "Windows 10", 1000, 8);
            testSmartPhone = new SmartPhone("Google", "Android 10", 128);
        }
    [TestMethod]
        public void FullComputerConstructorWorks()
        {
            Assert.AreEqual("Windows 10", testComputer.OperatingSystem);
            Assert.AreEqual(1000, testComputer.DiskStorageSize, .001);
            Assert.AreEqual(8, testComputer.RAMSize);
        }
        [TestMethod]
        public void OSOnlyComputerConstructorWorks()
        {
            Computer osOnlyTestComputer = new Computer("Windows 10");
            Assert.AreEqual("Windows 10", osOnlyTestComputer.OperatingSystem);
        }
        [TestMethod]
        public void RemainingDiskSpace ()
        {
            testComputer.StorageLeft(500);
            Assert.AreEqual(500, testComputer.DiskStorageSize, .001);
        }
        [TestMethod]
        public void LaptopInheritenceOfComputerBase()
        {
            Assert.AreEqual("Lenovo", testLaptop.Manufacturer);
            Assert.AreEqual("Windows 10", testLaptop.OperatingSystem);
            Assert.AreEqual(1000, testLaptop.DiskStorageSize, .001);
            Assert.AreEqual(8, testLaptop.RAMSize);
        }
        [TestMethod]
        public void LaptopDiskDriveDefault()
        {
            Assert.IsTrue(testLaptop.HasDiskDrive);
        }
        [TestMethod]
        public void LaptopRemainingHardDriv()
        {
            testLaptop.StorageLeft(500);
            Assert.AreEqual(500, testLaptop.DiskStorageSize, .001);
        }
        [TestMethod]
        public void SmartPhoneInheritenceOfComputerBase ()
        {
            Assert.AreEqual("Google", testSmartPhone.Manufacturer);
            Assert.AreEqual("Android 10", testSmartPhone.OperatingSystem);
            Assert.AreEqual(128, testSmartPhone.DiskStorageSize, .001);
        }
        [TestMethod]
        public void SmartPhoneHeadphoneJackDefault ()
        {
            Assert.IsFalse(testSmartPhone.HeadphoneJack);
        }
        [TestMethod]
        public void SmartPhoneRemaindStorage ()
        {
            testSmartPhone.StorageLeft(64);
            Assert.AreEqual(64, testSmartPhone.DiskStorageSize, .001);
        }

    }
}
