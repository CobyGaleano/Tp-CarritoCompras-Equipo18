using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPCarritoCompras_Equipo18
{
    public partial class Carrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            articuloNegocio negocio= new articuloNegocio();
            if(!IsPostBack)
            {
                dgvCarrito.DataSource = Session["Articulos"];
                dgvCarrito.DataBind();

            }
        }
    }
}