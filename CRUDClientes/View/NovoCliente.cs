using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios.Net;
using CRUDClientes.Model;
using CRUDClientes.Model.Helper;
using CRUDClientes.View;

namespace CRUDClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Aciona a pesquisa por CEP
        private void button1_Click(object sender, EventArgs e)
        {
            LocalizarCEP();
        }

        //Utiliza a referencia para obter o resultado da pesquisa por CEP e compõe os campos com a resposta
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
                }catch(Exception e)
                {
                    MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Válida os dados e salva um novo cliente
        private void btnSalvar_Click(object sender, EventArgs e)
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
                if (cliente.NovoRegistro(cliente))
                {
                    MessageBox.Show("Cliente inserido com sucesso.");
                    Clientes cli = new Clientes();
                    cli.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Não foi possivel inserir cliente.");
                }
            }
        }

        //retorna para a tela inicial
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();
            cli.Show();
            this.Hide();
        }

        //Fecha o sistema
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
