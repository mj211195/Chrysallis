using Chrysallis.BD;
using Chrysallis.Idiomas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chrysallis
{
    public partial class FormSocio : Form

    {
        List<comunidades> comunidades;
        private int id;

        public FormSocio()
        {
            InitializeComponent();
            this.id = 0;
        }

        public FormSocio(int id)
        {
            InitializeComponent();
            this.id = id;
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            long result;
            if (textBoxDni.Text.Trim().Equals(""))
            {
                MessageBox.Show(Strings.errorDni, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxPhone.Text.Trim().Equals(""))
            {
                MessageBox.Show(Strings.errorPhone, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!long.TryParse(textBoxPhone.Text.Trim(), out result))
            {
                MessageBox.Show(Strings.errorPhoneNum, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxName.Text.Trim().Equals(""))
            {
                MessageBox.Show(Strings.errorName, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxLastName.Text.Trim().Equals(""))
            {
                MessageBox.Show(Strings.errorLastName, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxEmail.Text.Trim().Equals(""))
            {
                MessageBox.Show(Strings.errorEmail, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show(Strings.errorPassword, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!textBoxPassword2.Text.Trim().Equals(textBoxPassword.Text.Trim()))
            {
                MessageBox.Show(Strings.errorPassword2, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                socios socio = new socios();
                socio.dni = textBoxDni.Text.Trim();
                socio.telefono = textBoxPhone.Text.Trim();
                socio.nombre = textBoxName.Text.Trim();
                socio.apellidos = textBoxLastName.Text.Trim();
                socio.mail = textBoxEmail.Text.Trim();

                OC.Core.Crypto.Hash hash = new OC.Core.Crypto.Hash();
                String clave = hash.Sha512(textBoxPassword.Text.Trim());
                socio.password = clave;

                socio.activo = checkBoxActive.Checked;
                socio.administrador = checkBoxAdministrator.Checked;
                socio.estatal = checkBoxState.Checked;
                if (checkBoxAdministrator.Checked)
                {
                    if (comboBoxComunity.SelectedItem != null)
                    {
                        //Apaño pq al cambiar idioma no funcionaba, intentaba guardarlo en otro idioma y petaba
                        foreach (comunidades c in comunidades)
                        {
                            String aux = GestorIdiomas.getComunidad(c.nombre);
                            if (aux.Equals(comboBoxComunity.Text))
                            {
                                socio.id_comunidad = c.id;
                            }
                        }
                    }
                    
                }
                else
                {
                    socio.id_comunidad = null;
                }

                if (SocioORM.InsertSocio(socio) && id != 0)
                {
                    MessageBox.Show(Strings.partnerCreated, Strings.created, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {

                    MessageBox.Show("El socio ha sido modificado", "MODIFICADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void FormSocio_Load(object sender, EventArgs e)
        {
            comunidades = ComunidadORM.SelectAllComunidades();
            //no uso el bindingsource pq me daba problemas al cambiar de idioma
            //bindingSourceComunidades.DataSource = comunidades;
            cambiarIdioma();
            buttonSave.Location = new System.Drawing.Point(97, 224);
        }

        public void cambiarIdioma()
        {
            this.Text = Strings.partner;
            labelPhone.Text = Strings.phone;
            labelName.Text = Strings.name;
            labelLastName.Text = Strings.lastName;
            labelEmail.Text = Strings.email;
            labelPassword.Text = Strings.password;
            labelComunidad.Text = Strings.comunity;
            labelPassword2.Text = Strings.password2;
            buttonSave.Text = Strings.save;
            checkBoxActive.Text = Strings.active;
            checkBoxState.Text = Strings.state;
            checkBoxAdministrator.Text = Strings.admin;


            //Apaño pq al cambiar idioma no funcionaba, intentaba guardarlo en otro idioma y petaba
            List<String> comunidadesString = new List<String>();
            foreach (comunidades c in comunidades)
            {
                comunidadesString.Add(GestorIdiomas.getComunidad(c.nombre));
            }
            comboBoxComunity.DataSource = comunidadesString;
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
