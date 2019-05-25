using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Conexao : IDisposable
    {
        private SqlConnection conexao;

        public Conexao()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSQLServer"].ConnectionString);
            conexao.Open();
        }


        public void ExecutaComando(string query)
        {

            var cmd = new SqlCommand
            {
                CommandText = query,
                CommandType = CommandType.Text,
                Connection = conexao
            };
            cmd.ExecuteNonQuery();
        }

        public SqlDataReader ExecutaComandoRetorno(string query)
        {
            var cmd = new SqlCommand(query, conexao);
            return cmd.ExecuteReader();
        }

        public void Dispose()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
