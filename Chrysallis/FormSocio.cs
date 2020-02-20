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
        private socios socio;

        public FormSocio()
        {
            InitializeComponent();
            this.socio = null;
        }

        public FormSocio(socios socio)
        {
            InitializeComponent();
            this.socio = socio;
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
                socios socioNuevo = new socios();
                comunidades com = new comunidades();
                socioNuevo.dni = textBoxDni.Text.Trim();
                socioNuevo.telefono = textBoxPhone.Text.Trim();
                socioNuevo.nombre = textBoxName.Text.Trim();
                socioNuevo.apellidos = textBoxLastName.Text.Trim();
                socioNuevo.mail = textBoxEmail.Text.Trim();

                String clave = textBoxPassword.Text.Trim();
                if(socio != null)
                {
                    if (!clave.Equals(socio.password))
                    {
                        OC.Core.Crypto.Hash hash = new OC.Core.Crypto.Hash();
                        clave = hash.Sha512(textBoxPassword.Text.Trim());

                    }
                }
                socioNuevo.password = clave;
                socioNuevo.activo = checkBoxActive.Checked;
                socioNuevo.administrador = checkBoxAdministrator.Checked;
                socioNuevo.estatal = checkBoxState.Checked;
                foreach (comunidades c in comunidades)
                {
                    String aux = GestorIdiomas.getComunidad(c.nombre);
                    if (aux.Equals(comboBoxComunity.Text))
                    {
                        com = c;
                        socioNuevo.comunidades1.Add(c);
                    }
                }
                if (checkBoxAdministrator.Checked)
                {
                    if (comboBoxComunity.SelectedItem != null)
                    {
                        //Apaño pq al cambiar idioma no funcionaba, intentaba guardarlo en otro idioma y petaba
                        socioNuevo.id_comunidad = com.id;
                    }
                    
                }
                else
                {
                    socioNuevo.id_comunidad = null;
                }
                if (socio == null)
                {
                    if (SocioORM.InsertSocio(socioNuevo))
                    {
                        MessageBox.Show(Strings.partnerCreated, Strings.created, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    socioNuevo.id = socio.id;
                    if (SocioORM.UpdateSocio(socioNuevo))
                    {
                        MessageBox.Show("El socio ha sido modificado", "MODIFICADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        private void FormSocio_Load(object sender, EventArgs e)
        {
            comunidades = ComunidadORM.SelectAllComunidades();
            //no uso el bindingsource pq me daba problemas al cambiar de idioma
            //bindingSourceComunidades.DataSource = comunidades;
            cambiarIdioma();
            //buttonSave.Location = new System.Drawing.Point(97, 224);

            if (socio != null)
            {
                textBoxDni.Text = socio.dni;
                textBoxPhone.Text = socio.telefono;
                textBoxName.Text = socio.nombre;
                textBoxLastName.Text = socio.apellidos;
                textBoxEmail.Text = socio.mail;
                textBoxPassword.Text = socio.password;
                textBoxPassword2.Text = socio.password;
                checkBoxActive.Checked = socio.activo;
                checkBoxAdministrator.Checked = socio.administrador;
                checkBoxState.Checked = (bool)socio.estatal;

                foreach (comunidades c in comunidades)
                {
                    if (c.id == socio.id_comunidad)
                    {
                        comboBoxComunity.Text = GestorIdiomas.getComunidad(c.nombre);
                    }
                }
                if (!(bool)FormLogin.socioLogin.estatal)
                {
                    checkBoxState.Enabled = false;
                    foreach (comunidades c in comunidades)
                    {
                        if (c.id == FormLogin.socioLogin.id_comunidad)
                        {
                            comboBoxComunity.Text = GestorIdiomas.getComunidad(c.nombre);
                        }
                    }
                    comboBoxComunity.Enabled = false;
                }
            }
        }

        public void cambiarIdioma()
        {
            
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

            if (socio == null)
            {
                this.Text = Strings.partner;
            }
            else
            {
                this.Text = Strings.modifyPartner;
            }

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
                //labelComunidad.Visible = true;
                //comboBoxComunity.Visible = true;
                //buttonSave.Location = new System.Drawing.Point(97, 251);
            }
            else
            {

                checkBoxState.Visible = false;
                //labelComunidad.Visible = false;
                //comboBoxComunity.Visible = false;
                //buttonSave.Location = new System.Drawing.Point(97, 224);
            }
        }
    }
}
