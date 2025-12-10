namespace Tyuiu.ShelomentsevYA.Sprint6.Task0.V21
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
            groupBoxCondition = new GroupBox();
            labelCondition = new Label();
            groupBoxInput = new GroupBox();
            labelLX = new Label();
            txtInput = new TextBox();
            groupBoxOutput = new GroupBox();
            labelResult = new Label();
            txtResult = new TextBox();
            btnExecute = new Button();
            btnHelp = new Button();
            groupBoxCondition.SuspendLayout();
            groupBoxInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(labelCondition);
            groupBoxCondition.Location = new Point(14, 16);
            groupBoxCondition.Margin = new Padding(3, 4, 3, 4);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Padding = new Padding(3, 4, 3, 4);
            groupBoxCondition.Size = new Size(411, 200);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(11, 33);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(318, 60);
            labelCondition.TabIndex = 0;
            labelCondition.Text = "Дано выражение F(x) = 2x³ + 0.5x² – 3.5x + 2.\r\nВычислить его значение при x = 2.\r\nОкруглить до трёх знаков после запятой.";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(labelLX);
            groupBoxInput.Controls.Add(txtInput);
            groupBoxInput.Location = new Point(14, 240);
            groupBoxInput.Margin = new Padding(3, 4, 3, 4);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Padding = new Padding(3, 4, 3, 4);
            groupBoxInput.Size = new Size(206, 133);
            groupBoxInput.TabIndex = 1;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // labelLX
            // 
            labelLX.AutoSize = true;
            labelLX.Location = new Point(11, 40);
            labelLX.Name = "labelLX";
            labelLX.Size = new Size(114, 20);
            labelLX.TabIndex = 0;
            labelLX.Text = "Переменная X:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(11, 73);
            txtInput.Margin = new Padding(3, 4, 3, 4);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(171, 27);
            txtInput.TabIndex = 1;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(labelResult);
            groupBoxOutput.Controls.Add(txtResult);
            groupBoxOutput.Location = new Point(240, 240);
            groupBoxOutput.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Padding = new Padding(3, 4, 3, 4);
            groupBoxOutput.Size = new Size(206, 133);
            groupBoxOutput.TabIndex = 2;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(11, 40);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(78, 20);
            labelResult.TabIndex = 0;
            labelResult.Text = "Результат:";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(11, 73);
            txtResult.Margin = new Padding(3, 4, 3, 4);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(171, 27);
            txtResult.TabIndex = 1;
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(263, 400);
            btnExecute.Margin = new Padding(3, 4, 3, 4);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(149, 47);
            btnExecute.TabIndex = 3;
            btnExecute.Text = "Выполнить";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // btnHelp
            // 
            btnHelp.Location = new Point(206, 400);
            btnHelp.Margin = new Padding(3, 4, 3, 4);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(40, 47);
            btnHelp.TabIndex = 4;
            btnHelp.Text = "?";
            btnHelp.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 480);
            Controls.Add(btnHelp);
            Controls.Add(btnExecute);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxCondition);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 21 | Шеломенцев Я.А.";
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label labelLX;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnHelp;
    }
}
