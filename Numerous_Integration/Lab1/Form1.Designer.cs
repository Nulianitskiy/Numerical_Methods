namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.z1 = new ZedGraph.ZedGraphControl();
            this.Create = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Central_Squares = new System.Windows.Forms.Button();
            this.AnsCSI = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AnsSIM = new System.Windows.Forms.Label();
            this.nCSI = new System.Windows.Forms.Label();
            this.nSIM = new System.Windows.Forms.Label();
            this.hCSI = new System.Windows.Forms.Label();
            this.hSIM = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // z1
            // 
            this.z1.Location = new System.Drawing.Point(9, 10);
            this.z1.Name = "z1";
            this.z1.ScrollGrace = 0D;
            this.z1.ScrollMaxX = 0D;
            this.z1.ScrollMaxY = 0D;
            this.z1.ScrollMaxY2 = 0D;
            this.z1.ScrollMinX = 0D;
            this.z1.ScrollMinY = 0D;
            this.z1.ScrollMinY2 = 0D;
            this.z1.Size = new System.Drawing.Size(787, 365);
            this.z1.TabIndex = 1;
            this.z1.UseExtendedPrintDialog = true;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(600, 410);
            this.Create.Margin = new System.Windows.Forms.Padding(2);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(132, 39);
            this.Create.TabIndex = 2;
            this.Create.Text = "Построить ";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 476);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "E";
            // 
            // Central_Squares
            // 
            this.Central_Squares.Location = new System.Drawing.Point(164, 409);
            this.Central_Squares.Margin = new System.Windows.Forms.Padding(2);
            this.Central_Squares.Name = "Central_Squares";
            this.Central_Squares.Size = new System.Drawing.Size(184, 39);
            this.Central_Squares.TabIndex = 15;
            this.Central_Squares.Text = "Решить методом прямоугольников";
            this.Central_Squares.UseVisualStyleBackColor = true;
            this.Central_Squares.Click += new System.EventHandler(this.CSI_Click);
            // 
            // AnsCSI
            // 
            this.AnsCSI.AutoSize = true;
            this.AnsCSI.Location = new System.Drawing.Point(161, 450);
            this.AnsCSI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AnsCSI.Name = "AnsCSI";
            this.AnsCSI.Size = new System.Drawing.Size(13, 13);
            this.AnsCSI.TabIndex = 16;
            this.AnsCSI.Text = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxE);
            this.groupBox1.Controls.Add(this.textBoxB);
            this.groupBox1.Controls.Add(this.textBoxA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 391);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(513, 123);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Методы интегрирования";
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(24, 73);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(100, 20);
            this.textBoxE.TabIndex = 2;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(24, 46);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 1;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(24, 19);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "11";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 39);
            this.button1.TabIndex = 21;
            this.button1.Text = "Решить методом Симпсона (Парабол)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Sim_Click);
            // 
            // AnsSIM
            // 
            this.AnsSIM.AutoSize = true;
            this.AnsSIM.Location = new System.Drawing.Point(377, 451);
            this.AnsSIM.Name = "AnsSIM";
            this.AnsSIM.Size = new System.Drawing.Size(13, 13);
            this.AnsSIM.TabIndex = 22;
            this.AnsSIM.Text = "1";
            // 
            // nCSI
            // 
            this.nCSI.AutoSize = true;
            this.nCSI.Location = new System.Drawing.Point(161, 471);
            this.nCSI.Name = "nCSI";
            this.nCSI.Size = new System.Drawing.Size(19, 13);
            this.nCSI.TabIndex = 23;
            this.nCSI.Text = "11";
            // 
            // nSIM
            // 
            this.nSIM.AutoSize = true;
            this.nSIM.Location = new System.Drawing.Point(377, 471);
            this.nSIM.Name = "nSIM";
            this.nSIM.Size = new System.Drawing.Size(19, 13);
            this.nSIM.TabIndex = 24;
            this.nSIM.Text = "11";
            // 
            // hCSI
            // 
            this.hCSI.AutoSize = true;
            this.hCSI.Location = new System.Drawing.Point(161, 491);
            this.hCSI.Name = "hCSI";
            this.hCSI.Size = new System.Drawing.Size(25, 13);
            this.hCSI.TabIndex = 25;
            this.hCSI.Text = "111";
            // 
            // hSIM
            // 
            this.hSIM.AutoSize = true;
            this.hSIM.Location = new System.Drawing.Point(377, 491);
            this.hSIM.Name = "hSIM";
            this.hSIM.Size = new System.Drawing.Size(25, 13);
            this.hSIM.TabIndex = 26;
            this.hSIM.Text = "111";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 513);
            this.Controls.Add(this.hSIM);
            this.Controls.Add(this.hCSI);
            this.Controls.Add(this.nSIM);
            this.Controls.Add(this.nCSI);
            this.Controls.Add(this.AnsSIM);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AnsCSI);
            this.Controls.Add(this.Central_Squares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Интегрирование";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl z1;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Central_Squares;
        private System.Windows.Forms.Label AnsCSI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label AnsSIM;
        private System.Windows.Forms.Label nCSI;
        private System.Windows.Forms.Label nSIM;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label hCSI;
        private System.Windows.Forms.Label hSIM;
    }
}

