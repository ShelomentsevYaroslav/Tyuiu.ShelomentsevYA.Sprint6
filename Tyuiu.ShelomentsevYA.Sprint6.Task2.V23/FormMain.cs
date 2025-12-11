using System;
using System.Windows.Forms;
using Tyuiu.ShelomentsevYA.Sprint6.Task2.V23.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint6.Task2.V23
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            double[] result = ds.GetMassFunction(-5, 5);

            dgvOutput.Rows.Clear();
            chartFunction.Series["Series1"].Points.Clear();

            int x = -5;

            for (int i = 0; i < result.Length; i++)
            {
                dgvOutput.Rows.Add(x, result[i]);
                chartFunction.Series["Series1"].Points.AddXY(x, result[i]);
                x++;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Шеломенцев Я.А.\nСпринт 6 · Задание 2 · Вариант 23",
                            "Справка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
