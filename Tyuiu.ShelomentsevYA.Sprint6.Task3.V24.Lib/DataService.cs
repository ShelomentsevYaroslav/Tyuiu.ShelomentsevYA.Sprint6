using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShelomentsevYA.Sprint6.Task3.V24.Lib
{
    public class DataService : ISprint6Task3V24
    {
        public int[,] Calculate(int[,] matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // создаём копию результата
            int[,] result = new int[rows, cols];

            // копируем всё в результат
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = matrix[i, j];

            // строка 1 — заменяем чётные на 0
            for (int j = 0; j < cols; j++)
            {
                if (result[1, j] % 2 == 0)
                {
                    result[1, j] = 0;
                }
            }

            return result;
        }
    }
}
