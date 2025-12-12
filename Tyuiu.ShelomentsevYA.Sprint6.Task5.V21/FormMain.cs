using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.ShelomentsevYA.Sprint6.Task5.V21.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint6.Task5.V21
{
    public partial class FormMain : Form
    {
        private readonly DataService ds = new DataService();
        private const string FilePath = @"C:\DataSprint6\InPutDataFileTask5V21.txt";

        public FormMain()
        {
            InitializeComponent();
            InitChart();
        }

        private void InitChart()
        {
            chartData.Series.Clear();
            chartData.ChartAreas.Clear();

            ChartArea area = new ChartArea("MainArea");
            chartData.ChartAreas.Add(area);

            Series series = new Series("Кратные 3")
            {
                ChartType = SeriesChartType.Column
            };

            chartData.Series.Add(series);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvData.Rows.Clear();
            chartData.Series[0].Points.Clear();

            double[] values = ds.LoadFromDataFile(FilePath);

            for (int i = 0; i < values.Length; i++)
            {
                dgvData.Rows.Add(i + 1, values[i]);
                chartData.Series[0].Points.AddXY(i + 1, values[i]);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Спринт 6\nТаск 5\nВариант 21\nАвтор: Шеломенцев Я.А.",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
