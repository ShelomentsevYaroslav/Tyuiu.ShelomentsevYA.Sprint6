using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.ShelomentsevYA.Sprint6.Task7.V1.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint6.Task7.V1
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();
        private int[,] matrix;

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                matrix = ds.GetMatrix(ofd.FileName);
                ShowMatrix(dgvIn, matrix);
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (matrix == null) return;

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] result = (int[,])matrix.Clone();

            // 🔥 ОБРАБОТКА ЗДЕСЬ, А НЕ В БИБЛИОТЕКЕ
            for (int i = 0; i < rows; i++)
            {
                if (result[i, 1] < 0)
                    result[i, 1] = 1;
            }

            ShowMatrix(dgvOut, result);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter sw = new StreamWriter(sfd.FileName);

                for (int i = 0; i < dgvOut.Rows.Count; i++)
                {
                    if (dgvOut.Rows[i].IsNewRow) continue;

                    string line = "";
                    for (int j = 0; j < dgvOut.Columns.Count; j++)
                        line += dgvOut.Rows[i].Cells[j].Value + ";";

                    sw.WriteLine(line.TrimEnd(';'));
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Шеломенцев Ярослав Александрович\n" +
                "Группа ИСТНб-25-1\n" +
                "Тюменский Индустриальный Университет\n\n" +
                "Спринт 6 | Task 7 | Вариант 1",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ShowMatrix(DataGridView dgv, int[,] m)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            int r = m.GetLength(0);
            int c = m.GetLength(1);

            for (int j = 0; j < c; j++)
                dgv.Columns.Add($"C{j}", $"C{j}");

            for (int i = 0; i < r; i++)
            {
                object[] row = new object[c];
                for (int j = 0; j < c; j++)
                    row[j] = m[i, j];
                dgv.Rows.Add(row);
            }
        }
    }
}
