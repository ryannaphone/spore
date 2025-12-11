namespace spore
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            listBox1 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            yearLabel = new Label();
            speedUpButton = new Button();
            speedDownButton = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            checkboxCustomData = new CheckBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(35, 147);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(291, 45);
            button1.TabIndex = 0;
            button1.Text = "Add a Creature";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 93);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(373, 9);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(641, 676);
            listBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 94);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 3;
            label2.Text = "creatures";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 15);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 32);
            label3.TabIndex = 4;
            label3.Text = "Year";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(79, 15);
            yearLabel.Margin = new Padding(2, 0, 2, 0);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(37, 32);
            yearLabel.TabIndex = 5;
            yearLabel.Text = "-1";
            // 
            // speedUpButton
            // 
            speedUpButton.Location = new Point(158, 18);
            speedUpButton.Margin = new Padding(2);
            speedUpButton.Name = "speedUpButton";
            speedUpButton.Size = new Size(44, 45);
            speedUpButton.TabIndex = 6;
            speedUpButton.Text = "+";
            speedUpButton.UseVisualStyleBackColor = true;
            speedUpButton.Click += speedUpButton_Click;
            // 
            // speedDownButton
            // 
            speedDownButton.Location = new Point(206, 18);
            speedDownButton.Margin = new Padding(2);
            speedDownButton.Name = "speedDownButton";
            speedDownButton.Size = new Size(44, 45);
            speedDownButton.TabIndex = 7;
            speedDownButton.Text = "-";
            speedDownButton.UseVisualStyleBackColor = true;
            speedDownButton.Click += speedDownButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(35, 209);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(291, 45);
            button2.TabIndex = 8;
            button2.Text = "Add 10 Creatures";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(35, 270);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(291, 45);
            button3.TabIndex = 9;
            button3.Text = "Add 100 Creatures";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(35, 327);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(291, 45);
            button4.TabIndex = 10;
            button4.Text = "Add 1000 Creatures";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(35, 387);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(291, 45);
            button5.TabIndex = 11;
            button5.Text = "Add 10000 Creatures";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(263, 15);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(94, 45);
            button6.TabIndex = 12;
            button6.Text = "Pause";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // checkboxCustomData
            // 
            checkboxCustomData.AutoSize = true;
            checkboxCustomData.Location = new Point(35, 453);
            checkboxCustomData.Name = "checkboxCustomData";
            checkboxCustomData.Size = new Size(289, 36);
            checkboxCustomData.TabIndex = 13;
            checkboxCustomData.Text = "Use custom attributes?";
            toolTip1.SetToolTip(checkboxCustomData, "On: Use attributes below\r\nOff: Use a random built-in");
            checkboxCustomData.UseVisualStyleBackColor = true;
            checkboxCustomData.CheckedChanged += checkboxCustomData_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 495);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 498);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 15;
            label4.Text = "Name";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 543);
            label5.Name = "label5";
            label5.Size = new Size(77, 32);
            label5.TabIndex = 16;
            label5.Text = "Die %";
            toolTip1.SetToolTip(label5, "An expression giving the death.\r\nUse the `age` variable to get the creature's age.");
            label5.Click += label5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 540);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 695);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(checkboxCustomData);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(speedDownButton);
            Controls.Add(speedUpButton);
            Controls.Add(yearLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private ListBox listBox1;
        private Label label2;
        private Label label3;
        private Label yearLabel;
        private Button speedUpButton;
        private Button speedDownButton;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private CheckBox checkboxCustomData;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private ToolTip toolTip1;
    }
}
