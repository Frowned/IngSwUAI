namespace UI.Recognitions
{
    partial class FrmReviewPendingNominations
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
            btnClearControls = new Button();
            btnSendComment = new Button();
            rtbComments = new RichTextBox();
            lblComments = new Label();
            SuspendLayout();
            // 
            // btnClearControls
            // 
            btnClearControls.BackColor = Color.ForestGreen;
            btnClearControls.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearControls.ForeColor = SystemColors.ButtonHighlight;
            btnClearControls.Location = new Point(308, 939);
            btnClearControls.Margin = new Padding(4, 5, 4, 5);
            btnClearControls.Name = "btnClearControls";
            btnClearControls.Size = new Size(209, 49);
            btnClearControls.TabIndex = 59;
            btnClearControls.Tag = "";
            btnClearControls.Text = "Limpiar";
            btnClearControls.UseVisualStyleBackColor = false;
            // 
            // btnSendComment
            // 
            btnSendComment.BackColor = Color.ForestGreen;
            btnSendComment.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendComment.ForeColor = SystemColors.ButtonHighlight;
            btnSendComment.Location = new Point(77, 939);
            btnSendComment.Margin = new Padding(4, 5, 4, 5);
            btnSendComment.Name = "btnSendComment";
            btnSendComment.Size = new Size(223, 49);
            btnSendComment.TabIndex = 58;
            btnSendComment.Tag = "";
            btnSendComment.Text = "Enviar nominación";
            btnSendComment.UseVisualStyleBackColor = false;
            // 
            // rtbComments
            // 
            rtbComments.Location = new Point(77, 634);
            rtbComments.Name = "rtbComments";
            rtbComments.Size = new Size(1247, 297);
            rtbComments.TabIndex = 57;
            rtbComments.Text = "";
            // 
            // lblComments
            // 
            lblComments.AutoSize = true;
            lblComments.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblComments.ForeColor = Color.ForestGreen;
            lblComments.Location = new Point(77, 599);
            lblComments.Name = "lblComments";
            lblComments.Size = new Size(170, 32);
            lblComments.TabIndex = 56;
            lblComments.Tag = "";
            lblComments.Text = "Comentarios:";
            // 
            // FrmReviewPendingNominations
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1610, 1054);
            Controls.Add(btnClearControls);
            Controls.Add(btnSendComment);
            Controls.Add(rtbComments);
            Controls.Add(lblComments);
            Name = "FrmReviewPendingNominations";
            Text = "FrmReviewPendingNominations";
            FormClosed += FrmReviewPendingNominations_FormClosed;
            Load += FrmReviewPendingNominations_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClearControls;
        private Button btnSendComment;
        private RichTextBox rtbComments;
        private Label lblComments;
    }
}