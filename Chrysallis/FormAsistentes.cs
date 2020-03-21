using Chrysallis.Idiomas;
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
            cambiarIdioma();
            bindingSourceAsistentes.DataSource = null;
            bindingSourceAsistentes.DataSource = BD.EventoORM.SelectAllAsistir(evento);
        }

        private void cambiarIdioma()
        {
            this.Text = Strings.assistants;
            dataGridViewAsistentes.Columns[0].HeaderText = Strings.name;
            dataGridViewAsistentes.Columns[1].HeaderText = Strings.howMany;
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
