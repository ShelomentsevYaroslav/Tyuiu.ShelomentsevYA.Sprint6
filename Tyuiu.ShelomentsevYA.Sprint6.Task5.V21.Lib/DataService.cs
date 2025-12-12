using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShelomentsevYA.Sprint6.Task5.V21.Lib
{
    public class DataService : ISprint6Task5V21
    {
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден", path);

            string content = File.ReadAllText(path);

            CultureInfo ru = new CultureInfo("ru-RU");

            string[] parts = content.Split(
                new[] { ' ', '\n', '\r', '\t' },
                StringSplitOptions.RemoveEmptyEntries
            );

            double[] result = parts
                .Select(p => double.Parse(p, ru))   // 👈 КЛЮЧЕВО
                .Where(x => x % 3 == 0)
                .Select(x => Math.Round(x, 3))
                .ToArray();

            return result;
        }
    }
}
