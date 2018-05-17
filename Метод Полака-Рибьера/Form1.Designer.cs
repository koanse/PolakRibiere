namespace Метод_Полака_Рибьера
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbA5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbA4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbA3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbA2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbA1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbA0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMaxIter = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbGradEps = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbXEps = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbFEps = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbMachEps = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbLambdaMax = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 342);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 363);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Траектория оптимизации";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 88);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип оптимизируемой функции";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 60);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(135, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Функция Розенброка";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(179, 35);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Квадратичная функция двух переменных";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "a =";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbB);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbA);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 75);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметры функции Розенброка";
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(47, 45);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(141, 20);
            this.tbB.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "b =";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(47, 19);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(141, 20);
            this.tbA.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbA5);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.tbA4);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.tbA3);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.tbA2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.tbA1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.tbA0);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(6, 100);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 181);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Параметры квадратичной функции";
            // 
            // tbA5
            // 
            this.tbA5.Location = new System.Drawing.Point(47, 150);
            this.tbA5.Name = "tbA5";
            this.tbA5.Size = new System.Drawing.Size(141, 20);
            this.tbA5.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "a5 =";
            // 
            // tbA4
            // 
            this.tbA4.Location = new System.Drawing.Point(47, 124);
            this.tbA4.Name = "tbA4";
            this.tbA4.Size = new System.Drawing.Size(141, 20);
            this.tbA4.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "a4 =";
            // 
            // tbA3
            // 
            this.tbA3.Location = new System.Drawing.Point(47, 97);
            this.tbA3.Name = "tbA3";
            this.tbA3.Size = new System.Drawing.Size(141, 20);
            this.tbA3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "a3 =";
            // 
            // tbA2
            // 
            this.tbA2.Location = new System.Drawing.Point(47, 71);
            this.tbA2.Name = "tbA2";
            this.tbA2.Size = new System.Drawing.Size(141, 20);
            this.tbA2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "a2 =";
            // 
            // tbA1
            // 
            this.tbA1.Location = new System.Drawing.Point(47, 45);
            this.tbA1.Name = "tbA1";
            this.tbA1.Size = new System.Drawing.Size(141, 20);
            this.tbA1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "a1 =";
            // 
            // tbA0
            // 
            this.tbA0.Location = new System.Drawing.Point(47, 19);
            this.tbA0.Name = "tbA0";
            this.tbA0.Size = new System.Drawing.Size(141, 20);
            this.tbA0.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "a0 =";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Расчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(220, 395);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(212, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Функция";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbLambdaMax);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.tbMachEps);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.tbFEps);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.tbXEps);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.tbGradEps);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.tbMaxIter);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tbX2);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tbX1);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(212, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(212, 369);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Результаты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "x1 Init.";
            // 
            // tbX1
            // 
            this.tbX1.Location = new System.Drawing.Point(83, 6);
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(123, 20);
            this.tbX1.TabIndex = 1;
            this.tbX1.Text = "0";
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(83, 32);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(123, 20);
            this.tbX2.TabIndex = 3;
            this.tbX2.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "x2 Init.";
            // 
            // tbMaxIter
            // 
            this.tbMaxIter.Location = new System.Drawing.Point(83, 58);
            this.tbMaxIter.Name = "tbMaxIter";
            this.tbMaxIter.Size = new System.Drawing.Size(123, 20);
            this.tbMaxIter.TabIndex = 5;
            this.tbMaxIter.Text = "100";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Max Iter.";
            // 
            // tbGradEps
            // 
            this.tbGradEps.Location = new System.Drawing.Point(83, 84);
            this.tbGradEps.Name = "tbGradEps";
            this.tbGradEps.Size = new System.Drawing.Size(123, 20);
            this.tbGradEps.TabIndex = 7;
            this.tbGradEps.Text = "0,00000000000001";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Grad. Eps.";
            // 
            // tbXEps
            // 
            this.tbXEps.Location = new System.Drawing.Point(83, 110);
            this.tbXEps.Name = "tbXEps";
            this.tbXEps.Size = new System.Drawing.Size(123, 20);
            this.tbXEps.TabIndex = 9;
            this.tbXEps.Text = "0,00000000000001";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "X Eps.";
            // 
            // tbFEps
            // 
            this.tbFEps.Location = new System.Drawing.Point(83, 136);
            this.tbFEps.Name = "tbFEps";
            this.tbFEps.Size = new System.Drawing.Size(123, 20);
            this.tbFEps.TabIndex = 11;
            this.tbFEps.Text = "0,00000000000001";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "F Eps.";
            // 
            // tbMachEps
            // 
            this.tbMachEps.Location = new System.Drawing.Point(83, 162);
            this.tbMachEps.Name = "tbMachEps";
            this.tbMachEps.Size = new System.Drawing.Size(123, 20);
            this.tbMachEps.TabIndex = 13;
            this.tbMachEps.Text = "0,00000000000001";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 165);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Mach. Eps.";
            // 
            // tbLambdaMax
            // 
            this.tbLambdaMax.Location = new System.Drawing.Point(83, 188);
            this.tbLambdaMax.Name = "tbLambdaMax";
            this.tbLambdaMax.Size = new System.Drawing.Size(123, 20);
            this.tbLambdaMax.TabIndex = 15;
            this.tbLambdaMax.Text = "0,001";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 191);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Lambda Max.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 420);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Оптимизация методом Полака-Рибьера";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbA5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbA4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbA3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbA2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbA1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbA0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbX1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbLambdaMax;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbMachEps;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbFEps;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbXEps;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbGradEps;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbMaxIter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbX2;
        private System.Windows.Forms.Label label10;
    }
}

