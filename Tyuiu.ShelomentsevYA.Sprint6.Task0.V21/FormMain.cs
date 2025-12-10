using System;
using System.Windows.Forms;
using Tyuiu.ShelomentsevYA.Sprint6.Task0.V21.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint6.Task0.V21
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(txtInput.Text);
                double result = ds.Calculate(x);
                txtResult.Text = result.ToString("F3");
            }
            catch
            {
                MessageBox.Show("Ошибка ввода. Введите целое число.");
            }
        }
    }
}
