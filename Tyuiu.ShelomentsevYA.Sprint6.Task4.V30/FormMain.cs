using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Tyuiu.ShelomentsevYA.Sprint6.Task4.V30.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint6.Task4.V30
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            chartFunction.Series[0].Points.Clear();

            double[] y = ds.GetMassFunction(-5, 5);

            int x = -5;
            for (int i = 0; i < y.Length; i++)
            {
                txtResult.AppendText($"x = {x}; f(x) = {y[i]}\r\n");
                chartFunction.Series[0].Points.AddXY(x, y[i]);
                x++;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "OutPutFileTask4V30.txt";
            sfd.Filter = "Text files (*.txt)|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, txtResult.Text, Encoding.UTF8);
                MessageBox.Show("Файл сохранён");
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Шеломенцев Я.А.\nСпринт 6\nЗадание 4\nВариант 30",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
