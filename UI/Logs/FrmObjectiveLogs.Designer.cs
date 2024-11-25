namespace UI.Logs
{
    partial class FrmObjectiveLogs
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
            cmbCollaborator = new ComboBox();
            lblCollaborator = new Label();
            btnExport = new Button();
            btnSearch = new Button();
            dtpDateTo = new DateTimePicker();
            lblDateTo = new Label();
            dtpDateFrom = new DateTimePicker();
            lblDate = new Label();
            dgvLogs = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            SuspendLayout();
            // 
            // cmbCollaborator
            // 
            cmbCollaborator.FormattingEnabled = true;
            cmbCollaborator.Location = new Point(990, 93);
            cmbCollaborator.Name = "cmbCollaborator";
            cmbCollaborator.Size = new Size(255, 33);
            cmbCollaborator.TabIndex = 73;
            // 
            // lblCollaborator
            // 
            lblCollaborator.AutoSize = true;
            lblCollaborator.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            lblCollaborator.ForeColor = Color.ForestGreen;
            lblCollaborator.Location = new Point(990, 64);
            lblCollaborator.Name = "lblCollaborator";
            lblCollaborator.Size = new Size(142, 28);
            lblCollaborator.TabIndex = 72;
            lblCollaborator.Tag = "";
            lblCollaborator.Text = "Colaborador:";
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.ForestGreen;
            btnExport.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = SystemColors.ButtonHighlight;
            btnExport.Location = new Point(96, 746);
            btnExport.Margin = new Padding(4, 5, 4, 5);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(309, 49);
            btnExport.TabIndex = 71;
            btnExport.Tag = "EXPORT";
            btnExport.Text = "Exportar";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.ForestGreen;
            btnSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(1646, 746);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(309, 49);
            btnSearch.TabIndex = 70;
            btnSearch.Tag = "SEARCH";
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dtpDateTo
            // 
            dtpDateTo.Location = new Point(543, 95);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(392, 31);
            dtpDateTo.TabIndex = 69;
            // 
            // lblDateTo
            // 
            lblDateTo.AutoSize = true;
            lblDateTo.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            lblDateTo.ForeColor = Color.ForestGreen;
            lblDateTo.Location = new Point(543, 64);
            lblDateTo.Name = "lblDateTo";
            lblDateTo.Size = new Size(131, 28);
            lblDateTo.TabIndex = 68;
            lblDateTo.Tag = "DATE_TO";
            lblDateTo.Text = "Fecha hasta:";
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.Location = new Point(94, 95);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(392, 31);
            dtpDateFrom.TabIndex = 67;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            lblDate.ForeColor = Color.ForestGreen;
            lblDate.Location = new Point(94, 64);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(137, 28);
            lblDate.TabIndex = 66;
            lblDate.Tag = "DATE_FROM";
            lblDate.Text = "Fecha desde:";
            // 
            // dgvLogs
            // 
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Location = new Point(96, 132);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.RowHeadersWidth = 62;
            dgvLogs.Size = new Size(1859, 592);
            dgvLogs.TabIndex = 65;
            // 
            // FrmObjectiveLogs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2123, 1126);
            Controls.Add(cmbCollaborator);
            Controls.Add(lblCollaborator);
            Controls.Add(btnExport);
            Controls.Add(btnSearch);
            Controls.Add(dtpDateTo);
            Controls.Add(lblDateTo);
            Controls.Add(dtpDateFrom);
            Controls.Add(lblDate);
            Controls.Add(dgvLogs);
            Name = "FrmObjectiveLogs";
            Text = "FrmObjectiveLogs";
            FormClosed += FrmObjectiveLogs_FormClosed;
            Load += FrmObjectiveLogs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCollaborator;
        private Label lblCollaborator;
        private Button btnExport;
        private Button btnSearch;
        private DateTimePicker dtpDateTo;
        private Label lblDateTo;
        private DateTimePicker dtpDateFrom;
        private Label lblDate;
        private DataGridView dgvLogs;
    }
}