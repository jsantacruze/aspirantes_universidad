using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aspirante_datos;

namespace aspirantes_negocio
{
    public class Genero_BO
    {
        public static List<Genero> getList()
        {
            try
            {
                return Genero_DAO.getList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
