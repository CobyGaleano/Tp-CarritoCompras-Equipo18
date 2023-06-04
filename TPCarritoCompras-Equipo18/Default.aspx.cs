using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Dominio;
using Negocio;

namespace TPCarritoCompras_Equipo18
{
    public partial class Default : System.Web.UI.Page
    {
        public List<Articulo> listaArticulos { get; set; }
        public List<Imagen> listaImagenes { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                articuloNegocio negocio = new articuloNegocio();
                ImagenNegocio img = new ImagenNegocio();

                //Session.Add("listaArticulos", negocio.listar()); //PARTE COMENTADA DEL FILTRO

                List<Articulo> articulos = negocio.listar();
                listaArticulos = articulos;
                listaImagenes = img.listar();

            }
            /*else 
            {
                listaArticulos = (List<Articulo>)Session["artFiltrado"];

            }*/

            //Si en la url viene un id agrego el articulo a la session
            if (Request.QueryString["Id"] != null)
            {
                List<Articulo> carritoArticulos;
                articuloNegocio negocio = new articuloNegocio();
                Articulo seleccionado;

                //Si es el primer articulo le creo una instancia a la lista
                if (Session["Articulos"] == null)
                {
                    carritoArticulos = new List<Articulo>();
                }
                //Si no a la lista le agrego a la lista lo que tiene la session 
                else
                {
                    carritoArticulos = (List<Articulo>)Session["Articulos"];
                }
                string id = Request.QueryString["Id"];
                //busco el articulo por el id
                seleccionado = negocio.buscar(int.Parse(id));
                //lo agrego a la lista 
                carritoArticulos.Add(seleccionado);
                //agrego la lista a la session
                Session.Add("Articulos", carritoArticulos);
            }
        }



        /* protected void filtrar_TextChanged(object sender, EventArgs e)
         {
             List<Articulo> lista = (List<Articulo>)Session["ListaArticulos"];
             List<Articulo> filtrada = lista.FindAll(x => x.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()));
             listaArticulos = filtrada;

         ENVIA LISTADO VACIO AL FOREACH Y ROMPE EL PROGRAMA

         Referencia a objeto no establecida como instancia de un objeto.'

         }*/
    }
}