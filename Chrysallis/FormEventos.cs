using Chrysallis.BD;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chrysallis
{
    public partial class FormEventos : Form
    {
        public FormEventos()
        {
            InitializeComponent();
        }

        private void FormEventos_Load(object sender, EventArgs e)
        {
            buttonAgregarEvento.Text = Idiomas.Strings.addEvent;
            this.Text = Idiomas.Strings._event;
            RefrescarDatos();
        }

        private void buttonAgregarEvento_Click(object sender, EventArgs e)
        {
            FormEvento formEvento = new FormEvento();
            formEvento.ShowDialog();
        }

        private void RefrescarDatos()
        {
            List<eventos> eventos;
            if ((bool)FormLogin.socioLogin.estatal)
            {
                eventos = EventoORM.SelectAllEventos();
            }
            else
            {
                eventos = EventoORM.SelectAllEventosByComunidad((int)FormLogin.socioLogin.id_comunidad);
            }
            if (eventos == null)
            {
                DialogResult result = MessageBox.Show("Error al acceder a la BD.\nSe procede a cerrar el programa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK || result == DialogResult.Abort)
                {
                    Application.Exit();
                }
            }
            else
            {
                bindingSourceEventos.DataSource = eventos;
            }

        }

        private void dateTimePickerFiltroFecha_ValueChanged(object sender, EventArgs e)
        {
            buscarPorFecha();
        }

        private void dateTimePickerHasta_ValueChanged(object sender, EventArgs e)
        {
            buscarPorFecha();
        }

        public void buscarPorFecha()
        {
            List<eventos> eventos;
            String desde = dateTimePickerDesde.Value.ToString("yyyy-MM-dd");
            String hasta = dateTimePickerHasta.Value.ToString("yyyy-MM-dd");

            if ((bool)FormLogin.socioLogin.estatal)
            {
                eventos = EventoORM.SelectAllEventosByFecha(DateTime.Parse(desde), DateTime.Parse(hasta));
            }
            else
            {
                eventos = EventoORM.SelectAllEventosByComunidadFecha((int)FormLogin.socioLogin.id_comunidad, DateTime.Parse(desde), DateTime.Parse(hasta));
            }
            if (eventos == null)
            {
                DialogResult result = MessageBox.Show("Error al acceder a la BD.\nSe procede a cerrar el programa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK || result == DialogResult.Abort)
                {
                    Application.Exit();
                }
            }
            else
            {
                bindingSourceEventos.DataSource = eventos;
            }
        }
    }
}
