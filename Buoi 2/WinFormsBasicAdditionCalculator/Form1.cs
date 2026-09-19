namespace WinFormsBasicAdditionCalculator
{
    public partial class FormBasicAdditionCalculator : Form
    {
        public FormBasicAdditionCalculator()
        {
            InitializeComponent();
            btnNewCalculation.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber1.Text, out int number1) &&
                int.TryParse(txtNumber2.Text, out int number2))
            {
                int sum = int.Parse(txtNumber1.Text) + int.Parse(txtNumber2.Text);
                txtResult.Text = $"Sum: {sum}";
                btnNewCalculation.Show();
            }
            else
            {
                MessageBox.Show("Please enter valid integers (int32) in both fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewCalculation_Click(object sender, EventArgs e)
        {
            btnNewCalculation.Hide();
            txtNumber1.Text = "";
            txtNumber2.Text = "";
            txtResult.Text = "";
        }
    }
}
