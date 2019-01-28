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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            clsCliente cliente = new clsCliente();
            DataTable dt = cliente.ObtemTodos();
            dgvClientes.DataSource = dt;
        }

        //Aciona Pesquisa pelo Cliente
        private void button1_Click(object sender, EventArgs e)
        {
            clsCliente cliente = new clsCliente();
            DataTable dt = cliente.ObtemTodos(strGeral: txtPesCliente.Text);
            dgvClientes.DataSource = dt;
        }

        //Abre a modal para cadastro de um novo cliente
        private void btnNovoCli_Click(object sender, EventArgs e)
        {
            Form1 nvCli = new Form1();
            nvCli.Show();
            this.Hide();
        }

        /*Aciona a tela de alteração de clientes e 
        alimenta a label de controle com o id do cliente selecionado*/
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idCliente = dgvClientes.CurrentRow.Cells["ID"].Value.ToString();
            if (idCliente != "" && idCliente != "0")
            {
                AlterarCliente ac = new AlterarCliente();
                ac.lblIdCliente.Text = idCliente;
                ac.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro, por favor recarregue o programa, ou selecione algum cliente válido");
            }
        }

        #region AÇÕES MENU
        //Abre o Form para cadastro de um novo cliente pela importação de dados pela planilha
        private void novoClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NovoClientePlanilha nvCliPlanilha = new NovoClientePlanilha();
            nvCliPlanilha.Show();
            this.Hide();
        }

        //Abre o Form para alteração de um cliente pela importação de dados pela planilha
        private void alterarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarClientePlanilha altCliPlanilha = new AlterarClientePlanilha();
            altCliPlanilha.Show();
            this.Hide();
        }

        //Abre o relatorio de relação entre produto e cliente
        private void clienteProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioGrafico rg = new RelatorioGrafico();
            rg.Show();
            this.Hide();
        }

        //Abre o relatorio de produtos em grid
        private void produtosGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioGrid rgd = new RelatorioGrid();
            rgd.Show();
            this.Hide();
        }

        //Fecha o sistema
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Abre o Form para cadastro de um novo cliente
        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 nvCli = new Form1();
            nvCli.Show();
            this.Hide();
        }

        //Abre o from de Lista de Clientes
        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();
            cli.Show();
            this.Hide();
        }
        #endregion

    }
}
