using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
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

        protected void dgvCarrito_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Eliminar")
            {
                int index= Convert.ToInt32(e.CommandArgument);
                GridViewRow row = dgvCarrito.Rows[index];

                List<Articulo> aux = (List<Articulo>)Session["Articulos"];
                aux.RemoveAt(index);
                Session["Articulos"] = aux;

                dgvCarrito.DataSource = Session["Articulos"];
                dgvCarrito.DataBind();

                Response.Redirect("Carrito.aspx",false);
            }
        }
    }
}