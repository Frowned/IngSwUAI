namespace UI.Logs
{
    partial class FrmProductsLogs
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
            BtnSearch = new Button();
            dtpDateTo = new DateTimePicker();
            lblDateTo = new Label();
            dtpDateFrom = new DateTimePicker();
            lblDate = new Label();
            label5 = new Label();
            dgvProductLogs = new DataGridView();
            btnSet = new Button();
            textBox1 = new TextBox();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductLogs).BeginInit();
            SuspendLayout();
            // 
            // BtnSearch
            // 
            BtnSearch.BackColor = Color.ForestGreen;
            BtnSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSearch.ForeColor = SystemColors.ButtonHighlight;
            BtnSearch.Location = new Point(1280, 765);
            BtnSearch.Margin = new Padding(4, 5, 4, 5);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(309, 49);
            BtnSearch.TabIndex = 62;
            BtnSearch.Tag = "SEARCH";
            BtnSearch.Text = "Buscar";
            BtnSearch.UseVisualStyleBackColor = false;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // dtpDateTo
            // 
            dtpDateTo.Location = new Point(676, 126);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(392, 31);
            dtpDateTo.TabIndex = 61;
            // 
            // lblDateTo
            // 
            lblDateTo.AutoSize = true;
            lblDateTo.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            lblDateTo.ForeColor = Color.ForestGreen;
            lblDateTo.Location = new Point(676, 95);
            lblDateTo.Name = "lblDateTo";
            lblDateTo.Size = new Size(131, 28);
            lblDateTo.TabIndex = 60;
            lblDateTo.Tag = "DATE_TO";
            lblDateTo.Text = "Fecha hasta:";
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.Location = new Point(227, 126);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(392, 31);
            dtpDateFrom.TabIndex = 59;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            lblDate.ForeColor = Color.ForestGreen;
            lblDate.Location = new Point(227, 95);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(137, 28);
            lblDate.TabIndex = 58;
            lblDate.Tag = "DATE_FROM";
            lblDate.Text = "Fecha desde:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(57, 95);
            label5.Name = "label5";
            label5.Size = new Size(136, 28);
            label5.TabIndex = 55;
            label5.Tag = "PRODUCT_ID";
            label5.Text = "Producto Id:";
            // 
            // dgvProductLogs
            // 
            dgvProductLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductLogs.Location = new Point(57, 165);
            dgvProductLogs.Name = "dgvProductLogs";
            dgvProductLogs.RowHeadersWidth = 62;
            dgvProductLogs.Size = new Size(1859, 592);
            dgvProductLogs.TabIndex = 53;
            // 
            // btnSet
            // 
            btnSet.BackColor = Color.ForestGreen;
            btnSet.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSet.ForeColor = SystemColors.ButtonHighlight;
            btnSet.Location = new Point(1607, 765);
            btnSet.Margin = new Padding(4, 5, 4, 5);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(309, 49);
            btnSet.TabIndex = 63;
            btnSet.Tag = "SEARCH";
            btnSet.Text = "Marcar activo";
            btnSet.UseVisualStyleBackColor = false;
            btnSet.Click += btnSet_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 64;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.ForestGreen;
            btnExport.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = SystemColors.ButtonHighlight;
            btnExport.Location = new Point(57, 765);
            btnExport.Margin = new Padding(4, 5, 4, 5);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(309, 49);
            btnExport.TabIndex = 65;
            btnExport.Tag = "EXPORT";
            btnExport.Text = "Exportar";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // FrmProductsLogs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2017, 890);
            Controls.Add(btnExport);
            Controls.Add(textBox1);
            Controls.Add(btnSet);
            Controls.Add(BtnSearch);
            Controls.Add(dtpDateTo);
            Controls.Add(lblDateTo);
            Controls.Add(dtpDateFrom);
            Controls.Add(lblDate);
            Controls.Add(label5);
            Controls.Add(dgvProductLogs);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProductsLogs";
            Text = "Bitácora de productos";
            WindowState = FormWindowState.Maximized;
            FormClosed += FrmProductsLogs_FormClosed;
            Load += FrmProductsLogs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSearch;
        private DateTimePicker dtpDateTo;
        private Label lblDateTo;
        private DateTimePicker dtpDateFrom;
        private Label lblDate;
        private Label label5;
        private DataGridView dgvProductLogs;
        private Button btnSet;
        private TextBox textBox1;
        private Button btnExport;
    }
}