namespace Tyuiu.ShelomentsevYA.Sprint6.Task7.V1
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private DataGridView dgvIn;
        private DataGridView dgvOut;
        private Button btnLoad;
        private Button btnProcess;
        private Button btnSave;
        private Button btnHelp;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvIn = new DataGridView();
            dgvOut = new DataGridView();
            btnLoad = new Button();
            btnProcess = new Button();
            btnSave = new Button();
            btnHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOut).BeginInit();
            SuspendLayout();
            // 
            // dgvIn
            // 
            dgvIn.ColumnHeadersHeight = 29;
            dgvIn.Location = new Point(20, 20);
            dgvIn.Name = "dgvIn";
            dgvIn.RowHeadersWidth = 51;
            dgvIn.Size = new Size(400, 575);
            dgvIn.TabIndex = 0;
            // 
            // dgvOut
            // 
            dgvOut.ColumnHeadersHeight = 29;
            dgvOut.Location = new Point(450, 20);
            dgvOut.Name = "dgvOut";
            dgvOut.RowHeadersWidth = 51;
            dgvOut.Size = new Size(400, 575);
            dgvOut.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 636);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(180, 50);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Загрузить";
            btnLoad.Click += btnLoad_Click;
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(240, 636);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(180, 50);
            btnProcess.TabIndex = 3;
            btnProcess.Text = "Обработать";
            btnProcess.Click += btnProcess_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(450, 636);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 50);
            btnSave.TabIndex = 4;
            btnSave.Text = "Сохранить";
            btnSave.Click += btnSave_Click;
            // 
            // btnHelp
            // 
            btnHelp.Location = new Point(670, 636);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(180, 50);
            btnHelp.TabIndex = 5;
            btnHelp.Text = "Справка";
            btnHelp.Click += btnHelp_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(869, 698);
            Controls.Add(dgvIn);
            Controls.Add(dgvOut);
            Controls.Add(btnLoad);
            Controls.Add(btnProcess);
            Controls.Add(btnSave);
            Controls.Add(btnHelp);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Task 7 | Вариант 1 | Шеломенцев Я.А.";
            ((System.ComponentModel.ISupportInitialize)dgvIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOut).EndInit();
            ResumeLayout(false);
        }
    }
}
