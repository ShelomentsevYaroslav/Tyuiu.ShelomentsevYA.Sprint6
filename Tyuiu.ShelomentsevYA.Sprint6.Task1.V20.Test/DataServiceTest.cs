using Tyuiu.ShelomentsevYA.Sprint6.Task1.V20.Lib;
namespace Tyuiu.ShelomentsevYA.Sprint6.Task1.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double[] expected =
            {
                -27.22, -22.25, -16.66, -11.04, -6.13,
                -3.00, 4.84, 8.86, 14.43, 20.18, 25.24
            };

            double[] actual = ds.GetMassFunction(-5, 5);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
