namespace GestorParaViveros
{
    partial class frmVentanaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            btnConfiguracion = new Button();
            btnGastos = new Button();
            btnCompras = new Button();
            btnInventario = new Button();
            btnVentas = new Button();
            btnAnaliticas = new Button();
            btnInicio = new Button();
            pnlUsuarioInfo = new Panel();
            lblRolUsuario = new Label();
            lblNombreUsuario = new Label();
            pbxImagenPerfil = new PictureBox();
            pnlNav = new Panel();
            lblTitulo = new Label();
            pnlBarraSuperior = new Panel();
            btnCerrar = new Button();
            pnlCargadorDeFormularios = new Panel();
            pnlMenu.SuspendLayout();
            pnlUsuarioInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxImagenPerfil).BeginInit();
            pnlBarraSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(24, 30, 54);
            pnlMenu.Controls.Add(btnConfiguracion);
            pnlMenu.Controls.Add(btnGastos);
            pnlMenu.Controls.Add(btnCompras);
            pnlMenu.Controls.Add(btnInventario);
            pnlMenu.Controls.Add(btnVentas);
            pnlMenu.Controls.Add(btnAnaliticas);
            pnlMenu.Controls.Add(btnInicio);
            pnlMenu.Controls.Add(pnlUsuarioInfo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(186, 577);
            pnlMenu.TabIndex = 0;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Dock = DockStyle.Bottom;
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfiguracion.ForeColor = Color.FromArgb(0, 126, 249);
            btnConfiguracion.Image = presentacion.Properties.Resources.ajuste_white;
            btnConfiguracion.Location = new Point(0, 535);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(186, 42);
            btnConfiguracion.TabIndex = 7;
            btnConfiguracion.Text = "CONFIGURACION";
            btnConfiguracion.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnConfiguracion.UseVisualStyleBackColor = true;
            btnConfiguracion.Click += btnConfiguracion_Click;
            btnConfiguracion.Leave += btnConfiguracion_Leave;
            // 
            // btnGastos
            // 
            btnGastos.Dock = DockStyle.Top;
            btnGastos.FlatAppearance.BorderSize = 0;
            btnGastos.FlatStyle = FlatStyle.Flat;
            btnGastos.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGastos.ForeColor = Color.FromArgb(0, 126, 249);
            btnGastos.Image = presentacion.Properties.Resources.medico_white;
            btnGastos.Location = new Point(0, 370);
            btnGastos.Name = "btnGastos";
            btnGastos.Size = new Size(186, 42);
            btnGastos.TabIndex = 6;
            btnGastos.Text = "GASTOS";
            btnGastos.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGastos.UseVisualStyleBackColor = true;
            btnGastos.Click += btnGastos_Click;
            btnGastos.Leave += btnGastos_Leave;
            // 
            // btnCompras
            // 
            btnCompras.Dock = DockStyle.Top;
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompras.ForeColor = Color.FromArgb(0, 126, 249);
            btnCompras.Image = presentacion.Properties.Resources.carrito_white;
            btnCompras.Location = new Point(0, 328);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(186, 42);
            btnCompras.TabIndex = 5;
            btnCompras.Text = "COMPRAS";
            btnCompras.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCompras.UseVisualStyleBackColor = true;
            btnCompras.Click += btnCompras_Click;
            btnCompras.Leave += btnCompras_Leave;
            // 
            // btnInventario
            // 
            btnInventario.Dock = DockStyle.Top;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventario.ForeColor = Color.FromArgb(0, 126, 249);
            btnInventario.Image = presentacion.Properties.Resources.planta_white;
            btnInventario.Location = new Point(0, 286);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(186, 42);
            btnInventario.TabIndex = 4;
            btnInventario.Text = "INVENTARIO";
            btnInventario.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            btnInventario.Leave += btnInventario_Leave;
            // 
            // btnVentas
            // 
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = Color.FromArgb(0, 126, 249);
            btnVentas.Image = presentacion.Properties.Resources.vender_white;
            btnVentas.Location = new Point(0, 244);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(186, 42);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "VENDER";
            btnVentas.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            btnVentas.Leave += btnVentas_Leave;
            // 
            // btnAnaliticas
            // 
            btnAnaliticas.Dock = DockStyle.Top;
            btnAnaliticas.FlatAppearance.BorderSize = 0;
            btnAnaliticas.FlatStyle = FlatStyle.Flat;
            btnAnaliticas.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnaliticas.ForeColor = Color.FromArgb(0, 126, 249);
            btnAnaliticas.Image = presentacion.Properties.Resources.analitica_white;
            btnAnaliticas.Location = new Point(0, 202);
            btnAnaliticas.Name = "btnAnaliticas";
            btnAnaliticas.Size = new Size(186, 42);
            btnAnaliticas.TabIndex = 2;
            btnAnaliticas.Text = "ANALITICAS";
            btnAnaliticas.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAnaliticas.UseVisualStyleBackColor = true;
            btnAnaliticas.Click += btnAnaliticas_Click;
            btnAnaliticas.Leave += btnAnaliticas_Leave;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.FromArgb(0, 126, 249);
            btnInicio.Image = presentacion.Properties.Resources.home_white;
            btnInicio.Location = new Point(0, 160);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(186, 42);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "INICIO";
            btnInicio.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            btnInicio.Leave += btnInicio_Leave;
            // 
            // pnlUsuarioInfo
            // 
            pnlUsuarioInfo.Controls.Add(lblRolUsuario);
            pnlUsuarioInfo.Controls.Add(lblNombreUsuario);
            pnlUsuarioInfo.Controls.Add(pbxImagenPerfil);
            pnlUsuarioInfo.Dock = DockStyle.Top;
            pnlUsuarioInfo.Location = new Point(0, 0);
            pnlUsuarioInfo.Name = "pnlUsuarioInfo";
            pnlUsuarioInfo.Size = new Size(186, 160);
            pnlUsuarioInfo.TabIndex = 0;
            // 
            // lblRolUsuario
            // 
            lblRolUsuario.AutoSize = true;
            lblRolUsuario.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRolUsuario.ForeColor = Color.FromArgb(158, 161, 178);
            lblRolUsuario.Location = new Point(29, 129);
            lblRolUsuario.Name = "lblRolUsuario";
            lblRolUsuario.Size = new Size(126, 13);
            lblRolUsuario.TabIndex = 2;
            lblRolUsuario.Text = "Some User Text here";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreUsuario.ForeColor = Color.FromArgb(0, 156, 149);
            lblNombreUsuario.Location = new Point(45, 100);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(93, 18);
            lblNombreUsuario.TabIndex = 1;
            lblNombreUsuario.Text = "User Name";
            // 
            // pbxImagenPerfil
            // 
            pbxImagenPerfil.Image = presentacion.Properties.Resources.perfil;
            pbxImagenPerfil.Location = new Point(60, 22);
            pbxImagenPerfil.Name = "pbxImagenPerfil";
            pbxImagenPerfil.Size = new Size(63, 63);
            pbxImagenPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            pbxImagenPerfil.TabIndex = 0;
            pbxImagenPerfil.TabStop = false;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);
            pnlNav.Location = new Point(0, 193);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 100);
            pnlNav.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(158, 161, 176);
            lblTitulo.Location = new Point(6, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(87, 32);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Inicio";
            // 
            // pnlBarraSuperior
            // 
            pnlBarraSuperior.Controls.Add(btnCerrar);
            pnlBarraSuperior.Controls.Add(lblTitulo);
            pnlBarraSuperior.Dock = DockStyle.Top;
            pnlBarraSuperior.Location = new Point(186, 0);
            pnlBarraSuperior.Name = "pnlBarraSuperior";
            pnlBarraSuperior.Size = new Size(765, 50);
            pnlBarraSuperior.TabIndex = 8;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = presentacion.Properties.Resources.cruz_white;
            btnCerrar.Location = new Point(719, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(46, 41);
            btnCerrar.TabIndex = 3;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pnlCargadorDeFormularios
            // 
            pnlCargadorDeFormularios.Dock = DockStyle.Bottom;
            pnlCargadorDeFormularios.Location = new Point(186, 100);
            pnlCargadorDeFormularios.Name = "pnlCargadorDeFormularios";
            pnlCargadorDeFormularios.Size = new Size(765, 477);
            pnlCargadorDeFormularios.TabIndex = 9;
            // 
            // frmVentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(pnlCargadorDeFormularios);
            Controls.Add(pnlBarraSuperior);
            Controls.Add(pnlNav);
            Controls.Add(pnlMenu);
            ForeColor = Color.FromArgb(37, 42, 64);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmVentanaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            pnlMenu.ResumeLayout(false);
            pnlUsuarioInfo.ResumeLayout(false);
            pnlUsuarioInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxImagenPerfil).EndInit();
            pnlBarraSuperior.ResumeLayout(false);
            pnlBarraSuperior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlUsuarioInfo;
        private PictureBox pbxImagenPerfil;
        private Label lblRolUsuario;
        private Label lblNombreUsuario;
        private Button btnInventario;
        private Button btnVentas;
        private Button btnAnaliticas;
        private Button btnInicio;
        private Button btnConfiguracion;
        private Button btnGastos;
        private Button btnCompras;
        private Panel pnlNav;
        private Label lblTitulo;
        private TextBox textBox1;
        private Button button1;
        private Panel pnlBarraSuperior;
        private Button btnCerrar;
        private Panel pnlCargadorDeFormularios;
    }
}
