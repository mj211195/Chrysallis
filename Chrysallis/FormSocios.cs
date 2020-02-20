using Chrysallis.BD;
using Chrysallis.Idiomas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chrysallis
{
    public partial class FormSocios : Form
    {
        public FormSocios()
        {
            InitializeComponent();
        }

        private void FormSocios_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
            buttonAgregarSocio.Text = Strings.addPartner;
            this.Text = Strings.partners;
        }

        private void buttonAgregarSocio_Click(object sender, EventArgs e)
        {
            FormSocio formSocio = new FormSocio();
            formSocio.ShowDialog();
            RefrescarDatos();
        }

        private void RefrescarDatos()
        {
            List<socios> socios = SocioORM.SelectAllSocios();
            if (socios == null)
            {
                DialogResult result = MessageBox.Show("Error al acceder a la BD.\nSe procede a cerrar el programa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK || result == DialogResult.Abort)
                {
                    Application.Exit();
                }
            }
            else if ((bool)FormLogin.socioLogin.estatal)
            {
                bindingSourceSocios.DataSource = socios;
            }
            else
            {
                //Apaño muy feo
                List<socios> sociosComunidad = SocioORM.SelectAllSociosByComunidad((int)FormLogin.socioLogin.id_comunidad);
                List<socios> aux = SocioORM.SelectAllSocios();
                foreach (socios s in aux)
                {
                    foreach (comunidades c in s.comunidades1)
                    {
                        if(c.id == FormLogin.socioLogin.id_comunidad && !sociosComunidad.Contains(s))
                        {
                            sociosComunidad.Add(s);
                        }
                    }
                }
                bindingSourceSocios.DataSource = sociosComunidad;
            }


            //Apaño feo feo pero feo
            List<comunidades> comunidades = ComunidadORM.SelectAllComunidades();
            foreach (DataGridViewRow item in dataGridViewSocios.Rows)
            {
                foreach (comunidades c in comunidades)
                {
                    String aux = GestorIdiomas.getComunidad(c.nombre);
                    if (item.Cells[11].Value != null)
                    {
                        if ((int)item.Cells[11].Value == c.id)
                        {
                            item.Cells[12].Value = aux;
                        }
                    }
                }
            }
        }

        private void dataGridViewSocios_DoubleClick(object sender, EventArgs e)
        {

            socios socio = (socios)dataGridViewSocios.SelectedRows[0].DataBoundItem;
            FormSocio formSocio = new FormSocio(socio);
            formSocio.ShowDialog();
            RefrescarDatos();
        }

        private void dataGridViewSocios_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            socios s = (socios)dataGridViewSocios.SelectedRows[0].DataBoundItem;
            if (s.id != FormLogin.socioLogin.id)
            {
                DialogResult resultado = MessageBox.Show("¿Quiere eliminar el hotel seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    SocioORM.DeleteSocio((socios)dataGridViewSocios.SelectedRows[0].DataBoundItem);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show("No puede eliminar su propio usuario!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
    }
}
