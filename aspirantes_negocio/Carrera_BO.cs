
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aspirante_datos;

namespace aspirantes_negocio
{
    public class Carrera_BO
    {
        public static List<Carrera> getListByFiltro(string filtro)
        {
            try
            {
                return Carrera_DAO.getListByFiltro(filtro);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
