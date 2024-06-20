namespace OOP_24_
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(283, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(555, 60);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(199, 27);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(26, 171);
            button1.Name = "button1";
            button1.Size = new Size(209, 29);
            button1.TabIndex = 3;
            button1.Text = "Запустить поток 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(283, 171);
            button2.Name = "button2";
            button2.Size = new Size(211, 29);
            button2.TabIndex = 7;
            button2.Text = "Запустить поток 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(555, 171);
            button3.Name = "button3";
            button3.Size = new Size(199, 29);
            button3.TabIndex = 8;
            button3.Text = "Запустить поток 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.ForeColor = Color.Red;
            button4.Location = new Point(26, 206);
            button4.Name = "button4";
            button4.Size = new Size(209, 29);
            button4.TabIndex = 9;
            button4.Text = "Зупинить поток 1";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.ForeColor = Color.Red;
            button5.Location = new Point(283, 206);
            button5.Name = "button5";
            button5.Size = new Size(211, 29);
            button5.TabIndex = 10;
            button5.Text = "Зупинить поток 2";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.ForeColor = Color.Red;
            button6.Location = new Point(555, 206);
            button6.Name = "button6";
            button6.Size = new Size(199, 29);
            button6.TabIndex = 11;
            button6.Text = "Зупинить поток 3";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(26, 101);
            label1.Name = "label1";
            label1.Size = new Size(209, 34);
            label1.TabIndex = 12;
            label1.Text = " ";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(283, 101);
            label2.Name = "label2";
            label2.Size = new Size(211, 34);
            label2.TabIndex = 13;
            label2.Text = " ";
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(555, 101);
            label3.Name = "label3";
            label3.Size = new Size(199, 34);
            label3.TabIndex = 14;
            label3.Text = " ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(93, 26);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 15;
            label4.Text = "RC-5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(355, 26);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 16;
            label5.Text = "MD-3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(571, 26);
            label6.Name = "label6";
            label6.Size = new Size(163, 25);
            label6.TabIndex = 17;
            label6.Text = "Шифр Цезаря";
            // 
            // button7
            // 
            button7.Location = new Point(153, 294);
            button7.Name = "button7";
            button7.Size = new Size(491, 29);
            button7.TabIndex = 18;
            button7.Text = "Запустити всі потоки";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.ForeColor = Color.Red;
            button8.Location = new Point(153, 338);
            button8.Name = "button8";
            button8.Size = new Size(491, 29);
            button8.TabIndex = 19;
            button8.Text = "Зупинити всі потоки";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            ShowIcon = false;
            Text = "OOP 24";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button7;
        private Button button8;
    }
}
