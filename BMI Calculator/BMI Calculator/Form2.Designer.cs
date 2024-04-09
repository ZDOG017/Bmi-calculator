namespace BMI_Calculator
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label4 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 19);
            label1.Name = "label1";
            label1.Size = new Size(304, 35);
            label1.TabIndex = 0;
            label1.Text = "BMI Calculator";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 75);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(48, 116);
            label2.Name = "label2";
            label2.Size = new Size(74, 26);
            label2.TabIndex = 2;
            label2.Text = "Weight";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 159);
            label3.Name = "label3";
            label3.Size = new Size(135, 26);
            label3.TabIndex = 3;
            label3.Text = "Height (in cm)";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 192, 192);
            textBox1.Location = new Point(144, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 192, 192);
            textBox2.Location = new Point(144, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(225, 23);
            textBox2.TabIndex = 5;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton1.Location = new Point(144, 203);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(106, 30);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Kilogram";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton2.Location = new Point(284, 203);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(85, 30);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Pound";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(48, 234);
            label4.Name = "label4";
            label4.Size = new Size(66, 26);
            label4.TabIndex = 8;
            label4.Text = "Result";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(255, 192, 192);
            textBox3.Location = new Point(53, 263);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(316, 87);
            textBox3.TabIndex = 9;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(53, 365);
            button1.Name = "button1";
            button1.Size = new Size(316, 33);
            button1.TabIndex = 10;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(53, 404);
            button2.Name = "button2";
            button2.Size = new Size(153, 34);
            button2.TabIndex = 11;
            button2.Text = "Back<-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(212, 404);
            button3.Name = "button3";
            button3.Size = new Size(157, 34);
            button3.TabIndex = 12;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 250, 215);
            ClientSize = new Size(423, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "BMI Calculator";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label4;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}