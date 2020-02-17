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
                /*if (checkBoxAdministrator.Checked)
                {
                    socio.id_comunidad = comboBoxComunity.SelectedValue;
                }

                hotel.id_ciudad = (int)comboBoxCiudad.SelectedValue;
                hotel.nombre = textBoxNombre.Text;
                hotel.categoria = int.Parse(textBoxCategoria.Text.Trim());
                hotel.direccion = textBoxDireccion.Text;
                hotel.telefono = int.Parse(textBoxTelefono.Text);
                hotel.tipo = comboBoxTipo.Text;
                hotel.cif = comboBoxCadena.SelectedValue.ToString();


                if (nombre == null)
                {
                    if (BD.ORM.InsertHotel(hotel))
                    {
                        MessageBox.Show("El hotel ha sido creado", "CREADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
                else
                {
                    BD.ORM.UpdateHotel(hotel);
                    MessageBox.Show("El hotel ha sido modificado", "MODIFICADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }*/
            }
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
