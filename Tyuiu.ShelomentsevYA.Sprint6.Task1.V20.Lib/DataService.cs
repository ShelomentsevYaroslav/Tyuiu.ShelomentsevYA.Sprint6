using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShelomentsevYA.Sprint6.Task1.V20.Lib
{
    public class DataService : ISprint6Task1V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = stopValue - startValue + 1;
            double[] result = new double[size];

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) - 2 * x;

                double value;

                if (Math.Abs(denominator) < 1e-9)
                {
                    value = 0;
                }
                else
                {
                    value = (2 * x - 3) / denominator + 5 * x - Math.Sin(x);
                }

                result[index] = Math.Round(value, 2);

                index++;
            }

            return result;
        }
    }
}
