using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aspirante_datos
{
    public class Carrera_DAO
    {
        public static List<Carrera> getListByFiltro(string filtro)
        {
            try
            {
                using (AspirantesEntities db = new AspirantesEntities())
                {
                    var result = db.Carrera.Where(c => c.carrera_nombre.Contains(filtro))
                        .ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static Carrera getByID(string id)
        {
            try
            {
                using (AspirantesEntities db = new AspirantesEntities())
                {
                    var result = db.Carrera.Find(id);
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
