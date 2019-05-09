namespace Memory_Allocation
{
    partial class Form2
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
            this.panel_of_processes = new System.Windows.Forms.Panel();
            this.btn_to_form3 = new System.Windows.Forms.Button();
            this.back_form1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Processes";
            // 
            // txt_number_of_processes
            // 
            this.txt_number_of_processes.Location = new System.Drawing.Point(175, 22);
            this.txt_number_of_processes.Name = "txt_number_of_processes";
            this.txt_number_of_processes.Size = new System.Drawing.Size(47, 20);
            this.txt_number_of_processes.TabIndex = 1;
            // 
            // panel_of_processes
            // 
            this.panel_of_processes.AutoScroll = true;
            this.panel_of_processes.Location = new System.Drawing.Point(12, 46);
            this.panel_of_processes.Name = "panel_of_processes";
            this.panel_of_processes.Size = new System.Drawing.Size(256, 297);
            this.panel_of_processes.TabIndex = 2;
            // 
            // btn_to_form3
            // 
            this.btn_to_form3.Location = new System.Drawing.Point(228, 20);
            this.btn_to_form3.Name = "btn_to_form3";
            this.btn_to_form3.Size = new System.Drawing.Size(43, 23);
            this.btn_to_form3.TabIndex = 3;
            this.btn_to_form3.Text = ">>";
            this.btn_to_form3.UseVisualStyleBackColor = true;
            this.btn_to_form3.Click += new System.EventHandler(this.btn_to_form3_Click);
            // 
            // back_form1
            // 
            this.back_form1.Location = new System.Drawing.Point(12, 18);
            this.back_form1.Name = "back_form1";
            this.back_form1.Size = new System.Drawing.Size(43, 23);
            this.back_form1.TabIndex = 5;
            this.back_form1.Text = "<<";
            this.back_form1.UseVisualStyleBackColor = true;
            this.back_form1.Click += new System.EventHandler(this.back_form1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 341);
            this.Controls.Add(this.back_form1);
            this.Controls.Add(this.btn_to_form3);
            this.Controls.Add(this.panel_of_processes);
            this.Controls.Add(this.txt_number_of_processes);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Memory Allocation";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_number_of_processes;
        private System.Windows.Forms.Panel panel_of_processes;
        private System.Windows.Forms.Button btn_to_form3;
        private System.Windows.Forms.Button back_form1;

    }
}