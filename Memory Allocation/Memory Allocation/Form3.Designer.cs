namespace Memory_Allocation
{
    partial class Form3
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
            this.back_form2 = new System.Windows.Forms.Button();
            this.btn_to_form4 = new System.Windows.Forms.Button();
            this.panel_of_processes = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size of Segments";
            // 
            // back_form2
            // 
            this.back_form2.Location = new System.Drawing.Point(13, 17);
            this.back_form2.Name = "back_form2";
            this.back_form2.Size = new System.Drawing.Size(43, 23);
            this.back_form2.TabIndex = 7;
            this.back_form2.Text = "<<";
            this.back_form2.UseVisualStyleBackColor = true;
            this.back_form2.Click += new System.EventHandler(this.back_form2_Click);
            // 
            // btn_to_form4
            // 
            this.btn_to_form4.Location = new System.Drawing.Point(229, 19);
            this.btn_to_form4.Name = "btn_to_form4";
            this.btn_to_form4.Size = new System.Drawing.Size(43, 23);
            this.btn_to_form4.TabIndex = 6;
            this.btn_to_form4.Text = ">>";
            this.btn_to_form4.UseVisualStyleBackColor = true;
            this.btn_to_form4.Click += new System.EventHandler(this.btn_to_form4_Click);
            // 
            // panel_of_processes
            // 
            this.panel_of_processes.AutoScroll = true;
            this.panel_of_processes.Location = new System.Drawing.Point(3, 69);
            this.panel_of_processes.Name = "panel_of_processes";
            this.panel_of_processes.Size = new System.Drawing.Size(269, 343);
            this.panel_of_processes.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 411);
            this.Controls.Add(this.panel_of_processes);
            this.Controls.Add(this.back_form2);
            this.Controls.Add(this.btn_to_form4);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Memory Allocation";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_form2;
        private System.Windows.Forms.Button btn_to_form4;
        private System.Windows.Forms.Panel panel_of_processes;
    }
}