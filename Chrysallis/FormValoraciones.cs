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
        //Recogemos todas las valoraciones del evento seleccionado anteriormente
        public FormValoraciones(eventos evento)
        {
            InitializeComponent();
            double promedio = 0;
            int contador = 0;
            bindingSourceValoraciones.DataSource = null;
            List<asistir> valoraciones = BD.AsistirORM.SelectAllValoracion(evento);
            bindingSourceValoraciones.DataSource = valoraciones;
            cambiarIdioma();
            foreach(asistir a in valoraciones)
            {
                if(a.valoracion > 0)
                {
                    promedio += (double)a.valoracion;
                    contador++;
                }
            }
            if(contador > 0)
            {
                promedio = promedio / contador;
            }
            labelPromedio.Text += promedio.ToString() + "/5";
        }

        //Cambiamos el idioma segun seleccionado
        private void cambiarIdioma()
        {
            this.Text = Strings.ratings;
            dataGridViewValoraciones.Columns[0].HeaderText = Strings.assessment;
            dataGridViewValoraciones.Columns[1].HeaderText = Strings.commentary;
            labelPromedio.Text = Strings.promedio;
        }


    }
}
