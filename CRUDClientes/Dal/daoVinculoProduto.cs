using CRUDClientes.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDClientes.Dal
{
    class daoVinculoProduto
    {
        ConexaoBD conexao = new ConexaoBD();
        internal DataTable ObtemTodos(int idCliente = 0, string strGeral = "", string Cliente = "", int idProdutoVinculado = 0, string dataInicial = "", string datafinal = "")
        {
            string strQuery = @"SELECT idProdutoVinculado as Id
                                  ,tblProdutoVinculado.idCliente as IdCliente
                                  ,tblCliente.cliNome as Cliente
                                  ,prodDescricao as Produto
                                  ,prodQnt as Quantidade
                                  ,prodDataVinculo as Data
                              FROM tblProdutoVinculado
                              LEFT JOIN tblCliente on tblCliente.idCliente = tblProdutoVinculado.idCliente
                              WHERE 1=1";

            if (idCliente != 0)
                strQuery += " and tblProdutoVinculado.idCliente = " + idCliente;
            if (idProdutoVinculado != 0)
                strQuery += " and idProdutoVinculado = " + idProdutoVinculado;
            if (strGeral != "")
                strQuery += " and prodDescricao LIKE '%" + strGeral + "%'";
            if (Cliente != "")
                strQuery += " and tblCliente.cliNome LIKE '%" + Cliente + "%'";
            if (dataInicial != "" && datafinal != "" & dataInicial != "  /  /" && datafinal != "  /  /")
                strQuery += " and prodDataVinculo BETWEEN CONVERT(date,'"+dataInicial+"',103) AND CONVERT(date,'"+datafinal+"',103)";

            try
            {
                conexao.ObterCon.Open();
                SqlCommand comando = new SqlCommand(strQuery, conexao.ObterCon);
                comando.ExecuteNonQuery();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                conexao.ObterCon.Close();
            }
        }
        internal bool NovoRegistro(clsVinculoProduto vinculoProduto)
        {
            string strQuery = $@"INSERT INTO tblProdutoVinculado
                                    (idCliente
                                    ,prodDescricao
                                    ,prodQnt
                                    ,prodDataVinculo)
                                VALUES
                                    (
                                    '{vinculoProduto.idCliente}',
                                    '{vinculoProduto.prodDescricao}',
                                    '{vinculoProduto.prodQnt}',
                                    CONVERT(date,'{vinculoProduto.prodDataVinculo}',103))";

            try
            {
                conexao.ObterCon.Open();
                SqlCommand comando = new SqlCommand(strQuery, conexao.ObterCon);
                int result = comando.ExecuteNonQuery();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                conexao.ObterCon.Close();
            }
        }
        internal DataTable ObterProdutoPlanilha(string caminho)
        {
            string caminhotratado = caminho.Replace('/', '\\');
            string ConnectionString = $@"provider=Microsoft.ACE.OLEDB.12.0;Data Source='{caminhotratado}';Extended Properties=Excel 12.0 Xml;";

            using (OleDbConnection db = new OleDbConnection(ConnectionString))
            using (OleDbCommand command = db.CreateCommand())
            {
                try
                {
                    db.Open();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT * FROM [Sheet1$]";
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    return dt;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
                finally
                {
                    db.Close();
                }
            }
        }

        internal bool DeletarRegistro(clsVinculoProduto vinculoProduto)
        {
            string strQuery = $@"DELETE FROM tblProdutoVinculado
                                WHERE idProdutoVinculado = {vinculoProduto.idProdutoVinculado}";

            try
            {
                conexao.ObterCon.Open();
                SqlCommand comando = new SqlCommand(strQuery, conexao.ObterCon);
                int result = comando.ExecuteNonQuery();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                conexao.ObterCon.Close();
            }
        }

    }
}
