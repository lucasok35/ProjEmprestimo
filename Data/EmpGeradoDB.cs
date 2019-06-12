using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Data
{
    public class EmpGeradoDB
    {
        private Conexao conexao;

        public bool Insert(EmpGerado empgerado)
        {

            try
            {
                //Query de inclusão de dados
                string sql = string.Format("insert into TB_EmpGerado(IdEmprestimo, Parcela, DataVencimento) values ('{0}', '{1}', '{2}', '{3}')",
                    empgerado.Emprestimo.IdEmprestimo, empgerado.Parcela, empgerado.VencParcela);

                //Abrir conexão para inclusão das informações
                using (conexao = new Conexao())
                {
                    conexao.ExecutaComando(sql);
                }


                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<EmpGerado> All()
        {
            using (conexao = new Conexao())
            {
                var sql = "SELECT G.IdEmpGerado, G.Parcela, G.VencParcela " +
                    "FROM TB_EmpGerado G, TB_Emprestimo E WHERE G.IdEmprestimo = E.IdEmprestimo";
                var retorno = conexao.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
            }
        }

        private List<EmpGerado> TransformaSQLReaderEmList(SqlDataReader retorno)
        {
            var listEmpGerado = new List<EmpGerado>();

            while (retorno.Read())
            {
                var item = new EmpGerado()
                {
                    IdEmpGerado = Convert.ToInt32(retorno["IdEmpGerado"].ToString()),
                    Emprestimo = new Emprestimo() { IdEmprestimo = Convert.ToInt32(retorno["IdEmprestimo"]) },
                    Parcela = Convert.ToInt32(retorno["Parcela"].ToString()),
                    VencParcela = Convert.ToDateTime(retorno["VencParcela"].ToString()),                    

                };

                listEmpGerado.Add(item);
            }
            return listEmpGerado;
        }
    }
}
