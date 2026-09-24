namespace FormCalculator
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
            btn0 = new Button();
            btn1 = new Button();
            btn4 = new Button();
            btn7 = new Button();
            btn9 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn8 = new Button();
            txtDisplay = new TextBox();
            btnAdd = new Button();
            btnDivide = new Button();
            btnSubstract = new Button();
            btnMutiply = new Button();
            btnClear = new Button();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // btn0
            // 
            btn0.Location = new Point(12, 387);
            btn0.Name = "btn0";
            btn0.Size = new Size(57, 51);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += NumberButton_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 320);
            btn1.Name = "btn1";
            btn1.Size = new Size(57, 51);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += NumberButton_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 263);
            btn4.Name = "btn4";
            btn4.Size = new Size(57, 51);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += NumberButton_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 206);
            btn7.Name = "btn7";
            btn7.Size = new Size(57, 51);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += NumberButton_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(207, 206);
            btn9.Name = "btn9";
            btn9.Size = new Size(57, 51);
            btn9.TabIndex = 1;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += NumberButton_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(112, 320);
            btn2.Name = "btn2";
            btn2.Size = new Size(57, 51);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += NumberButton_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(207, 320);
            btn3.Name = "btn3";
            btn3.Size = new Size(57, 51);
            btn3.TabIndex = 1;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += NumberButton_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(112, 263);
            btn5.Name = "btn5";
            btn5.Size = new Size(57, 51);
            btn5.TabIndex = 1;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += NumberButton_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(207, 263);
            btn6.Name = "btn6";
            btn6.Size = new Size(57, 51);
            btn6.TabIndex = 1;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += NumberButton_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(112, 206);
            btn8.Name = "btn8";
            btn8.Size = new Size(57, 51);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += NumberButton_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.BorderStyle = BorderStyle.FixedSingle;
            txtDisplay.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(12, 127);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(347, 50);
            txtDisplay.TabIndex = 2;
            txtDisplay.TextChanged += textBox1_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(302, 320);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(57, 51);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btn0_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(207, 387);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(57, 51);
            btnDivide.TabIndex = 3;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnSubstract
            // 
            btnSubstract.Location = new Point(302, 263);
            btnSubstract.Name = "btnSubstract";
            btnSubstract.Size = new Size(57, 51);
            btnSubstract.TabIndex = 4;
            btnSubstract.Text = "-";
            btnSubstract.UseVisualStyleBackColor = true;
            btnSubstract.Click += btnSubstract_Click;
            // 
            // btnMutiply
            // 
            btnMutiply.Location = new Point(302, 206);
            btnMutiply.Name = "btnMutiply";
            btnMutiply.Size = new Size(57, 51);
            btnMutiply.TabIndex = 5;
            btnMutiply.Text = "*";
            btnMutiply.UseVisualStyleBackColor = true;
            btnMutiply.Click += btnMutiply_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(112, 387);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(57, 51);
            btnClear.TabIndex = 6;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(302, 395);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(57, 43);
            btnEqual.TabIndex = 8;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 450);
            Controls.Add(btnEqual);
            Controls.Add(btnClear);
            Controls.Add(btnMutiply);
            Controls.Add(btnSubstract);
            Controls.Add(btnDivide);
            Controls.Add(txtDisplay);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn8);
            Controls.Add(btnAdd);
            Controls.Add(btn9);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn1);
            Controls.Add(btn0);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btn0;
        private Button btn1;
        private Button btn4;
        private Button btn7;
        private Button btn9;
        private Button btn2;
        private Button btn3;
        private Button btn5;
        private Button btn6;
        private Button btn8;
        private TextBox txtDisplay;
        private Button btnAdd;
        private Button btnDivide;
        private Button btnSubstract;
        private Button btnMutiply;
        private Button btnClear;
        private Button btnEqual;
    }
}
