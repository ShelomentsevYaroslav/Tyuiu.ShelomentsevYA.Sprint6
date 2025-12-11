namespace Tyuiu.ShelomentsevYA.Sprint6.Task3.V24
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.Label labelCondition;

        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.DataGridView dgvMatrix;

        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnHelp;

        private System.Windows.Forms.DataGridViewTextBoxColumn col0;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBoxCondition = new GroupBox();
            labelCondition = new Label();
            groupBoxResult = new GroupBox();
            dgvMatrix = new DataGridView();
            col0 = new DataGridViewTextBoxColumn();
            col1 = new DataGridViewTextBoxColumn();
            col2 = new DataGridViewTextBoxColumn();
            col3 = new DataGridViewTextBoxColumn();
            col4 = new DataGridViewTextBoxColumn();
            btnExecute = new Button();
            btnHelp = new Button();
            groupBoxCondition.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatrix).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(labelCondition);
            groupBoxCondition.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxCondition.Location = new Point(12, 12);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(460, 160);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // labelCondition
            // 
            labelCondition.Font = new Font("Segoe UI", 10F);
            labelCondition.Location = new Point(10, 25);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(440, 130);
            labelCondition.TabIndex = 0;
            labelCondition.Text = "Дан массив 5×5 элементов.\nЗаменить чётные значения во второй строке на 0.\nРезультат вывести в DataGridView.\nГрафический интерфейс оформить по шаблону из лекции.";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(dgvMatrix);
            groupBoxResult.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxResult.Location = new Point(12, 180);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(748, 382);
            groupBoxResult.TabIndex = 1;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результаты";
            // 
            // dgvMatrix
            // 
            dgvMatrix.AllowUserToAddRows = false;
            dgvMatrix.AllowUserToDeleteRows = false;
            dgvMatrix.AllowUserToResizeRows = false;
            dgvMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatrix.Columns.AddRange(new DataGridViewColumn[] { col0, col1, col2, col3, col4 });
            dgvMatrix.Location = new Point(10, 25);
            dgvMatrix.Name = "dgvMatrix";
            dgvMatrix.RowHeadersVisible = false;
            dgvMatrix.RowHeadersWidth = 51;
            dgvMatrix.Size = new Size(732, 351);
            dgvMatrix.TabIndex = 0;
            // 
            // col0
            // 
            col0.HeaderText = "0";
            col0.MinimumWidth = 6;
            col0.Name = "col0";
            col0.Width = 125;
            // 
            // col1
            // 
            col1.HeaderText = "1";
            col1.MinimumWidth = 6;
            col1.Name = "col1";
            col1.Width = 125;
            // 
            // col2
            // 
            col2.HeaderText = "2";
            col2.MinimumWidth = 6;
            col2.Name = "col2";
            col2.Width = 125;
            // 
            // col3
            // 
            col3.HeaderText = "3";
            col3.MinimumWidth = 6;
            col3.Name = "col3";
            col3.Width = 125;
            // 
            // col4
            // 
            col4.HeaderText = "4";
            col4.MinimumWidth = 6;
            col4.Name = "col4";
            col4.Width = 125;
            // 
            // btnExecute
            // 
            btnExecute.Font = new Font("Segoe UI", 10F);
            btnExecute.Location = new Point(12, 616);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(140, 40);
            btnExecute.TabIndex = 2;
            btnExecute.Text = "Выполнить";
            btnExecute.Click += btnExecute_Click;
            // 
            // btnHelp
            // 
            btnHelp.Font = new Font("Segoe UI", 14F);
            btnHelp.Location = new Point(158, 616);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(40, 40);
            btnHelp.TabIndex = 3;
            btnHelp.Text = "?";
            btnHelp.Click += btnHelp_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(931, 668);
            Controls.Add(groupBoxCondition);
            Controls.Add(groupBoxResult);
            Controls.Add(btnExecute);
            Controls.Add(btnHelp);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 24 | Шеломенцев Я.А.";
            groupBoxCondition.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMatrix).EndInit();
            ResumeLayout(false);
        }
    }
}
