namespace StockManagementSystem
{
    partial class userUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userUC));
            this.txtUserid = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.oldPasswordTB = new System.Windows.Forms.TextBox();
            this.newPasswordTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newPasswordTB2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chgPasswordBTN = new System.Windows.Forms.Button();
            this.txtUserType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserid
            // 
            this.txtUserid.AutoSize = true;
            this.txtUserid.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtUserid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUserid.Location = new System.Drawing.Point(11, 274);
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.Size = new System.Drawing.Size(24, 22);
            this.txtUserid.TabIndex = 0;
            this.txtUserid.Text = "id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Font = new System.Drawing.Font("Open Sans Semibold", 36F, System.Drawing.FontStyle.Bold);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsername.Location = new System.Drawing.Point(289, 15);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(8);
            this.txtUsername.Size = new System.Drawing.Size(507, 81);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "Username : ######";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Open Sans Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmail.Location = new System.Drawing.Point(292, 84);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(8);
            this.txtEmail.Size = new System.Drawing.Size(272, 59);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "Email : ######";
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Font = new System.Drawing.Font("Open Sans Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.Location = new System.Drawing.Point(292, 143);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(8);
            this.txtPassword.Size = new System.Drawing.Size(337, 59);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Password : ######";
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Open Sans Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChange.Location = new System.Drawing.Point(625, 151);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(171, 51);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.chgPasswordBTN);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.newPasswordTB2);
            this.panel1.Controls.Add(this.newPasswordTB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.oldPasswordTB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1100, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 243);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.label3.Size = new System.Drawing.Size(124, 46);
            this.label3.TabIndex = 1;
            this.label3.Text = "Old Password :";
            // 
            // oldPasswordTB
            // 
            this.oldPasswordTB.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oldPasswordTB.Location = new System.Drawing.Point(128, 12);
            this.oldPasswordTB.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.oldPasswordTB.Name = "oldPasswordTB";
            this.oldPasswordTB.Size = new System.Drawing.Size(218, 29);
            this.oldPasswordTB.TabIndex = 2;
            // 
            // newPasswordTB
            // 
            this.newPasswordTB.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newPasswordTB.Location = new System.Drawing.Point(128, 82);
            this.newPasswordTB.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.newPasswordTB.Name = "newPasswordTB";
            this.newPasswordTB.Size = new System.Drawing.Size(218, 29);
            this.newPasswordTB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(5, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.label4.Size = new System.Drawing.Size(122, 44);
            this.label4.TabIndex = 3;
            this.label4.Text = "New Password :";
            // 
            // newPasswordTB2
            // 
            this.newPasswordTB2.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newPasswordTB2.Location = new System.Drawing.Point(128, 154);
            this.newPasswordTB2.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.newPasswordTB2.Name = "newPasswordTB2";
            this.newPasswordTB2.Size = new System.Drawing.Size(218, 29);
            this.newPasswordTB2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(5, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.label5.Size = new System.Drawing.Size(122, 44);
            this.label5.TabIndex = 7;
            this.label5.Text = "New Password :";
            // 
            // chgPasswordBTN
            // 
            this.chgPasswordBTN.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chgPasswordBTN.Location = new System.Drawing.Point(7, 193);
            this.chgPasswordBTN.Name = "chgPasswordBTN";
            this.chgPasswordBTN.Size = new System.Drawing.Size(339, 33);
            this.chgPasswordBTN.TabIndex = 8;
            this.chgPasswordBTN.Text = "Change Password";
            this.chgPasswordBTN.UseVisualStyleBackColor = true;
            this.chgPasswordBTN.Click += new System.EventHandler(this.chgPasswordBTN_Click);
            // 
            // txtUserType
            // 
            this.txtUserType.AutoSize = true;
            this.txtUserType.Font = new System.Drawing.Font("Open Sans Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.txtUserType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUserType.Location = new System.Drawing.Point(292, 202);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Padding = new System.Windows.Forms.Padding(8);
            this.txtUserType.Size = new System.Drawing.Size(297, 59);
            this.txtUserType.TabIndex = 7;
            this.txtUserType.Text = "User Type : ####";
            // 
            // userUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.txtUserType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUserid);
            this.Name = "userUC";
            this.Size = new System.Drawing.Size(1468, 666);
            this.Load += new System.EventHandler(this.userUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label txtUserid;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label txtUsername;
        public System.Windows.Forms.Label txtEmail;
        public System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button chgPasswordBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newPasswordTB2;
        private System.Windows.Forms.TextBox newPasswordTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox oldPasswordTB;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label txtUserType;
    }
}
