namespace Timaverkefni8
{
    partial class nyskra
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
            this.btnafnnyskra = new System.Windows.Forms.TextBox();
            this.tbktnyskra = new System.Windows.Forms.TextBox();
            this.tbsimanumernyskra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btskra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnafnnyskra
            // 
            this.btnafnnyskra.Location = new System.Drawing.Point(169, 142);
            this.btnafnnyskra.Name = "btnafnnyskra";
            this.btnafnnyskra.Size = new System.Drawing.Size(100, 20);
            this.btnafnnyskra.TabIndex = 0;
            // 
            // tbktnyskra
            // 
            this.tbktnyskra.Location = new System.Drawing.Point(169, 92);
            this.tbktnyskra.Name = "tbktnyskra";
            this.tbktnyskra.Size = new System.Drawing.Size(100, 20);
            this.tbktnyskra.TabIndex = 1;
            // 
            // tbsimanumernyskra
            // 
            this.tbsimanumernyskra.Location = new System.Drawing.Point(169, 194);
            this.tbsimanumernyskra.Name = "tbsimanumernyskra";
            this.tbsimanumernyskra.Size = new System.Drawing.Size(100, 20);
            this.tbsimanumernyskra.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Simanumer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nafn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kennitala";
            // 
            // btskra
            // 
            this.btskra.Location = new System.Drawing.Point(169, 245);
            this.btskra.Name = "btskra";
            this.btskra.Size = new System.Drawing.Size(100, 29);
            this.btskra.TabIndex = 6;
            this.btskra.Text = "Skrá";
            this.btskra.UseVisualStyleBackColor = true;
            this.btskra.Click += new System.EventHandler(this.btskra_Click);
            // 
            // nyskra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 351);
            this.Controls.Add(this.btskra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbsimanumernyskra);
            this.Controls.Add(this.tbktnyskra);
            this.Controls.Add(this.btnafnnyskra);
            this.Name = "nyskra";
            this.Text = "nyskra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox btnafnnyskra;
        private System.Windows.Forms.TextBox tbktnyskra;
        private System.Windows.Forms.TextBox tbsimanumernyskra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btskra;
    }
}