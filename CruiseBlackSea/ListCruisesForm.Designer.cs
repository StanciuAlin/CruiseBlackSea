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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStripListCruises = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.dgvListCruises = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCruiseType = new System.Windows.Forms.Label();
            this.cbxSelectCruisePeriod = new System.Windows.Forms.ComboBox();
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
            this.statusStripListCruises.Location = new System.Drawing.Point(0, 518);
            this.statusStripListCruises.Name = "statusStripListCruises";
            this.statusStripListCruises.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStripListCruises.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStripListCruises.Size = new System.Drawing.Size(632, 22);
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
            this.dgvListCruises.AllowUserToAddRows = false;
            this.dgvListCruises.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListCruises.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListCruises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListCruises.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListCruises.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListCruises.GridColor = System.Drawing.SystemColors.Desktop;
            this.dgvListCruises.Location = new System.Drawing.Point(15, 110);
            this.dgvListCruises.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListCruises.Name = "dgvListCruises";
            this.dgvListCruises.ReadOnly = true;
            this.dgvListCruises.RowHeadersVisible = false;
            this.dgvListCruises.RowTemplate.Height = 24;
            this.dgvListCruises.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListCruises.Size = new System.Drawing.Size(603, 335);
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
            this.btnClose.Location = new System.Drawing.Point(450, 460);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(168, 42);
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
            this.lblTitle.Location = new System.Drawing.Point(143, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.lblCruiseType.Location = new System.Drawing.Point(106, 64);
            this.lblCruiseType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCruiseType.Name = "lblCruiseType";
            this.lblCruiseType.Size = new System.Drawing.Size(199, 20);
            this.lblCruiseType.TabIndex = 34;
            this.lblCruiseType.Text = "Select cruise period";
            // 
            // cbxSelectCruisePeriod
            // 
            this.cbxSelectCruisePeriod.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbxSelectCruisePeriod.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectCruisePeriod.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbxSelectCruisePeriod.FormattingEnabled = true;
            this.cbxSelectCruisePeriod.Items.AddRange(new object[] {
            "3 days",
            "5 days",
            "8 days"});
            this.cbxSelectCruisePeriod.Location = new System.Drawing.Point(331, 61);
            this.cbxSelectCruisePeriod.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSelectCruisePeriod.Name = "cbxSelectCruisePeriod";
            this.cbxSelectCruisePeriod.Size = new System.Drawing.Size(150, 28);
            this.cbxSelectCruisePeriod.TabIndex = 35;
            this.cbxSelectCruisePeriod.SelectionChangeCommitted += new System.EventHandler(this.cbxSelectCruisePeriod_SelectionChangeCommitted);
            // 
            // ListCruisesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(632, 540);
            this.Controls.Add(this.cbxSelectCruisePeriod);
            this.Controls.Add(this.lblCruiseType);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvListCruises);
            this.Controls.Add(this.statusStripListCruises);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ComboBox cbxSelectCruisePeriod;
    }
}