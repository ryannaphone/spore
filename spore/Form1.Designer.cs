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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(46, 339);
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
            label1.Location = new Point(103, 260);
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
            listBox1.Size = new Size(300, 414);
            listBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 262);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
