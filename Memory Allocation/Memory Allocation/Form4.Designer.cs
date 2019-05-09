namespace Memory_Allocation
{
    partial class Form4
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
            this.label3 = new System.Windows.Forms.Label();
            this.back_form3 = new System.Windows.Forms.Button();
            this.btn_to_form5 = new System.Windows.Forms.Button();
            this.txt_memory_size = new System.Windows.Forms.TextBox();
            this.txt_number_of_holes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Memory Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. of Holes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Memory";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // back_form3
            // 
            this.back_form3.Location = new System.Drawing.Point(13, 21);
            this.back_form3.Name = "back_form3";
            this.back_form3.Size = new System.Drawing.Size(43, 23);
            this.back_form3.TabIndex = 9;
            this.back_form3.Text = "<<";
            this.back_form3.UseVisualStyleBackColor = true;
            this.back_form3.Click += new System.EventHandler(this.back_form3_Click);
            // 
            // btn_to_form5
            // 
            this.btn_to_form5.Location = new System.Drawing.Point(229, 23);
            this.btn_to_form5.Name = "btn_to_form5";
            this.btn_to_form5.Size = new System.Drawing.Size(43, 23);
            this.btn_to_form5.TabIndex = 8;
            this.btn_to_form5.Text = ">>";
            this.btn_to_form5.UseVisualStyleBackColor = true;
            this.btn_to_form5.Click += new System.EventHandler(this.btn_to_form5_Click);
            // 
            // txt_memory_size
            // 
            this.txt_memory_size.Location = new System.Drawing.Point(119, 70);
            this.txt_memory_size.Name = "txt_memory_size";
            this.txt_memory_size.Size = new System.Drawing.Size(65, 20);
            this.txt_memory_size.TabIndex = 10;
            // 
            // txt_number_of_holes
            // 
            this.txt_number_of_holes.Location = new System.Drawing.Point(119, 96);
            this.txt_number_of_holes.Name = "txt_number_of_holes";
            this.txt_number_of_holes.Size = new System.Drawing.Size(65, 20);
            this.txt_number_of_holes.TabIndex = 11;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 135);
            this.Controls.Add(this.txt_number_of_holes);
            this.Controls.Add(this.txt_memory_size);
            this.Controls.Add(this.back_form3);
            this.Controls.Add(this.btn_to_form5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Memory Allocation";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button back_form3;
        private System.Windows.Forms.Button btn_to_form5;
        private System.Windows.Forms.TextBox txt_memory_size;
        private System.Windows.Forms.TextBox txt_number_of_holes;
    }
}