namespace Memory_Allocation
{
    partial class frm_number_of_processes
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
            this.txt_number_of_processes = new System.Windows.Forms.TextBox();
            this.to_form2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Processes";
            // 
            // txt_number_of_processes
            // 
            this.txt_number_of_processes.Location = new System.Drawing.Point(114, 16);
            this.txt_number_of_processes.Name = "txt_number_of_processes";
            this.txt_number_of_processes.Size = new System.Drawing.Size(83, 20);
            this.txt_number_of_processes.TabIndex = 1;
            // 
            // to_form2
            // 
            this.to_form2.Location = new System.Drawing.Point(168, 74);
            this.to_form2.Name = "to_form2";
            this.to_form2.Size = new System.Drawing.Size(75, 23);
            this.to_form2.TabIndex = 2;
            this.to_form2.Text = "Next";
            this.to_form2.UseVisualStyleBackColor = true;
            this.to_form2.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.to_form2);
            this.panel1.Controls.Add(this.txt_number_of_processes);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 126);
            this.panel1.TabIndex = 3;
            // 
            // frm_number_of_processes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 150);
            this.Controls.Add(this.panel1);
            this.Name = "frm_number_of_processes";
            this.Text = "Memory Allocation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_number_of_processes;
        private System.Windows.Forms.Button to_form2;
        private System.Windows.Forms.Panel panel1;
    }
}

