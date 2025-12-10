using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShelomentsevYA.Sprint6.Task2.V23.Lib
{
    public class DataService : ISprint6Task2V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] result = new double[length];

            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 2 * x - 2;

                double fx;

                if (denominator == 0)
                {
                    fx = 0;
                }
                else
                {
                    fx = 4 - 2 * x + (2 + Math.Cos(x)) / denominator;
                }

                result[index] = Math.Round(fx, 2);
                index++;
            }

            return result;
        }
    }
}
