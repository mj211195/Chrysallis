using Chrysallis.BD;
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

        public FormEvento()
        {
            InitializeComponent();
        }

        private void FormEvento_Load(object sender, EventArgs e)
        {
            bindingSourceComunidades.DataSource = ComunidadORM.SelectAllComunidades();
            cargarHora();
            cambiarIdioma(); 
     
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
            else if (listBoxNotificaciones.SelectedItems.Count == 0)
            {
                MessageBox.Show("Se tiene que seleccionar minimo una notificacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
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
            comboBoxHora.Items.Clear();

            for (int minutos = 0; minutos < 1440; minutos += 15)
            {
                string hour = new DateTime().AddMinutes(minutos).ToString("HH:mm");
                comboBoxHora.Items.Add(hour);
            }
            comboBoxHora.Text = "07:00";
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

        }
    }
}
