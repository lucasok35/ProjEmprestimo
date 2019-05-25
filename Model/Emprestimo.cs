using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Emprestimo
    {
        #region Propriedades
        public int IdEmprestimo { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataEmp { get; set; }
        public decimal Percjuros { get; set; }
        public int QtdParc { get; set; }


        #endregion Propriedades

        #region Métodos

        public override string ToString()
        {
            return "IdGerado: " + this.IdEmprestimo + "\nDescrição " + this.Descricao + "\nValor: " +
                this.Valor + "\nData: " + this.DataEmp + "\nTaxa Juros: " + this.Percjuros +
                "\nQuantidade Parcelas: " + this.QtdParc;
        }

        #endregion Métodos
    }
}
