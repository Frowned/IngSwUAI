namespace UI
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            statusStrip1 = new StatusStrip();
            userToolStrip = new ToolStripStatusLabel();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            helpProvider = new HelpProvider();
            panel1 = new Panel();
            pnlAdmin = new Panel();
            btnManageBackup = new Button();
            btnManageProducts = new Button();
            btnManageLang = new Button();
            btnManageRoles = new Button();
            btnAdmin = new Button();
            pnlReports = new Panel();
            btnReportProducts = new Button();
            btnReportEvents = new Button();
            btnReport = new Button();
            btnHelp = new Button();
            pnlProducts = new Panel();
            btnViewProducts = new Button();
            btnProducts = new Button();
            pnlPoints = new Panel();
            btnTransferPoints = new Button();
            btnExchangePoints = new Button();
            btnCheckPoints = new Button();
            btnPoints = new Button();
            btnLogout = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            lblTitle = new Label();
            buttonsPnl = new Panel();
            btnMinimize = new Button();
            btnMaximizeRestore = new Button();
            btnClose = new Button();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            pnlAdmin.SuspendLayout();
            pnlReports.SuspendLayout();
            pnlProducts.SuspendLayout();
            pnlPoints.SuspendLayout();
            panel2.SuspendLayout();
            buttonsPnl.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { userToolStrip, toolStripDropDownButton1 });
            statusStrip1.Location = new Point(0, 629);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1181, 32);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // userToolStrip
            // 
            userToolStrip.Name = "userToolStrip";
            userToolStrip.Size = new Size(199, 25);
            userToolStrip.Text = "Usuario (No conectado)";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(42, 29);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            toolStripDropDownButton1.Click += toolStripDropDownButton1_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(51, 51, 77);
            panel1.Controls.Add(pnlAdmin);
            panel1.Controls.Add(btnAdmin);
            panel1.Controls.Add(pnlReports);
            panel1.Controls.Add(btnReport);
            panel1.Controls.Add(btnHelp);
            panel1.Controls.Add(pnlProducts);
            panel1.Controls.Add(btnProducts);
            panel1.Controls.Add(pnlPoints);
            panel1.Controls.Add(btnPoints);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 629);
            panel1.TabIndex = 3;
            // 
            // pnlAdmin
            // 
            pnlAdmin.AutoSize = true;
            pnlAdmin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlAdmin.BackColor = Color.FromArgb(34, 34, 52);
            pnlAdmin.Controls.Add(btnManageBackup);
            pnlAdmin.Controls.Add(btnManageProducts);
            pnlAdmin.Controls.Add(btnManageLang);
            pnlAdmin.Controls.Add(btnManageRoles);
            pnlAdmin.Dock = DockStyle.Top;
            pnlAdmin.Location = new Point(0, 720);
            pnlAdmin.Name = "pnlAdmin";
            pnlAdmin.Size = new Size(313, 228);
            pnlAdmin.TabIndex = 13;
            // 
            // btnManageBackup
            // 
            btnManageBackup.BackColor = Color.FromArgb(34, 34, 52);
            btnManageBackup.Dock = DockStyle.Top;
            btnManageBackup.FlatAppearance.BorderSize = 0;
            btnManageBackup.FlatStyle = FlatStyle.Flat;
            btnManageBackup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageBackup.ForeColor = SystemColors.Control;
            btnManageBackup.Location = new Point(0, 171);
            btnManageBackup.Name = "btnManageBackup";
            btnManageBackup.Size = new Size(313, 57);
            btnManageBackup.TabIndex = 9;
            btnManageBackup.Tag = "MANAGE_BACKUP";
            btnManageBackup.Text = "Gestionar Backup";
            btnManageBackup.UseVisualStyleBackColor = false;
            btnManageBackup.Click += btnManageBackup_Click;
            // 
            // btnManageProducts
            // 
            btnManageProducts.BackColor = Color.FromArgb(34, 34, 52);
            btnManageProducts.Dock = DockStyle.Top;
            btnManageProducts.FlatAppearance.BorderSize = 0;
            btnManageProducts.FlatStyle = FlatStyle.Flat;
            btnManageProducts.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageProducts.ForeColor = SystemColors.Control;
            btnManageProducts.Location = new Point(0, 114);
            btnManageProducts.Name = "btnManageProducts";
            btnManageProducts.Size = new Size(313, 57);
            btnManageProducts.TabIndex = 8;
            btnManageProducts.Tag = "MANAGE_PRODUCTS";
            btnManageProducts.Text = "Gestionar productos";
            btnManageProducts.UseVisualStyleBackColor = false;
            btnManageProducts.Click += btnManageProducts_Click;
            // 
            // btnManageLang
            // 
            btnManageLang.BackColor = Color.FromArgb(34, 34, 52);
            btnManageLang.Dock = DockStyle.Top;
            btnManageLang.FlatAppearance.BorderSize = 0;
            btnManageLang.FlatStyle = FlatStyle.Flat;
            btnManageLang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageLang.ForeColor = SystemColors.Control;
            btnManageLang.Location = new Point(0, 57);
            btnManageLang.Name = "btnManageLang";
            btnManageLang.Size = new Size(313, 57);
            btnManageLang.TabIndex = 7;
            btnManageLang.Tag = "MANAGE_LANGUAGE";
            btnManageLang.Text = "Gestionar idioma";
            btnManageLang.UseVisualStyleBackColor = false;
            btnManageLang.Click += btnManageLang_Click;
            // 
            // btnManageRoles
            // 
            btnManageRoles.BackColor = Color.FromArgb(34, 34, 52);
            btnManageRoles.Dock = DockStyle.Top;
            btnManageRoles.FlatAppearance.BorderSize = 0;
            btnManageRoles.FlatStyle = FlatStyle.Flat;
            btnManageRoles.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageRoles.ForeColor = SystemColors.Control;
            btnManageRoles.Location = new Point(0, 0);
            btnManageRoles.Name = "btnManageRoles";
            btnManageRoles.Size = new Size(313, 57);
            btnManageRoles.TabIndex = 6;
            btnManageRoles.Tag = "MANAGE_ROLES";
            btnManageRoles.Text = "Gestionar perfiles";
            btnManageRoles.UseVisualStyleBackColor = false;
            btnManageRoles.Click += btnManageRoles_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Dock = DockStyle.Top;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = SystemColors.Control;
            btnAdmin.Location = new Point(0, 663);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(313, 57);
            btnAdmin.TabIndex = 12;
            btnAdmin.Tag = "MENU_ADMIN";
            btnAdmin.Text = "Configuración";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // pnlReports
            // 
            pnlReports.AutoSize = true;
            pnlReports.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlReports.BackColor = Color.FromArgb(34, 34, 52);
            pnlReports.Controls.Add(btnReportProducts);
            pnlReports.Controls.Add(btnReportEvents);
            pnlReports.Dock = DockStyle.Top;
            pnlReports.Location = new Point(0, 549);
            pnlReports.Name = "pnlReports";
            pnlReports.Size = new Size(313, 114);
            pnlReports.TabIndex = 11;
            // 
            // btnReportProducts
            // 
            btnReportProducts.BackColor = Color.FromArgb(34, 34, 52);
            btnReportProducts.Dock = DockStyle.Top;
            btnReportProducts.FlatAppearance.BorderSize = 0;
            btnReportProducts.FlatStyle = FlatStyle.Flat;
            btnReportProducts.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportProducts.ForeColor = SystemColors.Control;
            btnReportProducts.Location = new Point(0, 57);
            btnReportProducts.Name = "btnReportProducts";
            btnReportProducts.Size = new Size(313, 57);
            btnReportProducts.TabIndex = 7;
            btnReportProducts.Tag = "";
            btnReportProducts.Text = "Bitácora productos";
            btnReportProducts.UseVisualStyleBackColor = false;
            btnReportProducts.Click += btnReportProducts_Click;
            // 
            // btnReportEvents
            // 
            btnReportEvents.BackColor = Color.FromArgb(34, 34, 52);
            btnReportEvents.Dock = DockStyle.Top;
            btnReportEvents.FlatAppearance.BorderSize = 0;
            btnReportEvents.FlatStyle = FlatStyle.Flat;
            btnReportEvents.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportEvents.ForeColor = SystemColors.Control;
            btnReportEvents.Location = new Point(0, 0);
            btnReportEvents.Name = "btnReportEvents";
            btnReportEvents.Size = new Size(313, 57);
            btnReportEvents.TabIndex = 6;
            btnReportEvents.Tag = "";
            btnReportEvents.Text = "Bitácora eventos";
            btnReportEvents.UseVisualStyleBackColor = false;
            btnReportEvents.Click += btnReportEvents_Click;
            // 
            // btnReport
            // 
            btnReport.Dock = DockStyle.Top;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.ForeColor = SystemColors.Control;
            btnReport.Location = new Point(0, 492);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(313, 57);
            btnReport.TabIndex = 10;
            btnReport.Tag = "MENU_REPORTS";
            btnReport.Text = "Reportería";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnHelp
            // 
            btnHelp.Dock = DockStyle.Bottom;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHelp.ForeColor = SystemColors.Control;
            btnHelp.Location = new Point(0, 948);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(313, 57);
            btnHelp.TabIndex = 9;
            btnHelp.Tag = "MENU_HELP";
            btnHelp.Text = "Ayuda";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // pnlProducts
            // 
            pnlProducts.AutoSize = true;
            pnlProducts.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlProducts.BackColor = Color.FromArgb(34, 34, 52);
            pnlProducts.Controls.Add(btnViewProducts);
            pnlProducts.Dock = DockStyle.Top;
            pnlProducts.Location = new Point(0, 435);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Size = new Size(313, 57);
            pnlProducts.TabIndex = 8;
            // 
            // btnViewProducts
            // 
            btnViewProducts.BackColor = Color.FromArgb(34, 34, 52);
            btnViewProducts.Dock = DockStyle.Top;
            btnViewProducts.FlatAppearance.BorderSize = 0;
            btnViewProducts.FlatStyle = FlatStyle.Flat;
            btnViewProducts.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewProducts.ForeColor = SystemColors.Control;
            btnViewProducts.Location = new Point(0, 0);
            btnViewProducts.Name = "btnViewProducts";
            btnViewProducts.Size = new Size(313, 57);
            btnViewProducts.TabIndex = 6;
            btnViewProducts.Tag = "MENU_VIEW_PRODUCTS";
            btnViewProducts.Text = "Ver productos";
            btnViewProducts.UseVisualStyleBackColor = false;
            btnViewProducts.Click += btnViewProducts_Click;
            // 
            // btnProducts
            // 
            btnProducts.Dock = DockStyle.Top;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducts.ForeColor = SystemColors.Control;
            btnProducts.Location = new Point(0, 378);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(313, 57);
            btnProducts.TabIndex = 7;
            btnProducts.Tag = "MENU_PRODUCTS";
            btnProducts.Text = "Catalogo";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // pnlPoints
            // 
            pnlPoints.AutoSize = true;
            pnlPoints.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlPoints.BackColor = Color.FromArgb(34, 34, 52);
            pnlPoints.Controls.Add(btnTransferPoints);
            pnlPoints.Controls.Add(btnExchangePoints);
            pnlPoints.Controls.Add(btnCheckPoints);
            pnlPoints.Dock = DockStyle.Top;
            pnlPoints.Location = new Point(0, 207);
            pnlPoints.Name = "pnlPoints";
            pnlPoints.Size = new Size(313, 171);
            pnlPoints.TabIndex = 6;
            // 
            // btnTransferPoints
            // 
            btnTransferPoints.BackColor = Color.FromArgb(34, 34, 52);
            btnTransferPoints.Dock = DockStyle.Top;
            btnTransferPoints.FlatAppearance.BorderSize = 0;
            btnTransferPoints.FlatStyle = FlatStyle.Flat;
            btnTransferPoints.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransferPoints.ForeColor = SystemColors.Control;
            btnTransferPoints.Location = new Point(0, 114);
            btnTransferPoints.Name = "btnTransferPoints";
            btnTransferPoints.Size = new Size(313, 57);
            btnTransferPoints.TabIndex = 8;
            btnTransferPoints.Tag = "MENU_TRANSFER_POINTS";
            btnTransferPoints.Text = "Transferir puntos";
            btnTransferPoints.UseVisualStyleBackColor = false;
            btnTransferPoints.Click += btnTransferPoints_Click;
            // 
            // btnExchangePoints
            // 
            btnExchangePoints.BackColor = Color.FromArgb(34, 34, 52);
            btnExchangePoints.Dock = DockStyle.Top;
            btnExchangePoints.FlatAppearance.BorderSize = 0;
            btnExchangePoints.FlatStyle = FlatStyle.Flat;
            btnExchangePoints.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExchangePoints.ForeColor = SystemColors.Control;
            btnExchangePoints.Location = new Point(0, 57);
            btnExchangePoints.Name = "btnExchangePoints";
            btnExchangePoints.Size = new Size(313, 57);
            btnExchangePoints.TabIndex = 7;
            btnExchangePoints.Tag = "MENU_EXCHANGE_POINTS";
            btnExchangePoints.Text = "Canjear puntos";
            btnExchangePoints.UseVisualStyleBackColor = false;
            btnExchangePoints.Click += btnExchangePoints_Click;
            // 
            // btnCheckPoints
            // 
            btnCheckPoints.BackColor = Color.FromArgb(34, 34, 52);
            btnCheckPoints.Dock = DockStyle.Top;
            btnCheckPoints.FlatAppearance.BorderSize = 0;
            btnCheckPoints.FlatStyle = FlatStyle.Flat;
            btnCheckPoints.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckPoints.ForeColor = SystemColors.Control;
            btnCheckPoints.Location = new Point(0, 0);
            btnCheckPoints.Name = "btnCheckPoints";
            btnCheckPoints.Size = new Size(313, 57);
            btnCheckPoints.TabIndex = 6;
            btnCheckPoints.Tag = "MENU_CHECK_POINTS";
            btnCheckPoints.Text = "Consultar puntos";
            btnCheckPoints.UseVisualStyleBackColor = false;
            btnCheckPoints.Click += btnCheckPoints_Click;
            // 
            // btnPoints
            // 
            btnPoints.Dock = DockStyle.Top;
            btnPoints.FlatAppearance.BorderSize = 0;
            btnPoints.FlatStyle = FlatStyle.Flat;
            btnPoints.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPoints.ForeColor = SystemColors.Control;
            btnPoints.Location = new Point(0, 150);
            btnPoints.Name = "btnPoints";
            btnPoints.Size = new Size(313, 57);
            btnPoints.TabIndex = 5;
            btnPoints.Tag = "MENU_POINTS";
            btnPoints.Text = "Puntos";
            btnPoints.UseVisualStyleBackColor = true;
            btnPoints.Click += btnPoints_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Location = new Point(0, 1005);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(313, 57);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Cerrar sesión";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(38, 39, 59);
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(313, 150);
            panel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.AllowDrop = true;
            panel2.BackColor = Color.FromArgb(15, 66, 11);
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(buttonsPnl);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(339, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(842, 153);
            panel2.TabIndex = 5;
            panel2.DoubleClick += panel2_DoubleClick;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.Control;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(132, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Prueba";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonsPnl
            // 
            buttonsPnl.Controls.Add(btnMinimize);
            buttonsPnl.Controls.Add(btnMaximizeRestore);
            buttonsPnl.Controls.Add(btnClose);
            buttonsPnl.Dock = DockStyle.Right;
            buttonsPnl.Location = new Point(668, 0);
            buttonsPnl.Name = "buttonsPnl";
            buttonsPnl.Size = new Size(174, 153);
            buttonsPnl.TabIndex = 0;
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.ForeColor = SystemColors.ButtonFace;
            btnMinimize.Location = new Point(33, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(39, 34);
            btnMinimize.TabIndex = 2;
            btnMinimize.Text = "__";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximizeRestore
            // 
            btnMaximizeRestore.FlatAppearance.BorderSize = 0;
            btnMaximizeRestore.FlatStyle = FlatStyle.Flat;
            btnMaximizeRestore.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximizeRestore.ForeColor = SystemColors.ButtonFace;
            btnMaximizeRestore.Location = new Point(78, 12);
            btnMaximizeRestore.Name = "btnMaximizeRestore";
            btnMaximizeRestore.Size = new Size(39, 34);
            btnMaximizeRestore.TabIndex = 1;
            btnMaximizeRestore.Text = "🗗";
            btnMaximizeRestore.UseVisualStyleBackColor = false;
            btnMaximizeRestore.Click += btnMaximizeRestore_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ButtonFace;
            btnClose.Location = new Point(123, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(39, 34);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1181, 661);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIFRE";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlAdmin.ResumeLayout(false);
            pnlReports.ResumeLayout(false);
            pnlProducts.ResumeLayout(false);
            pnlPoints.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            buttonsPnl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel userToolStrip;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem bitacoraEventosToolStripMenuItem1;
        private HelpProvider helpProvider;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel buttonsPnl;
        private Button btnClose;
        private Button btnMinimize;
        private Button btnMaximizeRestore;
        private Button btnLogout;
        private Button btnProducts;
        private Panel pnlPoints;
        private Button btnExchangePoints;
        private Button btnCheckPoints;
        private Button btnPoints;
        private Button btnHelp;
        private Panel pnlProducts;
        private Button btnViewProducts;
        private Button btnReport;
        private Panel pnlReports;
        private Button btnReportProducts;
        private Button btnReportEvents;
        private Button btnTransferPoints;
        private Button btnAdmin;
        private Panel pnlAdmin;
        private Button btnManageLang;
        private Button btnManageRoles;
        private Button btnManageBackup;
        private Button btnManageProducts;
        private Label lblTitle;
    }
}