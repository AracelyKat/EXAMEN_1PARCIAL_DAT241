namespace CalculadoraNotacion
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
            label1 = new Label();
            label2 = new Label();
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
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(38, 19);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(469, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 63);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 1;
            label1.Text = "NOTACION INFIJA : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 98);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 2;
            label2.Text = "NOTACION POSTFIJA:";
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(38, 318);
            button1.Name = "button1";
            button1.Size = new Size(86, 48);
            button1.TabIndex = 3;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += composicion;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(137, 318);
            button2.Name = "button2";
            button2.Size = new Size(86, 48);
            button2.TabIndex = 4;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += composicion;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(234, 318);
            button3.Name = "button3";
            button3.Size = new Size(86, 48);
            button3.TabIndex = 5;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += composicion;
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(38, 256);
            button4.Name = "button4";
            button4.Size = new Size(86, 48);
            button4.TabIndex = 8;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += composicion;
            // 
            // button5
            // 
            button5.BackColor = Color.Gray;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(137, 256);
            button5.Name = "button5";
            button5.Size = new Size(86, 48);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += composicion;
            // 
            // button6
            // 
            button6.BackColor = Color.Gray;
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(234, 256);
            button6.Name = "button6";
            button6.Size = new Size(86, 48);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += composicion;
            // 
            // button7
            // 
            button7.BackColor = Color.Gray;
            button7.BackgroundImageLayout = ImageLayout.None;
            button7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(38, 195);
            button7.Name = "button7";
            button7.Size = new Size(86, 48);
            button7.TabIndex = 11;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += composicion;
            // 
            // button8
            // 
            button8.BackColor = Color.Gray;
            button8.BackgroundImageLayout = ImageLayout.None;
            button8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(137, 195);
            button8.Name = "button8";
            button8.Size = new Size(86, 48);
            button8.TabIndex = 10;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += composicion;
            // 
            // button9
            // 
            button9.BackColor = Color.Gray;
            button9.BackgroundImageLayout = ImageLayout.None;
            button9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(234, 195);
            button9.Name = "button9";
            button9.Size = new Size(86, 48);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += composicion;
            // 
            // button10
            // 
            button10.BackColor = Color.Gray;
            button10.BackgroundImageLayout = ImageLayout.None;
            button10.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            button10.Location = new Point(326, 316);
            button10.Name = "button10";
            button10.Size = new Size(86, 48);
            button10.TabIndex = 14;
            button10.Text = "/";
            button10.UseVisualStyleBackColor = false;
            button10.Click += composicion;
            // 
            // button11
            // 
            button11.BackColor = Color.Gray;
            button11.BackgroundImageLayout = ImageLayout.None;
            button11.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            button11.Location = new Point(326, 377);
            button11.Name = "button11";
            button11.Size = new Size(86, 48);
            button11.TabIndex = 13;
            button11.Text = "*";
            button11.UseVisualStyleBackColor = false;
            button11.Click += composicion;
            // 
            // button12
            // 
            button12.BackColor = Color.Gray;
            button12.BackgroundImageLayout = ImageLayout.None;
            button12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.Location = new Point(421, 256);
            button12.Name = "button12";
            button12.Size = new Size(86, 172);
            button12.TabIndex = 12;
            button12.Text = "=";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.Gray;
            button13.BackgroundImageLayout = ImageLayout.None;
            button13.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.Location = new Point(234, 380);
            button13.Name = "button13";
            button13.Size = new Size(86, 48);
            button13.TabIndex = 17;
            button13.Text = "0";
            button13.UseVisualStyleBackColor = false;
            button13.Click += composicion;
            // 
            // button14
            // 
            button14.BackColor = Color.Gray;
            button14.BackgroundImageLayout = ImageLayout.None;
            button14.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button14.Location = new Point(137, 380);
            button14.Name = "button14";
            button14.Size = new Size(86, 48);
            button14.TabIndex = 16;
            button14.Text = ".";
            button14.UseVisualStyleBackColor = false;
            button14.Click += composicion;
            // 
            // button15
            // 
            button15.BackColor = Color.Gray;
            button15.BackgroundImageLayout = ImageLayout.None;
            button15.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button15.Location = new Point(38, 380);
            button15.Name = "button15";
            button15.Size = new Size(86, 48);
            button15.TabIndex = 15;
            button15.Text = "DEL";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.Gray;
            button16.BackgroundImageLayout = ImageLayout.None;
            button16.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            button16.Location = new Point(326, 254);
            button16.Name = "button16";
            button16.Size = new Size(86, 48);
            button16.TabIndex = 18;
            button16.Text = "-";
            button16.UseVisualStyleBackColor = false;
            button16.Click += composicion;
            // 
            // button17
            // 
            button17.BackColor = Color.Gray;
            button17.BackgroundImageLayout = ImageLayout.None;
            button17.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button17.Location = new Point(329, 139);
            button17.Name = "button17";
            button17.Size = new Size(86, 48);
            button17.TabIndex = 22;
            button17.Text = "LOG";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.Gray;
            button18.BackgroundImageLayout = ImageLayout.None;
            button18.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button18.Location = new Point(38, 136);
            button18.Name = "button18";
            button18.RightToLeft = RightToLeft.Yes;
            button18.Size = new Size(86, 48);
            button18.TabIndex = 21;
            button18.Text = "C";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.Gray;
            button19.BackgroundImageLayout = ImageLayout.None;
            button19.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button19.Location = new Point(137, 136);
            button19.Name = "button19";
            button19.Size = new Size(86, 48);
            button19.TabIndex = 20;
            button19.Text = " √";
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.Gray;
            button20.BackgroundImageLayout = ImageLayout.None;
            button20.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button20.Location = new Point(234, 136);
            button20.Name = "button20";
            button20.Size = new Size(86, 48);
            button20.TabIndex = 19;
            button20.Text = "X²";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // button21
            // 
            button21.BackColor = Color.Gray;
            button21.BackgroundImageLayout = ImageLayout.None;
            button21.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            button21.Location = new Point(328, 195);
            button21.Name = "button21";
            button21.Size = new Size(86, 48);
            button21.TabIndex = 23;
            button21.Text = "+";
            button21.UseVisualStyleBackColor = false;
            button21.Click += composicion;
            // 
            // button22
            // 
            button22.BackColor = Color.Gray;
            button22.BackgroundImageLayout = ImageLayout.None;
            button22.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            button22.Location = new Point(420, 195);
            button22.Name = "button22";
            button22.Size = new Size(86, 48);
            button22.TabIndex = 25;
            button22.Text = ")";
            button22.UseVisualStyleBackColor = false;
            button22.Click += composicion;
            // 
            // button23
            // 
            button23.BackColor = Color.Gray;
            button23.BackgroundImageLayout = ImageLayout.None;
            button23.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button23.Location = new Point(421, 139);
            button23.Name = "button23";
            button23.Size = new Size(86, 48);
            button23.TabIndex = 24;
            button23.Text = "(";
            button23.UseVisualStyleBackColor = false;
            button23.Click += composicion;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Location = new Point(205, 62);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(302, 27);
            textBox2.TabIndex = 26;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Location = new Point(204, 95);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(302, 27);
            textBox3.TabIndex = 27;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 461);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button22);
            Controls.Add(button23);
            Controls.Add(button21);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button16);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
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
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
