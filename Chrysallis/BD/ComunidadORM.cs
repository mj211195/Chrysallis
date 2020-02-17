using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core;
using System.Linq;
using System.Windows.Forms;

namespace Chrysallis.BD
{
    public static class ComunidadORM
    {
        public static List<comunidades> SelectAllComunidades()
        {
            List<comunidades> _comunidades = null;
            try
            {

                _comunidades =
                    (from c in ORM.bd.comunidades
                     orderby c.nombre
                     select c
                    ).ToList();

            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _comunidades;
        }
    }
}
