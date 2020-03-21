using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chrysallis
{
    public partial class FormAsistentes : Form
    {
        public FormAsistentes(eventos evento)
        {
            InitializeComponent();
            mostrarDatos();
            bindingSourceAsistentes.DataSource = null;
            bindingSourceAsistentes.DataSource = BD.EventoORM.SelectAllAsistir(evento);
        }

        private void mostrarDatos()
        {
            
        }

        private void dataGridViewAsistentes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            asistir _asistir;
            List<socios> listaSocio = BD.SocioORM.SelectAllSocios();
            if (e.ColumnIndex == 0)
            {
                _asistir = (asistir)dataGridViewAsistentes.Rows[e.RowIndex].DataBoundItem;
                foreach (var item in listaSocio)
                {
                    if (item.id == _asistir.id_socio)
                    {
                        e.Value = item.nombre;
                    }
                }
            }
        }
    }
}
