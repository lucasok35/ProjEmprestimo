using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EmpGerado
    {

        #region Propriedades
        public int IdEmpGerado { get; set; }
        public Emprestimo IdEmprestimo { get; set; }
        public decimal Parcela { get; set; }
        public DateTime VencParcela { get; set; }
        #endregion Propriedades


        public override string ToString()
        {
            return "IdEmpGerado: " + this.IdEmpGerado + "\nParcela " + this.Parcela + "\nVencimento da Parcela: " +
            this.VencParcela;
        }
    }


}
