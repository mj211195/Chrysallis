using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chrysallis.BD
{
    public static class DocumentoORM
    {
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
    }
}
