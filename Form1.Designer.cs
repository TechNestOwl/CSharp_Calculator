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
            resultContainer = new TextBox();
            calcBtn = new Button();
            exitBtn = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            darkModeToolStripMenuItem = new ToolStripMenuItem();
            lightModeToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            ForLoop_Btn = new Button();
            WhileLoop_Btn = new Button();
            memoryBtn = new Button();
            memoryLabel = new Label();
            mPlus_Btn = new Button();
            ((System.ComponentModel.ISupportInitialize)userInput_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userInput_2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Cascadia Code", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(163, 100);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(153, 24);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "C# Calculator";
            // 
            // clearBtn
            // 
            clearBtn.BackColor = SystemColors.GradientActiveCaption;
            clearBtn.Location = new Point(185, 147);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(44, 46);
            clearBtn.TabIndex = 1;
            clearBtn.Text = "CE";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // divisionToggle
            // 
            divisionToggle.AutoSize = true;
            divisionToggle.Location = new Point(198, 300);
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
            additionToggle.Location = new Point(198, 211);
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
            subtractToggle.Location = new Point(198, 259);
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
            multiplyToggle.Location = new Point(196, 349);
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
            userInput_1.Location = new Point(69, 159);
            userInput_1.Name = "userInput_1";
            userInput_1.Size = new Size(92, 26);
            userInput_1.TabIndex = 9;
            userInput_1.ValueChanged += userInput_1_ValueChanged;
            // 
            // userInput_2
            // 
            userInput_2.Location = new Point(265, 159);
            userInput_2.Name = "userInput_2";
            userInput_2.Size = new Size(92, 26);
            userInput_2.TabIndex = 10;
            userInput_2.ValueChanged += userInput_2_ValueChanged;
            // 
            // resultContainer
            // 
            resultContainer.Location = new Point(163, 437);
            resultContainer.Name = "resultContainer";
            resultContainer.Size = new Size(98, 26);
            resultContainer.TabIndex = 11;
            resultContainer.TextChanged += resultContainer_TextChanged;
            // 
            // calcBtn
            // 
            calcBtn.Location = new Point(163, 389);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(98, 28);
            calcBtn.TabIndex = 12;
            calcBtn.Text = "Calculate";
            calcBtn.UseVisualStyleBackColor = true;
            calcBtn.Click += calcBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(255, 128, 0);
            exitBtn.Location = new Point(163, 513);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(90, 28);
            exitBtn.TabIndex = 14;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            exitBtn.MouseEnter += exitBtn_MouseEnter;
            exitBtn.MouseLeave += exitBtn_MouseLeave;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(19, 19);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, colorToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(470, 28);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(125, 26);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(125, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darkModeToolStripMenuItem, lightModeToolStripMenuItem });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(59, 24);
            colorToolStripMenuItem.Text = "Color";
            // 
            // darkModeToolStripMenuItem
            // 
            darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            darkModeToolStripMenuItem.Size = new Size(167, 26);
            darkModeToolStripMenuItem.Text = "Dark Mode";
            darkModeToolStripMenuItem.Click += darkModeToolStripMenuItem_Click;
            // 
            // lightModeToolStripMenuItem
            // 
            lightModeToolStripMenuItem.Name = "lightModeToolStripMenuItem";
            lightModeToolStripMenuItem.Size = new Size(167, 26);
            lightModeToolStripMenuItem.Text = "Light Mode";
            lightModeToolStripMenuItem.Click += lightModeToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(132, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // ForLoop_Btn
            // 
            ForLoop_Btn.BackColor = SystemColors.ButtonHighlight;
            ForLoop_Btn.Location = new Point(12, 695);
            ForLoop_Btn.Name = "ForLoop_Btn";
            ForLoop_Btn.Size = new Size(98, 28);
            ForLoop_Btn.TabIndex = 16;
            ForLoop_Btn.Text = "For Loop";
            ForLoop_Btn.UseVisualStyleBackColor = false;
            ForLoop_Btn.Click += ForLoop_Btn_Click;
            // 
            // WhileLoop_Btn
            // 
            WhileLoop_Btn.Location = new Point(12, 729);
            WhileLoop_Btn.Name = "WhileLoop_Btn";
            WhileLoop_Btn.Size = new Size(98, 28);
            WhileLoop_Btn.TabIndex = 17;
            WhileLoop_Btn.Text = "While Loop";
            WhileLoop_Btn.UseVisualStyleBackColor = true;
            WhileLoop_Btn.Click += WhileLoop_Btn_Click;
            // 
            // memoryBtn
            // 
            memoryBtn.Location = new Point(12, 661);
            memoryBtn.Name = "memoryBtn";
            memoryBtn.Size = new Size(45, 28);
            memoryBtn.TabIndex = 18;
            memoryBtn.Text = "M";
            memoryBtn.UseVisualStyleBackColor = true;
            memoryBtn.Click += memoryBtn_Click;
            // 
            // memoryLabel
            // 
            memoryLabel.AutoSize = true;
            memoryLabel.BackColor = Color.Cornsilk;
            memoryLabel.Location = new Point(216, 700);
            memoryLabel.Name = "memoryLabel";
            memoryLabel.Size = new Size(0, 20);
            memoryLabel.TabIndex = 19;
            memoryLabel.MouseEnter += memoryLabel_MouseEnter;
            memoryLabel.MouseLeave += memoryLabel_MouseLeave;
            // 
            // mPlus_Btn
            // 
            mPlus_Btn.Location = new Point(63, 661);
            mPlus_Btn.Name = "mPlus_Btn";
            mPlus_Btn.Size = new Size(47, 28);
            mPlus_Btn.TabIndex = 20;
            mPlus_Btn.Text = "M+";
            mPlus_Btn.UseVisualStyleBackColor = true;
            mPlus_Btn.Click += mPlus_Btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 791);
            Controls.Add(mPlus_Btn);
            Controls.Add(memoryLabel);
            Controls.Add(memoryBtn);
            Controls.Add(WhileLoop_Btn);
            Controls.Add(ForLoop_Btn);
            Controls.Add(exitBtn);
            Controls.Add(calcBtn);
            Controls.Add(resultContainer);
            Controls.Add(userInput_2);
            Controls.Add(userInput_1);
            Controls.Add(multiplyToggle);
            Controls.Add(subtractToggle);
            Controls.Add(additionToggle);
            Controls.Add(divisionToggle);
            Controls.Add(clearBtn);
            Controls.Add(titleLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "C# Calculator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)userInput_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userInput_2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private TextBox resultContainer;
        private Button calcBtn;
        private Button exitBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem darkModeToolStripMenuItem;
        private ToolStripMenuItem lightModeToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button ForLoop_Btn;
        private Button WhileLoop_Btn;
        private Button memoryBtn;
        private Label memoryLabel;
        private Button mPlus_Btn;
    }
}
