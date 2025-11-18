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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(46, 188);
            button1.Name = "button1";
            button1.Size = new Size(381, 58);
            button1.TabIndex = 0;
            button1.Text = "Add a Random Creature";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 119);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
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
            listBox1.ItemHeight = 41;
            listBox1.Location = new Point(488, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(837, 865);
            listBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 121);
            label2.Name = "label2";
            label2.Size = new Size(139, 41);
            label2.TabIndex = 3;
            label2.Text = "creatures";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 19);
            label3.Name = "label3";
            label3.Size = new Size(73, 41);
            label3.TabIndex = 4;
            label3.Text = "Year";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(103, 19);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(46, 41);
            yearLabel.TabIndex = 5;
            yearLabel.Text = "-1";
            // 
            // speedUpButton
            // 
            speedUpButton.Location = new Point(207, 23);
            speedUpButton.Name = "speedUpButton";
            speedUpButton.Size = new Size(57, 58);
            speedUpButton.TabIndex = 6;
            speedUpButton.Text = "+";
            speedUpButton.UseVisualStyleBackColor = true;
            speedUpButton.Click += speedUpButton_Click;
            // 
            // speedDownButton
            // 
            speedDownButton.Location = new Point(270, 23);
            speedDownButton.Name = "speedDownButton";
            speedDownButton.Size = new Size(57, 58);
            speedDownButton.TabIndex = 7;
            speedDownButton.Text = "-";
            speedDownButton.UseVisualStyleBackColor = true;
            speedDownButton.Click += speedDownButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(46, 268);
            button2.Name = "button2";
            button2.Size = new Size(381, 58);
            button2.TabIndex = 8;
            button2.Text = "Add 10 Random Creature";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(46, 346);
            button3.Name = "button3";
            button3.Size = new Size(381, 58);
            button3.TabIndex = 9;
            button3.Text = "Add 100 Random Creature";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(46, 419);
            button4.Name = "button4";
            button4.Size = new Size(381, 58);
            button4.TabIndex = 10;
            button4.Text = "Add 1000 Random Creature";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(46, 496);
            button5.Name = "button5";
            button5.Size = new Size(381, 58);
            button5.TabIndex = 11;
            button5.Text = "Add 10000 Random Creature";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(344, 19);
            button6.Name = "button6";
            button6.Size = new Size(123, 58);
            button6.TabIndex = 12;
            button6.Text = "Pause";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 890);
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
    }
}
