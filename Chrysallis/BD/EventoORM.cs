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
    public static class EventoORM
    {
        
        public static List<eventos> SelectAllEventos()
        {
            List<eventos> eventos = null;
            try
            {
                eventos = (
                from e in ORM.bd.eventos
                select e).ToList();
            }
            catch (EntityException ex)
            {
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return eventos;
        }

        public static List<eventos> SelectAllEventosByComunidad(int comunidad)
        {
            List<eventos> eventos = null;
            try
            {
                eventos = (
                from e in ORM.bd.eventos
                where e.id_comunidad == comunidad
                select e).ToList();
            }
            catch (EntityException ex)
            {
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return eventos;
        }

        public static List<eventos> SelectAllEventosByComunidadFecha(int comunidad, DateTime desde, DateTime hasta)
        {
            List<eventos> eventos = null;
            try
            {
                eventos = (
                from e in ORM.bd.eventos
                where e.id_comunidad == comunidad && (e.fecha > desde && e.fecha < hasta)
                select e).ToList();
            }
            catch (EntityException ex)
            {
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return eventos;
        }

        public static List<eventos> SelectAllEventosByFecha(DateTime desde, DateTime hasta)
        {
            List<eventos> eventos = null;
            try
            {
                eventos = (
                from e in ORM.bd.eventos
                where (e.fecha >= desde && e.fecha <= hasta)
                select e).ToList();
            }
            catch (EntityException ex)
            {
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return eventos;
        }

        public static Boolean InsertEvento(eventos evento)
        {
            Boolean correcto = false;
            try
            {
                ORM.bd.eventos.Add(evento);
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

        public static void DeleteEvento(eventos evento)
        {
            ORM.bd.eventos.Remove(evento);
            ORM.bd.SaveChanges();
        }


    }
}
