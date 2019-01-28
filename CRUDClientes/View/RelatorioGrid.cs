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
    public partial class RelatorioGrid : Form
    {
        public RelatorioGrid()
        {
            InitializeComponent();
            LoadProdutos();
        }

        //Retorna para tela inicial
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes cliente = new Clientes();
            cliente.Show();
        }

        //Carrega a grid de produtos com os dados vindos do SELECT recebendo os parâmetros se necessário
        private void LoadProdutos(string strgeral = "", string cliente = "" ,string dataInicial = "", string dataFinal = "")
        {
            clsVinculoProduto vinculoProduto = new clsVinculoProduto();
            DataTable dt = vinculoProduto.ObtemTodos(strGeral: strgeral, cliente: cliente, dataInicial: dataInicial, datafinal: dataFinal);
            dgvProdutos.DataSource = dt;
        }

        //Realiza a passagem dos parâmetros dependendo do filtro acionado
        private void btnPesquisaProd_Click(object sender, EventArgs e)
        {
            LoadProdutos(txtProduto.Text, txtCliente.Text, txtDtIni.Text, txtDtFim.Text);
        }

        //Fecha o sistema
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
