namespace Timaverkefni8
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
            this.btkennitala = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btskrainn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btkennitala
            // 
            this.btkennitala.Location = new System.Drawing.Point(191, 110);
            this.btkennitala.Name = "btkennitala";
            this.btkennitala.Size = new System.Drawing.Size(100, 20);
            this.btkennitala.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kennitala";
            // 
            // btskrainn
            // 
            this.btskrainn.Location = new System.Drawing.Point(320, 108);
            this.btskrainn.Name = "btskrainn";
            this.btskrainn.Size = new System.Drawing.Size(75, 23);
            this.btskrainn.TabIndex = 2;
            this.btskrainn.Text = "Skrá inn";
            this.btskrainn.UseVisualStyleBackColor = true;
            this.btskrainn.Click += new System.EventHandler(this.btskrainn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 340);
            this.Controls.Add(this.btskrainn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btkennitala);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox btkennitala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btskrainn;
    }
}