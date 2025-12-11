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
            button6 = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(35, 147);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(81, 45);
            button1.TabIndex = 0;
            button1.Text = "Add";
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
            listBox1.Margin = new Padding(2, 2, 2, 2);
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
            speedUpButton.Margin = new Padding(2, 2, 2, 2);
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
            speedDownButton.Margin = new Padding(2, 2, 2, 2);
            speedDownButton.Name = "speedDownButton";
            speedDownButton.Size = new Size(44, 45);
            speedDownButton.TabIndex = 7;
            speedDownButton.Text = "-";
            speedDownButton.UseVisualStyleBackColor = true;
            speedDownButton.Click += speedDownButton_Click;
            // 
            // button6
            // 
            button6.Location = new Point(263, 15);
            button6.Margin = new Padding(2, 2, 2, 2);
            button6.Name = "button6";
            button6.Size = new Size(94, 45);
            button6.TabIndex = 12;
            button6.Text = "Pause";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "10", "100", "1000", "10000" });
            comboBox1.Location = new Point(121, 150);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(111, 40);
            comboBox1.TabIndex = 13;
            comboBox1.Text = "1";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 153);
            label4.Name = "label4";
            label4.Size = new Size(125, 32);
            label4.TabIndex = 14;
            label4.Text = "creature(s)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 695);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(button6);
            Controls.Add(speedDownButton);
            Controls.Add(speedUpButton);
            Controls.Add(yearLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(2, 2, 2, 2);
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
        private Button button6;
        private ComboBox comboBox1;
        private Label label4;
    }
}
