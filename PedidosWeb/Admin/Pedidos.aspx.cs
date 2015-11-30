using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.Entity;
using System.Web.UI.WebControls;

namespace PedidosWeb.Admin
{
    public partial class Pedidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtDataEmissao.Text = string.Format("{0:dd/MM/yyyy}", DateTime.Now);
                BindarGrid();
            }
        }

        #region metodos privados

        private void BindarGrid()
        {
            List<Pedido> pedido = new List<Pedido>();

            pedido.Add(new Pedido { ID = 1, Documento = "329342", Cliente = "Teste", DataEmissao = DateTime.Parse("20/05/2015") });
            pedido.Add(new Pedido { ID = 2, Documento = "123354", Cliente = "Teste", DataEmissao = DateTime.Parse("13/04/2015") });
            pedido.Add(new Pedido { ID = 3, Documento = "548778", Cliente = "Teste", DataEmissao = DateTime.Parse("04/05/2015") });
            pedido.Add(new Pedido { ID = 4, Documento = "231678", Cliente = "Teste", DataEmissao = DateTime.Parse("15/08/2015") });

            gvProdutos.DataSource = pedido;
            gvProdutos.DataBind();

            gvPedidos.DataSource = pedido;
            gvPedidos.DataBind();
        }

        #endregion

        #region grid

        protected void gvPedidos_Sorting(object sender, GridViewSortEventArgs e)
        {

        }

        protected void gvPedidos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void gvPedidos_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        #endregion

        #region buttons

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}