namespace myCalculator
{
    partial class Newform
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button24 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(10, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(389, 155);
            this.textBox1.TabIndex = 36;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(371, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 32);
            this.label9.TabIndex = 27;
            this.label9.Text = "^";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 22);
            this.label8.TabIndex = 28;
            this.label8.Text = "FLOOR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "CEIL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "ABS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(181, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "π";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "MOD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "DEC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "OCT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "BIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.GhostWhite;
            this.button24.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button24.Location = new System.Drawing.Point(2, 243);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(100, 62);
            this.button24.TabIndex = 25;
            this.button24.Text = "%";
            this.button24.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.GhostWhite;
            this.button20.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button20.Location = new System.Drawing.Point(2, 307);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(100, 62);
            this.button20.TabIndex = 24;
            this.button20.Text = "(";
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.GhostWhite;
            this.button16.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button16.Location = new System.Drawing.Point(2, 370);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(100, 62);
            this.button16.TabIndex = 23;
            this.button16.Text = "7";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.GhostWhite;
            this.button12.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(2, 433);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 62);
            this.button12.TabIndex = 22;
            this.button12.Text = "4";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.GhostWhite;
            this.button8.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(2, 496);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 62);
            this.button8.TabIndex = 21;
            this.button8.Text = "1";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.GhostWhite;
            this.button4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(2, 559);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 62);
            this.button4.TabIndex = 20;
            this.button4.Text = "⚫";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.GhostWhite;
            this.button23.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button23.Location = new System.Drawing.Point(103, 243);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(100, 62);
            this.button23.TabIndex = 3;
            this.button23.Text = "🔚";
            this.button23.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.GhostWhite;
            this.button19.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button19.Location = new System.Drawing.Point(103, 307);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(100, 62);
            this.button19.TabIndex = 18;
            this.button19.Text = "log";
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.GhostWhite;
            this.button15.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button15.Location = new System.Drawing.Point(103, 370);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(100, 62);
            this.button15.TabIndex = 17;
            this.button15.Text = "8";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.GhostWhite;
            this.button11.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(103, 433);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 62);
            this.button11.TabIndex = 16;
            this.button11.Text = "5";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.GhostWhite;
            this.button7.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(103, 496);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 62);
            this.button7.TabIndex = 15;
            this.button7.Text = "2";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.GhostWhite;
            this.button3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(103, 559);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 62);
            this.button3.TabIndex = 14;
            this.button3.Text = "0";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.GhostWhite;
            this.button22.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button22.Location = new System.Drawing.Point(205, 243);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(100, 62);
            this.button22.TabIndex = 13;
            this.button22.Text = "🔙";
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.GhostWhite;
            this.button18.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button18.Location = new System.Drawing.Point(205, 307);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(100, 62);
            this.button18.TabIndex = 12;
            this.button18.Text = ")";
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.GhostWhite;
            this.button14.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button14.Location = new System.Drawing.Point(205, 370);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(100, 62);
            this.button14.TabIndex = 11;
            this.button14.Text = "9";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.GhostWhite;
            this.button21.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button21.Location = new System.Drawing.Point(306, 243);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(100, 62);
            this.button21.TabIndex = 10;
            this.button21.Text = "❎";
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.GhostWhite;
            this.button17.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button17.Location = new System.Drawing.Point(306, 307);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(100, 62);
            this.button17.TabIndex = 9;
            this.button17.Text = "➗";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.GhostWhite;
            this.button10.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(205, 433);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 62);
            this.button10.TabIndex = 8;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.GhostWhite;
            this.button13.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button13.Location = new System.Drawing.Point(306, 370);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 62);
            this.button13.TabIndex = 7;
            this.button13.Text = "❌";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.GhostWhite;
            this.button6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(205, 496);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 62);
            this.button6.TabIndex = 6;
            this.button6.Text = "3";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.GhostWhite;
            this.button9.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(306, 433);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 62);
            this.button9.TabIndex = 5;
            this.button9.Text = "➖";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.GhostWhite;
            this.button2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(205, 559);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 62);
            this.button2.TabIndex = 4;
            this.button2.Text = "00";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.GhostWhite;
            this.button5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(306, 496);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 62);
            this.button5.TabIndex = 26;
            this.button5.Text = "➕";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(306, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 62);
            this.button1.TabIndex = 19;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Newform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 622);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Newform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Newform";
            this.Load += new System.EventHandler(this.Newform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button24;
        private Button button20;
        private Button button16;
        private Button button12;
        private Button button8;
        private Button button4;
        private Button button23;
        private Button button19;
        private Button button15;
        private Button button11;
        private Button button7;
        private Button button3;
        private Button button22;
        private Button button18;
        private Button button14;
        private Button button21;
        private Button button17;
        private Button button10;
        private Button button13;
        private Button button6;
        private Button button9;
        private Button button2;
        private Button button5;
        private Button button1;
    }
}