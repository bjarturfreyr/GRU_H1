namespace GRU_H1_Backend
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_1password = new System.Windows.Forms.TextBox();
            this.txt_1username = new System.Windows.Forms.TextBox();
            this.bt_1login = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_1password);
            this.groupBox1.Controls.Add(this.txt_1username);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // txt_1password
            // 
            this.txt_1password.Location = new System.Drawing.Point(73, 45);
            this.txt_1password.Name = "txt_1password";
            this.txt_1password.Size = new System.Drawing.Size(100, 20);
            this.txt_1password.TabIndex = 1;
            this.txt_1password.UseSystemPasswordChar = true;
            // 
            // txt_1username
            // 
            this.txt_1username.Location = new System.Drawing.Point(73, 19);
            this.txt_1username.Name = "txt_1username";
            this.txt_1username.Size = new System.Drawing.Size(100, 20);
            this.txt_1username.TabIndex = 0;
            // 
            // bt_1login
            // 
            this.bt_1login.Location = new System.Drawing.Point(124, 92);
            this.bt_1login.Name = "bt_1login";
            this.bt_1login.Size = new System.Drawing.Size(75, 23);
            this.bt_1login.TabIndex = 0;
            this.bt_1login.Text = "Log In";
            this.bt_1login.UseVisualStyleBackColor = true;
            this.bt_1login.Click += new System.EventHandler(this.bt_1login_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(24, 97);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Help";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 124);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.bt_1login);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "GRU Backend";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_1password;
        private System.Windows.Forms.TextBox txt_1username;
        private System.Windows.Forms.Button bt_1login;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

