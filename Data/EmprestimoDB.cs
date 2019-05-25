using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Data
{
    public class EmprestimoDB
    {
        private Conexao conexao;

        public bool Insert(Emprestimo emprestimo)
        {

            try
            {
                //Query de inclusão de dados
                string sql = string.Format("insert into TB_Emprestimo values ('{0}', '{1}', '{2}','{3}','{4}')",
                    emprestimo.Descricao, emprestimo.Valor, emprestimo.DataEmp, emprestimo.Percjuros, emprestimo.QtdParc);

                //Abrir conexão para inclusão das informações
                using (conexao = new Conexao())
                {
                    conexao.ExecutaComando(sql);
                }


                return true;
            }
            catch (Exception)
            {

                //return false;
                throw;
            }

        }
    }
}
