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
    public partial class FormSocio : Form
    {
        public FormSocio()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSocio_Load(object sender, EventArgs e)
        {
            cambiarIdioma();
        }

        public void cambiarIdioma()
        {
            this.Text = Idiomas.Strings.partner;
            labelPhone.Text = Idiomas.Strings.phone;
            labelName.Text = Idiomas.Strings.name;
            labelLastName.Text = Idiomas.Strings.lastName;
            labelAddress.Text = Idiomas.Strings.address;
            labelEmail.Text = Idiomas.Strings.email;
            labelPassword.Text = Idiomas.Strings.password;
            labelComunidad.Text = Idiomas.Strings.comunity;
            buttonSave.Text = Idiomas.Strings.save;
            checkBoxActive.Text = Idiomas.Strings.active;
            checkBoxState.Text = Idiomas.Strings.state;
            checkBoxAdministrator.Text = Idiomas.Strings.admin;

        }
    }
}
