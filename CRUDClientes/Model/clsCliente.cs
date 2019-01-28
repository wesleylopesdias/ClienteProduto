using CRUDClientes.Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDClientes.Model
{
    class clsCliente
    {
        public int idCliente { get; set; }
        public string cliNome { get; set; }
        public string cliEmail { get; set; }
        public string cliTelefone { get; set; }
        public string cliCelular { get; set; }
        public string cliCEP { get; set; }
        public string cliNumero { get; set; }
        public string cliEstado { get; set; }
        public string cliCidade { get; set; }
        public string cliBairro { get; set; }
        public string cliLogradouro { get; set; }
        public string cliGUID { get; set; }

        public clsCliente()
        {
            cliGUID = Guid.NewGuid().ToString();
        }

        internal DataTable ObtemTodos(int idCliente = 0, string strGeral = "", bool qntProds = false)
        {
            return new daoCliente().ObtemTodos(idCliente, strGeral, qntProds);
        }

        internal DataTable ClientePlanilha(string caminho)
        {
            return new daoCliente().ObterClientePlanilha(caminho);
        }

        internal bool NovoRegistro(clsCliente cliente)
        {
            return new daoCliente().NovoRegistro(cliente);
        }

        internal bool AtualizarRegistro(clsCliente cliente)
        {
            return new daoCliente().AtualizarRegistro(cliente);
        }

        internal bool DeletarRegistro(clsCliente cliente)
        {
            return new daoCliente().DeletarRegistro(cliente);
        }
    }
}
