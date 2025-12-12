using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShelomentsevYA.Sprint6.Task6.V19.Lib
{
    public class DataService : ISprint6Task6V19
    {
        public string CollectTextFromFile(string path)
        {
            string text = File.ReadAllText(path);

            string[] words = text.Split(
                new char[] { ' ', '\n', '\r', '\t' },
                System.StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                if (word.Contains('l'))
                {
                    result.Append(word).Append(' ');
                }
            }

            return result.ToString().Trim();
        }
    }
}
