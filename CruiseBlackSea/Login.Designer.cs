namespace CruiseBlackSea
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pbLoginForm = new System.Windows.Forms.PictureBox();
            this.gbLoginForm = new System.Windows.Forms.GroupBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogInLoginForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginForm)).BeginInit();
            this.gbLoginForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLoginForm
            // 
            this.pbLoginForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbLoginForm.Image = global::CruiseBlackSea.Properties.Resources.loginImage;
            this.pbLoginForm.Location = new System.Drawing.Point(76, 12);
            this.pbLoginForm.Name = "pbLoginForm";
            this.pbLoginForm.Size = new System.Drawing.Size(160, 135);
            this.pbLoginForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoginForm.TabIndex = 0;
            this.pbLoginForm.TabStop = false;
            // 
            // gbLoginForm
            // 
            this.gbLoginForm.Controls.Add(this.tbxPassword);
            this.gbLoginForm.Controls.Add(this.tbxUserName);
            this.gbLoginForm.Controls.Add(this.lblPassword);
            this.gbLoginForm.Controls.Add(this.lblUsername);
            this.gbLoginForm.Controls.Add(this.btnLogInLoginForm);
            this.gbLoginForm.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLoginForm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gbLoginForm.Location = new System.Drawing.Point(12, 116);
            this.gbLoginForm.Name = "gbLoginForm";
            this.gbLoginForm.Size = new System.Drawing.Size(302, 218);
            this.gbLoginForm.TabIndex = 1;
            this.gbLoginForm.TabStop = false;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Stylus BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(165, 100);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(100, 30);
            this.tbxPassword.TabIndex = 4;
            // 
            // tbxUserName
            // 
            this.tbxUserName.Font = new System.Drawing.Font("Stylus BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUserName.Location = new System.Drawing.Point(165, 61);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(100, 30);
            this.tbxUserName.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(36, 103);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 19);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(31, 64);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(96, 19);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "User name";
            // 
            // btnLogInLoginForm
            // 
            this.btnLogInLoginForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogInLoginForm.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogInLoginForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogInLoginForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnLogInLoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogInLoginForm.Location = new System.Drawing.Point(92, 151);
            this.btnLogInLoginForm.Name = "btnLogInLoginForm";
            this.btnLogInLoginForm.Size = new System.Drawing.Size(104, 31);
            this.btnLogInLoginForm.TabIndex = 0;
            this.btnLogInLoginForm.Text = "Log In";
            this.btnLogInLoginForm.UseVisualStyleBackColor = false;
            this.btnLogInLoginForm.Click += new System.EventHandler(this.btnLogInLoginForm_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(323, 344);
            this.Controls.Add(this.pbLoginForm);
            this.Controls.Add(this.gbLoginForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginForm)).EndInit();
            this.gbLoginForm.ResumeLayout(false);
            this.gbLoginForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLoginForm;
        private System.Windows.Forms.GroupBox gbLoginForm;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogInLoginForm;
    }
}