namespace CSharp_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            userInput_1.Text = string.Empty;
            userInput_2.Text = string.Empty;
            resultContainer.Text = string.Empty;
            if (divisionToggle.Checked)
            {
                divisionToggle.Checked = false;
            }
            if (multiplyToggle.Checked)
            {
                multiplyToggle.Checked = false;
            }
            if (subtractToggle.Checked)
            {
                subtractToggle.Checked = false;
            }
            if (additionToggle.Checked)
            {
                additionToggle.Checked = false;
            }
        }

        private void divisionToggle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void multiplyToggle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void subtractToggle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void additionToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (additionToggle.Checked)
            {
                decimal result = (userInput_1.Value + userInput_2.Value);

                resultContainer.Text = result.ToString();

            }
        }

        private void userInput_1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void userInput_2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void resultContainer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
