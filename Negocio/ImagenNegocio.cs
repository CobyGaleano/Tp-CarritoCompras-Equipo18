using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> listar(int id = 0)
        {

            List<Imagen> listar = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                if (id > 0)
                {
                    datos.setearConsulta("select Id,IdArticulo,ImagenUrl from IMAGENES where IdArticulo= @id ");
                    datos.setearParametros("id", id);
                }
                else
                {
                    datos.setearConsulta("select Id,IdArticulo,ImagenUrl from IMAGENES");
                }
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen imagen = new Imagen();

                    imagen.Id = (int)datos.Lector["Id"];
                    imagen.IdArticulo = (int)datos.Lector["IdArticulo"];
                    imagen.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    listar.Add(imagen);

                }

                return listar;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
