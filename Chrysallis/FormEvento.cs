using Chrysallis.BD;
using Chrysallis.Idiomas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chrysallis
{
   
    
    public partial class FormEvento : Form
    {
        List<comunidades> comunidades;
        eventos evento = new eventos();
        private Boolean modificar;
        List<documentos> documentosLista = new List<documentos>();
        List<notificaciones> notificacion = new List<notificaciones>();
        public FormEvento()
        {
            InitializeComponent();
            modificar = false;
        }

        public FormEvento(eventos evento, Boolean modificar)
        {
            InitializeComponent();
            this.evento = evento;
            this.modificar = modificar;
            cargarDatos(evento);
            cambiarForma();
        }

        private void cargarDatos(eventos evento)
        {
            textBoxNombre.Text = evento.nombre;
            textBoxDescripcion.Text = evento.descripcion;
            textBoxImagen.Text = evento.nombreImagen;
            dateTimePickerFecha.Value = evento.fecha;
            textBoxUbicacion.Text = evento.ubicacion;
            dateTimePickerFechaLimite.Value = (DateTime)evento.fechaLimite.Value;
            dateTimePickerHora.Value = evento.fecha + evento.hora;
            comboBoxComunity.SelectedValue = evento.id_comunidad;
            bindingSourceNotificacionesGuardar.DataSource = evento.notificaciones;
            
            
            textBoxNumeroAsistentes.Text = evento.numAsistentes.ToString();
            foreach (documentos d in documentosLista)
            {
                documentosLista.Add(d);
            }
            bindingSourceDocumentos.DataSource = evento.documentos;
            
        }

        private void cambiarForma()
        {
            comboBoxComunity.Enabled = false;
        }

        private void FormEvento_Load(object sender, EventArgs e)
        {
            bindingSourceNotificaciones.DataSource = null;
            bindingSourceNotificaciones.DataSource = NotificacionORM.SelectAllNotificaciones();
            comunidades = ComunidadORM.SelectAllComunidades();
            dateTimePickerHora.CustomFormat = "HH:mm";
            dateTimePickerFecha.Value = DateTime.Today;
            dateTimePickerFechaLimite.Value = DateTime.Today;
            cambiarIdioma();
            foreach (comunidades c in comunidades)
            {
                if (c.id == evento.id_comunidad)
                {
                    comboBoxComunity.Text = GestorIdiomas.getComunidad(c.nombre);
                }
            }
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Se tiene que introducir nombre al evento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxDescripcion.Text.Trim().Equals(""))
            {
                MessageBox.Show("Se tiene que introducir una descripción", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateTimePickerFecha.Value < DateTime.Today)
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
            else if (listBoxNotificacionesBase.SelectedItems.Count == 0)
            {
                MessageBox.Show("Se tiene que seleccionar minimo una notificacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                

                eventos eventoNew = new eventos();
                documentos documento = new documentos();
                eventoNew.nombre = textBoxNombre.Text.Trim();
                eventoNew.descripcion = textBoxDescripcion.Text.Trim();
                eventoNew.nombreImagen = openFileDialogImagen.SafeFileName;

                if (textBoxImagen.Text != "")
                {
                    eventoNew.nombreImagen = openFileDialogImagen.SafeFileName;
                }
                else
                {
                    evento.nombreImagen = null;
                }

                if (textBoxImagen.Text != "")
                {
                    eventoNew.imagen = File.ReadAllBytes(openFileDialogImagen.FileName);
                }
                else
                {
                    evento.imagen = null;
                }
                
                eventoNew.fecha = dateTimePickerFecha.Value.Date;
                eventoNew.ubicacion = textBoxUbicacion.Text.Trim();
                eventoNew.hora = dateTimePickerHora.Value.TimeOfDay;
                eventoNew.fechaLimite = dateTimePickerFechaLimite.Value.Date;
                eventoNew.numAsistentes = int.Parse(textBoxNumeroAsistentes.Text.Trim());

                if (documentosLista.Count != 0)
                {
                    eventoNew.documentos = documentosLista;
                }
                else
                {
                    eventoNew.documentos = null;
                }
                
                if (notificacion.Count != 0)
                {
                    eventoNew.notificaciones = notificacion;
                }
                else
                {
                    eventoNew.notificaciones = null;
                }
                

                if (comboBoxComunity.SelectedItem != null)
                {
                    //Apaño pq al cambiar idioma no funcionaba, intentaba guardarlo en otro idioma y petaba
                    foreach (comunidades c in comunidades)
                    {
                        String aux = GestorIdiomas.getComunidad(c.nombre);
                        if (aux.Equals(comboBoxComunity.Text))
                        {
                            eventoNew.comunidades = c;
                        }
                    }
                }
                
                
                
                if (!modificar)
                {
                    if (EventoORM.InsertEvento(eventoNew))
                    {
                        MessageBox.Show("El evento ha sido creado", "CREADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    eventoNew.id = evento.id;
                    if (EventoORM.UpdateEvento(eventoNew))
                    {
                        MessageBox.Show("El evento ha sido modificado", "MODIFICADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        //Muestra error en caso de que no sea correcto el archivo seleccionado
        private void errorDocumento()
        {
            MessageBox.Show("El arxiu seleccionat no es un document");
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
            labelNombre.Text = Idiomas.Strings.name;
            labelImagen.Text = Idiomas.Strings.image;
            buttonDocumento.Text = Idiomas.Strings.choose;
            labelDescripcion.Text = Idiomas.Strings.description;
            buttonNuevo.Text = Idiomas.Strings.newdoc;
            buttonEliminar.Text = Idiomas.Strings.remove;
            buttonVer.Text = Idiomas.Strings.see;
            

            //Apaño pq al cambiar idioma no funcionaba, intentaba guardarlo en otro idioma y petaba
            List<String> comunidadesString = new List<String>();
            foreach (comunidades c in comunidades)
            {
                comunidadesString.Add(GestorIdiomas.getComunidad(c.nombre));
            }
            comboBoxComunity.DataSource = comunidadesString;
        }

        private void buttonDocumento_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialogImagen.ShowDialog() == DialogResult.OK)
                {
                    string documento = openFileDialogImagen.SafeFileName;
                    textBoxImagen.Text = documento;
                    
                }
            }
            catch (Exception)
            {
                errorDocumento();
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialogDocumentos.ShowDialog() == DialogResult.OK)
                {
                    documentos documento = new documentos();
                    documento.nombre = openFileDialogDocumentos.SafeFileName;
                    documento.documento = File.ReadAllBytes(openFileDialogDocumentos.FileName);
                    documentosLista.Add(documento);
                    bindingSourceDocumentos.DataSource = null;
                    bindingSourceDocumentos.DataSource = documentosLista;
                }
            }
            catch (Exception)
            {
                errorDocumento();
            }
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            documentos documento;
            if (listBoxDocumentos.SelectedItem != null)
            {
                documento = (documentos)listBoxDocumentos.SelectedItem;
                File.WriteAllBytes(documento.nombre, documento.documento);
                Process.Start(documento.nombre);
            }
           
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {  
             bindingSourceDocumentos.RemoveAt(listBoxDocumentos.SelectedIndex);
        }

        private void buttonAñadirNot_Click(object sender, EventArgs e)
        {
            notificaciones notificacionNueva = new notificaciones();

            if (listBoxNotificacionesBase.SelectedItem != null)
            {
                notificacion.Add((notificaciones)listBoxNotificacionesBase.SelectedItem);
                bindingSourceNotificacionesGuardar.DataSource = null;
                bindingSourceNotificacionesGuardar.DataSource = notificacion;
                bindingSourceNotificaciones.RemoveAt(listBoxNotificacionesBase.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Tienes que seleccionar al menos un elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void buttonEliminarNot_Click(object sender, EventArgs e)
        {
            notificaciones notificacionEliminar = new notificaciones();

            if (listBoxNotificacionesSelec.SelectedItem!= null)
            {
                notificacionEliminar.antelacion = ((notificaciones)listBoxNotificacionesSelec.SelectedItem).antelacion;
                bindingSourceNotificaciones.Add(notificacionEliminar);
                bindingSourceNotificacionesGuardar.RemoveAt(listBoxNotificacionesSelec.SelectedIndex);
                bindingSourceNotificaciones.Sort = "antelacion";
                //bindingSourceNotificaciones.DataSource = bindingSourceNotificaciones.Sort = "id";
                //bindingSourceNotificaciones.RemoveSort;
            }
            else
            {
                MessageBox.Show("Tienes que seleccionar al menos un elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
           
            
        }
    }
}
