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
                string sql = string.Format("insert into TB_EmpGerado values ('{0}', '{1}', '{2}')",
                    empgerado.Parcela, empgerado.VencParcela, empgerado.IdEmprestimo);

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
                var sql = "SELECT IdEmprestimo, Parcela, VencParcela FROM TB_EmpGerado";
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
                    IdEmpGerado = int.Parse(retorno["IdEmpGerado"].ToString()),
                    Parcela = int.Parse(retorno["Parcela"].ToString()),
                    VencParcela = Convert.ToDateTime(retorno["VencParcela"].ToString()),

                };

                listEmpGerado.Add(item);
            }
            return listEmpGerado;
        }
    }
}
