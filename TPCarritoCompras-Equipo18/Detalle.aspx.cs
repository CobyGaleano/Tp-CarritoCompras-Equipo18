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
    public partial class Detalle : System.Web.UI.Page
    {
        public int Id { get; set; }
        public List<Imagen> listaImagenes { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            articuloNegocio negocio = new articuloNegocio();
            Articulo seleccionado;
            if (!IsPostBack)
            {
                //Recibo el id del articulo seleccionado
                Id = int.Parse(Request.QueryString["id"]);
                ImagenNegocio img = new ImagenNegocio();
                //Traigo sus atributos
                seleccionado = negocio.buscar(Id);
                //Traigo las imagenes que se relacionan con el id, reutilizando el metodo listar
                listaImagenes = img.listar(Id);

                lblCodigo.Text = seleccionado.Codigo;
                lblNombre.Text = seleccionado.Nombre;
                lblDescripcion.Text = seleccionado.Descripcion;
                lblCategoria.Text = seleccionado.categoria.Descripcion;
                lblMarca.Text = seleccionado.marca.Descripcion;
                lblPrecio.Text = seleccionado.Precio.ToString();
                lblAñadir.Text = "no se cliqueo";
            }
        }

        protected void btn_Añadir_Click(object sender, EventArgs e)
        {
            lblAñadir.Text = "se añadio el producto al carrito";
            try
            {
                //Si en la url viene un id agrego el articulo a la session
                //if (Request.QueryString["Id"] != null)
                //{
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
                //string id = Request.QueryString["id"];
                //busco el articulo por el id
                seleccionado = negocio.buscar(Id);
                //seleccionado = negocio.buscar(int.Parse(id));
                //lo agrego a la lista 
                carritoArticulos.Add(seleccionado);
                //agrego la lista a la session
                Session.Add("Articulos", carritoArticulos);
                //}                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}