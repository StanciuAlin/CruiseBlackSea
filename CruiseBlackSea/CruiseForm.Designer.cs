namespace CruiseBlackSea
{
    partial class CruiseForm
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
            this.components = new System.ComponentModel.Container();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.statusStripListCruises = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFinalCruise = new System.Windows.Forms.Label();
            this.statusStripListCruises.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1000;
            // 
            // statusStripListCruises
            // 
            this.statusStripListCruises.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStripListCruises.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripListCruises.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLblDateTime});
            this.statusStripListCruises.Location = new System.Drawing.Point(0, 616);
            this.statusStripListCruises.Name = "statusStripListCruises";
            this.statusStripListCruises.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStripListCruises.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStripListCruises.Size = new System.Drawing.Size(1055, 22);
            this.statusStripListCruises.TabIndex = 31;
            this.statusStripListCruises.Text = "statusStripUpdateDistanceForm";
            // 
            // toolStripStatusLblDateTime
            // 
            this.toolStripStatusLblDateTime.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLblDateTime.ForeColor = System.Drawing.Color.DodgerBlue;
            this.toolStripStatusLblDateTime.Name = "toolStripStatusLblDateTime";
            this.toolStripStatusLblDateTime.Size = new System.Drawing.Size(0, 17);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CruiseBlackSea.Properties.Resources.Black_Sea;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1055, 616);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // lblFinalCruise
            // 
            this.lblFinalCruise.AutoSize = true;
            this.lblFinalCruise.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalCruise.Font = new System.Drawing.Font("Swis721 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalCruise.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblFinalCruise.Location = new System.Drawing.Point(881, 50);
            this.lblFinalCruise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalCruise.Name = "lblFinalCruise";
            this.lblFinalCruise.Size = new System.Drawing.Size(0, 24);
            this.lblFinalCruise.TabIndex = 33;
            // 
            // CruiseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1055, 638);
            this.Controls.Add(this.lblFinalCruise);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStripListCruises);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CruiseForm";
            this.Text = "Booked Cruise";
            this.statusStripListCruises.ResumeLayout(false);
            this.statusStripListCruises.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.StatusStrip statusStripListCruises;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblDateTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFinalCruise;
    }
}