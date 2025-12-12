using Tyuiu.ShelomentsevYA.Sprint6.Task4.V30.Lib;
namespace Tyuiu.ShelomentsevYA.Sprint6.Task4.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int start = -5;
            int stop = 5;

            double[] result = ds.GetMassFunction(start, stop);

            Assert.AreEqual(11, result.Length);

            double expectedAtMinus5 =
                Math.Round((5 * (-5) + 2.5) / (Math.Sin(-5) + 2) + 2 * (-5) + 2, 2);

            double expectedAt0 =
                Math.Round((5 * 0 + 2.5) / (Math.Sin(0) + 2) + 2 * 0 + 2, 2);

            Assert.AreEqual(expectedAtMinus5, result[0]);
            Assert.AreEqual(expectedAt0, result[5]);
        }
    }
}
