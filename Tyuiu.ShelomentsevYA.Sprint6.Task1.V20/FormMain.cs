using System;
using System.Text;
using System.Windows.Forms;
using Tyuiu.ShelomentsevYA.Sprint6.Task1.V20.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint6.Task1.V20
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
            double[] array = ds.GetMassFunction(-5, 5);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("x\tf(x)");

            int i = 0;
            for (int x = -5; x <= 5; x++)
            {
                sb.AppendLine($"{x}\t{array[i]}");
                i++;
            }

            txtResult.Text = sb.ToString();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Шеломенцев Я.А.\nГруппа: ИСТНб-25-1", "Справка");
        }
    }
}
