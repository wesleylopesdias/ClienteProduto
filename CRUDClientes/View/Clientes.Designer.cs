namespace CRUDClientes.View
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarPlanilhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relátorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCadCli = new System.Windows.Forms.Label();
            this.txtPesCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNovoCli = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.relátorioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeClientesToolStripMenuItem,
            this.novoClienteToolStripMenuItem,
            this.importarPlanilhaToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // listaDeClientesToolStripMenuItem
            // 
            this.listaDeClientesToolStripMenuItem.Name = "listaDeClientesToolStripMenuItem";
            this.listaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.listaDeClientesToolStripMenuItem.Text = "Lista de Clientes";
            this.listaDeClientesToolStripMenuItem.Click += new System.EventHandler(this.listaDeClientesToolStripMenuItem_Click);
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.novoClienteToolStripMenuItem.Text = "Novo Cliente";
            this.novoClienteToolStripMenuItem.Click += new System.EventHandler(this.novoClienteToolStripMenuItem_Click);
            // 
            // importarPlanilhaToolStripMenuItem
            // 
            this.importarPlanilhaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoClienteToolStripMenuItem1,
            this.alterarClienteToolStripMenuItem});
            this.importarPlanilhaToolStripMenuItem.Name = "importarPlanilhaToolStripMenuItem";
            this.importarPlanilhaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.importarPlanilhaToolStripMenuItem.Text = "Importar Planilha";
            // 
            // novoClienteToolStripMenuItem1
            // 
            this.novoClienteToolStripMenuItem1.Name = "novoClienteToolStripMenuItem1";
            this.novoClienteToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.novoClienteToolStripMenuItem1.Text = "Novo Cliente";
            this.novoClienteToolStripMenuItem1.Click += new System.EventHandler(this.novoClienteToolStripMenuItem1_Click);
            // 
            // alterarClienteToolStripMenuItem
            // 
            this.alterarClienteToolStripMenuItem.Name = "alterarClienteToolStripMenuItem";
            this.alterarClienteToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.alterarClienteToolStripMenuItem.Text = "Alterar Cliente";
            this.alterarClienteToolStripMenuItem.Click += new System.EventHandler(this.alterarClienteToolStripMenuItem_Click);
            // 
            // relátorioToolStripMenuItem
            // 
            this.relátorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteProdutoToolStripMenuItem,
            this.produtosGridToolStripMenuItem});
            this.relátorioToolStripMenuItem.Name = "relátorioToolStripMenuItem";
            this.relátorioToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relátorioToolStripMenuItem.Text = "Relátorios";
            // 
            // clienteProdutoToolStripMenuItem
            // 
            this.clienteProdutoToolStripMenuItem.Name = "clienteProdutoToolStripMenuItem";
            this.clienteProdutoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.clienteProdutoToolStripMenuItem.Text = "Produto/Cliente";
            this.clienteProdutoToolStripMenuItem.Click += new System.EventHandler(this.clienteProdutoToolStripMenuItem_Click);
            // 
            // produtosGridToolStripMenuItem
            // 
            this.produtosGridToolStripMenuItem.Name = "produtosGridToolStripMenuItem";
            this.produtosGridToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.produtosGridToolStripMenuItem.Text = "Produtos Grid";
            this.produtosGridToolStripMenuItem.Click += new System.EventHandler(this.produtosGridToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(42, 140);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(610, 243);
            this.dgvClientes.TabIndex = 29;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(173, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 1);
            this.panel1.TabIndex = 31;
            // 
            // lblCadCli
            // 
            this.lblCadCli.AutoSize = true;
            this.lblCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCli.Location = new System.Drawing.Point(261, 39);
            this.lblCadCli.Name = "lblCadCli";
            this.lblCadCli.Size = new System.Drawing.Size(186, 29);
            this.lblCadCli.TabIndex = 30;
            this.lblCadCli.Text = "Lista de clientes";
            // 
            // txtPesCliente
            // 
            this.txtPesCliente.Location = new System.Drawing.Point(42, 104);
            this.txtPesCliente.Name = "txtPesCliente";
            this.txtPesCliente.Size = new System.Drawing.Size(325, 20);
            this.txtPesCliente.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Pesquisa por nome e email";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(373, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 25);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNovoCli
            // 
            this.btnNovoCli.Location = new System.Drawing.Point(510, 104);
            this.btnNovoCli.Name = "btnNovoCli";
            this.btnNovoCli.Size = new System.Drawing.Size(142, 23);
            this.btnNovoCli.TabIndex = 35;
            this.btnNovoCli.Text = "Novo Cliente +";
            this.btnNovoCli.UseVisualStyleBackColor = true;
            this.btnNovoCli.Click += new System.EventHandler(this.btnNovoCli_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Para editar cliente, basta selecionar alguma célula da linha do mesmo";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 409);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNovoCli);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCadCli);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relátorioToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCadCli;
        private System.Windows.Forms.TextBox txtPesCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNovoCli;
        private System.Windows.Forms.ToolStripMenuItem listaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarPlanilhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alterarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}