using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjEmprestimo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReloadGrid();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            EmpGerado empgerado = new EmpGerado()
            {
                Parcela = Parcela * (2/100)+Parcela;
            };

            Emprestimo emprestimo = new Emprestimo()
            {
                Descricao = txtDescricao.Text,
                Valor = Convert.ToDecimal(txtValor.Text),
                DataEmp = Convert.ToDateTime(lblData.Text),
                Percjuros = Convert.ToDecimal(txtJuros.Text),
                QtdParc = Convert.ToInt32(txtParcelas.Text)
                

            };

            if (new EmprestimoDB().Insert(emprestimo))
            {
                lblMsg.Text = "Registro Inserido com Sucesso!";
                lblMsg.ForeColor = Color.Blue;
                ReloadGrid();
            }
            else
            {
                lblMsg.Text = "Erro ao Inserir Registro!";
                lblMsg.ForeColor = Color.Red;
            }
        }

        public void ReloadGrid()
        {
            gvEmprestimo.DataSource = new EmpGeradoDB().All();
            gvEmprestimo.DataBind();

        }

        
    }
}