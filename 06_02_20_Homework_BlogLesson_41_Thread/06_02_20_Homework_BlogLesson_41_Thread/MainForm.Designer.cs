namespace _06_02_20_Homework_BlogLesson_41_Thread
{
    partial class MainForm
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
            this.lblTargil1 = new System.Windows.Forms.Label();
            this.btnTargil1 = new System.Windows.Forms.Button();
            this.txtGuessedRezult = new System.Windows.Forms.TextBox();
            this.btnExercise2threads = new System.Windows.Forms.Button();
            this.lblTargil2outputThreads = new System.Windows.Forms.Label();
            this.pnlExercise1 = new System.Windows.Forms.Panel();
            this.pnlExercise2 = new System.Windows.Forms.Panel();
            this.btnExercise2NoThreads = new System.Windows.Forms.Button();
            this.lblTargil2outputNoThreads = new System.Windows.Forms.Label();
            this.pnlExercise1.SuspendLayout();
            this.pnlExercise2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTargil1
            // 
            this.lblTargil1.AutoSize = true;
            this.lblTargil1.Location = new System.Drawing.Point(10, 11);
            this.lblTargil1.Name = "lblTargil1";
            this.lblTargil1.Size = new System.Drawing.Size(35, 13);
            this.lblTargil1.TabIndex = 0;
            this.lblTargil1.Text = "label1";
            // 
            // btnTargil1
            // 
            this.btnTargil1.Location = new System.Drawing.Point(13, 64);
            this.btnTargil1.Name = "btnTargil1";
            this.btnTargil1.Size = new System.Drawing.Size(75, 23);
            this.btnTargil1.TabIndex = 1;
            this.btnTargil1.Text = "Start";
            this.btnTargil1.UseVisualStyleBackColor = true;
            this.btnTargil1.Click += new System.EventHandler(this.btnTargil1_Click);
            // 
            // txtGuessedRezult
            // 
            this.txtGuessedRezult.Location = new System.Drawing.Point(13, 38);
            this.txtGuessedRezult.Name = "txtGuessedRezult";
            this.txtGuessedRezult.Size = new System.Drawing.Size(72, 20);
            this.txtGuessedRezult.TabIndex = 2;
            this.txtGuessedRezult.Text = "type rez here";
            // 
            // btnExercise2threads
            // 
            this.btnExercise2threads.Location = new System.Drawing.Point(12, 69);
            this.btnExercise2threads.Name = "btnExercise2threads";
            this.btnExercise2threads.Size = new System.Drawing.Size(163, 23);
            this.btnExercise2threads.TabIndex = 3;
            this.btnExercise2threads.Text = "Measure time with threads";
            this.btnExercise2threads.UseVisualStyleBackColor = true;
            this.btnExercise2threads.Click += new System.EventHandler(this.btnExercise2_Click);
            // 
            // lblTargil2outputThreads
            // 
            this.lblTargil2outputThreads.Location = new System.Drawing.Point(12, 19);
            this.lblTargil2outputThreads.Name = "lblTargil2outputThreads";
            this.lblTargil2outputThreads.Size = new System.Drawing.Size(96, 45);
            this.lblTargil2outputThreads.TabIndex = 4;
            this.lblTargil2outputThreads.Text = "label1";
            // 
            // pnlExercise1
            // 
            this.pnlExercise1.Controls.Add(this.txtGuessedRezult);
            this.pnlExercise1.Controls.Add(this.lblTargil1);
            this.pnlExercise1.Controls.Add(this.btnTargil1);
            this.pnlExercise1.Location = new System.Drawing.Point(12, 12);
            this.pnlExercise1.Name = "pnlExercise1";
            this.pnlExercise1.Size = new System.Drawing.Size(176, 115);
            this.pnlExercise1.TabIndex = 5;
            // 
            // pnlExercise2
            // 
            this.pnlExercise2.Controls.Add(this.lblTargil2outputNoThreads);
            this.pnlExercise2.Controls.Add(this.btnExercise2NoThreads);
            this.pnlExercise2.Controls.Add(this.lblTargil2outputThreads);
            this.pnlExercise2.Controls.Add(this.btnExercise2threads);
            this.pnlExercise2.Location = new System.Drawing.Point(212, 12);
            this.pnlExercise2.Name = "pnlExercise2";
            this.pnlExercise2.Size = new System.Drawing.Size(393, 115);
            this.pnlExercise2.TabIndex = 6;
            // 
            // btnExercise2NoThreads
            // 
            this.btnExercise2NoThreads.Location = new System.Drawing.Point(206, 69);
            this.btnExercise2NoThreads.Name = "btnExercise2NoThreads";
            this.btnExercise2NoThreads.Size = new System.Drawing.Size(161, 23);
            this.btnExercise2NoThreads.TabIndex = 5;
            this.btnExercise2NoThreads.Text = "Measure time without threads";
            this.btnExercise2NoThreads.UseVisualStyleBackColor = true;
            this.btnExercise2NoThreads.Click += new System.EventHandler(this.btnExercise2NoThreads_Click);
            // 
            // lblTargil2outputNoThreads
            // 
            this.lblTargil2outputNoThreads.Location = new System.Drawing.Point(203, 20);
            this.lblTargil2outputNoThreads.Name = "lblTargil2outputNoThreads";
            this.lblTargil2outputNoThreads.Size = new System.Drawing.Size(96, 45);
            this.lblTargil2outputNoThreads.TabIndex = 6;
            this.lblTargil2outputNoThreads.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 143);
            this.Controls.Add(this.pnlExercise2);
            this.Controls.Add(this.pnlExercise1);
            this.Name = "MainForm";
            this.Text = "06_02_20_Homework_BlogLesson_41_Thread";
            this.pnlExercise1.ResumeLayout(false);
            this.pnlExercise1.PerformLayout();
            this.pnlExercise2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTargil1;
        private System.Windows.Forms.Button btnTargil1;
        private System.Windows.Forms.TextBox txtGuessedRezult;
        private System.Windows.Forms.Button btnExercise2threads;
        private System.Windows.Forms.Label lblTargil2outputThreads;
        private System.Windows.Forms.Panel pnlExercise1;
        private System.Windows.Forms.Panel pnlExercise2;
        private System.Windows.Forms.Button btnExercise2NoThreads;
        private System.Windows.Forms.Label lblTargil2outputNoThreads;
    }
}

