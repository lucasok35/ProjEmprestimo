using Model;
using Data;
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


            Emprestimo emprestimo = new Emprestimo()
            {
                Descricao = txtDescricao.Text,
                Valor = Convert.ToDecimal(txtValor.Text),
                DataEmp = DateTime.Now,
                Percjuros = Convert.ToDecimal(txtJuros.Text),
                QtdParc = Convert.ToInt32(txtParcelas.Text),

            };

            if(new EmprestimoDB().Insert(emprestimo))
            {
                Decimal ValorParcela = Convert.ToInt32(txtValor.Text) * 0.02m;
                int QtdParcelas = Convert.ToInt32(txtParcelas.Text);
                DateTime DataVenc = emprestimo.DataEmp.AddDays(30);

                for (int i=0;i <= QtdParcelas;i++)
                {
                    EmpGerado empgerado = new EmpGerado()
                    {
                        Emprestimo.Equals,
                        Parcela = ValorParcela / QtdParcelas,
                        VencParcela = DataVenc.AddDays(30)
                        
                    };
                }
                
            }

            if (new EmprestimoDB().Insert(emprestimo))
            {
                lblMsg.Text = "Registro Inserido com Sucesso!";
                lblMsg.ForeColor = Color.Blue;

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