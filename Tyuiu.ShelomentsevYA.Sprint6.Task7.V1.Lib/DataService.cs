using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShelomentsevYA.Sprint6.Task7.V1.Lib
{
    public class DataService : ISprint6Task7V1
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] parts = lines[i].Split(';');

                for (int j = 0; j < cols; j++)
                {
                    int value = int.Parse(parts[j]);

                    if (j == 1 && value < 0)
                        value = 1;

                    matrix[i, j] = value;
                }
            }

            return matrix;
        }
    }
}
