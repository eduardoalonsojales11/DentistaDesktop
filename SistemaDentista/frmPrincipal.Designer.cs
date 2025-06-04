
namespace SistemaDentista
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDentista = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.agendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgDentistas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.MAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSuporte = new System.Windows.Forms.ToolStripMenuItem();
            this.MSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.agendasToolStripMenuItem,
            this.MAjuda,
            this.MSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDentista,
            this.menuPaciente,
            this.menuConsulta});
            this.cadastrosToolStripMenuItem.Image = global::SistemaDentista.Properties.Resources._9133514_signup_register_login_icon;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // menuDentista
            // 
            this.menuDentista.Name = "menuDentista";
            this.menuDentista.Size = new System.Drawing.Size(224, 26);
            this.menuDentista.Text = "Dentista";
            this.menuDentista.Click += new System.EventHandler(this.menuDentista_Click);
            // 
            // menuPaciente
            // 
            this.menuPaciente.Name = "menuPaciente";
            this.menuPaciente.Size = new System.Drawing.Size(224, 26);
            this.menuPaciente.Text = "Paciente";
            this.menuPaciente.Click += new System.EventHandler(this.menuPaciente_Click);
            // 
            // menuConsulta
            // 
            this.menuConsulta.Name = "menuConsulta";
            this.menuConsulta.Size = new System.Drawing.Size(224, 26);
            this.menuConsulta.Text = "Consulta";
            // 
            // agendasToolStripMenuItem
            // 
            this.agendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAgDentistas,
            this.menuAgPacientes,
            this.menuAgConsultas});
            this.agendasToolStripMenuItem.Image = global::SistemaDentista.Properties.Resources._1622828_calendar_date_event_month_plan_icon;
            this.agendasToolStripMenuItem.Name = "agendasToolStripMenuItem";
            this.agendasToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.agendasToolStripMenuItem.Text = "Agendas";
            // 
            // menuAgDentistas
            // 
            this.menuAgDentistas.Name = "menuAgDentistas";
            this.menuAgDentistas.Size = new System.Drawing.Size(224, 26);
            this.menuAgDentistas.Text = "Dentistas";
            this.menuAgDentistas.Click += new System.EventHandler(this.menuAgDentistas_Click);
            // 
            // menuAgPacientes
            // 
            this.menuAgPacientes.Name = "menuAgPacientes";
            this.menuAgPacientes.Size = new System.Drawing.Size(224, 26);
            this.menuAgPacientes.Text = "Pacientes";
            this.menuAgPacientes.Click += new System.EventHandler(this.menuAgPacientes_Click);
            // 
            // menuAgConsultas
            // 
            this.menuAgConsultas.Name = "menuAgConsultas";
            this.menuAgConsultas.Size = new System.Drawing.Size(224, 26);
            this.menuAgConsultas.Text = "Consultas";
            // 
            // MAjuda
            // 
            this.MAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSuporte});
            this.MAjuda.Image = global::SistemaDentista.Properties.Resources._40797_help_blue_icon;
            this.MAjuda.Name = "MAjuda";
            this.MAjuda.Size = new System.Drawing.Size(82, 24);
            this.MAjuda.Text = "Ajuda";
            // 
            // menuSuporte
            // 
            this.menuSuporte.Name = "menuSuporte";
            this.menuSuporte.Size = new System.Drawing.Size(144, 26);
            this.menuSuporte.Text = "Suporte";
            // 
            // MSair
            // 
            this.MSair.Image = global::SistemaDentista.Properties.Resources._618316_arrow_exit_logout_sign_out_icon;
            this.MSair.Name = "MSair";
            this.MSair.Size = new System.Drawing.Size(68, 24);
            this.MSair.Text = "Sair";
            this.MSair.Click += new System.EventHandler(this.MSair_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Odonto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MAjuda;
        private System.Windows.Forms.ToolStripMenuItem MSair;
        private System.Windows.Forms.ToolStripMenuItem menuDentista;
        private System.Windows.Forms.ToolStripMenuItem menuPaciente;
        private System.Windows.Forms.ToolStripMenuItem menuConsulta;
        private System.Windows.Forms.ToolStripMenuItem menuAgDentistas;
        private System.Windows.Forms.ToolStripMenuItem menuAgPacientes;
        private System.Windows.Forms.ToolStripMenuItem menuAgConsultas;
        private System.Windows.Forms.ToolStripMenuItem menuSuporte;
    }
}

