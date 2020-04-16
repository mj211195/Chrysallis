using Chrysallis.BD;
using Chrysallis.Idiomas;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Chrysallis
{
   
    
    public partial class FormEvento : Form
    {
        List<comunidades> comunidades;
        eventos evento = new eventos();
        eventos eventoNew = new eventos();
        private Boolean modificar;
        List<documentos> documentosLista = new List<documentos>();
        List<notificaciones> notificacion = new List<notificaciones>();

        //Cargamos formulario para agregar un nuevo evento
        public FormEvento()
        {
            InitializeComponent();
            modificar = false;
        }

        //Cargamos formulario para modificar un evento
        public FormEvento(eventos evento, Boolean modificar)
        {
            InitializeComponent();
            this.evento = evento;
            this.eventoNew = evento;
            this.modificar = modificar;
            cargarDatos(evento);
            cambiarForma();
        }

        //Cargamos los datos del evento seleccionado para modificalo
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
            if(evento.notificaciones.Count != 0)
            {
                notificacion = evento.notificaciones.ToList();
                bindingSourceNotificacionesGuardar.DataSource = notificacion;
            }
            textBoxNumeroAsistentes.Text = evento.numAsistentes.ToString();
            if(evento.documentos.Count != 0)
            {
                foreach (documentos d in documentosLista)
                {
                    documentosLista.Add(d);
                }
                bindingSourceDocumentos.DataSource = evento.documentos;
                documentosLista = evento.documentos.ToList();
            }
            
        }

        //Se bloquea el combobox de comunidades al modificar para que no se pueda modificar
        private void cambiarForma()
        {
            comboBoxComunity.Enabled = false;
        }

        //Cuando cargamos el formulario cargamos los datos de notificaciones y de las comundades
        private void FormEvento_Load(object sender, EventArgs e)
        {
            bindingSourceNotificaciones.DataSource = null;
            bindingSourceNotificaciones.DataSource = NotificacionORM.SelectAllNotificaciones();
            comunidades = ComunidadORM.SelectAllComunidades();
            dateTimePickerHora.CustomFormat = "HH:mm";
            cambiarIdioma();
            foreach (comunidades c in comunidades)
            {
                if (c.id == evento.id_comunidad)
                {
                    comboBoxComunity.Text = GestorIdiomas.getComunidad(c.nombre);
                }
            }
            if (!modificar)
            {
                dateTimePickerFecha.Value = DateTime.Today;
                dateTimePickerFechaLimite.Value = DateTime.Today;
            }
            else
            {
                foreach (notificaciones n in evento.notificaciones)
                {
                    bindingSourceNotificaciones.Remove(n);
                }
            }

        }

        //Hacemos click para guardar los datos del evento
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Comprobamos que todos los campos esten llenos y en formato correcto
            if (textBoxNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show(Strings.errorName, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxDescripcion.Text.Trim().Equals(""))
            {
                MessageBox.Show(Strings.errorDescription, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateTimePickerFecha.Value < DateTime.Today)
            {
                MessageBox.Show(Strings.errorDate, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxUbicacion.Text.Trim().Equals(""))
            {
                MessageBox.Show(Strings.errorLocation, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateTimePickerFechaLimite.Value < DateTime.Today)
            {
                MessageBox.Show(Strings.errorDate, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (listBoxNotificacionesSelec.SelectedItems.Count == 0)
            {
                MessageBox.Show(Strings.errorNotification, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateTimePickerFechaLimite.Value > dateTimePickerFecha.Value)
            {
                MessageBox.Show(Strings.errorDateLimit, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(textBoxNumeroAsistentes.Text, out int num))
            {
                MessageBox.Show(Strings.errorAsistentes, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                //Pasamos los datos rellenados al nuevo evento
                documentos documento = new documentos();
                eventoNew.nombre = textBoxNombre.Text.Trim();
                eventoNew.descripcion = textBoxDescripcion.Text.Trim();

                //Si creamos el evento la pasamos como base64String
                if (textBoxImagen.Text != "" && !modificar)
                {
                    eventoNew.nombreImagen = openFileDialogImagen.SafeFileName;
                    string base64String = Convert.ToBase64String(File.ReadAllBytes(openFileDialogImagen.FileName));
                    eventoNew.imagen = base64String;
                }
                //Si modificamos el evento si es diferente al que hemos cargado le pasamos el nuevo string
                else if (modificar)
                {
                    if (!textBoxImagen.Text.Equals(eventoNew.nombreImagen))
                    {
                        eventoNew.nombreImagen = openFileDialogImagen.SafeFileName;
                        string base64String = Convert.ToBase64String(File.ReadAllBytes(openFileDialogImagen.FileName));
                        eventoNew.imagen = base64String;
                    }
                }
                //En el caso de este vacio lo pasamos como null
                else
                {
                    evento.imagen = null;
                    evento.nombreImagen = "";
                }
                
                eventoNew.fecha = dateTimePickerFecha.Value.Date;
                eventoNew.ubicacion = textBoxUbicacion.Text.Trim();
                eventoNew.hora = dateTimePickerHora.Value.TimeOfDay;
                eventoNew.fechaLimite = dateTimePickerFechaLimite.Value.Date;
                eventoNew.documentos = documentosLista;
                eventoNew.notificaciones = notificacion;
                if (!textBoxNumeroAsistentes.Text.Trim().Equals(""))
                {
                    eventoNew.numAsistentes = int.Parse(textBoxNumeroAsistentes.Text.Trim());
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
                            eventoNew.id_comunidad = c.id;
                        }
                    }
                }
                
                
                //Si creamos el evento mostramos su mensaje
                if (!modificar)
                {
                    if (EventoORM.InsertEvento(eventoNew))
                    {
                        MessageBox.Show(Strings.eventCreated, Strings.created, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                //Si moficamos el evento mostramos su mensaje
                else
                {
                    if (EventoORM.UpdateEvento(eventoNew))
                    {
                        MessageBox.Show(Strings.eventModified, Strings.modified, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        //Muestra error en caso de que no sea correcto el archivo seleccionado
        private void errorDocumento()
        {
            MessageBox.Show(Strings.errorDocument);
        }

        //Metodo para cambiar el idioma
        public void cambiarIdioma()
        {
            this.Text = Strings.addEvent;
            if (modificar)
            {
                this.Text = Strings.modifyEvent;
            }
            labelFecha.Text = Strings.date;
            labelUbicacion.Text = Strings.location;
            labelHora.Text = Strings.time;
            labelFechaLimite.Text = Strings.deadline;
            labelNumeroAsistentes.Text = Strings.numberOfAttendees;
            labelComunidad.Text = Strings.community;
            labelDocumentos.Text = Strings.documents;
            labelNotificaciones.Text = Strings.notifications;
            buttonSave.Text = Strings.save;
            buttonDocumento.Text = Strings.choose;
            labelNombre.Text = Strings.name;
            labelImagen.Text = Strings.image;
            buttonDocumento.Text = Strings.choose;
            labelDescripcion.Text = Strings.description;
            buttonNuevo.Text = Strings.newdoc;
            buttonEliminar.Text = Strings.remove;
            buttonVer.Text = Strings.see;
            buttonAñadirNot.Text = Strings.add;
            buttonEliminarNot.Text = Strings.delete;
            

            //Apaño pq al cambiar idioma no funcionaba, intentaba guardarlo en otro idioma y petaba
            List<String> comunidadesString = new List<String>();
            foreach (comunidades c in comunidades)
            {
                comunidadesString.Add(GestorIdiomas.getComunidad(c.nombre));
            }
            comboBoxComunity.DataSource = comunidadesString;
        }

        //Al apretar el boton abre un openFileDialog, recogemos el archivo y su nombre
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

        //Al apretar el boton abre un openFileDialog para añadirlo a la lista de documentos
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialogDocumentos.ShowDialog() == DialogResult.OK)
                {
                    documentos documento = new documentos();
                    documento.nombre = openFileDialogDocumentos.SafeFileName;
                    documento.documento = Convert.ToBase64String(File.ReadAllBytes(openFileDialogDocumentos.FileName));
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

        //Al hacer click sobre el boton y tener un documento seleccionado nos lo abre con los programas propios del sistema
        private void buttonVer_Click(object sender, EventArgs e)
        {
            documentos documento;
            if (listBoxDocumentos.SelectedItem != null)
            {
                documento = (documentos)listBoxDocumentos.SelectedItem;
                byte[] docBytes = Convert.FromBase64String(documento.documento);
                File.WriteAllBytes(documento.nombre,docBytes);
                Process.Start(documento.nombre);
            }
           
        }

        //Al seleccionar un documento y pulsar el boton eliminar nos lo elimina de la lista
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxDocumentos.SelectedItem != null)
            {
                documentosLista.Remove((documentos)listBoxDocumentos.SelectedItem);
                bindingSourceDocumentos.RemoveAt(listBoxDocumentos.SelectedIndex);
            }
            
        }

        //AL seleccionar la notificacion y pulsar en añadir nos lo pasa a la lista de notificacines seleccionadas
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
                MessageBox.Show(Strings.errorNotification, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        //AL seleccionar la notificacion y pulsar en eliminar nos lo pasa a la lista de notificacines base eliminandola de las seleccionadas
        private void buttonEliminarNot_Click(object sender, EventArgs e)
        {
            notificaciones notificacionEliminar = new notificaciones();

            if (listBoxNotificacionesSelec.SelectedItem!= null)
            {
                notificacionEliminar.antelacion = ((notificaciones)listBoxNotificacionesSelec.SelectedItem).antelacion;
                bindingSourceNotificaciones.Add(notificacionEliminar);
                bindingSourceNotificacionesGuardar.RemoveAt(listBoxNotificacionesSelec.SelectedIndex);
                bindingSourceNotificaciones.Sort = "antelacion ASC";
                
            }
            else
            {
                MessageBox.Show(Strings.errorNotification, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
           
            
        }
    }
}
