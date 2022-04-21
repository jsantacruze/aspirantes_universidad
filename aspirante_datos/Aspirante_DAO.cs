using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aspirante_datos
{
    public class Aspirante_DAO
    {
        //METODO PARA DEVOLVER LA LISTA DE ASPIRANTES POR FILTRO
        public static List<Aspirante> getListaByFiltro(string filtro)
        {
            try
            {
                using (AspirantesEntities db = new AspirantesEntities())
                {
                    var result = db.Aspirante
                        .Where(a => a.aspirante_nombres.Contains(filtro)
                                 || a.aspirante_apellidos.Contains(filtro)).ToList();
                        return result;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
