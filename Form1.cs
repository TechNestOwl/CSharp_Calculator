/*********************************************************

   Gill Guimaraes

   Lab #4 - September 12, 2024

   I wrote this code myself...
   I did not use AI or copy code from Google or another student

 *********************************************************/



namespace CSharp_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (additionToggle.Checked)
                {
                    decimal result = (userInput_1.Value + userInput_2.Value);

                    resultContainer.Text = result.ToString();

                }
                if (subtractToggle.Checked)
                {
                    decimal result = (userInput_1.Value - userInput_2.Value);
                    resultContainer.Text = result.ToString();
                }
                if (multiplyToggle.Checked)
                {
                    decimal result = (userInput_1.Value * userInput_2.Value);
                    resultContainer.Text = result.ToString();
                }
                if (divisionToggle.Checked)
                {
                    decimal result = (userInput_1.Value / userInput_2.Value);
                    resultContainer.Text = result.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Please enter two numbers and select an arithmetic option.");
            }

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //setting the background color
            this.BackColor = Color.DarkBlue;
            this.ForeColor = Color.Gray;
        }

        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            this.ForeColor = SystemColors.ControlText;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gill Guimaraes | CIST 2341");

        }

        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            clearBtn.Visible = false;
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            clearBtn.Visible = true;
        }

        private void ForLoop_Btn_Click(object sender, EventArgs e)
        {
            //incrementing for loop
            for (int count = 0; count <= 10; count++)
            {
                Console.WriteLine("Go Falcons", count); 
                System.Diagnostics.Debug.WriteLine("Go Falcons", count);
            }
        }

        private void WhileLoop_Btn_Click(object sender, EventArgs e)
        {
            //decrementing while loop
            int count = 10;
            while (count >= 0)
            {
                Console.WriteLine("Go Falcons", count);
                System.Diagnostics.Debug.WriteLine("Go Falcons", count);
                count--;

            }
        }
    }
}
