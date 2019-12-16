namespace CruiseBlackSea
{
    partial class CurrentUserForm
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
            this.lblWelcomeCurrentUserForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcomeCurrentUserForm
            // 
            this.lblWelcomeCurrentUserForm.AutoSize = true;
            this.lblWelcomeCurrentUserForm.Location = new System.Drawing.Point(164, 114);
            this.lblWelcomeCurrentUserForm.Name = "lblWelcomeCurrentUserForm";
            this.lblWelcomeCurrentUserForm.Size = new System.Drawing.Size(0, 13);
            this.lblWelcomeCurrentUserForm.TabIndex = 0;
            // 
            // CurrentUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWelcomeCurrentUserForm);
            this.Name = "CurrentUserForm";
            this.Text = "CurrentUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeCurrentUserForm;
    }
}