using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPCarritoCompras_Equipo18
{
    public partial class Master : System.Web.UI.MasterPage
    {
        public int cantArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Articulos"] != null)
                {
                    List<Articulo> listaCarrito = new List<Articulo>();
                    listaCarrito = (List<Articulo>)Session["Articulos"];
                    cantArticulos = listaCarrito.Count;
                }
                else
                {
                    cantArticulos = 0;
                }
                lblCantProductos.Text = cantArticulos.ToString();
            }
        }
    }
}