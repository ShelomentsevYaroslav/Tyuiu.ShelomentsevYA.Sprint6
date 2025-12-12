namespace Tyuiu.ShelomentsevYA.Sprint6.Task6.V19
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.TextBox textBoxCondition;

        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxIn;

        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox textBoxOut;

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnHelp;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();

            // groupBoxCondition
            this.groupBoxCondition.Controls.Add(this.textBoxCondition);
            this.groupBoxCondition.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition.Size = new System.Drawing.Size(760, 80);
            this.groupBoxCondition.Text = "Условие";

            // textBoxCondition
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.ReadOnly = true;
            this.textBoxCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCondition.Text =
                "Загрузить файл.\r\n" +
                "Вывести слова, содержащие букву 'l'.";

            // groupBoxInput
            this.groupBoxInput.Controls.Add(this.textBoxIn);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 100);
            this.groupBoxInput.Size = new System.Drawing.Size(360, 300);
            this.groupBoxInput.Text = "Входные данные";

            // textBoxIn
            this.textBoxIn.Multiline = true;
            this.textBoxIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn.Dock = System.Windows.Forms.DockStyle.Fill;

            // groupBoxOutput
            this.groupBoxOutput.Controls.Add(this.textBoxOut);
            this.groupBoxOutput.Location = new System.Drawing.Point(412, 100);
            this.groupBoxOutput.Size = new System.Drawing.Size(360, 300);
            this.groupBoxOutput.Text = "Результат";

            // textBoxOut
            this.textBoxOut.Multiline = true;
            this.textBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut.Dock = System.Windows.Forms.DockStyle.Fill;

            // btnOpenFile
            this.btnOpenFile.Location = new System.Drawing.Point(12, 420);
            this.btnOpenFile.Size = new System.Drawing.Size(150, 40);
            this.btnOpenFile.Text = "Загрузить файл";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);

            // btnExecute
            this.btnExecute.Location = new System.Drawing.Point(180, 420);
            this.btnExecute.Size = new System.Drawing.Size(150, 40);
            this.btnExecute.Text = "Выполнить";
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);

            // btnHelp
            this.btnHelp.Location = new System.Drawing.Point(622, 420);
            this.btnHelp.Size = new System.Drawing.Size(150, 40);
            this.btnHelp.Text = "Справка";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);

            // FormMain
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.groupBoxCondition);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnHelp);
            this.Text = "Спринт 6 | Таск 6 | Вариант 19 | Шеломенцев Я.А.";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }
    }
}
