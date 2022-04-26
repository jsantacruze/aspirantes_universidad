using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aspirante_datos;

namespace aspirantes_negocio
{
    public class Aspirante_BO
    {
        public static List<Aspirante> getListaByFiltro(string filtro)
        {
            try
            {
                return Aspirante_DAO.getListaByFiltro(filtro);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<Aspirante> getListaByFiltroAndCarrera(string filtro, string carrera_id)
        {
            try
            {
                return Aspirante_DAO.getListaByFiltroAndCarrera(filtro, carrera_id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
