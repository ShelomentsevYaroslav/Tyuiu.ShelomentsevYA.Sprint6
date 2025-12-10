using Tyuiu.ShelomentsevYA.Sprint6.Task0.V21.Lib;
namespace Tyuiu.ShelomentsevYA.Sprint6.Task0.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            
            double result = ds.Calculate(x);

            double expected = 13.000;
            Assert.AreEqual(expected, result);
        }
    }
}
