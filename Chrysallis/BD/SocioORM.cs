using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chrysallis.BD
{
    public static class SocioORM
    {
        public static socios LoginSocio(String dni,String password, ref Boolean correcto)
        {
            socios socio = null;
            try
            {
                socio = (
                from s in ORM.bd.socios
                where s.dni.Equals(dni) && s.password.Equals(password) && s.administrador == true && s.activo == true
                select s).FirstOrDefault();
            }
            catch (EntityException ex)
            {
                correcto = false;
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            return socio;
        }

        public static List<socios> SelectAllSocios()
        {
            List<socios> socios = null;
            try
            {
                socios = (
                from s in ORM.bd.socios
                select s).ToList();
            }
            catch (EntityException ex)
            {
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return socios;
        }

        public static Boolean InsertSocio(socios socio)
        {
            Boolean correcto = false;
            try
            {
                ORM.bd.socios.Add(socio);
                ORM.bd.SaveChanges();
                correcto = true;
            }
            catch (DbUpdateException e)
            {
                ORM.RejectChanges();
                SqlException sqlEx = (SqlException)e.InnerException.InnerException;
                MessageBox.Show(sqlEx.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return correcto;
        }

        public static Boolean UpdateSocio(socios socio)
        {
            socios _socio = ORM.bd.socios.Find(socio.id);
            Boolean correcto = false;
            try
            {
                ORM.bd.SaveChanges();
                correcto = true;
            }
            catch (Exception e)
            {
                SqlException sqlEx = (SqlException)e.InnerException.InnerException;
                MessageBox.Show(sqlEx.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return correcto;
        }
    }
}
