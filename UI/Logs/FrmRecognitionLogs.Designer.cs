namespace UI.Logs
{
    partial class FrmRecognitionLogs
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
            btnExport = new Button();
            btnSearch = new Button();
            dtpDateTo = new DateTimePicker();
            lblDateTo = new Label();
            dtpDateFrom = new DateTimePicker();
            lblDate = new Label();
            dgvLogs = new DataGridView();
            lblCollaborator = new Label();
            cmbCollaborator = new ComboBox();
            cmbType = new ComboBox();
            lblType = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            SuspendLayout();
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.ForestGreen;
            btnExport.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = SystemColors.ButtonHighlight;
            btnExport.Location = new Point(100, 706);
            btnExport.Margin = new Padding(4, 5, 4, 5);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(309, 49);
            btnExport.TabIndex = 61;
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
            btnSearch.Location = new Point(1650, 706);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(309, 49);
            btnSearch.TabIndex = 60;
            btnSearch.Tag = "SEARCH";
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dtpDateTo
            // 
            dtpDateTo.Location = new Point(547, 55);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(392, 31);
            dtpDateTo.TabIndex = 59;
            // 
            // lblDateTo
            // 
            lblDateTo.AutoSize = true;
            lblDateTo.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            lblDateTo.ForeColor = Color.ForestGreen;
            lblDateTo.Location = new Point(547, 24);
            lblDateTo.Name = "lblDateTo";
            lblDateTo.Size = new Size(131, 28);
            lblDateTo.TabIndex = 58;
            lblDateTo.Tag = "DATE_TO";
            lblDateTo.Text = "Fecha hasta:";
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.Location = new Point(98, 55);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(392, 31);
            dtpDateFrom.TabIndex = 57;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            lblDate.ForeColor = Color.ForestGreen;
            lblDate.Location = new Point(98, 24);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(137, 28);
            lblDate.TabIndex = 56;
            lblDate.Tag = "DATE_FROM";
            lblDate.Text = "Fecha desde:";
            // 
            // dgvLogs
            // 
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Location = new Point(100, 92);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.RowHeadersWidth = 62;
            dgvLogs.Size = new Size(1859, 592);
            dgvLogs.TabIndex = 55;
            // 
            // lblCollaborator
            // 
            lblCollaborator.AutoSize = true;
            lblCollaborator.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            lblCollaborator.ForeColor = Color.ForestGreen;
            lblCollaborator.Location = new Point(994, 24);
            lblCollaborator.Name = "lblCollaborator";
            lblCollaborator.Size = new Size(142, 28);
            lblCollaborator.TabIndex = 63;
            lblCollaborator.Tag = "";
            lblCollaborator.Text = "Colaborador:";
            // 
            // cmbCollaborator
            // 
            cmbCollaborator.FormattingEnabled = true;
            cmbCollaborator.Location = new Point(994, 53);
            cmbCollaborator.Name = "cmbCollaborator";
            cmbCollaborator.Size = new Size(255, 33);
            cmbCollaborator.TabIndex = 64;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(1310, 53);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(255, 33);
            cmbType.TabIndex = 66;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            lblType.ForeColor = Color.ForestGreen;
            lblType.Location = new Point(1310, 24);
            lblType.Name = "lblType";
            lblType.Size = new Size(63, 28);
            lblType.TabIndex = 65;
            lblType.Tag = "";
            lblType.Text = "Tipo:";
            // 
            // FrmRecognitionLogs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2235, 805);
            Controls.Add(cmbType);
            Controls.Add(lblType);
            Controls.Add(cmbCollaborator);
            Controls.Add(lblCollaborator);
            Controls.Add(btnExport);
            Controls.Add(btnSearch);
            Controls.Add(dtpDateTo);
            Controls.Add(lblDateTo);
            Controls.Add(dtpDateFrom);
            Controls.Add(lblDate);
            Controls.Add(dgvLogs);
            Name = "FrmRecognitionLogs";
            Text = "FrmRecognitionLogs";
            FormClosed += FrmRecognitionLogs_FormClosed;
            Load += FrmRecognitionLogs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnExport;
        private Button btnSearch;
        private DateTimePicker dtpDateTo;
        private Label lblDateTo;
        private DateTimePicker dtpDateFrom;
        private Label lblDate;
        private DataGridView dgvLogs;
        private Label lblCollaborator;
        private ComboBox cmbCollaborator;
        private ComboBox cmbType;
        private Label lblType;
    }
}