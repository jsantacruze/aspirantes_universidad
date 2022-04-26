using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aspirante_datos
{
    public class Genero_DAO
    {
        public static List<Genero> getList()
        {
            try
            {
                using (AspirantesEntities db = new AspirantesEntities())
                {
                    var result = db.Genero.ToList();
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
