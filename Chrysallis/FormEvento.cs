﻿using Chrysallis.BD;
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
    public partial class FormEvento : Form
    {
        List<comunidades> comunidades;
        eventos eventos = new eventos();
        public FormEvento()
        {
            InitializeComponent();
        }

        private void FormEvento_Load(object sender, EventArgs e)
        {
            List<notificaciones> notificaciones = NotificacionORM.SelectAllNotificaciones();
            bindingSourceNotificaciones.DataSource = notificaciones;

            comunidades = ComunidadORM.SelectAllComunidades();
            dateTimePickerHora.CustomFormat = "HH:mm";
            dateTimePickerFecha.Value = DateTime.Today;
            dateTimePickerFechaLimite.Value = DateTime.Today;
            cargarHora();
            cambiarIdioma();
            foreach (comunidades c in comunidades)
            {
                if (c.id == eventos.id_comunidad)
                {
                    comboBoxComunity.Text = GestorIdiomas.getComunidad(c.nombre);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFecha.Value < DateTime.Today)
            {
                MessageBox.Show("No se pueden poner fechas anteriores a la actual", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxUbicacion.Text.Trim().Equals(""))
            {
                MessageBox.Show("La ubicacion no puede estar vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateTimePickerFechaLimite.Value < DateTime.Today)
            {
                MessageBox.Show("No se pueden poner fechas anteriores a la actual", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxNumeroAsistentes.Text.Trim().Equals(""))
            {
                MessageBox.Show("Se tiene que introducir el numero de asistentes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Comentado de momento para que no de error al crear evento
            //else if (listBoxNotificaciones.SelectedItems.Count == 0)
            //{
            //    MessageBox.Show("Se tiene que seleccionar minimo una notificacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            else
            {
                eventos evento = new eventos();
                evento.fecha = dateTimePickerFecha.Value;
                evento.ubicacion = textBoxUbicacion.Text.Trim();
                evento.hora = dateTimePickerHora.Value.TimeOfDay;
                evento.fechaLimite = dateTimePickerFechaLimite.Value;
                evento.numAsistentes = int.Parse(textBoxNumeroAsistentes.Text.Trim());
                if (comboBoxComunity.SelectedItem != null)
                {
                    //Apaño pq al cambiar idioma no funcionaba, intentaba guardarlo en otro idioma y petaba
                    foreach (comunidades c in comunidades)
                    {
                        String aux = GestorIdiomas.getComunidad(c.nombre);
                        if (aux.Equals(comboBoxComunity.Text))
                        {
                            evento.comunidades = c;
                        }
                    }
                }
                //List<string> documento = new List<string>();
                //evento.documentos = documento;
                //evento.notificaciones = listBoxNotificaciones.SelectedItems();
                EventoORM.InsertEvento(evento);
            }
            

            this.Close();
        }

        private void buttonDocumento_Click(object sender, EventArgs e)
        {
            try
            {
                if (Documento1.ShowDialog() == DialogResult.OK)
                {
                    string documento = Documento1.FileName;
                    textBoxDocumentos.Text = documento;
                }
            }
            catch (Exception)
            {
                errorDocumento();
            }
        }

        private void buttonDocumentos2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Documento1.ShowDialog() == DialogResult.OK)
                {
                    string documento = Documento1.FileName;
                    textBoxDocumentos2.Text = documento;
                }
            }
            catch (Exception)
            {
                errorDocumento();
            }
        }

        private void buttonDocumentos3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Documento1.ShowDialog() == DialogResult.OK)
                {
                    string documento = Documento1.FileName;
                    textBoxDocumentos3.Text = documento;
                }
            }
            catch (Exception)
            {
                errorDocumento();
            }
        }

        //Muestra error en caso de que no sea correcto el archivo seleccionado
        private void errorDocumento()
        {
            MessageBox.Show("El arxiu seleccionat no es un document");
        }

        //Metodo para cargar las horas en el comoBoxHora
        private void cargarHora()
        {
            //comboBoxHora.Items.Clear();

            //for (int minutos = 0; minutos < 1440; minutos += 15)
            //{
            //    string hour = new DateTime().AddMinutes(minutos).ToString("HH:mm");
            //    comboBoxHora.Items.Add(hour);
            //}
            //comboBoxHora.Text = "07:00";
        }

        //Metodo para cambiar el idioma
        public void cambiarIdioma()
        {
            this.Text = Idiomas.Strings.partner;
            labelFecha.Text = Idiomas.Strings.date;
            labelUbicacion.Text = Idiomas.Strings.location;
            labelHora.Text = Idiomas.Strings.time;
            labelFechaLimite.Text = Idiomas.Strings.deadline;
            labelNumeroAsistentes.Text = Idiomas.Strings.numberOfAttendees;
            labelComunidad.Text = Idiomas.Strings.community;
            labelDocumentos.Text = Idiomas.Strings.documents;
            labelNotificaciones.Text = Idiomas.Strings.notifications;
            buttonSave.Text = Idiomas.Strings.save;
            buttonDocumento.Text = Idiomas.Strings.chosse;
            buttonDocumentos2.Text = Idiomas.Strings.chosse;
            buttonDocumentos3.Text = Idiomas.Strings.chosse;

            //Apaño pq al cambiar idioma no funcionaba, intentaba guardarlo en otro idioma y petaba
            List<String> comunidadesString = new List<String>();
            foreach (comunidades c in comunidades)
            {
                comunidadesString.Add(GestorIdiomas.getComunidad(c.nombre));
            }
            comboBoxComunity.DataSource = comunidadesString;
        }

    }
}
