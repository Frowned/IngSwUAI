namespace UI.Logs
{
    partial class FrmEventsLogs
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
            dataGridView1 = new DataGridView();
            cmbCriticality = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            cmbModule = new ComboBox();
            lblDate = new Label();
            dtpDateFrom = new DateTimePicker();
            dtpDateTo = new DateTimePicker();
            lblDateTo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1489, 592);
            dataGridView1.TabIndex = 0;
            // 
            // cmbCriticality
            // 
            cmbCriticality.FormattingEnabled = true;
            cmbCriticality.Location = new Point(28, 77);
            cmbCriticality.Name = "cmbCriticality";
            cmbCriticality.Size = new Size(182, 33);
            cmbCriticality.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(28, 46);
            label5.Name = "label5";
            label5.Size = new Size(113, 28);
            label5.TabIndex = 45;
            label5.Tag = "CRITICALITY";
            label5.Text = "Criticidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(266, 46);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 47;
            label1.Tag = "MODULE";
            label1.Text = "Modulo:";
            // 
            // cmbModule
            // 
            cmbModule.FormattingEnabled = true;
            cmbModule.Location = new Point(266, 77);
            cmbModule.Name = "cmbModule";
            cmbModule.Size = new Size(182, 33);
            cmbModule.TabIndex = 46;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            lblDate.ForeColor = Color.ForestGreen;
            lblDate.Location = new Point(513, 46);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(137, 28);
            lblDate.TabIndex = 48;
            lblDate.Tag = "DATE_FROM";
            lblDate.Text = "Fecha desde:";
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.Location = new Point(513, 77);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(392, 31);
            dtpDateFrom.TabIndex = 49;
            // 
            // dtpDateTo
            // 
            dtpDateTo.Location = new Point(962, 77);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(392, 31);
            dtpDateTo.TabIndex = 51;
            // 
            // lblDateTo
            // 
            lblDateTo.AutoSize = true;
            lblDateTo.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            lblDateTo.ForeColor = Color.ForestGreen;
            lblDateTo.Location = new Point(962, 46);
            lblDateTo.Name = "lblDateTo";
            lblDateTo.Size = new Size(73, 28);
            lblDateTo.TabIndex = 50;
            lblDateTo.Tag = "DATE_TO";
            lblDateTo.Text = "Fecha:";
            // 
            // FrmEventsLogs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1529, 720);
            Controls.Add(dtpDateTo);
            Controls.Add(lblDateTo);
            Controls.Add(dtpDateFrom);
            Controls.Add(lblDate);
            Controls.Add(label1);
            Controls.Add(cmbModule);
            Controls.Add(label5);
            Controls.Add(cmbCriticality);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEventsLogs";
            Text = "Logs";
            WindowState = FormWindowState.Maximized;
            FormClosed += FrmEventsLogs_FormClosed;
            Load += FrmEventsLogs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cmbCriticality;
        private Label label5;
        private Label label1;
        private ComboBox cmbModule;
        private Label lblDate;
        private DateTimePicker dtpDateFrom;
        private DateTimePicker dtpDateTo;
        private Label lblDateTo;
    }
}