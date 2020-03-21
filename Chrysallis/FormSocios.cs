using Chrysallis.BD;
using Chrysallis.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Chrysallis
{
    public partial class FormSocios : Form
    {
        List<socios> socios;
        public FormSocios()
        {
            InitializeComponent();
        }

        private void FormSocios_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
            buttonAgregarSocio.Text = Strings.addPartner;
            cambiarIdioma();
        }

        public void cambiarIdioma()
        {
            this.Text = Strings.partners;
            labelSearch.Text = Strings.buscar;
            labelFilterComunidad.Text = Strings.community;
            buttonClean.Text = Strings.clean;

            dataGridViewSocios.Columns[2].HeaderText = Strings.phone;
            dataGridViewSocios.Columns[3].HeaderText = Strings.name;
            dataGridViewSocios.Columns[4].HeaderText = Strings.lastName;
            dataGridViewSocios.Columns[5].HeaderText = Strings.active;
            dataGridViewSocios.Columns[6].HeaderText = Strings.email;
            dataGridViewSocios.Columns[7].HeaderText = Strings.password;
            dataGridViewSocios.Columns[8].HeaderText = Strings.admin;
            dataGridViewSocios.Columns[10].HeaderText = Strings.state;
            dataGridViewSocios.Columns[12].HeaderText = Strings.community;

        }


        private void buttonAgregarSocio_Click(object sender, EventArgs e)
        {
            FormSocio formSocio = new FormSocio();
            formSocio.ShowDialog();
            RefrescarDatos();
        }

        private void RefrescarDatos()
        {
            List<comunidades> comunidades = ComunidadORM.SelectAllComunidades();
            List<comunidades> comunidadesOriginal;
                comunidadesOriginal = (from c in comunidades
                                       let a = new comunidades() { id = c.id, nombre = GestorIdiomas.getComunidad(c.nombre) }
                                       select a).ToList();
            socios = SocioORM.SelectAllSocios();
            bindingSourceComunidades.DataSource = comunidadesOriginal;
            if (socios == null)
            {
                DialogResult result = MessageBox.Show(Strings.errorBD, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                List<socios> sociosComunidad = SocioORM.SelectAllSociosByComunidad((int)FormLogin.socioLogin.id_comunidad);
                bindingSourceSocios.DataSource = sociosComunidad;
                labelFilterComunidad.Visible = false;
                comboBoxFilterComunidad.Visible = false;
                buttonClean.Visible = false;
            }

        }

        private void dataGridViewSocios_DoubleClick(object sender, EventArgs e)
        {

            socios socio = (socios)dataGridViewSocios.SelectedRows[0].DataBoundItem;
            FormSocio formSocio = new FormSocio(socio, true);
            formSocio.ShowDialog();
            RefrescarDatos();
        }

        private void dataGridViewSocios_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            socios s = (socios)dataGridViewSocios.SelectedRows[0].DataBoundItem;
            Boolean correcto;
            if (s.id != FormLogin.socioLogin.id)
            {
                DialogResult resultado = MessageBox.Show(Strings.confirmDeleteUser, Strings.confirmation, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    correcto = SocioORM.DeleteSocio((socios)dataGridViewSocios.SelectedRows[0].DataBoundItem);
                    if (!correcto)
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show(Strings.cannotDeleteYourself, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void dataGridViewSocios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            socios _socio;

            if (e.ColumnIndex == 12)
            {
                _socio = (socios)dataGridViewSocios.Rows[e.RowIndex].DataBoundItem;
                if (_socio.comunidades != null)
                {
                    e.Value = GestorIdiomas.getComunidad(_socio.comunidades.nombre);
                }
                
            }
        }

        private void pictureBoxLupa_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Equals(""))
            {
                if (FormLogin.socioLogin.estatal)
                {
                    bindingSourceSocios.DataSource = SocioORM.SelectAllSocios();
                }
                else
                {
                    List<socios> sociosComunidad = SocioORM.SelectAllSociosByComunidad((int)FormLogin.socioLogin.id_comunidad);
                    bindingSourceSocios.DataSource = sociosComunidad;
                }
            }
            else
            {
                String busqueda = textBoxSearch.Text;
                if (FormLogin.socioLogin.estatal)
                {
                    bindingSourceSocios.DataSource = SocioORM.SelectSocioBySearch(busqueda);
                }
                else
                {
                    bindingSourceSocios.DataSource = SocioORM.SelectSocioBySearchAndComunity(busqueda, FormLogin.socioLogin.id_comunidad.Value);
                }
            }
        }

        private void comboBoxFilterComunidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxFilterComunidad.SelectedItem != null)
            {
                List<socios> sociosFilter = SocioORM.SelectAllSociosByComunidad(int.Parse(comboBoxFilterComunidad.SelectedValue.ToString()));
                 bindingSourceSocios.DataSource = sociosFilter;
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            bindingSourceSocios.DataSource = socios;
        }
    }
}
