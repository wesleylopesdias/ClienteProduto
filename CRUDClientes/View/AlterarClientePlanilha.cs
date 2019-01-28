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
    public partial class AlterarClientePlanilha : Form
    {
        public AlterarClientePlanilha()
        {
            InitializeComponent();
        }

        //Apresente o form de instruções para importar e usar dados da planilha
        private void button1_Click(object sender, EventArgs e)
        {
            InformaçõesImportarDados iid = new InformaçõesImportarDados();
            iid.Show();
        }

        //Abre o explorer para a escolha da planilha com os dados e configura alguns atributos do openfileDialog
        private void btnSelecionar_Click(object sender, EventArgs e)
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

        //Recupera as informações da planilha e altera um ou mais cliente(s)
        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (txtCaminho.Text != "")
            {
                clsCliente cliente = new clsCliente();
                DataTable dtCliente = cliente.ClientePlanilha(txtCaminho.Text);
                foreach (DataRow i in dtCliente.Rows)
                {
                    try
                    {
                        cliente.idCliente = Convert.ToInt32(i["Id"]);
                        cliente.cliNome = i["Nome"].ToString();
                        cliente.cliEmail = i["Email"].ToString();
                        cliente.cliTelefone = i["Telefone"].ToString();
                        cliente.cliCelular = i["Celular"].ToString();
                        cliente.cliCEP = i["CEP"].ToString();
                        cliente.cliNumero = i["Numero"].ToString();
                        cliente.cliEstado = i["Estado"].ToString();
                        cliente.cliCidade = i["Cidade"].ToString();
                        cliente.cliBairro = i["Bairro"].ToString();
                        cliente.cliLogradouro = i["Logradouro"].ToString();
                        if (cliente.AtualizarRegistro(cliente))
                        {
                            MessageBox.Show("Cliente alterado com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel alterar cliente.");
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Erro ao tentar alterar cliente: "+ ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor escolha um arquivo.");
            }
            Clientes cli = new Clientes();
            cli.Show();
            this.Hide();
        }

        //Cancela a operação
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.Show();
            this.Hide();
        }

        //Fecha o sistema
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
