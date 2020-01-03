namespace CruiseBlackSea
{
    partial class UpdateDistanceForm
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
            this.btnSaveDistance = new System.Windows.Forms.Button();
            this.lblTitleUpdateDistanceForm = new System.Windows.Forms.Label();
            this.lblStartHarbour = new System.Windows.Forms.Label();
            this.lblEndHarbour = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.statusStripUpdateDistance = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.cbxStartHarbourUpdateDistanceForm = new System.Windows.Forms.ComboBox();
            this.cbxEndHarbourUpdateDistanceForm = new System.Windows.Forms.ComboBox();
            this.tbxDistanceBetweenHarboursUpdateDistanceForm = new System.Windows.Forms.TextBox();
            this.statusStripUpdateDistance.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveDistance
            // 
            this.btnSaveDistance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveDistance.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnSaveDistance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSaveDistance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnSaveDistance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDistance.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDistance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveDistance.Location = new System.Drawing.Point(148, 214);
            this.btnSaveDistance.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSaveDistance.Name = "btnSaveDistance";
            this.btnSaveDistance.Size = new System.Drawing.Size(160, 42);
            this.btnSaveDistance.TabIndex = 21;
            this.btnSaveDistance.Text = "Save";
            this.btnSaveDistance.UseVisualStyleBackColor = false;
            this.btnSaveDistance.Click += new System.EventHandler(this.btnSaveDistance_Click);
            // 
            // lblTitleUpdateDistanceForm
            // 
            this.lblTitleUpdateDistanceForm.AutoSize = true;
            this.lblTitleUpdateDistanceForm.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleUpdateDistanceForm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitleUpdateDistanceForm.Location = new System.Drawing.Point(82, 18);
            this.lblTitleUpdateDistanceForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleUpdateDistanceForm.Name = "lblTitleUpdateDistanceForm";
            this.lblTitleUpdateDistanceForm.Size = new System.Drawing.Size(356, 24);
            this.lblTitleUpdateDistanceForm.TabIndex = 22;
            this.lblTitleUpdateDistanceForm.Text = "Update distance between X and Y";
            // 
            // lblStartHarbour
            // 
            this.lblStartHarbour.AutoSize = true;
            this.lblStartHarbour.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblStartHarbour.Location = new System.Drawing.Point(69, 78);
            this.lblStartHarbour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartHarbour.Name = "lblStartHarbour";
            this.lblStartHarbour.Size = new System.Drawing.Size(171, 24);
            this.lblStartHarbour.TabIndex = 23;
            this.lblStartHarbour.Text = "Start harbour";
            // 
            // lblEndHarbour
            // 
            this.lblEndHarbour.AutoSize = true;
            this.lblEndHarbour.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEndHarbour.Location = new System.Drawing.Point(69, 119);
            this.lblEndHarbour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndHarbour.Name = "lblEndHarbour";
            this.lblEndHarbour.Size = new System.Drawing.Size(148, 24);
            this.lblEndHarbour.TabIndex = 24;
            this.lblEndHarbour.Text = "End harbour";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDistance.Location = new System.Drawing.Point(69, 160);
            this.lblDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(103, 24);
            this.lblDistance.TabIndex = 25;
            this.lblDistance.Text = "Distance";
            // 
            // statusStripUpdateDistance
            // 
            this.statusStripUpdateDistance.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStripUpdateDistance.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripUpdateDistance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLblDateTime});
            this.statusStripUpdateDistance.Location = new System.Drawing.Point(0, 272);
            this.statusStripUpdateDistance.Name = "statusStripUpdateDistance";
            this.statusStripUpdateDistance.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.statusStripUpdateDistance.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStripUpdateDistance.Size = new System.Drawing.Size(486, 22);
            this.statusStripUpdateDistance.TabIndex = 29;
            this.statusStripUpdateDistance.Text = "statusStripUpdateDistanceForm";
            // 
            // toolStripStatusLblDateTime
            // 
            this.toolStripStatusLblDateTime.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLblDateTime.ForeColor = System.Drawing.Color.DodgerBlue;
            this.toolStripStatusLblDateTime.Name = "toolStripStatusLblDateTime";
            this.toolStripStatusLblDateTime.Size = new System.Drawing.Size(0, 17);
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // cbxStartHarbourUpdateDistanceForm
            // 
            this.cbxStartHarbourUpdateDistanceForm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbxStartHarbourUpdateDistanceForm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbxStartHarbourUpdateDistanceForm.FormattingEnabled = true;
            this.cbxStartHarbourUpdateDistanceForm.Items.AddRange(new object[] {
            "1 - Constanta",
            "2 - Varna",
            "3 - Burgas",
            "4 - Istanbul",
            "5 - Kozlu",
            "6 - Samsun",
            "7 - Batumi",
            "8 - Sokhumi",
            "9 - Sochi",
            "10 - Anapa",
            "11 - Ialta",
            "12 - Sevastopol",
            "13 - Odessa"});
            this.cbxStartHarbourUpdateDistanceForm.Location = new System.Drawing.Point(236, 74);
            this.cbxStartHarbourUpdateDistanceForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxStartHarbourUpdateDistanceForm.Name = "cbxStartHarbourUpdateDistanceForm";
            this.cbxStartHarbourUpdateDistanceForm.Size = new System.Drawing.Size(174, 32);
            this.cbxStartHarbourUpdateDistanceForm.TabIndex = 30;
            // 
            // cbxEndHarbourUpdateDistanceForm
            // 
            this.cbxEndHarbourUpdateDistanceForm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbxEndHarbourUpdateDistanceForm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbxEndHarbourUpdateDistanceForm.FormattingEnabled = true;
            this.cbxEndHarbourUpdateDistanceForm.Items.AddRange(new object[] {
            "1 - Constanta",
            "2 - Varna",
            "3 - Burgas",
            "4 - Istanbul",
            "5 - Kozlu",
            "6 - Samsun",
            "7 - Batumi",
            "8 - Sokhumi",
            "9 - Sochi",
            "10 - Anapa",
            "11 - Ialta",
            "12 - Sevastopol",
            "13 - Odessa"});
            this.cbxEndHarbourUpdateDistanceForm.Location = new System.Drawing.Point(236, 115);
            this.cbxEndHarbourUpdateDistanceForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxEndHarbourUpdateDistanceForm.Name = "cbxEndHarbourUpdateDistanceForm";
            this.cbxEndHarbourUpdateDistanceForm.Size = new System.Drawing.Size(174, 32);
            this.cbxEndHarbourUpdateDistanceForm.TabIndex = 31;
            // 
            // tbxDistanceBetweenHarboursUpdateDistanceForm
            // 
            this.tbxDistanceBetweenHarboursUpdateDistanceForm.Font = new System.Drawing.Font("Swis721 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDistanceBetweenHarboursUpdateDistanceForm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbxDistanceBetweenHarboursUpdateDistanceForm.Location = new System.Drawing.Point(236, 156);
            this.tbxDistanceBetweenHarboursUpdateDistanceForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxDistanceBetweenHarboursUpdateDistanceForm.Name = "tbxDistanceBetweenHarboursUpdateDistanceForm";
            this.tbxDistanceBetweenHarboursUpdateDistanceForm.Size = new System.Drawing.Size(174, 31);
            this.tbxDistanceBetweenHarboursUpdateDistanceForm.TabIndex = 32;
            // 
            // UpdateDistanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(486, 294);
            this.Controls.Add(this.tbxDistanceBetweenHarboursUpdateDistanceForm);
            this.Controls.Add(this.cbxEndHarbourUpdateDistanceForm);
            this.Controls.Add(this.cbxStartHarbourUpdateDistanceForm);
            this.Controls.Add(this.statusStripUpdateDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblEndHarbour);
            this.Controls.Add(this.lblStartHarbour);
            this.Controls.Add(this.lblTitleUpdateDistanceForm);
            this.Controls.Add(this.btnSaveDistance);
            this.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximumSize = new System.Drawing.Size(504, 341);
            this.MinimumSize = new System.Drawing.Size(504, 341);
            this.Name = "UpdateDistanceForm";
            this.Text = "Update distance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateDistanceForm_FormClosing);
            this.statusStripUpdateDistance.ResumeLayout(false);
            this.statusStripUpdateDistance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveDistance;
        private System.Windows.Forms.Label lblTitleUpdateDistanceForm;
        private System.Windows.Forms.Label lblStartHarbour;
        private System.Windows.Forms.Label lblEndHarbour;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.StatusStrip statusStripUpdateDistance;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblDateTime;
        public System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.ComboBox cbxStartHarbourUpdateDistanceForm;
        private System.Windows.Forms.ComboBox cbxEndHarbourUpdateDistanceForm;
        private System.Windows.Forms.TextBox tbxDistanceBetweenHarboursUpdateDistanceForm;
    }
}