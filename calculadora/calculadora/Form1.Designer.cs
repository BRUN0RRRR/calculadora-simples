namespace calculadora
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            textBox3 = new TextBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 275);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Entrada de Dados";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 207);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 1;
            label4.Text = "Resultado:";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(106, 205);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 23);
            textBox3.TabIndex = 2;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(217, 109);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(130, 19);
            radioButton4.TabIndex = 14;
            radioButton4.TabStop = true;
            radioButton4.Text = "MULTIPLICAÇÃO(X)";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(218, 85);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(77, 19);
            radioButton3.TabIndex = 13;
            radioButton3.TabStop = true;
            radioButton3.Text = "DIVIDIR(/)";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(218, 60);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(79, 19);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "MENOS(-)";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(218, 39);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(69, 19);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "MAIS(+)";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(179, 142);
            button2.Name = "button2";
            button2.Size = new Size(83, 34);
            button2.TabIndex = 10;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(69, 142);
            button1.Name = "button1";
            button1.Size = new Size(83, 34);
            button1.TabIndex = 9;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 87);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 8;
            label3.Text = "Numero 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 34);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 7;
            label2.Text = "Numero 1";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 21);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 6;
            label1.Text = "Escolha um Operação";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(33, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(135, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(396, 298);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
        private RadioButton radioButton1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private Label label4;
        private TextBox textBox3;
    }
}
