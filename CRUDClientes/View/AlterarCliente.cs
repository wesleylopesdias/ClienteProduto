using CRUDClientes.Model;
using CRUDClientes.Model.Helper;
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
    public partial class AlterarCliente : Form
    {
        public AlterarCliente()
        {
            InitializeComponent();            
        }

        //Compõe o cliente com as informações vindas do SELECT
        private void LoadCliente(int IdCliente)
        {
            clsCliente cliente = new clsCliente();
            if (IdCliente != 0)
            {
                DataTable dtCliente = cliente.ObtemTodos(IdCliente);
                if (dtCliente != null & dtCliente.Rows.Count > 0)
                {
                    txtNome.Text = dtCliente.Rows[0]["Nome"].ToString();
                    txtEmail.Text = dtCliente.Rows[0]["Email"].ToString();
                    txtTelefone.Text = dtCliente.Rows[0]["Telefone"].ToString();
                    txtCelular.Text = dtCliente.Rows[0]["Celular"].ToString();
                    txtCep.Text = dtCliente.Rows[0]["CEP"].ToString();
                    txtNum.Text = dtCliente.Rows[0]["Numero"].ToString();
                    txtEstado.Text = dtCliente.Rows[0]["UF"].ToString();
                    txtCidade.Text = dtCliente.Rows[0]["Cidade"].ToString();
                    txtBairro.Text = dtCliente.Rows[0]["Bairro"].ToString();
                    txtLogradouro.Text = dtCliente.Rows[0]["Logradouro"].ToString();
                }
                else
                {
                    MessageBox.Show("Não foi possivel carregar cliente");
                }
            }
            else
            {
                MessageBox.Show("Não foi possivel carregar cliente");
            }

        }

        //Carrega a referencia e a utiliza para pesquisar o CEP e compor os campos
        private void LocalizarCEP()
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(txtCep.Text);
                    txtLogradouro.Text = resultado.end;
                    txtCidade.Text = resultado.cidade;
                    txtBairro.Text = resultado.bairro;
                    txtEstado.Text = resultado.uf;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Cancela a operação
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes cliente = new Clientes();
            cliente.Show();
        }

        //Altera o cliente selecionado
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            clsHelper helper = new clsHelper();
            if (txtNome.Text == "")
            {
                MessageBox.Show("O campo nome é obrigatório");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("O campo email é obrigatório");
            }
            else if (!helper.validaEmail(txtEmail.Text))
            {
                MessageBox.Show("Informe um email válido");
            }
            else if (txtLogradouro.Text == "")
            {
                MessageBox.Show("O campo logradouro é obrigatório");
            }
            else
            {
                clsCliente cliente = new clsCliente();
                cliente.cliNome = txtNome.Text;
                cliente.cliEmail = txtEmail.Text;
                cliente.cliTelefone = txtTelefone.Text;
                cliente.cliCelular = txtCelular.Text;
                cliente.cliCEP = txtCep.Text;
                cliente.cliNumero = txtNum.Text;
                cliente.cliEstado = txtEstado.Text;
                cliente.cliCidade = txtCidade.Text;
                cliente.cliBairro = txtBairro.Text;
                cliente.cliLogradouro = txtLogradouro.Text;
                cliente.idCliente = Convert.ToInt32(lblIdCliente.Text);
                if (cliente.AtualizarRegistro(cliente))
                {
                    MessageBox.Show("Cliente alterado com sucesso.");
                    Clientes cli = new Clientes();
                    cli.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Não foi possivel alterar cliente.");
                }
            }
        }

        //Aciona o evento de pesquisa de CEP
        private void button1_Click(object sender, EventArgs e)
        {
            LocalizarCEP();
        }

        //No Load do From carrega as informações do cliente e de seus produtos vinculados
        private void AlterarCliente_Load(object sender, EventArgs e)
        {
            if (lblIdCliente.Text != "" && lblIdCliente.Text != "0")
            {
                LoadCliente(Convert.ToInt32(lblIdCliente.Text));
                LoadProdutosVinculados(Convert.ToInt32(lblIdCliente.Text));
            }
            else
            {
                MessageBox.Show("Ocorreu um erro, por favor recarregue o programa");
            }

        }

        //Delete o cliente selecionado
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                if (lblIdCliente.Text != "")
                {
                    clsCliente cliente = new clsCliente();
                    cliente.idCliente = Convert.ToInt32(lblIdCliente.Text);
                    if (cliente.DeletarRegistro(cliente))
                    {
                        clsVinculoProduto vinculoProduto = new clsVinculoProduto();
                        DataTable dtProds = vinculoProduto.ObtemTodos(idCliente: Convert.ToInt32(lblIdCliente.Text));
                        if (dtProds != null && dtProds.Rows.Count > 0)
                        {
                            foreach (DataRow i in dtProds.Rows)
                            {
                                vinculoProduto.idProdutoVinculado = Convert.ToInt32(i["Id"]);
                                if (!vinculoProduto.DeletarRegistro(vinculoProduto))
                                {
                                    MessageBox.Show("Não foi possivel deletar produtos do cliente");
                                }
                            }
                        }
                        MessageBox.Show("Cliente deletado com sucesso");
                        Clientes cli = new Clientes();
                        cli.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel deletar cliente");
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possivel deletar cliente");
                }
            }
        }

        //Define algumas propiedades do OpenDialog e abre o dialogo com o explorer para a escolha da planilha
        private void btnSelecionaPlan_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Title = "Selecionar Planilha";
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            DialogResult dr = this.openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    foreach (String arquivo in openFileDialog1.FileNames)
                    {
                        txtCaminho.Text = arquivo;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel selecionar arquivo" + ex.Message);
                }
            }
        }

        //Alimenta a grid com dados vindos do SELECT
        private void LoadProdutosVinculados(int idCliente)
        {
            clsVinculoProduto vinculoProduto = new clsVinculoProduto();
            DataTable dt = vinculoProduto.ObtemTodos(idCliente: idCliente);
            dgvProdutos.DataSource = dt;
        }

        //Obtem as informações da planilha escolhida e salvas as informações no banco
        private void btnImportarPlanilha_Click(object sender, EventArgs e)
        {
            if (txtCaminho.Text != "")
            {
                try
                {
                    clsVinculoProduto vinculoProduto = new clsVinculoProduto();
                    DataTable dtProduto = vinculoProduto.ProdutoPlanilha(txtCaminho.Text);
                    foreach (DataRow i in dtProduto.Rows)
                    {
                        vinculoProduto.prodDescricao = i["Produto"].ToString();
                        vinculoProduto.prodQnt = Convert.ToInt32(i["Quantidade"]);
                        vinculoProduto.idCliente = Convert.ToInt32(lblIdCliente.Text);
                        vinculoProduto.prodDataVinculo = DateTime.Now;

                        if (vinculoProduto.NovoRegistro(vinculoProduto))
                        {
                            MessageBox.Show("Produto vinculado com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel vincular produto.");
                        }
                        LoadProdutosVinculados(Convert.ToInt32(lblIdCliente.Text));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar Vincular produto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor escolha um arquivo.");
            }
        }

        private void btnPesquisaProd_Click(object sender, EventArgs e)
        {
            clsVinculoProduto vinculoProduto = new clsVinculoProduto();
            DataTable dt = vinculoProduto.ObtemTodos(idCliente: Convert.ToInt32(lblIdCliente.Text), strGeral: txtpesquisaProd.Text);
            dgvProdutos.DataSource = dt;
        }

        private void btnInformacao_Click(object sender, EventArgs e)
        {
            InformaçõesImportarDados iid = new InformaçõesImportarDados();
            iid.Show();
        }

        //Fecha o sistema
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
