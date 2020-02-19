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
            List<eventos> eventos = EventoORM.SelectAllEventos();
            if (eventos == null)
            {
                DialogResult result = MessageBox.Show("Error al acceder a la BD.\nSe procede a cerrar el programa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK || result == DialogResult.Abort)
                {
                    Application.Exit();
                }
            }
            else if (FormLogin.socioLogin.estatal == true)
            {
                bindingSourceEventos.DataSource = eventos;
            }
            else
            {

            }

        }
    }
}
