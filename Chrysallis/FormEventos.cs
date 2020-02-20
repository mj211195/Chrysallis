using Be.Timvw.Framework.ComponentModel;
using Chrysallis.BD;
using Chrysallis.Idiomas;
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

            buttonAgregarEvento.Text = Strings.addEvent;
            cambiarIdioma();
            RefrescarDatos();
            
        }

        private void buttonAgregarEvento_Click(object sender, EventArgs e)
        {
            FormEvento formEvento = new FormEvento();
            formEvento.ShowDialog();
            RefrescarDatos();
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
                SortableBindingList<eventos> events = new SortableBindingList<eventos>(eventos);
                bindingSourceEventos.DataSource = events;
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

        private void dataGridViewEventos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            eventos _evento;

            if (e.ColumnIndex == 11)
            {
                _evento = (eventos)dataGridViewEventos.Rows[e.RowIndex].DataBoundItem;
                e.Value = GestorIdiomas.getComunidad(_evento.comunidades.nombre);
            }
        }

        public void cambiarIdioma()
        {
            this.Text = Strings._event;
            labelDesde.Text = Strings.from;
            labelHasta.Text = Strings.to;
            dataGridViewEventos.Columns[1].HeaderText = Strings.date;
            dataGridViewEventos.Columns[2].HeaderText = Strings.location;
            dataGridViewEventos.Columns[3].HeaderText = Strings.time;
            dataGridViewEventos.Columns[4].HeaderText = Strings.deadline;
            dataGridViewEventos.Columns[5].HeaderText = Strings.numberOfAttendees;
            dataGridViewEventos.Columns[11].HeaderText = Strings.community;
        }

        private void dataGridViewEventos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(Strings.confirmDeleteEvent, Strings.confirmation, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                EventoORM.DeleteEvento((eventos)dataGridViewEventos.SelectedRows[0].DataBoundItem);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
