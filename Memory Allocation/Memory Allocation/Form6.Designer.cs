namespace Memory_Allocation
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Button();
            this.lst_process = new System.Windows.Forms.Panel();
            this.lst_memory = new System.Windows.Forms.Panel();
            this.firstfit = new System.Windows.Forms.RadioButton();
            this.bestfit = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.worstfit = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Processes";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(355, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Memory";
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(235, 318);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(75, 23);
            this.home.TabIndex = 4;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // lst_process
            // 
            this.lst_process.AutoScroll = true;
            this.lst_process.BackColor = System.Drawing.Color.White;
            this.lst_process.Location = new System.Drawing.Point(12, 38);
            this.lst_process.Name = "lst_process";
            this.lst_process.Size = new System.Drawing.Size(187, 303);
            this.lst_process.TabIndex = 5;
            // 
            // lst_memory
            // 
            this.lst_memory.AutoScroll = true;
            this.lst_memory.BackColor = System.Drawing.Color.Silver;
            this.lst_memory.Location = new System.Drawing.Point(345, 38);
            this.lst_memory.Name = "lst_memory";
            this.lst_memory.Size = new System.Drawing.Size(190, 303);
            this.lst_memory.TabIndex = 6;
            // 
            // firstfit
            // 
            this.firstfit.AutoSize = true;
            this.firstfit.Location = new System.Drawing.Point(11, 36);
            this.firstfit.Name = "firstfit";
            this.firstfit.Size = new System.Drawing.Size(58, 17);
            this.firstfit.TabIndex = 7;
            this.firstfit.TabStop = true;
            this.firstfit.Text = "First Fit";
            this.firstfit.UseVisualStyleBackColor = true;
            // 
            // bestfit
            // 
            this.bestfit.AutoSize = true;
            this.bestfit.Location = new System.Drawing.Point(11, 59);
            this.bestfit.Name = "bestfit";
            this.bestfit.Size = new System.Drawing.Size(60, 17);
            this.bestfit.TabIndex = 8;
            this.bestfit.TabStop = true;
            this.bestfit.Text = "Best Fit";
            this.bestfit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.worstfit);
            this.groupBox1.Controls.Add(this.bestfit);
            this.groupBox1.Controls.Add(this.firstfit);
            this.groupBox1.Location = new System.Drawing.Point(216, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 124);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithuim";
            // 
            // worstfit
            // 
            this.worstfit.AutoSize = true;
            this.worstfit.Location = new System.Drawing.Point(11, 83);
            this.worstfit.Name = "worstfit";
            this.worstfit.Size = new System.Drawing.Size(67, 17);
            this.worstfit.TabIndex = 9;
            this.worstfit.TabStop = true;
            this.worstfit.Text = "Worst Fit";
            this.worstfit.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 374);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lst_memory);
            this.Controls.Add(this.lst_process);
            this.Controls.Add(this.home);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Memory Allocation";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel lst_process;
        private System.Windows.Forms.Panel lst_memory;
        private System.Windows.Forms.RadioButton firstfit;
        private System.Windows.Forms.RadioButton bestfit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton worstfit;
    }
}