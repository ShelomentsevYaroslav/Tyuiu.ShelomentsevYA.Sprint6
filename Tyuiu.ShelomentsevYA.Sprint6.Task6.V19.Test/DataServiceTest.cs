using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.ShelomentsevYA.Sprint6.Task6.V19.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint6.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFile_CorrectWordsReturned()
        {
            // Arrange
            string testPath = @"C:\DataSprint6\InPutDataFileTask6V19_test.txt";

            File.WriteAllText(testPath,
                "hello world\n" +
                "test lamp apple\n" +
                "sky cloud sun");

            DataService ds = new DataService();

            // Act
            string result = ds.CollectTextFromFile(testPath);

            // Assert
            string expected = "hello world lamp apple cloud";
            Assert.AreEqual(expected, result);

            // Cleanup
            File.Delete(testPath);
        }
    }
}
