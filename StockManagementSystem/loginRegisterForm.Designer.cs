namespace StockManagementSystem
{
    partial class loginRegisterForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.BTNregister = new System.Windows.Forms.Button();
            this.loginUC1 = new StockManagementSystem.loginUC();
            this.registerUC1 = new StockManagementSystem.registerUC();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(264, 181);
            this.button1.Margin = new System.Windows.Forms.Padding(7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNregister
            // 
            this.BTNregister.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNregister.Location = new System.Drawing.Point(137, 181);
            this.BTNregister.Margin = new System.Windows.Forms.Padding(7);
            this.BTNregister.Name = "BTNregister";
            this.BTNregister.Size = new System.Drawing.Size(113, 34);
            this.BTNregister.TabIndex = 4;
            this.BTNregister.Text = "Register";
            this.BTNregister.UseVisualStyleBackColor = true;
            this.BTNregister.Click += new System.EventHandler(this.BTNregister_Click);
            // 
            // loginUC1
            // 
            this.loginUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginUC1.Location = new System.Drawing.Point(0, 0);
            this.loginUC1.Name = "loginUC1";
            this.loginUC1.Size = new System.Drawing.Size(402, 153);
            this.loginUC1.TabIndex = 1;
            // 
            // registerUC1
            // 
            this.registerUC1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.registerUC1.Location = new System.Drawing.Point(0, 0);
            this.registerUC1.Name = "registerUC1";
            this.registerUC1.Size = new System.Drawing.Size(402, 178);
            this.registerUC1.TabIndex = 2;
            // 
            // loginRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(402, 250);
            this.Controls.Add(this.BTNregister);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loginUC1);
            this.Controls.Add(this.registerUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginRegisterForm";
            this.Load += new System.EventHandler(this.loginRegisterForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTNregister;
        private loginUC loginUC1;
        private registerUC registerUC1;
    }
}