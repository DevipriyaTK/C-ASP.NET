namespace Counting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int firstNumber = 0, secondNumber = 0;
        int divisibleTerm = 0;
        string divisibleNumbers = "";
        int controlNumber = 1;

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (txtStartFrom.Text.Trim() == "" || txtTo.Text.Trim() == "")
                MessageBox.Show("Please fill necessary fields");
            else if (cmbDivisibleTerm.SelectedIndex == -1)
                MessageBox.Show("Please select the divisible term");
            else
            {
                firstNumber = Convert.ToInt32(txtStartFrom.Text);
                secondNumber = Convert.ToInt32(txtTo.Text);
                for (int i = firstNumber; i < secondNumber; i++)
                {
                    if (i % divisibleTerm == 0)
                    {
                        divisibleNumbers += i.ToString() + " ";
                        if (controlNumber % 10 == 0)
                            divisibleNumbers += Environment.NewLine;
                        controlNumber++;
                    }
                }
                txtDivisibleNumbers.Text = divisibleNumbers;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDivisibleTerm.Items.Add("2");
            cmbDivisibleTerm.Items.Add("3");
            cmbDivisibleTerm.Items.Add("4");
            cmbDivisibleTerm.Items.Add("5");
            cmbDivisibleTerm.Items.Add("6");
            cmbDivisibleTerm.Items.Add("7");
            cmbDivisibleTerm.Items.Add("8");
            cmbDivisibleTerm.Items.Add("9");
            cmbDivisibleTerm.Items.Add("10");

        }

        private void cmbDivisibleTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisibleTerm = Convert.ToInt32(cmbDivisibleTerm.SelectedItem);
        }

        private void txtStartFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlack.Checked)
            {
                rbBlue.Checked = false;
                rbGreen.Checked = false;
                rbRed.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Black;
            }
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRed.Checked)
            {
                rbGreen.Checked = false;
                rbBlack.Checked = false;
                rbBlue.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Red;
            }
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlue.Checked)
            {
                rbGreen.Checked = false;
                rbBlack.Checked = false;
                rbRed.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Blue;
            }
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGreen.Checked)
            {
                rbBlack.Checked = false;
                rbBlue.Checked = false;
                rbRed.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Green;
            }
        }

        private void chBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chBold.Checked)
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font, FontStyle.Bold);
            else
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font, FontStyle.Regular);
        }

        private void chItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chItalic.Checked)
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font, FontStyle.Italic);
            else
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font, FontStyle.Regular);

        }
    }
}