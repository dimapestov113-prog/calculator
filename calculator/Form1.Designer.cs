namespace calculator
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            buttonumnoj = new Button();
            buttondelit = new Button();
            buttonravno = new Button();
            buttonplus = new Button();
            buttonmunis = new Button();
            buttondellete = new Button();
            button11 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 23F);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 58);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(12, 208);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonsNumber_Click;
            // 
            // button2
            // 
            button2.Location = new Point(78, 208);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ButtonsNumber_Click;
            // 
            // button3
            // 
            button3.Location = new Point(144, 208);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ButtonsNumber_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 142);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += ButtonsNumber_Click;
            // 
            // button5
            // 
            button5.Location = new Point(78, 142);
            button5.Name = "button5";
            button5.Size = new Size(60, 60);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += ButtonsNumber_Click;
            // 
            // button6
            // 
            button6.Location = new Point(144, 142);
            button6.Name = "button6";
            button6.Size = new Size(60, 60);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += ButtonsNumber_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 76);
            button7.Name = "button7";
            button7.Size = new Size(60, 60);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += ButtonsNumber_Click;
            // 
            // button8
            // 
            button8.Location = new Point(78, 76);
            button8.Name = "button8";
            button8.Size = new Size(60, 60);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += ButtonsNumber_Click;
            // 
            // button9
            // 
            button9.Location = new Point(144, 76);
            button9.Name = "button9";
            button9.Size = new Size(60, 60);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += ButtonsNumber_Click;
            // 
            // button10
            // 
            button10.Location = new Point(78, 274);
            button10.Name = "button10";
            button10.Size = new Size(60, 60);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += ButtonsNumber_Click;
            // 
            // buttonumnoj
            // 
            buttonumnoj.Location = new Point(12, 274);
            buttonumnoj.Name = "buttonumnoj";
            buttonumnoj.Size = new Size(60, 60);
            buttonumnoj.TabIndex = 11;
            buttonumnoj.Text = "*";
            buttonumnoj.UseVisualStyleBackColor = true;
            buttonumnoj.Click += buttonumnoj_Click;
            // 
            // buttondelit
            // 
            buttondelit.Location = new Point(144, 274);
            buttondelit.Name = "buttondelit";
            buttondelit.Size = new Size(60, 60);
            buttondelit.TabIndex = 12;
            buttondelit.Text = "/";
            buttondelit.UseVisualStyleBackColor = true;
            buttondelit.Click += buttondelit_Click;
            // 
            // buttonravno
            // 
            buttonravno.Location = new Point(210, 274);
            buttonravno.Name = "buttonravno";
            buttonravno.Size = new Size(60, 60);
            buttonravno.TabIndex = 13;
            buttonravno.Text = "=";
            buttonravno.UseVisualStyleBackColor = true;
            buttonravno.Click += buttonravno_Click;
            // 
            // buttonplus
            // 
            buttonplus.Location = new Point(210, 142);
            buttonplus.Name = "buttonplus";
            buttonplus.Size = new Size(60, 60);
            buttonplus.TabIndex = 14;
            buttonplus.Text = "+";
            buttonplus.UseVisualStyleBackColor = true;
            buttonplus.Click += buttonplus_Click;
            // 
            // buttonmunis
            // 
            buttonmunis.Location = new Point(210, 76);
            buttonmunis.Name = "buttonmunis";
            buttonmunis.Size = new Size(60, 60);
            buttonmunis.TabIndex = 15;
            buttonmunis.Text = "-";
            buttonmunis.UseVisualStyleBackColor = true;
            buttonmunis.Click += buttonmunis_Click;
            // 
            // buttondellete
            // 
            buttondellete.Location = new Point(210, 10);
            buttondellete.Name = "buttondellete";
            buttondellete.Size = new Size(60, 60);
            buttondellete.TabIndex = 16;
            buttondellete.Text = "<-";
            buttondellete.UseVisualStyleBackColor = true;
            buttondellete.Click += buttondellete_Click;
            // 
            // button11
            // 
            button11.Location = new Point(210, 208);
            button11.Name = "button11";
            button11.Size = new Size(60, 60);
            button11.TabIndex = 17;
            button11.Text = "%";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 342);
            Controls.Add(button11);
            Controls.Add(buttondellete);
            Controls.Add(buttonmunis);
            Controls.Add(buttonplus);
            Controls.Add(buttonravno);
            Controls.Add(buttondelit);
            Controls.Add(buttonumnoj);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button buttonumnoj;
        private Button buttondelit;
        private Button buttonravno;
        private Button buttonplus;
        private Button buttonmunis;
        private Button buttondellete;
        private Button button11;
    }
}
