using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShelomentsevYA.Sprint6.Task4.V30.Lib
{
    public class DataService : ISprint6Task4V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = stopValue - startValue + 1;
            double[] result = new double[size];

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Sin(x) + 2;

                if (Math.Abs(denominator) < 0.000001)
                {
                    result[index] = 0;
                }
                else
                {
                    double value = (5 * x + 2.5) / denominator + 2 * x + 2;
                    result[index] = Math.Round(value, 2);
                }

                index++;
            }

            return result;
        }
    }
}
