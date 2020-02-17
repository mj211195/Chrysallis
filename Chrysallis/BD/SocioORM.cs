using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chrysallis.BD
{
    public static class SocioORM
    {
        public static socios SelectSocio(String dni,String password)
        {
            socios socio = null;
            try
            {
                socio = (
                from s in ORM.bd.socios
                where s.dni.Equals(dni) && s.password.Equals(password)
                select s).FirstOrDefault();
            }
            catch (EntityException ex)
            {
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return socio;
        }
    }
}
