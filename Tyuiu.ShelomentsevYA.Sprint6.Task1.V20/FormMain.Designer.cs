namespace Tyuiu.ShelomentsevYA.Sprint6.Task1.V20
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.labelCondition = new System.Windows.Forms.Label();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();

            this.groupBoxCondition.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();

            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.labelCondition);
            this.groupBoxCondition.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(500, 150);
            this.groupBoxCondition.TabIndex = 0;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие";

            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Location = new System.Drawing.Point(10, 25);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(480, 80);
            this.labelCondition.Text =
                "Табулировать функцию F(x) на интервале [-5; 5] с шагом 1.\n" +
                "F(x) = (2x - 3) / (cos(x) - 2x) + 5x - sin(x)\n" +
                "Выполнить проверку деления на ноль (возвращать 0).\n" +
                "Округлить значения до двух знаков после запятой.\n" +
                "Результат вывести в текстовое поле.";

            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.txtResult);
            this.groupBoxOutput.Location = new System.Drawing.Point(12, 170);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(500, 300);
            this.groupBoxOutput.TabIndex = 1;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод данных";

            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(10, 25);
            this.txtResult.Multiline = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(480, 260);
            this.txtResult.ReadOnly = true;
            this.txtResult.Name = "txtResult";

            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 480);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(50, 30);
            this.btnHelp.Text = "?";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);

            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(380, 480);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(130, 30);
            this.btnExecute.Text = "Выполнить";
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);

            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(530, 530);
            this.Controls.Add(this.groupBoxCondition);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExecute);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 20 | Шеломенцев Я.А.";

            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnExecute;
    }
}
