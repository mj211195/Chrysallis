using Chrysallis.BD;
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
    public partial class FormSocios : Form
    {
        public FormSocios()
        {
            InitializeComponent();
        }

        private void FormSocios_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
            buttonAgregarSocio.Text = Idiomas.Strings.addPartner;
            this.Text = Idiomas.Strings.partners;
        }

        private void buttonAgregarSocio_Click(object sender, EventArgs e)
        {
            FormSocio formSocio = new FormSocio();
            formSocio.ShowDialog();
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
            else
            {
                bindingSourceSocios.DataSource = socios;
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
    }
}
