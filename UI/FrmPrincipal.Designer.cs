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
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            iniciarSesiónToolStripMenuItem = new ToolStripMenuItem();
            cambiarIdiomaToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            administraciónToolStripMenuItem = new ToolStripMenuItem();
            gestionarEmpleadosToolStripMenuItem = new ToolStripMenuItem();
            gestionarPerfilesToolStripMenuItem = new ToolStripMenuItem();
            gestionarIdiomaToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            verProductosToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            userToolStrip = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, administraciónToolStripMenuItem, productosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { iniciarSesiónToolStripMenuItem, cambiarIdiomaToolStripMenuItem, cerrarSesiónToolStripMenuItem });
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(70, 29);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // iniciarSesiónToolStripMenuItem
            // 
            iniciarSesiónToolStripMenuItem.Name = "iniciarSesiónToolStripMenuItem";
            iniciarSesiónToolStripMenuItem.Size = new Size(270, 34);
            iniciarSesiónToolStripMenuItem.Text = "Iniciar sesión";
            iniciarSesiónToolStripMenuItem.Click += iniciarSesiónToolStripMenuItem_Click;
            // 
            // cambiarIdiomaToolStripMenuItem
            // 
            cambiarIdiomaToolStripMenuItem.Name = "cambiarIdiomaToolStripMenuItem";
            cambiarIdiomaToolStripMenuItem.Size = new Size(270, 34);
            cambiarIdiomaToolStripMenuItem.Text = "Cambiar idioma";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(270, 34);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            cerrarSesiónToolStripMenuItem.Click += cerrarSesiónToolStripMenuItem_Click;
            // 
            // administraciónToolStripMenuItem
            // 
            administraciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionarEmpleadosToolStripMenuItem, gestionarPerfilesToolStripMenuItem, gestionarIdiomaToolStripMenuItem });
            administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            administraciónToolStripMenuItem.Size = new Size(147, 29);
            administraciónToolStripMenuItem.Text = "Administración";
            // 
            // gestionarEmpleadosToolStripMenuItem
            // 
            gestionarEmpleadosToolStripMenuItem.Name = "gestionarEmpleadosToolStripMenuItem";
            gestionarEmpleadosToolStripMenuItem.Size = new Size(282, 34);
            gestionarEmpleadosToolStripMenuItem.Text = "Gestionar empleados";
            // 
            // gestionarPerfilesToolStripMenuItem
            // 
            gestionarPerfilesToolStripMenuItem.Name = "gestionarPerfilesToolStripMenuItem";
            gestionarPerfilesToolStripMenuItem.Size = new Size(282, 34);
            gestionarPerfilesToolStripMenuItem.Text = "Gestionar perfiles";
            // 
            // gestionarIdiomaToolStripMenuItem
            // 
            gestionarIdiomaToolStripMenuItem.Name = "gestionarIdiomaToolStripMenuItem";
            gestionarIdiomaToolStripMenuItem.Size = new Size(282, 34);
            gestionarIdiomaToolStripMenuItem.Text = "Gestionar idioma";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verProductosToolStripMenuItem });
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(109, 29);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // verProductosToolStripMenuItem
            // 
            verProductosToolStripMenuItem.Name = "verProductosToolStripMenuItem";
            verProductosToolStripMenuItem.Size = new Size(226, 34);
            verProductosToolStripMenuItem.Text = "Ver productos";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { userToolStrip });
            statusStrip1.Location = new Point(0, 418);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 32);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // userToolStrip
            // 
            userToolStrip.Name = "userToolStrip";
            userToolStrip.Size = new Size(199, 25);
            userToolStrip.Text = "Usuario (No conectado)";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem administraciónToolStripMenuItem;
        private ToolStripMenuItem gestionarEmpleadosToolStripMenuItem;
        private ToolStripMenuItem gestionarPerfilesToolStripMenuItem;
        private ToolStripMenuItem gestionarIdiomaToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem iniciarSesiónToolStripMenuItem;
        private ToolStripMenuItem cambiarIdiomaToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private ToolStripMenuItem verProductosToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel userToolStrip;
    }
}