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
    public static class AsistirORM
    {
        //Devolvemos lista de asistir de las personas que asistiran al evento
        public static List<asistir> SelectAllAsistir(eventos evento)
        {
            List<asistir> asistir = null;
            try
            {
                asistir = (
                from e in ORM.bd.asistir
                where e.id_evento == evento.id
                select e).ToList();
            }
            catch (EntityException ex)
            {
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return asistir;
        }

        //Devolvemos lista de asistir de las valoraciones del evento
        public static List<asistir> SelectAllValoracion(eventos evento)
        {
            List<asistir> asistir = null;
            try
            {
                asistir = (
                from e in ORM.bd.asistir
                where e.id_evento == evento.id && e.valoracion != 0
                select e).ToList();
            }
            catch (EntityException ex)
            {
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return asistir;
        }
    }
}
