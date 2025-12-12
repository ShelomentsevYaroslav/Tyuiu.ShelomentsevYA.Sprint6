namespace Tyuiu.ShelomentsevYA.Sprint6.Task5.V21
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnLoad = new System.Windows.Forms.Button();
            btnHelp = new System.Windows.Forms.Button();
            dgvData = new System.Windows.Forms.DataGridView();
            colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();

            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartData).BeginInit();
            SuspendLayout();

            // btnLoad
            btnLoad.Text = "Загрузить";
            btnLoad.Location = new System.Drawing.Point(12, 400);
            btnLoad.Size = new System.Drawing.Size(120, 35);
            btnLoad.Click += btnLoad_Click;

            // btnHelp
            btnHelp.Text = "?";
            btnHelp.Location = new System.Drawing.Point(150, 400);
            btnHelp.Size = new System.Drawing.Size(35, 35);
            btnHelp.Click += btnHelp_Click;

            // dgvData
            dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                colIndex, colValue});
            dgvData.Location = new System.Drawing.Point(12, 12);
            dgvData.Size = new System.Drawing.Size(240, 370);
            dgvData.RowHeadersVisible = false;

            colIndex.HeaderText = "№";
            colIndex.Width = 50;

            colValue.HeaderText = "Значение";
            colValue.Width = 150;

            // chartData
            chartData.Location = new System.Drawing.Point(270, 12);
            chartData.Size = new System.Drawing.Size(500, 370);

            // FormMain
            ClientSize = new System.Drawing.Size(790, 450);
            Controls.Add(btnLoad);
            Controls.Add(btnHelp);
            Controls.Add(dgvData);
            Controls.Add(chartData);
            Text = "Спринт 6 | Таск 5 | Вариант 21 | Шеломенцев Я.А.";

            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartData).EndInit();
            ResumeLayout(false);
        }
    }
}
