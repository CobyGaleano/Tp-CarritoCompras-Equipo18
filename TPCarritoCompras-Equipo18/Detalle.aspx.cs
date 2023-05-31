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
            if (!IsPostBack)
            {
                //Recibo el id del articulo seleccionado
                int Id = int.Parse(Request.QueryString["id"]);
                ImagenNegocio img = new ImagenNegocio();
                //Traigo sus atributos
                Articulo seleccionado = negocio.buscar(Id);
                //Traigo las imagenes que se relacionan con el id, reutilizando el metodo listar
                listaImagenes = img.listar(Id);

                lblCodigo.Text = seleccionado.Codigo;
                lblNombre.Text = seleccionado.Nombre;
                lblDescripcion.Text = seleccionado.Descripcion;
                lblCategoria.Text = seleccionado.categoria.Descripcion;
                lblMarca.Text = seleccionado.marca.Descripcion;
                lblPrecio.Text = seleccionado.Precio.ToString();
            }
        }
    }
}