namespace CruiseBlackSea
{
    partial class ListCruisesForm
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
            this.statusStripListCruises = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.dgvListCruises = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCruiseType = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusStripListCruises.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCruises)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStripListCruises
            // 
            this.statusStripListCruises.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStripListCruises.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripListCruises.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLblDateTime});
            this.statusStripListCruises.Location = new System.Drawing.Point(0, 421);
            this.statusStripListCruises.Name = "statusStripListCruises";
            this.statusStripListCruises.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStripListCruises.Size = new System.Drawing.Size(906, 22);
            this.statusStripListCruises.TabIndex = 30;
            this.statusStripListCruises.Text = "statusStripUpdateDistanceForm";
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
            // 
            // dgvListCruises
            // 
            this.dgvListCruises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCruises.Location = new System.Drawing.Point(12, 82);
            this.dgvListCruises.Name = "dgvListCruises";
            this.dgvListCruises.RowTemplate.Height = 24;
            this.dgvListCruises.Size = new System.Drawing.Size(882, 268);
            this.dgvListCruises.TabIndex = 31;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.Location = new System.Drawing.Point(760, 366);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 34);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Location = new System.Drawing.Point(325, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(357, 29);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "List all cruises disponible";
            // 
            // lblCruiseType
            // 
            this.lblCruiseType.AutoSize = true;
            this.lblCruiseType.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCruiseType.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCruiseType.Location = new System.Drawing.Point(12, 50);
            this.lblCruiseType.Name = "lblCruiseType";
            this.lblCruiseType.Size = new System.Drawing.Size(199, 20);
            this.lblCruiseType.TabIndex = 34;
            this.lblCruiseType.Text = "Select cruise period";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBox1.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "3 days",
            "5 days",
            "8 days"});
            this.comboBox1.Location = new System.Drawing.Point(255, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 35;
            // 
            // ListCruisesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(906, 443);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCruiseType);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvListCruises);
            this.Controls.Add(this.statusStripListCruises);
            this.Name = "ListCruisesForm";
            this.Text = "List Cruises";
            this.statusStripListCruises.ResumeLayout(false);
            this.statusStripListCruises.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCruises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripListCruises;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblDateTime;
        public System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.DataGridView dgvListCruises;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCruiseType;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}