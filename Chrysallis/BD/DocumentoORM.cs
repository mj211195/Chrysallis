using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chrysallis.BD
{
    public static class DocumentoORM
    {
        //Devolvemos la lista de documentos ordenadas por id
        public static List<documentos> SelectAllDocumentos()
        {
            List<documentos> _documentos = null;
            try
            {

                _documentos =
                    (from d in ORM.bd.documentos
                     orderby d.id
                     select d
                    ).ToList();

            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un documento correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return _documentos;
        }

        //Insertamos la lista de documentos pasada por parametro para guardar en la base de datos
        public static Boolean insertDocumentos(documentos documento)
        {
            Boolean correcto = false;
            try
            {
                ORM.bd.documentos.Add(documento);
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
    }
}
