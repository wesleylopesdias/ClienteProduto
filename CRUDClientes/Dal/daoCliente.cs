using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CRUDClientes.Model;
using System.Data.OleDb;

namespace CRUDClientes.Dal
{
    class daoCliente
    {
        ConexaoBD conexao = new ConexaoBD();
        internal DataTable ObtemTodos(int idCliente = 0 , string strGeral = "", bool qntProds = false)
        {
            string qnt = "";
            if (qntProds)
            {
                qnt = @",(SELECT COUNT(*) FROM tblProdutoVinculado WHERE tblProdutoVinculado.idCliente = tblCliente.idCliente) as QntDeProdutos";
            }
            string strQuery = $@"SELECT idCliente as ID
                                  ,cliNome as Nome
                                  ,cliEmail as Email
                                  ,cliTelefone as Telefone
                                  ,cliCelular as Celular
                                  ,cliCEP as CEP
                                  ,cliNumero as Numero
                                  ,cliEstado as UF
                                  ,cliCidade as Cidade
                                  ,cliBairro as Bairro
                                  ,cliLogradouro as Logradouro
                                  ,cliGUID as Codigo
                                  {qnt}
                              FROM tblCliente WHERE 1=1";
            if (idCliente != 0)
                strQuery += " and idCliente = "+idCliente;
            if(strGeral != "")
                strQuery += " and (cliNome LIKE '%" + strGeral + "%' or cliEmail LIKE '%" + strGeral + "%')";

            try
            {
                conexao.ObterCon.Open();
                SqlCommand comando = new SqlCommand(strQuery, conexao.ObterCon);
                comando.ExecuteNonQuery();
                SqlDataAdapter  dataAdapter = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                return dt;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                conexao.ObterCon.Close();
            }
        }

        internal bool NovoRegistro(clsCliente cliente)
        {
            string strQuery = $@"INSERT INTO tblCliente
                                   (cliNome
                                   ,cliEmail
                                   ,cliTelefone
                                   ,cliCelular
                                   ,cliCEP
                                   ,cliNumero
                                   ,cliEstado
                                   ,cliCidade
                                   ,cliBairro
                                   ,cliLogradouro
                                   ,cliGUID)
                                VALUES(
                                    '{cliente.cliNome}',
                                    '{cliente.cliEmail}',
                                    '{cliente.cliTelefone}',
                                    '{cliente.cliCelular}',
                                    '{cliente.cliCEP}',
                                    '{cliente.cliNumero}',
                                    '{cliente.cliEstado}',
                                    '{cliente.cliCidade}',
                                    '{cliente.cliBairro}',
                                    '{cliente.cliLogradouro}',
                                    '{cliente.cliGUID}')";

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

        internal bool AtualizarRegistro(clsCliente cliente)
        {
            string strQuery = $@"UPDATE tblCliente
                                SET cliNome = '{cliente.cliNome}'
                                    ,cliEmail = '{cliente.cliEmail}' 
                                    ,cliTelefone = '{cliente.cliTelefone}'
                                    ,cliCelular = '{cliente.cliCelular}'
                                    ,cliCEP = '{cliente.cliCEP}'
                                    ,cliNumero = '{cliente.cliNumero}'
                                    ,cliEstado = '{cliente.cliEstado}'
                                    ,cliCidade = '{cliente.cliCidade}'
                                    ,cliBairro = '{cliente.cliBairro}'
                                    ,cliLogradouro = '{cliente.cliLogradouro}'
                                WHERE idCliente = {cliente.idCliente}";

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

        internal bool DeletarRegistro(clsCliente cliente)
        {
            string strQuery = $@"DELETE FROM tblCliente
                                WHERE idCliente = {cliente.idCliente}";

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

        internal DataTable ObterClientePlanilha(string caminho)
        {
            string caminhotratado = caminho.Replace('/','\\');
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

                }catch(Exception ex)
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
    }
}
