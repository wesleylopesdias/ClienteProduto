using CRUDClientes.Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDClientes.Model
{
    class clsVinculoProduto
    {
        public int idProdutoVinculado { get; set; }
        public int idCliente { get; set; }
        public string prodDescricao { get; set; }
        public int prodQnt { get; set; }
        public DateTime prodDataVinculo { get; set; }

        internal DataTable ObtemTodos(int idCliente = 0, string strGeral = "", string cliente = "", int idProdutoVinculado = 0, string dataInicial = "", string datafinal = "")
        {
            return new daoVinculoProduto().ObtemTodos(idCliente, strGeral, cliente, idProdutoVinculado, dataInicial, datafinal);
        }
        internal DataTable ProdutoPlanilha(string caminho)
        {
            return new daoVinculoProduto().ObterProdutoPlanilha(caminho);
        }

        internal bool NovoRegistro(clsVinculoProduto vinculoProduto)
        {
            return new daoVinculoProduto().NovoRegistro(vinculoProduto);
        }

        internal bool DeletarRegistro(clsVinculoProduto vinculoProduto)
        {
            return new daoVinculoProduto().DeletarRegistro(vinculoProduto);
        }
    }
}
