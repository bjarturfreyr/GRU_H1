namespace GRU_H1_Backend
{
    partial class Mainframe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainframe));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.userisadmin = new System.Windows.Forms.CheckBox();
            this.btuserrefresh = new System.Windows.Forms.Button();
            this.txtuserphone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtuseremail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btusermynd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.userpicture = new System.Windows.Forms.PictureBox();
            this.bteydanotanda = new System.Windows.Forms.Button();
            this.btbreytanotanda = new System.Windows.Forms.Button();
            this.btskranotanda = new System.Windows.Forms.Button();
            this.txtuserpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtuserusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btbannotandi = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(628, 393);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btbannotandi);
            this.tabPage2.Controls.Add(this.txtuserid);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.userisadmin);
            this.tabPage2.Controls.Add(this.btuserrefresh);
            this.tabPage2.Controls.Add(this.txtuserphone);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtuseremail);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btusermynd);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.userpicture);
            this.tabPage2.Controls.Add(this.bteydanotanda);
            this.tabPage2.Controls.Add(this.btbreytanotanda);
            this.tabPage2.Controls.Add(this.btskranotanda);
            this.tabPage2.Controls.Add(this.txtuserpassword);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtuserusername);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(620, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Users";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(483, 6);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.ReadOnly = true;
            this.txtuserid.Size = new System.Drawing.Size(128, 20);
            this.txtuserid.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "User ID";
            // 
            // userisadmin
            // 
            this.userisadmin.AutoSize = true;
            this.userisadmin.Location = new System.Drawing.Point(435, 136);
            this.userisadmin.Name = "userisadmin";
            this.userisadmin.Size = new System.Drawing.Size(156, 17);
            this.userisadmin.TabIndex = 6;
            this.userisadmin.Text = "Er þessi notandi kerfisstjóri?";
            this.userisadmin.UseVisualStyleBackColor = true;
            // 
            // btuserrefresh
            // 
            this.btuserrefresh.Location = new System.Drawing.Point(159, 338);
            this.btuserrefresh.Name = "btuserrefresh";
            this.btuserrefresh.Size = new System.Drawing.Size(96, 23);
            this.btuserrefresh.TabIndex = 27;
            this.btuserrefresh.Text = "Refresh";
            this.btuserrefresh.UseVisualStyleBackColor = true;
            this.btuserrefresh.Click += new System.EventHandler(this.btuserrefresh_Click);
            // 
            // txtuserphone
            // 
            this.txtuserphone.Location = new System.Drawing.Point(483, 110);
            this.txtuserphone.Name = "txtuserphone";
            this.txtuserphone.Size = new System.Drawing.Size(128, 20);
            this.txtuserphone.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Netfang";
            // 
            // txtuseremail
            // 
            this.txtuseremail.Location = new System.Drawing.Point(483, 84);
            this.txtuseremail.Name = "txtuseremail";
            this.txtuseremail.Size = new System.Drawing.Size(128, 20);
            this.txtuseremail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Símanúmer";
            // 
            // btusermynd
            // 
            this.btusermynd.Location = new System.Drawing.Point(499, 277);
            this.btusermynd.Name = "btusermynd";
            this.btusermynd.Size = new System.Drawing.Size(75, 23);
            this.btusermynd.TabIndex = 22;
            this.btusermynd.Text = "Browse...";
            this.btusermynd.UseVisualStyleBackColor = true;
            this.btusermynd.Click += new System.EventHandler(this.btusermynd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Insert Picture";
            // 
            // userpicture
            // 
            this.userpicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userpicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("userpicture.InitialImage")));
            this.userpicture.Location = new System.Drawing.Point(464, 172);
            this.userpicture.Name = "userpicture";
            this.userpicture.Size = new System.Drawing.Size(110, 99);
            this.userpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userpicture.TabIndex = 20;
            this.userpicture.TabStop = false;
            // 
            // bteydanotanda
            // 
            this.bteydanotanda.Location = new System.Drawing.Point(515, 309);
            this.bteydanotanda.Name = "bteydanotanda";
            this.bteydanotanda.Size = new System.Drawing.Size(45, 23);
            this.bteydanotanda.TabIndex = 19;
            this.bteydanotanda.Text = "Eyða";
            this.bteydanotanda.UseVisualStyleBackColor = true;
            this.bteydanotanda.Click += new System.EventHandler(this.bteydanotanda_Click);
            // 
            // btbreytanotanda
            // 
            this.btbreytanotanda.Location = new System.Drawing.Point(464, 309);
            this.btbreytanotanda.Name = "btbreytanotanda";
            this.btbreytanotanda.Size = new System.Drawing.Size(45, 23);
            this.btbreytanotanda.TabIndex = 18;
            this.btbreytanotanda.Text = "Breyta";
            this.btbreytanotanda.UseVisualStyleBackColor = true;
            this.btbreytanotanda.Click += new System.EventHandler(this.btbreytanotanda_Click);
            // 
            // btskranotanda
            // 
            this.btskranotanda.Location = new System.Drawing.Point(413, 309);
            this.btskranotanda.Name = "btskranotanda";
            this.btskranotanda.Size = new System.Drawing.Size(45, 23);
            this.btskranotanda.TabIndex = 17;
            this.btskranotanda.Text = "Skrá";
            this.btskranotanda.UseVisualStyleBackColor = true;
            this.btskranotanda.Click += new System.EventHandler(this.btskranotanda_Click);
            // 
            // txtuserpassword
            // 
            this.txtuserpassword.Location = new System.Drawing.Point(483, 58);
            this.txtuserpassword.Name = "txtuserpassword";
            this.txtuserpassword.Size = new System.Drawing.Size(128, 20);
            this.txtuserpassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lykilorð";
            // 
            // txtuserusername
            // 
            this.txtuserusername.Location = new System.Drawing.Point(483, 32);
            this.txtuserusername.Name = "txtuserusername";
            this.txtuserusername.Size = new System.Drawing.Size(128, 20);
            this.txtuserusername.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Notandanafn";
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(398, 326);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(589, 367);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Blogs";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btbannotandi
            // 
            this.btbannotandi.Location = new System.Drawing.Point(566, 309);
            this.btbannotandi.Name = "btbannotandi";
            this.btbannotandi.Size = new System.Drawing.Size(45, 23);
            this.btbannotandi.TabIndex = 30;
            this.btbannotandi.Text = "Ban";
            this.btbannotandi.UseVisualStyleBackColor = true;
            this.btbannotandi.Click += new System.EventHandler(this.btbannotandi_Click);
            // 
            // Mainframe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 417);
            this.Controls.Add(this.tabControl1);
            this.Name = "Mainframe";
            this.Text = "Mainframe";
            this.Load += new System.EventHandler(this.Mainframe_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userpicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btskranotanda;
        private System.Windows.Forms.TextBox txtuserpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtuserusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bteydanotanda;
        private System.Windows.Forms.Button btbreytanotanda;
        private System.Windows.Forms.Button btusermynd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox userpicture;
        private System.Windows.Forms.TextBox txtuserphone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtuseremail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btuserrefresh;
        private System.Windows.Forms.CheckBox userisadmin;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btbannotandi;
    }
}