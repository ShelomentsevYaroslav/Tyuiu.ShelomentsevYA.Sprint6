using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShelomentsevYA.Sprint6.Task6.V19.Lib
{
    public class DataService : ISprint6Task6V19
    {
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Файл не найден", path);
            }

            string[] lines = File.ReadAllLines(path, Encoding.UTF8);

            StringBuilder result = new StringBuilder();

            foreach (string line in lines)
            {
                // разбиваем строку на слова
                string[] words = line.Split(
                    new char[] { ' ', '\t', ',', '.', ';', ':', '!', '?', '-', '(', ')', '\r', '\n' },
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    // ищем букву l или L
                    if (word.Contains('l') || word.Contains('L'))
                    {
                        result.Append(word);
                        result.Append(" ");
                    }
                }
            }

            return result.ToString().Trim();
        }
    }
}
