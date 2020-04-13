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
    public partial class FormValoraciones : Form
    {
        public FormValoraciones(eventos evento)
        {
            InitializeComponent();
            bindingSourceValoraciones.DataSource = null;
            bindingSourceValoraciones.DataSource = BD.AsistirORM.SelectAllValoracion(evento);
            cambiarIdioma();
        }

        private void cambiarIdioma()
        {
            this.Text = Strings.ratings;
            dataGridViewValoraciones.Columns[0].HeaderText = Strings.assessment;
            dataGridViewValoraciones.Columns[1].HeaderText = Strings.commentary;
        }


    }
}
