namespace CRUDClientes.View
{
    partial class RelatorioGrafico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioGrafico));
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtPesRelatorio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisaCli = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grafico
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico.Legends.Add(legend1);
            this.grafico.Location = new System.Drawing.Point(25, 116);
            this.grafico.Name = "grafico";
            this.grafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Produtos";
            this.grafico.Series.Add(series1);
            this.grafico.Size = new System.Drawing.Size(642, 300);
            this.grafico.TabIndex = 0;
            this.grafico.Text = "chart1";
            // 
            // txtPesRelatorio
            // 
            this.txtPesRelatorio.Location = new System.Drawing.Point(25, 79);
            this.txtPesRelatorio.Name = "txtPesRelatorio";
            this.txtPesRelatorio.Size = new System.Drawing.Size(242, 20);
            this.txtPesRelatorio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente";
            // 
            // btnPesquisaCli
            // 
            this.btnPesquisaCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisaCli.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisaCli.FlatAppearance.BorderSize = 0;
            this.btnPesquisaCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaCli.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisaCli.Image")));
            this.btnPesquisaCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisaCli.Location = new System.Drawing.Point(275, 75);
            this.btnPesquisaCli.Name = "btnPesquisaCli";
            this.btnPesquisaCli.Size = new System.Drawing.Size(28, 25);
            this.btnPesquisaCli.TabIndex = 61;
            this.btnPesquisaCli.UseVisualStyleBackColor = true;
            this.btnPesquisaCli.Click += new System.EventHandler(this.btnPesquisaCli_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Relatório Produto\\Cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 63;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
            this.menuStrip1.TabIndex = 64;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // RelatorioGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 428);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPesquisaCli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesRelatorio);
            this.Controls.Add(this.grafico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RelatorioGrafico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relação Produto\\Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.TextBox txtPesRelatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisaCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}