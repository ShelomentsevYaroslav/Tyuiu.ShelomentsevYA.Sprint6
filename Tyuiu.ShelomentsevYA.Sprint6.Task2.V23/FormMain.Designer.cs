using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.ShelomentsevYA.Sprint6.Task2.V23
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private Button btnExecute;
        private Button btnHelp;
        private DataGridView dgvOutput;
        private DataGridViewTextBoxColumn colX;
        private DataGridViewTextBoxColumn colFx;

        private GroupBox groupBoxCondition;
        private Label labelCondition;

        private GroupBox groupBoxResult;
        private Chart chartFunction;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ChartArea chartArea1 = new ChartArea();
            Series series1 = new Series();
            btnExecute = new Button();
            btnHelp = new Button();
            dgvOutput = new DataGridView();
            colX = new DataGridViewTextBoxColumn();
            colFx = new DataGridViewTextBoxColumn();
            groupBoxCondition = new GroupBox();
            labelCondition = new Label();
            groupBoxResult = new GroupBox();
            chartFunction = new Chart();
            ((System.ComponentModel.ISupportInitialize)dgvOutput).BeginInit();
            groupBoxCondition.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // btnExecute
            // 
            btnExecute.Font = new Font("Segoe UI", 10F);
            btnExecute.Location = new Point(12, 500);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(140, 40);
            btnExecute.TabIndex = 2;
            btnExecute.Text = "Выполнить";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // btnHelp
            // 
            btnHelp.Font = new Font("Segoe UI", 10F);
            btnHelp.Location = new Point(180, 500);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(40, 40);
            btnHelp.TabIndex = 3;
            btnHelp.Text = "?";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // dgvOutput
            // 
            dgvOutput.AllowUserToAddRows = false;
            dgvOutput.AllowUserToDeleteRows = false;
            dgvOutput.AllowUserToResizeRows = false;
            dgvOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOutput.Columns.AddRange(new DataGridViewColumn[] { colX, colFx });
            dgvOutput.Location = new Point(15, 25);
            dgvOutput.Name = "dgvOutput";
            dgvOutput.RowHeadersVisible = false;
            dgvOutput.RowHeadersWidth = 51;
            dgvOutput.Size = new Size(430, 260);
            dgvOutput.TabIndex = 0;
            // 
            // colX
            // 
            colX.HeaderText = "x";
            colX.MinimumWidth = 6;
            colX.Name = "colX";
            colX.Width = 80;
            // 
            // colFx
            // 
            colFx.HeaderText = "f(x)";
            colFx.MinimumWidth = 6;
            colFx.Name = "colFx";
            colFx.Width = 130;
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(labelCondition);
            groupBoxCondition.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxCondition.Location = new Point(12, 12);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(460, 167);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // labelCondition
            // 
            labelCondition.Font = new Font("Segoe UI", 10F);
            labelCondition.Location = new Point(10, 25);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(440, 145);
            labelCondition.TabIndex = 0;
            labelCondition.Text = "Табулировать функцию:\nF(x) = 4 - 2x + (2 + cos(x)) / (2x - 2)\n\nДиапазон: [-5; 5], шаг 1.\nПри делении на ноль вернуть 0.\nРезультаты вывести в таблицу и график.";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(dgvOutput);
            groupBoxResult.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxResult.Location = new Point(12, 185);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(460, 309);
            groupBoxResult.TabIndex = 1;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результаты";
            // 
            // chartFunction
            // 
            chartArea1.Name = "Area1";
            chartFunction.ChartAreas.Add(chartArea1);
            chartFunction.Location = new Point(478, 12);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "Area1";
            series1.ChartType = SeriesChartType.Line;
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(449, 482);
            chartFunction.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 780);
            Controls.Add(groupBoxCondition);
            Controls.Add(chartFunction);
            Controls.Add(groupBoxResult);
            Controls.Add(btnExecute);
            Controls.Add(btnHelp);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 23 | Шеломенцев Я.А.";
            ((System.ComponentModel.ISupportInitialize)dgvOutput).EndInit();
            groupBoxCondition.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }
    }
}
