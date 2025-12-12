using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShelomentsevYA.Sprint6.Task5.V21.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint6.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_ValidFile_ReturnsCorrectValues()
        {
            // Arrange
            string path = @"C:\DataSprint6\InPutDataFileTask5V21.txt";
            DataService ds = new DataService();

            // Act
            double[] result = ds.LoadFromDataFile(path);

            // Assert
            foreach (double value in result)
            {
                Assert.IsTrue(value % 3 == 0);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void LoadFromDataFile_FileNotFound_ThrowsException()
        {
            // Arrange
            string path = @"C:\DataSprint6\NoSuchFile.txt";
            DataService ds = new DataService();

            // Act
            ds.LoadFromDataFile(path);
        }
    }
}
