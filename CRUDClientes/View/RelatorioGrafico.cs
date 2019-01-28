using CRUDClientes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDClientes.View
{
    public partial class RelatorioGrafico : Form
    {
        public RelatorioGrafico()
        {
            InitializeComponent();
            LoadRelatorio();
        }

        //Aciona o evento de composição do gráfico
        private void btnPesquisaCli_Click(object sender, EventArgs e)
        {
            LoadRelatorio();
        }

        //Compõe o gráfico, com as informações vindas do SELECT no DataTable
        private void LoadRelatorio()
        {
            clsCliente cliente = new clsCliente();
            DataTable dt = cliente.ObtemTodos(strGeral: txtPesRelatorio.Text, qntProds: true);
            if (dt != null && dt.Rows.Count > 0)
            {
                grafico.Series["Produtos"].Points.Clear();
                foreach (DataRow i in dt.Rows)
                {
                    grafico.Series["Produtos"].Points.AddXY(i["Nome"].ToString(), i["QntDeProdutos"].ToString());
                }
            }
        }

        //Volta para a tela inicial
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes cliente = new Clientes();
            cliente.Show();
        }

        //Fecha o sistema
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
