namespace CRUDClientes.View
{
    partial class AlterarClientePlanilha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarClientePlanilha));
            this.btnInformcaoAlt = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCadCli = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInformcaoAlt
            // 
            this.btnInformcaoAlt.FlatAppearance.BorderSize = 0;
            this.btnInformcaoAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformcaoAlt.Image = ((System.Drawing.Image)(resources.GetObject("btnInformcaoAlt.Image")));
            this.btnInformcaoAlt.Location = new System.Drawing.Point(333, 146);
            this.btnInformcaoAlt.Name = "btnInformcaoAlt";
            this.btnInformcaoAlt.Size = new System.Drawing.Size(19, 31);
            this.btnInformcaoAlt.TabIndex = 44;
            this.btnInformcaoAlt.UseVisualStyleBackColor = true;
            this.btnInformcaoAlt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(254, 218);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 31);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Voltar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(32, 218);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(98, 31);
            this.btnImportar.TabIndex = 42;
            this.btnImportar.Text = "Importar dados";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(53, 146);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(277, 31);
            this.btnSelecionar.TabIndex = 41;
            this.btnSelecionar.Text = "Selecionar...";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(32, 112);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.ReadOnly = true;
            this.txtCaminho.Size = new System.Drawing.Size(320, 20);
            this.txtCaminho.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 1);
            this.panel1.TabIndex = 38;
            // 
            // lblCadCli
            // 
            this.lblCadCli.AutoSize = true;
            this.lblCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCli.Location = new System.Drawing.Point(15, 45);
            this.lblCadCli.Name = "lblCadCli";
            this.lblCadCli.Size = new System.Drawing.Size(369, 29);
            this.lblCadCli.TabIndex = 37;
            this.lblCadCli.Text = "Alteração de clientes por planilha";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(395, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // AlterarClientePlanilha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 288);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnInformcaoAlt);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCadCli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AlterarClientePlanilha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Cliente Planilha";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInformcaoAlt;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCadCli;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}