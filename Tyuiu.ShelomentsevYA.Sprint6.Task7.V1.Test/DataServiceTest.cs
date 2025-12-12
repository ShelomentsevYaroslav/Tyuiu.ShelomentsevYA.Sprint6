using Tyuiu.ShelomentsevYA.Sprint6.Task7.V1.Lib;
namespace Tyuiu.ShelomentsevYA.Sprint6.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = "test.csv";
            string[] data =
            {
                "1;-2;3",
                "4;-5;6"
            };

            File.WriteAllLines(path, data);

            DataService ds = new DataService();
            int[,] result = ds.GetMatrix(path);

            Assert.AreEqual(2, result.GetLength(0));
            Assert.AreEqual(3, result.GetLength(1));

            Assert.AreEqual(1, result[0, 0]);
            Assert.AreEqual(-2, result[0, 1]);
            Assert.AreEqual(6, result[1, 2]);
        }
    }
}
