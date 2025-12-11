using System;
using System.Windows.Forms;
using Tyuiu.ShelomentsevYA.Sprint6.Task3.V24.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint6.Task3.V24
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

        private int[,] matrix =
        {
            { -17, -6, 10,  5,  3 },
            { -10, -14, 10, -7, -3 },
            { -19,  9,  8, -17, -9 },
            { -19, -5, -9, -18, 14 },
            {  17, 12, 11,  12,  2 }
        };

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(matrix);

            dgvMatrix.Rows.Clear();

            for (int i = 0; i < 5; i++)
            {
                dgvMatrix.Rows.Add(
                    result[i, 0],
                    result[i, 1],
                    result[i, 2],
                    result[i, 3],
                    result[i, 4]
                );
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Шеломенцев Я.А.\nСпринт 6, Задание 3, Вариант 24",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
