using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.ShelomentsevYA.Sprint6.Task6.V19.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint6.Task6.V19
{
    public partial class FormMain : Form
    {
        private readonly DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Выбор входного файла";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxIn.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(openFileDialog1.FileName))
                {
                    MessageBox.Show("Сначала выберите файл", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                textBoxOut.Text = ds.CollectTextFromFile(openFileDialog1.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Задание:\n" +
                "Загрузить текстовый файл.\n" +
                "Вывести слова, содержащие букву 'l'.",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
