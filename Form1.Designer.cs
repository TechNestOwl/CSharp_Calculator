namespace CSharp_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            clearBtn = new Button();
            divisionToggle = new RadioButton();
            additionToggle = new RadioButton();
            subtractToggle = new RadioButton();
            multiplyToggle = new RadioButton();
            userInput_1 = new NumericUpDown();
            userInput_2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)userInput_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userInput_2).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(165, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(98, 20);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "C# Calculator";
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(189, 51);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(44, 46);
            clearBtn.TabIndex = 1;
            clearBtn.Text = "CE";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // divisionToggle
            // 
            divisionToggle.AutoSize = true;
            divisionToggle.Location = new Point(200, 204);
            divisionToggle.Name = "divisionToggle";
            divisionToggle.Size = new Size(33, 24);
            divisionToggle.TabIndex = 3;
            divisionToggle.TabStop = true;
            divisionToggle.Text = "/";
            divisionToggle.UseVisualStyleBackColor = true;
            divisionToggle.CheckedChanged += divisionToggle_CheckedChanged;
            // 
            // additionToggle
            // 
            additionToggle.AutoSize = true;
            additionToggle.Location = new Point(200, 115);
            additionToggle.Name = "additionToggle";
            additionToggle.Size = new Size(37, 24);
            additionToggle.TabIndex = 4;
            additionToggle.TabStop = true;
            additionToggle.Text = "+";
            additionToggle.UseVisualStyleBackColor = true;
            additionToggle.CheckedChanged += additionToggle_CheckedChanged;
            // 
            // subtractToggle
            // 
            subtractToggle.AutoSize = true;
            subtractToggle.Location = new Point(200, 163);
            subtractToggle.Name = "subtractToggle";
            subtractToggle.Size = new Size(33, 24);
            subtractToggle.TabIndex = 5;
            subtractToggle.TabStop = true;
            subtractToggle.Text = "-";
            subtractToggle.UseVisualStyleBackColor = true;
            subtractToggle.CheckedChanged += subtractToggle_CheckedChanged;
            // 
            // multiplyToggle
            // 
            multiplyToggle.AutoSize = true;
            multiplyToggle.Location = new Point(198, 253);
            multiplyToggle.Name = "multiplyToggle";
            multiplyToggle.Size = new Size(33, 24);
            multiplyToggle.TabIndex = 8;
            multiplyToggle.TabStop = true;
            multiplyToggle.Text = "*";
            multiplyToggle.UseVisualStyleBackColor = true;
            multiplyToggle.CheckedChanged += multiplyToggle_CheckedChanged;
            // 
            // userInput_1
            // 
            userInput_1.Location = new Point(71, 63);
            userInput_1.Name = "userInput_1";
            userInput_1.Size = new Size(92, 26);
            userInput_1.TabIndex = 9;
            // 
            // userInput_2
            // 
            userInput_2.Location = new Point(267, 63);
            userInput_2.Name = "userInput_2";
            userInput_2.Size = new Size(92, 26);
            userInput_2.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 791);
            Controls.Add(userInput_2);
            Controls.Add(userInput_1);
            Controls.Add(multiplyToggle);
            Controls.Add(subtractToggle);
            Controls.Add(additionToggle);
            Controls.Add(divisionToggle);
            Controls.Add(clearBtn);
            Controls.Add(titleLabel);
            Name = "Form1";
            Text = "C# Calculator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)userInput_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userInput_2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Button clearBtn;
        private RadioButton divisionToggle;
        private RadioButton additionToggle;
        private RadioButton subtractToggle;
        private RadioButton multiplyToggle;
        private NumericUpDown userInput_1;
        private NumericUpDown userInput_2;
    }
}
