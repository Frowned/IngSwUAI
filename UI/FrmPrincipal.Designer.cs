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
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            iniciarSesiónToolStripMenuItem = new ToolStripMenuItem();
            cambiarClaveToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            puntosToolStripMenuItem = new ToolStripMenuItem();
            consultarPuntosToolStripMenuItem = new ToolStripMenuItem();
            canjearPuntosToolStripMenuItem = new ToolStripMenuItem();
            verProductosToolStripMenuItem = new ToolStripMenuItem();
            administraciónToolStripMenuItem = new ToolStripMenuItem();
            gestionarEmpleadosToolStripMenuItem = new ToolStripMenuItem();
            gestionarPerfilesToolStripMenuItem = new ToolStripMenuItem();
            gestionarIdiomaToolStripMenuItem = new ToolStripMenuItem();
            gestionarProductosToolStripMenuItem = new ToolStripMenuItem();
            gestionarObjetivosToolStripMenuItem = new ToolStripMenuItem();
            reporteríaToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            userToolStrip = new ToolStripStatusLabel();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, puntosToolStripMenuItem, administraciónToolStripMenuItem, reporteríaToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { iniciarSesiónToolStripMenuItem, cambiarClaveToolStripMenuItem, cerrarSesiónToolStripMenuItem });
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(70, 29);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // iniciarSesiónToolStripMenuItem
            // 
            iniciarSesiónToolStripMenuItem.Name = "iniciarSesiónToolStripMenuItem";
            iniciarSesiónToolStripMenuItem.Size = new Size(224, 34);
            iniciarSesiónToolStripMenuItem.Text = "Iniciar sesión";
            iniciarSesiónToolStripMenuItem.Click += iniciarSesiónToolStripMenuItem_Click;
            // 
            // cambiarClaveToolStripMenuItem
            // 
            cambiarClaveToolStripMenuItem.Name = "cambiarClaveToolStripMenuItem";
            cambiarClaveToolStripMenuItem.Size = new Size(270, 34);
            cambiarClaveToolStripMenuItem.Text = "Cambiar clave";
            cambiarClaveToolStripMenuItem.Click += cambiarClaveToolStripMenuItem_Click;
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(224, 34);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            cerrarSesiónToolStripMenuItem.Click += cerrarSesiónToolStripMenuItem_Click;
            // 
            // puntosToolStripMenuItem
            // 
            puntosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarPuntosToolStripMenuItem, canjearPuntosToolStripMenuItem, verProductosToolStripMenuItem });
            puntosToolStripMenuItem.Name = "puntosToolStripMenuItem";
            puntosToolStripMenuItem.Size = new Size(83, 29);
            puntosToolStripMenuItem.Text = "Puntos";
            // 
            // consultarPuntosToolStripMenuItem
            // 
            consultarPuntosToolStripMenuItem.Name = "consultarPuntosToolStripMenuItem";
            consultarPuntosToolStripMenuItem.Size = new Size(270, 34);
            consultarPuntosToolStripMenuItem.Text = "Consultar puntos";
            consultarPuntosToolStripMenuItem.Click += consultarPuntosToolStripMenuItem_Click;
            // 
            // canjearPuntosToolStripMenuItem
            // 
            canjearPuntosToolStripMenuItem.Name = "canjearPuntosToolStripMenuItem";
            canjearPuntosToolStripMenuItem.Size = new Size(270, 34);
            canjearPuntosToolStripMenuItem.Text = "Canjear puntos";
            canjearPuntosToolStripMenuItem.Click += canjearPuntosToolStripMenuItem_Click;
            // 
            // verProductosToolStripMenuItem
            // 
            verProductosToolStripMenuItem.Name = "verProductosToolStripMenuItem";
            verProductosToolStripMenuItem.Size = new Size(270, 34);
            verProductosToolStripMenuItem.Text = "Ver productos";
            verProductosToolStripMenuItem.Click += verProductosToolStripMenuItem_Click;
            // 
            // administraciónToolStripMenuItem
            // 
            administraciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionarEmpleadosToolStripMenuItem, gestionarPerfilesToolStripMenuItem, gestionarIdiomaToolStripMenuItem, gestionarProductosToolStripMenuItem, gestionarObjetivosToolStripMenuItem });
            administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            administraciónToolStripMenuItem.Size = new Size(147, 29);
            administraciónToolStripMenuItem.Text = "Administración";
            // 
            // gestionarEmpleadosToolStripMenuItem
            // 
            gestionarEmpleadosToolStripMenuItem.Name = "gestionarEmpleadosToolStripMenuItem";
            gestionarEmpleadosToolStripMenuItem.Size = new Size(282, 34);
            gestionarEmpleadosToolStripMenuItem.Text = "Gestionar empleados";
            gestionarEmpleadosToolStripMenuItem.Click += gestionarEmpleadosToolStripMenuItem_Click;
            // 
            // gestionarPerfilesToolStripMenuItem
            // 
            gestionarPerfilesToolStripMenuItem.Name = "gestionarPerfilesToolStripMenuItem";
            gestionarPerfilesToolStripMenuItem.Size = new Size(282, 34);
            gestionarPerfilesToolStripMenuItem.Text = "Gestionar perfiles";
            gestionarPerfilesToolStripMenuItem.Click += gestionarPerfilesToolStripMenuItem_Click;
            // 
            // gestionarIdiomaToolStripMenuItem
            // 
            gestionarIdiomaToolStripMenuItem.Name = "gestionarIdiomaToolStripMenuItem";
            gestionarIdiomaToolStripMenuItem.Size = new Size(282, 34);
            gestionarIdiomaToolStripMenuItem.Text = "Gestionar idioma";
            gestionarIdiomaToolStripMenuItem.Click += gestionarIdiomaToolStripMenuItem_Click;
            // 
            // gestionarProductosToolStripMenuItem
            // 
            gestionarProductosToolStripMenuItem.Name = "gestionarProductosToolStripMenuItem";
            gestionarProductosToolStripMenuItem.Size = new Size(282, 34);
            gestionarProductosToolStripMenuItem.Text = "Gestionar productos";
            gestionarProductosToolStripMenuItem.Click += gestionarProductosToolStripMenuItem_Click;
            // 
            // gestionarObjetivosToolStripMenuItem
            // 
            gestionarObjetivosToolStripMenuItem.Name = "gestionarObjetivosToolStripMenuItem";
            gestionarObjetivosToolStripMenuItem.Size = new Size(282, 34);
            gestionarObjetivosToolStripMenuItem.Text = "Gestionar objetivos";
            gestionarObjetivosToolStripMenuItem.Click += gestionarObjetivosToolStripMenuItem_Click;
            // 
            // reporteríaToolStripMenuItem
            // 
            reporteríaToolStripMenuItem.Name = "reporteríaToolStripMenuItem";
            reporteríaToolStripMenuItem.Size = new Size(109, 29);
            reporteríaToolStripMenuItem.Text = "Reportería";
            reporteríaToolStripMenuItem.Click += reporteríaToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(79, 29);
            ayudaToolStripMenuItem.Text = "Ayuda";
            ayudaToolStripMenuItem.Click += ayudaToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { userToolStrip, toolStripDropDownButton1 });
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
            Text = "SIFRE";
            WindowState = FormWindowState.Maximized;
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
        private ToolStripMenuItem puntosToolStripMenuItem;
        private ToolStripMenuItem iniciarSesiónToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel userToolStrip;
        private ToolStripMenuItem consultarPuntosToolStripMenuItem;
        private ToolStripMenuItem canjearPuntosToolStripMenuItem;
        private ToolStripMenuItem cambiarClaveToolStripMenuItem;
        private ToolStripMenuItem verProductosToolStripMenuItem;
        private ToolStripMenuItem gestionarProductosToolStripMenuItem;
        private ToolStripMenuItem gestionarObjetivosToolStripMenuItem;
        private ToolStripMenuItem reporteríaToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton1;
    }
}