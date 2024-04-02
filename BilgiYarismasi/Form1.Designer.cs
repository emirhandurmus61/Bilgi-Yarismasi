namespace BilgiYarismasi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblsoruno = new System.Windows.Forms.Label();
            this.lblno = new System.Windows.Forms.Label();
            this.lblfalse = new System.Windows.Forms.Label();
            this.lbltrue = new System.Windows.Forms.Label();
            this.lblyanlis = new System.Windows.Forms.Label();
            this.lbldogru = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl1tl = new System.Windows.Forms.Label();
            this.lbl2tl = new System.Windows.Forms.Label();
            this.lbl3t = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl4tl = new System.Windows.Forms.Label();
            this.lbl5tl = new System.Windows.Forms.Label();
            this.lbl6tl = new System.Windows.Forms.Label();
            this.lbl7tl = new System.Windows.Forms.Label();
            this.lbl8tl = new System.Windows.Forms.Label();
            this.lbl9tl = new System.Windows.Forms.Label();
            this.lbl10tl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(467, 180);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.SkyBlue;
            this.btnA.Location = new System.Drawing.Point(12, 274);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(322, 70);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.SkyBlue;
            this.btnB.Location = new System.Drawing.Point(376, 274);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(322, 70);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.SkyBlue;
            this.btnC.Location = new System.Drawing.Point(12, 365);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(322, 70);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.SkyBlue;
            this.btnD.Location = new System.Drawing.Point(376, 365);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(322, 70);
            this.btnD.TabIndex = 3;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.button4_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 221);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(686, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btnSonraki
            // 
            this.btnSonraki.BackColor = System.Drawing.Color.Silver;
            this.btnSonraki.Location = new System.Drawing.Point(12, 455);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(686, 77);
            this.btnSonraki.TabIndex = 6;
            this.btnSonraki.Text = "Sıradaki Soru";
            this.btnSonraki.UseVisualStyleBackColor = false;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblsoruno);
            this.panel1.Controls.Add(this.lblno);
            this.panel1.Controls.Add(this.lblfalse);
            this.panel1.Controls.Add(this.lbltrue);
            this.panel1.Controls.Add(this.lblyanlis);
            this.panel1.Controls.Add(this.lbldogru);
            this.panel1.Location = new System.Drawing.Point(500, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 178);
            this.panel1.TabIndex = 7;
            // 
            // lblsoruno
            // 
            this.lblsoruno.AutoSize = true;
            this.lblsoruno.Location = new System.Drawing.Point(14, 38);
            this.lblsoruno.Name = "lblsoruno";
            this.lblsoruno.Size = new System.Drawing.Size(103, 25);
            this.lblsoruno.TabIndex = 7;
            this.lblsoruno.Text = "Soru No:";
            // 
            // lblno
            // 
            this.lblno.AutoSize = true;
            this.lblno.Location = new System.Drawing.Point(139, 38);
            this.lblno.Name = "lblno";
            this.lblno.Size = new System.Drawing.Size(25, 25);
            this.lblno.TabIndex = 6;
            this.lblno.Text = "0";
            // 
            // lblfalse
            // 
            this.lblfalse.AutoSize = true;
            this.lblfalse.ForeColor = System.Drawing.Color.Red;
            this.lblfalse.Location = new System.Drawing.Point(139, 113);
            this.lblfalse.Name = "lblfalse";
            this.lblfalse.Size = new System.Drawing.Size(25, 25);
            this.lblfalse.TabIndex = 5;
            this.lblfalse.Text = "0";
            // 
            // lbltrue
            // 
            this.lbltrue.AutoSize = true;
            this.lbltrue.ForeColor = System.Drawing.Color.Green;
            this.lbltrue.Location = new System.Drawing.Point(139, 75);
            this.lbltrue.Name = "lbltrue";
            this.lbltrue.Size = new System.Drawing.Size(25, 25);
            this.lbltrue.TabIndex = 4;
            this.lbltrue.Text = "0";
            // 
            // lblyanlis
            // 
            this.lblyanlis.AutoSize = true;
            this.lblyanlis.ForeColor = System.Drawing.Color.Red;
            this.lblyanlis.Location = new System.Drawing.Point(38, 113);
            this.lblyanlis.Name = "lblyanlis";
            this.lblyanlis.Size = new System.Drawing.Size(79, 25);
            this.lblyanlis.TabIndex = 2;
            this.lblyanlis.Text = "Yanlış:";
            // 
            // lbldogru
            // 
            this.lbldogru.AutoSize = true;
            this.lbldogru.ForeColor = System.Drawing.Color.Green;
            this.lbldogru.Location = new System.Drawing.Point(35, 75);
            this.lbldogru.Name = "lbldogru";
            this.lbldogru.Size = new System.Drawing.Size(82, 25);
            this.lbldogru.TabIndex = 1;
            this.lbldogru.Text = "Doğru:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbl1tl);
            this.panel2.Controls.Add(this.lbl2tl);
            this.panel2.Controls.Add(this.lbl3t);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lbl4tl);
            this.panel2.Controls.Add(this.lbl5tl);
            this.panel2.Controls.Add(this.lbl6tl);
            this.panel2.Controls.Add(this.lbl7tl);
            this.panel2.Controls.Add(this.lbl8tl);
            this.panel2.Controls.Add(this.lbl9tl);
            this.panel2.Controls.Add(this.lbl10tl);
            this.panel2.Location = new System.Drawing.Point(731, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 421);
            this.panel2.TabIndex = 9;
            // 
            // lbl1tl
            // 
            this.lbl1tl.AutoSize = true;
            this.lbl1tl.Location = new System.Drawing.Point(29, 387);
            this.lbl1tl.Name = "lbl1tl";
            this.lbl1tl.Size = new System.Drawing.Size(94, 25);
            this.lbl1tl.TabIndex = 10;
            this.lbl1tl.Text = "1000 TL";
            // 
            // lbl2tl
            // 
            this.lbl2tl.AutoSize = true;
            this.lbl2tl.Location = new System.Drawing.Point(29, 351);
            this.lbl2tl.Name = "lbl2tl";
            this.lbl2tl.Size = new System.Drawing.Size(94, 25);
            this.lbl2tl.TabIndex = 9;
            this.lbl2tl.Text = "3000 TL";
            // 
            // lbl3t
            // 
            this.lbl3t.AutoSize = true;
            this.lbl3t.Location = new System.Drawing.Point(29, 317);
            this.lbl3t.Name = "lbl3t";
            this.lbl3t.Size = new System.Drawing.Size(94, 25);
            this.lbl3t.TabIndex = 8;
            this.lbl3t.Text = "7500 TL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "ÖDÜLLER";
            // 
            // lbl4tl
            // 
            this.lbl4tl.AutoSize = true;
            this.lbl4tl.Location = new System.Drawing.Point(29, 283);
            this.lbl4tl.Name = "lbl4tl";
            this.lbl4tl.Size = new System.Drawing.Size(114, 25);
            this.lbl4tl.TabIndex = 6;
            this.lbl4tl.Text = "15.000 TL";
            // 
            // lbl5tl
            // 
            this.lbl5tl.AutoSize = true;
            this.lbl5tl.Location = new System.Drawing.Point(29, 247);
            this.lbl5tl.Name = "lbl5tl";
            this.lbl5tl.Size = new System.Drawing.Size(114, 25);
            this.lbl5tl.TabIndex = 5;
            this.lbl5tl.Text = "30.000 TL";
            // 
            // lbl6tl
            // 
            this.lbl6tl.AutoSize = true;
            this.lbl6tl.Location = new System.Drawing.Point(29, 207);
            this.lbl6tl.Name = "lbl6tl";
            this.lbl6tl.Size = new System.Drawing.Size(114, 25);
            this.lbl6tl.TabIndex = 4;
            this.lbl6tl.Text = "50.000 TL";
            // 
            // lbl7tl
            // 
            this.lbl7tl.AutoSize = true;
            this.lbl7tl.Location = new System.Drawing.Point(29, 173);
            this.lbl7tl.Name = "lbl7tl";
            this.lbl7tl.Size = new System.Drawing.Size(127, 25);
            this.lbl7tl.TabIndex = 3;
            this.lbl7tl.Text = "125.000 TL";
            // 
            // lbl8tl
            // 
            this.lbl8tl.AutoSize = true;
            this.lbl8tl.Location = new System.Drawing.Point(29, 136);
            this.lbl8tl.Name = "lbl8tl";
            this.lbl8tl.Size = new System.Drawing.Size(127, 25);
            this.lbl8tl.TabIndex = 2;
            this.lbl8tl.Text = "250.000 TL";
            // 
            // lbl9tl
            // 
            this.lbl9tl.AutoSize = true;
            this.lbl9tl.Location = new System.Drawing.Point(29, 98);
            this.lbl9tl.Name = "lbl9tl";
            this.lbl9tl.Size = new System.Drawing.Size(127, 25);
            this.lbl9tl.TabIndex = 1;
            this.lbl9tl.Text = "500.000 TL";
            // 
            // lbl10tl
            // 
            this.lbl10tl.AutoSize = true;
            this.lbl10tl.Location = new System.Drawing.Point(29, 61);
            this.lbl10tl.Name = "lbl10tl";
            this.lbl10tl.Size = new System.Drawing.Size(147, 25);
            this.lbl10tl.TabIndex = 0;
            this.lbl10tl.Text = "1.000.000 TL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(774, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(322, 540);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 25);
            this.label17.TabIndex = 12;
            this.label17.Text = "label17";
            this.label17.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(414, 540);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 25);
            this.label18.TabIndex = 13;
            this.label18.Text = "label18";
            this.label18.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(954, 574);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSonraki;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblfalse;
        private System.Windows.Forms.Label lbltrue;
        private System.Windows.Forms.Label lblyanlis;
        private System.Windows.Forms.Label lbldogru;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl4tl;
        private System.Windows.Forms.Label lbl5tl;
        private System.Windows.Forms.Label lbl6tl;
        private System.Windows.Forms.Label lbl7tl;
        private System.Windows.Forms.Label lbl8tl;
        private System.Windows.Forms.Label lbl9tl;
        private System.Windows.Forms.Label lbl10tl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl1tl;
        private System.Windows.Forms.Label lbl2tl;
        private System.Windows.Forms.Label lbl3t;
        private System.Windows.Forms.Label lblsoruno;
        private System.Windows.Forms.Label lblno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Timer timer1;
    }
}

