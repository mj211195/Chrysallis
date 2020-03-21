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
                DialogResult result = MessageBox.Show(Strings.errorBD, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            
        }

        private void dateTimePickerHasta_ValueChanged(object sender, EventArgs e)
        {
            
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
                DialogResult result = MessageBox.Show(Strings.errorBD, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (e.ColumnIndex == 7)
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
            dataGridViewEventos.Columns[1].HeaderText = Strings.name;
            dataGridViewEventos.Columns[2].HeaderText = Strings.date;
            dataGridViewEventos.Columns[3].HeaderText = Strings.location;
            dataGridViewEventos.Columns[4].HeaderText = Strings.time;
            dataGridViewEventos.Columns[5].HeaderText = Strings.deadline;
            dataGridViewEventos.Columns[6].HeaderText = Strings.numberOfAttendees;
            dataGridViewEventos.Columns[7].HeaderText = Strings.community;
            buttonVerAsistentes.Text = Strings.seeAttendees;
            buttonVerValoraciones.Text = Strings.seeRatings;
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

        private void pictureBoxLupa_Click(object sender, EventArgs e)
        {
            buscarPorFecha();
        }

        private void dataGridViewEventos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            eventos evento = (eventos)dataGridViewEventos.SelectedRows[0].DataBoundItem;
            FormEvento eventoModificado = new FormEvento(evento, true);
            eventoModificado.ShowDialog();
        }

        private void buttonVerAsistentes_Click(object sender, EventArgs e)
        {
            eventos evento = (eventos)dataGridViewEventos.SelectedRows[0].DataBoundItem;
            FormAsistentes formAsistentes = new FormAsistentes(evento);
            formAsistentes.ShowDialog();
        }

        private void buttonVerValoraciones_Click(object sender, EventArgs e)
        {
            eventos evento = (eventos)dataGridViewEventos.SelectedRows[0].DataBoundItem;
            FormValoraciones formValoraciones = new FormValoraciones(evento);
            formValoraciones.Show();
        }
    }
}
