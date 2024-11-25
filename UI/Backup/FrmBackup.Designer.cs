namespace UI.Backup
{
    partial class FrmBackup
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
            label1 = new Label();
            BtnRestore = new Button();
            BtnBackup = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(39, 89);
            label1.Name = "label1";
            label1.Size = new Size(446, 32);
            label1.TabIndex = 22;
            label1.Tag = "MANAGE_BACKUP";
            label1.Text = "Gestión del backup de base de datos:";
            // 
            // BtnRestore
            // 
            BtnRestore.BackColor = Color.ForestGreen;
            BtnRestore.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRestore.ForeColor = SystemColors.ButtonHighlight;
            BtnRestore.Location = new Point(39, 195);
            BtnRestore.Margin = new Padding(4, 5, 4, 5);
            BtnRestore.Name = "BtnRestore";
            BtnRestore.Size = new Size(309, 49);
            BtnRestore.TabIndex = 24;
            BtnRestore.Tag = "RESTORE_BACKUP";
            BtnRestore.Text = "Restaurar";
            BtnRestore.UseVisualStyleBackColor = false;
            BtnRestore.Click += BtnRestore_Click;
            // 
            // BtnBackup
            // 
            BtnBackup.BackColor = Color.ForestGreen;
            BtnBackup.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBackup.ForeColor = SystemColors.ButtonHighlight;
            BtnBackup.Location = new Point(39, 136);
            BtnBackup.Margin = new Padding(4, 5, 4, 5);
            BtnBackup.Name = "BtnBackup";
            BtnBackup.Size = new Size(309, 49);
            BtnBackup.TabIndex = 23;
            BtnBackup.Tag = "GENERATE_BACKUP";
            BtnBackup.Text = "Generar respaldo";
            BtnBackup.UseVisualStyleBackColor = false;
            BtnBackup.Click += BtnBackup_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmBackup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1356, 695);
            Controls.Add(BtnRestore);
            Controls.Add(BtnBackup);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBackup";
            Text = "Backup";
            WindowState = FormWindowState.Maximized;
            FormClosed += FrmBackup_FormClosed;
            Load += FrmBackup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnRestore;
        private Button BtnBackup;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}