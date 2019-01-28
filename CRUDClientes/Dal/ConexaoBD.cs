using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDClientes.Dal
{
    class ConexaoBD
    {

        private static SqlConnection con;


        private string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        public SqlConnection ObterCon { get => con; }

        public ConexaoBD()
        {
            con = new SqlConnection(conn);
        }       
    }
}
