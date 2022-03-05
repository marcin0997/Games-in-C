namespace Kulka
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
            this.components = new System.ComponentModel.Container();
            this.label_topEasy = new System.Windows.Forms.Label();
            this.label_topMedium = new System.Windows.Forms.Label();
            this.label_topHard = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonEllipse2 = new Kulka.ButtonEllipse();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_topEasy
            // 
            this.label_topEasy.AutoSize = true;
            this.label_topEasy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_topEasy.Location = new System.Drawing.Point(9, 97);
            this.label_topEasy.Name = "label_topEasy";
            this.label_topEasy.Size = new System.Drawing.Size(111, 21);
            this.label_topEasy.TabIndex = 1;
            this.label_topEasy.Text = "TOP SCORE: 0";
            // 
            // label_topMedium
            // 
            this.label_topMedium.AutoSize = true;
            this.label_topMedium.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_topMedium.Location = new System.Drawing.Point(9, 209);
            this.label_topMedium.Name = "label_topMedium";
            this.label_topMedium.Size = new System.Drawing.Size(111, 21);
            this.label_topMedium.TabIndex = 3;
            this.label_topMedium.Text = "TOP SCORE: 0";
            // 
            // label_topHard
            // 
            this.label_topHard.AutoSize = true;
            this.label_topHard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_topHard.Location = new System.Drawing.Point(9, 315);
            this.label_topHard.Name = "label_topHard";
            this.label_topHard.Size = new System.Drawing.Size(111, 21);
            this.label_topHard.TabIndex = 5;
            this.label_topHard.Text = "TOP SCORE: 0";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_score.Location = new System.Drawing.Point(181, 416);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(76, 25);
            this.label_score.TabIndex = 7;
            this.label_score.Text = "SCORE:";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_time.Location = new System.Drawing.Point(458, 416);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(108, 25);
            this.label_time.TabIndex = 8;
            this.label_time.Text = "TIME LEFT:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(706, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 100);
            this.label9.TabIndex = 9;
            this.label9.Text = "TRENUJ\r\nKONCENTRACJE, \r\nREFLEKS ORAZ PAMIĘĆ \r\nMIĘŚNIOWĄ.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(706, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 150);
            this.label10.TabIndex = 10;
            this.label10.Text = "KLIKNIJ JAKIKOLWIEK\r\nPRZYCISK, ABY\r\nPRZEJŚĆ DALEJ\r\nI ROZPOCZĄĆ GRĘ\r\nNA WYBRANYM\r\n" +
    "POZIOMIE";
            // 
            // buttonEllipse2
            // 
            this.buttonEllipse2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEllipse2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.buttonEllipse2.Location = new System.Drawing.Point(46, 34);
            this.buttonEllipse2.Name = "buttonEllipse2";
            this.buttonEllipse2.Size = new System.Drawing.Size(61, 60);
            this.buttonEllipse2.TabIndex = 12;
            this.buttonEllipse2.UseVisualStyleBackColor = false;
            this.buttonEllipse2.Click += new System.EventHandler(this.buttonEllipse2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.buttonEllipse2);
            this.panel1.Location = new System.Drawing.Point(135, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 401);
            this.panel1.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(23, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "EASY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(23, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "MEDIUM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(23, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 35);
            this.button3.TabIndex = 15;
            this.button3.Text = "HARD";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_topHard);
            this.Controls.Add(this.label_topMedium);
            this.Controls.Add(this.label_topEasy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label_topEasy;
        private Label label_topMedium;
        private Label label_topHard;
        private Label label_score;
        private Label label_time;
        private Label label9;
        private Label label10;
        private ButtonEllipse buttonEllipse2;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}