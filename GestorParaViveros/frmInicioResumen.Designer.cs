namespace presentacion
{
    partial class frmInicioResumen
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
            pnlMensajito = new Panel();
            lblMensajito = new Label();
            lblTituloMensajito = new Label();
            pnlHistorial = new Panel();
            lblHistorial = new Label();
            pnlProgreso = new Panel();
            lblMensajeProgreso = new Label();
            cpbProgreso = new CircularProgressBar.CircularProgressBar();
            lblProgreso = new Label();
            pnlDeuda = new Panel();
            pbxDeuda = new PictureBox();
            lblMontoDeuda = new Label();
            lblDeuda = new Label();
            pnlIngresos = new Panel();
            pbxIngresos = new PictureBox();
            lblUltimosIngregos = new Label();
            lblMontoIngreso = new Label();
            lblIngresos = new Label();
            pnlMensajito.SuspendLayout();
            pnlHistorial.SuspendLayout();
            pnlProgreso.SuspendLayout();
            pnlDeuda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxDeuda).BeginInit();
            pnlIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxIngresos).BeginInit();
            SuspendLayout();
            // 
            // pnlMensajito
            // 
            pnlMensajito.Anchor = AnchorStyles.Top;
            pnlMensajito.BackColor = Color.FromArgb(37, 42, 64);
            pnlMensajito.Controls.Add(lblMensajito);
            pnlMensajito.Controls.Add(lblTituloMensajito);
            pnlMensajito.Location = new Point(497, 524);
            pnlMensajito.Name = "pnlMensajito";
            pnlMensajito.Size = new Size(412, 92);
            pnlMensajito.TabIndex = 10;
            // 
            // lblMensajito
            // 
            lblMensajito.AutoSize = true;
            lblMensajito.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensajito.ForeColor = Color.FromArgb(159, 151, 176);
            lblMensajito.Location = new Point(17, 43);
            lblMensajito.Name = "lblMensajito";
            lblMensajito.Size = new Size(64, 17);
            lblMensajito.TabIndex = 2;
            lblMensajito.Text = "mensajito";
            // 
            // lblTituloMensajito
            // 
            lblTituloMensajito.AutoSize = true;
            lblTituloMensajito.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloMensajito.ForeColor = Color.White;
            lblTituloMensajito.Location = new Point(16, 9);
            lblTituloMensajito.Name = "lblTituloMensajito";
            lblTituloMensajito.Size = new Size(59, 25);
            lblTituloMensajito.TabIndex = 0;
            lblTituloMensajito.Text = "ALGO";
            // 
            // pnlHistorial
            // 
            pnlHistorial.Anchor = AnchorStyles.Top;
            pnlHistorial.BackColor = Color.FromArgb(37, 42, 64);
            pnlHistorial.Controls.Add(lblHistorial);
            pnlHistorial.Location = new Point(497, 262);
            pnlHistorial.Name = "pnlHistorial";
            pnlHistorial.Size = new Size(503, 246);
            pnlHistorial.TabIndex = 11;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHistorial.ForeColor = Color.White;
            lblHistorial.Location = new Point(17, 18);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(82, 25);
            lblHistorial.TabIndex = 0;
            lblHistorial.Text = "Historial";
            // 
            // pnlProgreso
            // 
            pnlProgreso.Anchor = AnchorStyles.Top;
            pnlProgreso.BackColor = Color.FromArgb(37, 42, 64);
            pnlProgreso.Controls.Add(lblMensajeProgreso);
            pnlProgreso.Controls.Add(cpbProgreso);
            pnlProgreso.Controls.Add(lblProgreso);
            pnlProgreso.Location = new Point(116, 262);
            pnlProgreso.Name = "pnlProgreso";
            pnlProgreso.Size = new Size(258, 314);
            pnlProgreso.TabIndex = 12;
            // 
            // lblMensajeProgreso
            // 
            lblMensajeProgreso.AutoSize = true;
            lblMensajeProgreso.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensajeProgreso.ForeColor = Color.FromArgb(159, 151, 176);
            lblMensajeProgreso.Location = new Point(46, 234);
            lblMensajeProgreso.Name = "lblMensajeProgreso";
            lblMensajeProgreso.Size = new Size(155, 40);
            lblMensajeProgreso.TabIndex = 4;
            lblMensajeProgreso.Text = "Para el siguiente mes \r\nse necesitan: $555.343";
            lblMensajeProgreso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cpbProgreso
            // 
            cpbProgreso.AnimationSpeed = 500;
            cpbProgreso.BackColor = Color.Transparent;
            cpbProgreso.Font = new Font("Yu Gothic", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cpbProgreso.ForeColor = Color.White;
            cpbProgreso.InnerColor = Color.FromArgb(37, 42, 64);
            cpbProgreso.InnerMargin = 2;
            cpbProgreso.InnerWidth = -1;
            cpbProgreso.Location = new Point(51, 65);
            cpbProgreso.MarqueeAnimationSpeed = 2000;
            cpbProgreso.Name = "cpbProgreso";
            cpbProgreso.OuterColor = Color.FromArgb(24, 30, 54);
            cpbProgreso.OuterMargin = -25;
            cpbProgreso.OuterWidth = 26;
            cpbProgreso.ProgressColor = Color.FromArgb(0, 162, 249);
            cpbProgreso.ProgressWidth = 7;
            cpbProgreso.SecondaryFont = new Font("Segoe UI", 36F);
            cpbProgreso.Size = new Size(150, 150);
            cpbProgreso.StartAngle = 270;
            cpbProgreso.SubscriptColor = Color.FromArgb(166, 166, 166);
            cpbProgreso.SubscriptMargin = new Padding(10, -35, 0, 0);
            cpbProgreso.SubscriptText = "";
            cpbProgreso.SuperscriptColor = Color.FromArgb(166, 166, 166);
            cpbProgreso.SuperscriptMargin = new Padding(10, 35, 0, 0);
            cpbProgreso.SuperscriptText = "";
            cpbProgreso.TabIndex = 1;
            cpbProgreso.Text = "67%";
            cpbProgreso.TextMargin = new Padding(5, 8, 0, 0);
            cpbProgreso.Value = 68;
            // 
            // lblProgreso
            // 
            lblProgreso.AutoSize = true;
            lblProgreso.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgreso.ForeColor = Color.White;
            lblProgreso.Location = new Point(16, 21);
            lblProgreso.Name = "lblProgreso";
            lblProgreso.Size = new Size(126, 25);
            lblProgreso.TabIndex = 0;
            lblProgreso.Text = "Cubrir Gastos";
            // 
            // pnlDeuda
            // 
            pnlDeuda.Anchor = AnchorStyles.Top;
            pnlDeuda.BackColor = Color.FromArgb(37, 42, 64);
            pnlDeuda.Controls.Add(pbxDeuda);
            pnlDeuda.Controls.Add(lblMontoDeuda);
            pnlDeuda.Controls.Add(lblDeuda);
            pnlDeuda.Location = new Point(497, 59);
            pnlDeuda.Name = "pnlDeuda";
            pnlDeuda.Size = new Size(334, 130);
            pnlDeuda.TabIndex = 9;
            // 
            // pbxDeuda
            // 
            pbxDeuda.Image = Properties.Resources.pedir_prestado_white;
            pbxDeuda.Location = new Point(216, 18);
            pbxDeuda.Name = "pbxDeuda";
            pbxDeuda.Size = new Size(100, 89);
            pbxDeuda.SizeMode = PictureBoxSizeMode.Zoom;
            pbxDeuda.TabIndex = 3;
            pbxDeuda.TabStop = false;
            // 
            // lblMontoDeuda
            // 
            lblMontoDeuda.AutoSize = true;
            lblMontoDeuda.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMontoDeuda.ForeColor = Color.FromArgb(50, 226, 178);
            lblMontoDeuda.Location = new Point(16, 56);
            lblMontoDeuda.Name = "lblMontoDeuda";
            lblMontoDeuda.Size = new Size(99, 32);
            lblMontoDeuda.TabIndex = 1;
            lblMontoDeuda.Text = "$1234";
            // 
            // lblDeuda
            // 
            lblDeuda.AutoSize = true;
            lblDeuda.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeuda.ForeColor = Color.White;
            lblDeuda.Location = new Point(17, 18);
            lblDeuda.Name = "lblDeuda";
            lblDeuda.Size = new Size(159, 25);
            lblDeuda.TabIndex = 0;
            lblDeuda.Text = "Deuda Proveedor";
            // 
            // pnlIngresos
            // 
            pnlIngresos.Anchor = AnchorStyles.Top;
            pnlIngresos.BackColor = Color.FromArgb(37, 42, 64);
            pnlIngresos.Controls.Add(pbxIngresos);
            pnlIngresos.Controls.Add(lblUltimosIngregos);
            pnlIngresos.Controls.Add(lblMontoIngreso);
            pnlIngresos.Controls.Add(lblIngresos);
            pnlIngresos.Location = new Point(116, 59);
            pnlIngresos.Name = "pnlIngresos";
            pnlIngresos.Size = new Size(326, 130);
            pnlIngresos.TabIndex = 8;
            // 
            // pbxIngresos
            // 
            pbxIngresos.Image = Properties.Resources.dinero_white1;
            pbxIngresos.Location = new Point(203, 16);
            pbxIngresos.Name = "pbxIngresos";
            pbxIngresos.Size = new Size(100, 89);
            pbxIngresos.SizeMode = PictureBoxSizeMode.Zoom;
            pbxIngresos.TabIndex = 3;
            pbxIngresos.TabStop = false;
            // 
            // lblUltimosIngregos
            // 
            lblUltimosIngregos.AutoSize = true;
            lblUltimosIngregos.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUltimosIngregos.ForeColor = Color.FromArgb(159, 151, 176);
            lblUltimosIngregos.Location = new Point(17, 88);
            lblUltimosIngregos.Name = "lblUltimosIngregos";
            lblUltimosIngregos.Size = new Size(98, 17);
            lblUltimosIngregos.TabIndex = 2;
            lblUltimosIngregos.Text = "Ultimos 28 dias";
            // 
            // lblMontoIngreso
            // 
            lblMontoIngreso.AutoSize = true;
            lblMontoIngreso.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMontoIngreso.ForeColor = Color.FromArgb(0, 146, 249);
            lblMontoIngreso.Location = new Point(16, 56);
            lblMontoIngreso.Name = "lblMontoIngreso";
            lblMontoIngreso.Size = new Size(99, 32);
            lblMontoIngreso.TabIndex = 1;
            lblMontoIngreso.Text = "$1234";
            // 
            // lblIngresos
            // 
            lblIngresos.AutoSize = true;
            lblIngresos.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngresos.ForeColor = Color.White;
            lblIngresos.Location = new Point(17, 18);
            lblIngresos.Name = "lblIngresos";
            lblIngresos.Size = new Size(83, 25);
            lblIngresos.TabIndex = 0;
            lblIngresos.Text = "Ingresos";
            // 
            // frmInicioResumen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1048, 711);
            Controls.Add(pnlMensajito);
            Controls.Add(pnlHistorial);
            Controls.Add(pnlProgreso);
            Controls.Add(pnlDeuda);
            Controls.Add(pnlIngresos);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(733, 477);
            Name = "frmInicioResumen";
            Text = "frmInicioResumen";
            pnlMensajito.ResumeLayout(false);
            pnlMensajito.PerformLayout();
            pnlHistorial.ResumeLayout(false);
            pnlHistorial.PerformLayout();
            pnlProgreso.ResumeLayout(false);
            pnlProgreso.PerformLayout();
            pnlDeuda.ResumeLayout(false);
            pnlDeuda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxDeuda).EndInit();
            pnlIngresos.ResumeLayout(false);
            pnlIngresos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxIngresos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMensajito;
        private Label lblMensajito;
        private Label lblTituloMensajito;
        private Panel pnlHistorial;
        private Label lblHistorial;
        private Panel pnlProgreso;
        private Label lblMensajeProgreso;
        private CircularProgressBar.CircularProgressBar cpbProgreso;
        private Label lblProgreso;
        private Panel pnlDeuda;
        private PictureBox pbxDeuda;
        private Label lblMontoDeuda;
        private Label lblDeuda;
        private Panel pnlIngresos;
        private PictureBox pbxIngresos;
        private Label lblUltimosIngregos;
        private Label lblMontoIngreso;
        private Label lblIngresos;
    }
}