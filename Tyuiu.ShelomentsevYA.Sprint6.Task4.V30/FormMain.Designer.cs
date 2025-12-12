using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.ShelomentsevYA.Sprint6.Task4.V30
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.TextBox txtCondition;

        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TextBox txtResult;
        private Chart chartFunction;

        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHelp;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ChartArea chartArea1 = new ChartArea();
            Series series1 = new Series();

            groupBoxCondition = new System.Windows.Forms.GroupBox();
            txtCondition = new System.Windows.Forms.TextBox();

            groupBoxResult = new System.Windows.Forms.GroupBox();
            txtResult = new System.Windows.Forms.TextBox();
            chartFunction = new Chart();

            btnExecute = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnHelp = new System.Windows.Forms.Button();

            groupBoxCondition.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(chartFunction)).BeginInit();
            SuspendLayout();

            // ===== Условие =====
            groupBoxCondition.Text = "Условие";
            groupBoxCondition.Location = new System.Drawing.Point(12, 12);
            groupBoxCondition.Size = new System.Drawing.Size(760, 100);

            txtCondition.Multiline = true;
            txtCondition.ReadOnly = true;
            txtCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            txtCondition.Text =
                "F(x) = (5x + 2.5) / (sin(x) + 2) + 2x + 2\n" +
                "Диапазон [-5; 5], шаг 1 \n" +
                "При делении на ноль вернуть 0 \n" +
                "Округлить до 2 знаков \n" +
                "Построить график и сохранить в файл";

            groupBoxCondition.Controls.Add(txtCondition);

            // ===== Результаты =====
            groupBoxResult.Text = "Результаты";
            groupBoxResult.Location = new System.Drawing.Point(12, 120);
            groupBoxResult.Size = new System.Drawing.Size(760, 360);

            txtResult.Multiline = true;
            txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtResult.Location = new System.Drawing.Point(10, 25);
            txtResult.Size = new System.Drawing.Size(250, 320);

            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            chartFunction.Location = new System.Drawing.Point(270, 25);
            chartFunction.Size = new System.Drawing.Size(480, 320);

            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Spline;
            series1.Name = "f(x)";
            chartFunction.Series.Add(series1);

            groupBoxResult.Controls.Add(txtResult);
            groupBoxResult.Controls.Add(chartFunction);

            // ===== Кнопки =====
            btnExecute.Text = "Выполнить";
            btnExecute.Location = new System.Drawing.Point(12, 500);
            btnExecute.Size = new System.Drawing.Size(140, 40);
            btnExecute.Click += btnExecute_Click;

            btnSave.Text = "Сохранить";
            btnSave.Location = new System.Drawing.Point(170, 500);
            btnSave.Size = new System.Drawing.Size(140, 40);
            btnSave.Click += btnSave_Click;

            btnHelp.Text = "?";
            btnHelp.Location = new System.Drawing.Point(330, 500);
            btnHelp.Size = new System.Drawing.Size(40, 40);
            btnHelp.Click += btnHelp_Click;

            // ===== Form =====
            ClientSize = new System.Drawing.Size(784, 561);
            Controls.Add(groupBoxCondition);
            Controls.Add(groupBoxResult);
            Controls.Add(btnExecute);
            Controls.Add(btnSave);
            Controls.Add(btnHelp);

            Text = "Спринт 6 | Task 4 | Variant 30 | Шеломенцев Я.А.";
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(chartFunction)).EndInit();
            ResumeLayout(false);
        }
    }
}
