namespace chiyamode.Forms
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.passwordInp = new System.Windows.Forms.TextBox();
            this.newHere = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.registerNow = new System.Windows.Forms.Label();
            this.usermaneInp = new System.Windows.Forms.TextBox();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.confirmLbl = new System.Windows.Forms.Label();
            this.confirmInp = new System.Windows.Forms.TextBox();
            this.aminPwdLbl = new System.Windows.Forms.Label();
            this.adminPwdInp = new System.Windows.Forms.TextBox();
            this.addUserLbl = new System.Windows.Forms.Label();
            this.cross = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.cm = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordInp
            // 
            this.passwordInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordInp.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInp.Location = new System.Drawing.Point(123, 319);
            this.passwordInp.Name = "passwordInp";
            this.passwordInp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordInp.Size = new System.Drawing.Size(273, 27);
            this.passwordInp.TabIndex = 6;
            // 
            // newHere
            // 
            this.newHere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newHere.AutoSize = true;
            this.newHere.Font = new System.Drawing.Font("JetBrains Mono", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newHere.Location = new System.Drawing.Point(134, 538);
            this.newHere.Name = "newHere";
            this.newHere.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newHere.Size = new System.Drawing.Size(128, 18);
            this.newHere.TabIndex = 9;
            this.newHere.Text = "Already a user?";
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(118, 237);
            this.username.Name = "username";
            this.username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.username.Size = new System.Drawing.Size(81, 19);
            this.username.TabIndex = 4;
            this.username.Text = "Username";
            // 
            // registerNow
            // 
            this.registerNow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerNow.AutoSize = true;
            this.registerNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerNow.Font = new System.Drawing.Font("JetBrains Mono", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerNow.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.registerNow.Location = new System.Drawing.Point(268, 538);
            this.registerNow.Name = "registerNow";
            this.registerNow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.registerNow.Size = new System.Drawing.Size(112, 18);
            this.registerNow.TabIndex = 10;
            this.registerNow.Text = "Login Instead";
            this.registerNow.Click += new System.EventHandler(this.registerNow_Click);
            // 
            // usermaneInp
            // 
            this.usermaneInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usermaneInp.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usermaneInp.Location = new System.Drawing.Point(122, 259);
            this.usermaneInp.Name = "usermaneInp";
            this.usermaneInp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usermaneInp.Size = new System.Drawing.Size(273, 27);
            this.usermaneInp.TabIndex = 7;
            // 
            // addUserBtn
            // 
            this.addUserBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.addUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUserBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserBtn.Font = new System.Drawing.Font("JetBrains Mono", 11.33333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.addUserBtn.Location = new System.Drawing.Point(122, 491);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addUserBtn.Size = new System.Drawing.Size(273, 35);
            this.addUserBtn.TabIndex = 8;
            this.addUserBtn.Text = "Add User";
            this.addUserBtn.UseVisualStyleBackColor = false;
            // 
            // passwordLbl
            // 
            this.passwordLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(119, 297);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordLbl.Size = new System.Drawing.Size(81, 19);
            this.passwordLbl.TabIndex = 5;
            this.passwordLbl.Text = "Password";
            // 
            // confirmLbl
            // 
            this.confirmLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmLbl.AutoSize = true;
            this.confirmLbl.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmLbl.Location = new System.Drawing.Point(119, 362);
            this.confirmLbl.Name = "confirmLbl";
            this.confirmLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.confirmLbl.Size = new System.Drawing.Size(153, 19);
            this.confirmLbl.TabIndex = 5;
            this.confirmLbl.Text = "Confirm Password";
            // 
            // confirmInp
            // 
            this.confirmInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmInp.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmInp.Location = new System.Drawing.Point(123, 384);
            this.confirmInp.Name = "confirmInp";
            this.confirmInp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.confirmInp.Size = new System.Drawing.Size(273, 27);
            this.confirmInp.TabIndex = 6;
            // 
            // aminPwdLbl
            // 
            this.aminPwdLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aminPwdLbl.AutoSize = true;
            this.aminPwdLbl.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aminPwdLbl.Location = new System.Drawing.Point(119, 426);
            this.aminPwdLbl.Name = "aminPwdLbl";
            this.aminPwdLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aminPwdLbl.Size = new System.Drawing.Size(225, 19);
            this.aminPwdLbl.TabIndex = 5;
            this.aminPwdLbl.Text = "Verify you\'re the admin.";
            // 
            // adminPwdInp
            // 
            this.adminPwdInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adminPwdInp.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPwdInp.Location = new System.Drawing.Point(123, 448);
            this.adminPwdInp.Name = "adminPwdInp";
            this.adminPwdInp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adminPwdInp.Size = new System.Drawing.Size(273, 27);
            this.adminPwdInp.TabIndex = 6;
            // 
            // addUserLbl
            // 
            this.addUserLbl.AutoSize = true;
            this.addUserLbl.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserLbl.Location = new System.Drawing.Point(117, 188);
            this.addUserLbl.Name = "addUserLbl";
            this.addUserLbl.Size = new System.Drawing.Size(224, 31);
            this.addUserLbl.TabIndex = 11;
            this.addUserLbl.Text = "Add a new user.";
            // 
            // cross
            // 
            this.cross.AutoSize = true;
            this.cross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cross.Font = new System.Drawing.Font("OCR A Extended", 16F);
            this.cross.ForeColor = System.Drawing.SystemColors.Info;
            this.cross.Location = new System.Drawing.Point(1341, 2);
            this.cross.Name = "cross";
            this.cross.Size = new System.Drawing.Size(26, 25);
            this.cross.TabIndex = 0;
            this.cross.Text = "x";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(108)))), ((int)(((byte)(37)))));
            this.header.Controls.Add(this.cm);
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.closeBtn);
            this.header.Controls.Add(this.cross);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(502, 33);
            this.header.TabIndex = 12;
            // 
            // cm
            // 
            this.cm.AutoSize = true;
            this.cm.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 11.33333F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cm.Location = new System.Drawing.Point(33, 5);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(210, 22);
            this.cm.TabIndex = 4;
            this.cm.Text = "Add User - Chiyamode";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("OCR A Extended", 16F);
            this.closeBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.closeBtn.Location = new System.Drawing.Point(473, 1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(26, 25);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "x";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(502, 773);
            this.Controls.Add(this.header);
            this.Controls.Add(this.addUserLbl);
            this.Controls.Add(this.adminPwdInp);
            this.Controls.Add(this.confirmInp);
            this.Controls.Add(this.passwordInp);
            this.Controls.Add(this.newHere);
            this.Controls.Add(this.username);
            this.Controls.Add(this.registerNow);
            this.Controls.Add(this.usermaneInp);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.aminPwdLbl);
            this.Controls.Add(this.confirmLbl);
            this.Controls.Add(this.passwordLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox passwordInp;
        private System.Windows.Forms.Label newHere;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label registerNow;
        private System.Windows.Forms.TextBox usermaneInp;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label confirmLbl;
        private System.Windows.Forms.TextBox confirmInp;
        private System.Windows.Forms.Label aminPwdLbl;
        private System.Windows.Forms.TextBox adminPwdInp;
        private System.Windows.Forms.Label addUserLbl;
        private System.Windows.Forms.Label cross;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Label cm;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}