using System;
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
            int result;
            if (textBoxDni.Text.Trim().Equals(""))
            {
                MessageBox.Show("El DNI no puede estar vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxPhone.Text.Trim().Equals(""))
            {
                MessageBox.Show("El teléfono no puede estar vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(textBoxPhone.Text.Trim(), out result))
            {
                MessageBox.Show("El teléfono debe ser numérico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxName.Text.Trim().Equals(""))
            {
                MessageBox.Show("El nombre no puede estar vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxLastName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Los apellidos no pueden estar vacíos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxEmail.Text.Trim().Equals(""))
            {
                MessageBox.Show("El correo no puede estar vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("La contraseña no puede estar vacía", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!textBoxPassword2.Text.Trim().Equals(textBoxPassword.Text.Trim()))
            {
                MessageBox.Show("La contraseña no coincide", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                socios socio = new socios();
                socio.dni = textBoxDni.Text.Trim();
                socio.telefono = textBoxPhone.Text.Trim();
                socio.nombre = textBoxName.Text.Trim();
                socio.apellidos = textBoxLastName.Text.Trim();
                socio.mail = textBoxEmail.Text.Trim();
                socio.password = textBoxPassword.Text.Trim();
                socio.activo = checkBoxActive.Checked;
                socio.administrador = checkBoxAdministrator.Checked;
                socio.estatal = checkBoxState.Checked;
                if (checkBoxAdministrator.Checked)
                {
                    if (comboBoxComunity.SelectedItem != null)
                    {
                        socio.id_comunidad = (int)comboBoxComunity.SelectedValue;
                    }
                    
                }
                else
                {
                    socio.id_comunidad = null;
                }
                
                
            }
        }

        private void FormSocio_Load(object sender, EventArgs e)
        {
            bindingSourceComunidades.DataSource = BD.ComunidadORM.SelectAllComunidades();
            buttonSave.Location = new System.Drawing.Point(97, 224);
            cambiarIdioma();
        }

        public void cambiarIdioma()
        {
            this.Text = Idiomas.Strings.partner;
            labelPhone.Text = Idiomas.Strings.phone;
            labelName.Text = Idiomas.Strings.name;
            labelLastName.Text = Idiomas.Strings.lastName;
            labelEmail.Text = Idiomas.Strings.email;
            labelPassword.Text = Idiomas.Strings.password;
            labelComunidad.Text = Idiomas.Strings.comunity;
            buttonSave.Text = Idiomas.Strings.save;
            checkBoxActive.Text = Idiomas.Strings.active;
            checkBoxState.Text = Idiomas.Strings.state;
            checkBoxAdministrator.Text = Idiomas.Strings.admin;

        }

        private void checkBoxAdministrator_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdministrator.Checked)
            {
                checkBoxState.Visible = true;
                labelComunidad.Visible = true;
                comboBoxComunity.Visible = true;
                buttonSave.Location = new System.Drawing.Point(97,251);
            }
            else
            {

                checkBoxState.Visible = false;
                labelComunidad.Visible = false;
                comboBoxComunity.Visible = false;
                buttonSave.Location = new System.Drawing.Point(97, 224);
            }
        }
    }
}
