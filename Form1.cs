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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            if (divisionToggle.Checked)
            {
                divisionToggle.Checked = false;
            }if (multiplyToggle.Checked)
            {
                multiplyToggle.Checked = false;
            }
            if (subtractToggle.Checked)
            {
                subtractToggle.Checked = false;
            }if (additionToggle.Checked)
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

        }
    }
}
