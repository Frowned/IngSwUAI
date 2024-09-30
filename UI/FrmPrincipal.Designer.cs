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
            gestionarBackupToolStripMenuItem = new ToolStripMenuItem();
            bitacoraEventosToolStripMenuItem = new ToolStripMenuItem();
            reporteríaToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            userToolStrip = new ToolStripStatusLabel();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            bitacoraProductosToolStripMenuItem = new ToolStripMenuItem();
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
            inicioToolStripMenuItem.Tag = "MENU_START";
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // iniciarSesiónToolStripMenuItem
            // 
            iniciarSesiónToolStripMenuItem.Name = "iniciarSesiónToolStripMenuItem";
            iniciarSesiónToolStripMenuItem.Size = new Size(224, 34);
            iniciarSesiónToolStripMenuItem.Tag = "MENU_LOGIN";
            iniciarSesiónToolStripMenuItem.Text = "Iniciar sesión";
            iniciarSesiónToolStripMenuItem.Click += iniciarSesiónToolStripMenuItem_Click;
            // 
            // cambiarClaveToolStripMenuItem
            // 
            cambiarClaveToolStripMenuItem.Name = "cambiarClaveToolStripMenuItem";
            cambiarClaveToolStripMenuItem.Size = new Size(224, 34);
            cambiarClaveToolStripMenuItem.Tag = "MENU_CHANGE_PASSWORD";
            cambiarClaveToolStripMenuItem.Text = "Cambiar clave";
            cambiarClaveToolStripMenuItem.Click += cambiarClaveToolStripMenuItem_Click;
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(224, 34);
            cerrarSesiónToolStripMenuItem.Tag = "MENU_LOGOUT";
            cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            cerrarSesiónToolStripMenuItem.Click += cerrarSesiónToolStripMenuItem_Click;
            // 
            // puntosToolStripMenuItem
            // 
            puntosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarPuntosToolStripMenuItem, canjearPuntosToolStripMenuItem, verProductosToolStripMenuItem });
            puntosToolStripMenuItem.Name = "puntosToolStripMenuItem";
            puntosToolStripMenuItem.Size = new Size(83, 29);
            puntosToolStripMenuItem.Tag = "MENU_POINTS";
            puntosToolStripMenuItem.Text = "Puntos";
            // 
            // consultarPuntosToolStripMenuItem
            // 
            consultarPuntosToolStripMenuItem.Name = "consultarPuntosToolStripMenuItem";
            consultarPuntosToolStripMenuItem.Size = new Size(250, 34);
            consultarPuntosToolStripMenuItem.Tag = "MENU_CHECK_POINTS";
            consultarPuntosToolStripMenuItem.Text = "Consultar puntos";
            consultarPuntosToolStripMenuItem.Click += consultarPuntosToolStripMenuItem_Click;
            // 
            // canjearPuntosToolStripMenuItem
            // 
            canjearPuntosToolStripMenuItem.Name = "canjearPuntosToolStripMenuItem";
            canjearPuntosToolStripMenuItem.Size = new Size(250, 34);
            canjearPuntosToolStripMenuItem.Tag = "MENU_EXCHANGE_POINTS";
            canjearPuntosToolStripMenuItem.Text = "Canjear puntos";
            canjearPuntosToolStripMenuItem.Click += canjearPuntosToolStripMenuItem_Click;
            // 
            // verProductosToolStripMenuItem
            // 
            verProductosToolStripMenuItem.Name = "verProductosToolStripMenuItem";
            verProductosToolStripMenuItem.Size = new Size(250, 34);
            verProductosToolStripMenuItem.Tag = "MENU_VIEW_PRODUCTS";
            verProductosToolStripMenuItem.Text = "Ver productos";
            verProductosToolStripMenuItem.Click += verProductosToolStripMenuItem_Click;
            // 
            // administraciónToolStripMenuItem
            // 
            administraciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionarEmpleadosToolStripMenuItem, gestionarPerfilesToolStripMenuItem, gestionarIdiomaToolStripMenuItem, gestionarProductosToolStripMenuItem, gestionarObjetivosToolStripMenuItem, gestionarBackupToolStripMenuItem, bitacoraEventosToolStripMenuItem, bitacoraProductosToolStripMenuItem });
            administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            administraciónToolStripMenuItem.Size = new Size(147, 29);
            administraciónToolStripMenuItem.Tag = "MENU_ADMIN";
            administraciónToolStripMenuItem.Text = "Administración";
            // 
            // gestionarEmpleadosToolStripMenuItem
            // 
            gestionarEmpleadosToolStripMenuItem.Name = "gestionarEmpleadosToolStripMenuItem";
            gestionarEmpleadosToolStripMenuItem.Size = new Size(282, 34);
            gestionarEmpleadosToolStripMenuItem.Tag = "MANAGE_EMPLOYEES";
            gestionarEmpleadosToolStripMenuItem.Text = "Gestionar empleados";
            gestionarEmpleadosToolStripMenuItem.Click += gestionarEmpleadosToolStripMenuItem_Click;
            // 
            // gestionarPerfilesToolStripMenuItem
            // 
            gestionarPerfilesToolStripMenuItem.Name = "gestionarPerfilesToolStripMenuItem";
            gestionarPerfilesToolStripMenuItem.Size = new Size(282, 34);
            gestionarPerfilesToolStripMenuItem.Tag = "MANAGE_ROLES";
            gestionarPerfilesToolStripMenuItem.Text = "Gestionar perfiles";
            gestionarPerfilesToolStripMenuItem.Click += gestionarPerfilesToolStripMenuItem_Click;
            // 
            // gestionarIdiomaToolStripMenuItem
            // 
            gestionarIdiomaToolStripMenuItem.Name = "gestionarIdiomaToolStripMenuItem";
            gestionarIdiomaToolStripMenuItem.Size = new Size(282, 34);
            gestionarIdiomaToolStripMenuItem.Tag = "MANAGE_LANGUAGE";
            gestionarIdiomaToolStripMenuItem.Text = "Gestionar idioma";
            gestionarIdiomaToolStripMenuItem.Click += gestionarIdiomaToolStripMenuItem_Click;
            // 
            // gestionarProductosToolStripMenuItem
            // 
            gestionarProductosToolStripMenuItem.Name = "gestionarProductosToolStripMenuItem";
            gestionarProductosToolStripMenuItem.Size = new Size(282, 34);
            gestionarProductosToolStripMenuItem.Tag = "MANAGE_PRODUCTS";
            gestionarProductosToolStripMenuItem.Text = "Gestionar productos";
            gestionarProductosToolStripMenuItem.Click += gestionarProductosToolStripMenuItem_Click;
            // 
            // gestionarObjetivosToolStripMenuItem
            // 
            gestionarObjetivosToolStripMenuItem.Name = "gestionarObjetivosToolStripMenuItem";
            gestionarObjetivosToolStripMenuItem.Size = new Size(282, 34);
            gestionarObjetivosToolStripMenuItem.Tag = "MANAGE_OBJECTIVES";
            gestionarObjetivosToolStripMenuItem.Text = "Gestionar objetivos";
            gestionarObjetivosToolStripMenuItem.Click += gestionarObjetivosToolStripMenuItem_Click;
            // 
            // gestionarBackupToolStripMenuItem
            // 
            gestionarBackupToolStripMenuItem.Name = "gestionarBackupToolStripMenuItem";
            gestionarBackupToolStripMenuItem.Size = new Size(282, 34);
            gestionarBackupToolStripMenuItem.Text = "Gestionar backup";
            gestionarBackupToolStripMenuItem.Click += gestionarBackupToolStripMenuItem_Click;
            // 
            // bitacoraEventosToolStripMenuItem
            // 
            bitacoraEventosToolStripMenuItem.Name = "bitacoraEventosToolStripMenuItem";
            bitacoraEventosToolStripMenuItem.Size = new Size(282, 34);
            bitacoraEventosToolStripMenuItem.Text = "Bitácora Eventos";
            bitacoraEventosToolStripMenuItem.Click += bitacoraEventosToolStripMenuItem_Click;
            // 
            // reporteríaToolStripMenuItem
            // 
            reporteríaToolStripMenuItem.Name = "reporteríaToolStripMenuItem";
            reporteríaToolStripMenuItem.Size = new Size(109, 29);
            reporteríaToolStripMenuItem.Tag = "MENU_REPORTS";
            reporteríaToolStripMenuItem.Text = "Reportería";
            reporteríaToolStripMenuItem.Click += reporteríaToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(79, 29);
            ayudaToolStripMenuItem.Tag = "MENU_HELP";
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
            // bitacoraProductosToolStripMenuItem
            // 
            bitacoraProductosToolStripMenuItem.Name = "bitacoraProductosToolStripMenuItem";
            bitacoraProductosToolStripMenuItem.Size = new Size(282, 34);
            bitacoraProductosToolStripMenuItem.Text = "Bitácora Productos";
            bitacoraProductosToolStripMenuItem.Click += bitacoraProductosToolStripMenuItem_Click;
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
        private ToolStripMenuItem gestionarBackupToolStripMenuItem;
        private ToolStripMenuItem bitacoraEventosToolStripMenuItem;
        private ToolStripMenuItem bitacoraProductosToolStripMenuItem;
    }
}