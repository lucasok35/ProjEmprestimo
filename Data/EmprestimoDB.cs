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
    public class EmprestimoDB
    {
        private Conexao conexao;

        #region Métodos
        public bool Insert(Emprestimo emprestimo)
        {

            int IdEmprestimoReturn = 0;


            try
            {
                //Query de inclusão de dados
                string sql = string.Format("insert into TB_Emprestimo values]" +
                    " ('{0}', '{1}', '{2}','{3}','{4}'); SELECT SCOPE_IDENTITY() ",
                    emprestimo.Descricao, emprestimo.Valor, emprestimo.DataEmp, emprestimo.Percjuros, emprestimo.QtdParc);



                //Abrir conexão para inclusão das informações
                using (conexao = new Conexao())
                {
                    //Retorna o id do elemento inserido(verificar alteração no executacomando)
                    IdEmprestimoReturn = conexao.ExecutaComando(sql);
                }


                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private List<Emprestimo> TransformaSQLReaderEmList(SqlDataReader retorno)
        {
            var listEmprestimo = new List<Emprestimo>();

            while (retorno.Read())
            {
                var item = new Emprestimo()
                {
                    IdEmprestimo = Convert.ToInt32(retorno["IdEmprestimo"]),
                    Descricao = retorno["Descricao"].ToString(),
                    Valor = Convert.ToDecimal(retorno["Valor"]),
                    DataEmp = Convert.ToDateTime(retorno["DataEmp"]),
                    Percjuros = Convert.ToDecimal(retorno["Percjuros"]),
                    QtdParc = Convert.ToInt32(retorno["QtdParc"]),
                    

                };

                listEmprestimo.Add(item);
                
            }

            return listEmprestimo;
        }

        #endregion Métodos
    }
}
