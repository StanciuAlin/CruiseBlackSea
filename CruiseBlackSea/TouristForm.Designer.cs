namespace CruiseBlackSea
{
    partial class TouristForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStripListCruises = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbxSelectCruisePeriod = new System.Windows.Forms.ComboBox();
            this.lblCruiseType = new System.Windows.Forms.Label();
            this.lblStartPeriodTouristForm = new System.Windows.Forms.Label();
            this.lblEndPeriodTouristForm = new System.Windows.Forms.Label();
            this.dTPStartPeriodTourist = new System.Windows.Forms.DateTimePicker();
            this.dTPEndPeriodTourist = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDistanceBetweenHarboursUpdateDistanceForm = new System.Windows.Forms.TextBox();
            this.dgvListCruises = new System.Windows.Forms.DataGridView();
            this.btnBuyTicket = new System.Windows.Forms.Button();
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
            this.statusStripListCruises.Location = new System.Drawing.Point(0, 472);
            this.statusStripListCruises.Name = "statusStripListCruises";
            this.statusStripListCruises.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStripListCruises.Size = new System.Drawing.Size(831, 22);
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
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1000;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Location = new System.Drawing.Point(340, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(112, 29);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Tourist";
            // 
            // cbxSelectCruisePeriod
            // 
            this.cbxSelectCruisePeriod.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbxSelectCruisePeriod.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectCruisePeriod.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cbxSelectCruisePeriod.FormattingEnabled = true;
            this.cbxSelectCruisePeriod.Items.AddRange(new object[] {
            "3 days",
            "5 days",
            "8 days"});
            this.cbxSelectCruisePeriod.Location = new System.Drawing.Point(241, 49);
            this.cbxSelectCruisePeriod.Name = "cbxSelectCruisePeriod";
            this.cbxSelectCruisePeriod.Size = new System.Drawing.Size(121, 28);
            this.cbxSelectCruisePeriod.TabIndex = 37;
            // 
            // lblCruiseType
            // 
            this.lblCruiseType.AutoSize = true;
            this.lblCruiseType.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCruiseType.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCruiseType.Location = new System.Drawing.Point(45, 52);
            this.lblCruiseType.Name = "lblCruiseType";
            this.lblCruiseType.Size = new System.Drawing.Size(199, 20);
            this.lblCruiseType.TabIndex = 36;
            this.lblCruiseType.Text = "Select cruise period";
            // 
            // lblStartPeriodTouristForm
            // 
            this.lblStartPeriodTouristForm.AutoSize = true;
            this.lblStartPeriodTouristForm.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartPeriodTouristForm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblStartPeriodTouristForm.Location = new System.Drawing.Point(45, 88);
            this.lblStartPeriodTouristForm.Name = "lblStartPeriodTouristForm";
            this.lblStartPeriodTouristForm.Size = new System.Drawing.Size(128, 20);
            this.lblStartPeriodTouristForm.TabIndex = 38;
            this.lblStartPeriodTouristForm.Text = "Start period";
            // 
            // lblEndPeriodTouristForm
            // 
            this.lblEndPeriodTouristForm.AutoSize = true;
            this.lblEndPeriodTouristForm.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndPeriodTouristForm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEndPeriodTouristForm.Location = new System.Drawing.Point(45, 120);
            this.lblEndPeriodTouristForm.Name = "lblEndPeriodTouristForm";
            this.lblEndPeriodTouristForm.Size = new System.Drawing.Size(107, 20);
            this.lblEndPeriodTouristForm.TabIndex = 39;
            this.lblEndPeriodTouristForm.Text = "End Period";
            // 
            // dTPStartPeriodTourist
            // 
            this.dTPStartPeriodTourist.CalendarTitleBackColor = System.Drawing.Color.LightSkyBlue;
            this.dTPStartPeriodTourist.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.dTPStartPeriodTourist.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPStartPeriodTourist.Location = new System.Drawing.Point(241, 82);
            this.dTPStartPeriodTourist.Name = "dTPStartPeriodTourist";
            this.dTPStartPeriodTourist.Size = new System.Drawing.Size(200, 28);
            this.dTPStartPeriodTourist.TabIndex = 40;
            // 
            // dTPEndPeriodTourist
            // 
            this.dTPEndPeriodTourist.CalendarTitleBackColor = System.Drawing.Color.LightSkyBlue;
            this.dTPEndPeriodTourist.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.dTPEndPeriodTourist.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPEndPeriodTourist.Location = new System.Drawing.Point(241, 114);
            this.dTPEndPeriodTourist.Name = "dTPEndPeriodTourist";
            this.dTPEndPeriodTourist.Size = new System.Drawing.Size(200, 28);
            this.dTPEndPeriodTourist.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(45, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Num passengers";
            // 
            // tbxDistanceBetweenHarboursUpdateDistanceForm
            // 
            this.tbxDistanceBetweenHarboursUpdateDistanceForm.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDistanceBetweenHarboursUpdateDistanceForm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbxDistanceBetweenHarboursUpdateDistanceForm.Location = new System.Drawing.Point(241, 149);
            this.tbxDistanceBetweenHarboursUpdateDistanceForm.Name = "tbxDistanceBetweenHarboursUpdateDistanceForm";
            this.tbxDistanceBetweenHarboursUpdateDistanceForm.Size = new System.Drawing.Size(75, 28);
            this.tbxDistanceBetweenHarboursUpdateDistanceForm.TabIndex = 43;
            // 
            // dgvListCruises
            // 
            this.dgvListCruises.AllowUserToAddRows = false;
            this.dgvListCruises.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListCruises.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvListCruises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListCruises.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListCruises.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListCruises.GridColor = System.Drawing.SystemColors.Desktop;
            this.dgvListCruises.Location = new System.Drawing.Point(12, 193);
            this.dgvListCruises.Name = "dgvListCruises";
            this.dgvListCruises.ReadOnly = true;
            this.dgvListCruises.RowHeadersVisible = false;
            this.dgvListCruises.RowTemplate.Height = 24;
            this.dgvListCruises.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListCruises.Size = new System.Drawing.Size(805, 268);
            this.dgvListCruises.TabIndex = 44;
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuyTicket.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuyTicket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuyTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnBuyTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyTicket.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyTicket.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnBuyTicket.Location = new System.Drawing.Point(570, 92);
            this.btnBuyTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(169, 34);
            this.btnBuyTicket.TabIndex = 45;
            this.btnBuyTicket.Text = "Buy Ticket";
            this.btnBuyTicket.UseVisualStyleBackColor = false;
            this.btnBuyTicket.Click += new System.EventHandler(this.btnBuyTicket_Click);
            // 
            // TouristForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(831, 494);
            this.Controls.Add(this.btnBuyTicket);
            this.Controls.Add(this.dgvListCruises);
            this.Controls.Add(this.tbxDistanceBetweenHarboursUpdateDistanceForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dTPEndPeriodTourist);
            this.Controls.Add(this.dTPStartPeriodTourist);
            this.Controls.Add(this.lblEndPeriodTouristForm);
            this.Controls.Add(this.lblStartPeriodTouristForm);
            this.Controls.Add(this.cbxSelectCruisePeriod);
            this.Controls.Add(this.lblCruiseType);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.statusStripListCruises);
            this.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TouristForm";
            this.Text = "Tourist";
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbxSelectCruisePeriod;
        private System.Windows.Forms.Label lblCruiseType;
        private System.Windows.Forms.Label lblStartPeriodTouristForm;
        private System.Windows.Forms.Label lblEndPeriodTouristForm;
        private System.Windows.Forms.DateTimePicker dTPStartPeriodTourist;
        private System.Windows.Forms.DateTimePicker dTPEndPeriodTourist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDistanceBetweenHarboursUpdateDistanceForm;
        private System.Windows.Forms.DataGridView dgvListCruises;
        private System.Windows.Forms.Button btnBuyTicket;
    }
}