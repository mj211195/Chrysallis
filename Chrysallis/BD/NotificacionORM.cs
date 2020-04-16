using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chrysallis.BD
{
    public static class NotificacionORM
    {
        //Devolvemos la lista de notificaciones ordenadas por id
        public static List<notificaciones> SelectAllNotificaciones()
        {
            List<notificaciones> _notificaciones = null;
            try
            {

                _notificaciones =
                    (from n in ORM.bd.notificaciones
                     orderby n.id
                     select n
                    ).ToList();

            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _notificaciones;
        }

        //Devolvemos la lista de notificaciones ordenadas por antelacion
        public static List<notificaciones> SelectAllAntelacion()
        {
            List<notificaciones> lista = null;
            try
            {
                lista =
                    (from n in ORM.bd.notificaciones
                     orderby n.antelacion
                     select n
                    ).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lista;
        }
    }
}
