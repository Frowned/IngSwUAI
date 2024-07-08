namespace UI.Points
{
    partial class FrmExchangePoints
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
            SuspendLayout();
            // 
            // FrmExchangePoints
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1545, 799);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmExchangePoints";
            Text = "FrmExchangePoints";
            WindowState = FormWindowState.Maximized;
            FormClosed += FrmExchangePoints_FormClosed;
            Load += FrmExchangePoints_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}