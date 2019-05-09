namespace Memory_Allocation
{
    partial class Form5
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
            this.back_form3 = new System.Windows.Forms.Button();
            this.btn_to_form5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // back_form3
            // 
            this.back_form3.Location = new System.Drawing.Point(12, 35);
            this.back_form3.Name = "back_form3";
            this.back_form3.Size = new System.Drawing.Size(43, 23);
            this.back_form3.TabIndex = 12;
            this.back_form3.Text = "<<";
            this.back_form3.UseVisualStyleBackColor = true;
            this.back_form3.Click += new System.EventHandler(this.back_form3_Click);
            // 
            // btn_to_form5
            // 
            this.btn_to_form5.Location = new System.Drawing.Point(228, 37);
            this.btn_to_form5.Name = "btn_to_form5";
            this.btn_to_form5.Size = new System.Drawing.Size(43, 23);
            this.btn_to_form5.TabIndex = 11;
            this.btn_to_form5.Text = ">>";
            this.btn_to_form5.UseVisualStyleBackColor = true;
            this.btn_to_form5.Click += new System.EventHandler(this.btn_to_form5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Memory Holes";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(24, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 112);
            this.panel1.TabIndex = 13;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 194);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back_form3);
            this.Controls.Add(this.btn_to_form5);
            this.Controls.Add(this.label3);
            this.Name = "Form5";
            this.Text = "Memory Allocation";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_form3;
        private System.Windows.Forms.Button btn_to_form5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}