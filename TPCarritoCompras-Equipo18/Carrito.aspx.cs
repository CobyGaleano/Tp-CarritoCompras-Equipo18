using Dominio;
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
        public decimal precioTotal {  get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            articuloNegocio negocio= new articuloNegocio();
            if(!IsPostBack)
            {
                dgvCarrito.DataSource = Session["Articulos"];
                dgvCarrito.DataBind();

            }
            if (Session["Articulos"] != null)
            {
                List<Articulo> listaArticulos = new List<Articulo>();
                listaArticulos = (List<Articulo>)Session["Articulos"];

                foreach (Articulo item in listaArticulos)
                {
                    precioTotal += item.Precio;
                }
                lblTotal.Text = "Total: " + precioTotal.ToString();
            }
        }
    }
}