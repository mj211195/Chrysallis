using Chrysallis.BD;
using Chrysallis.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Chrysallis
{
    public partial class FormSocio : Form

    {
        List<comunidades> comunidades;
        private List<comunidades> comunidadesOriginal;
        private socios socio = null;
        private Boolean modificar;

        public FormSocio()
        {
            InitializeComponent();
            modificar = false;
        }

        public FormSocio(socios socio, Boolean modificar)
        {
            InitializeComponent();
            this.socio = socio;
            this.modificar = modificar;
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

                //bindingSourceComunidades.DataSource = comunidades;
                socios socioNuevo = new socios();
                socioNuevo.dni = textBoxDni.Text.Trim();
                socioNuevo.telefono = textBoxPhone.Text.Trim();
                socioNuevo.nombre = textBoxName.Text.Trim();
                socioNuevo.apellidos = textBoxLastName.Text.Trim();
                socioNuevo.mail = textBoxEmail.Text.Trim();
                socioNuevo.activo = checkBoxActive.Checked;
                socioNuevo.administrador = checkBoxAdministrator.Checked;
                socioNuevo.estatal = checkBoxState.Checked;
                if (modificar)
                {
                    String clave = textBoxPassword.Text.Trim();
                    if (!clave.Equals(socio.password))
                    {
                        OC.Core.Crypto.Hash hash = new OC.Core.Crypto.Hash();
                        clave = hash.Sha512(textBoxPassword.Text.Trim());

                    }
                    socioNuevo.password = clave;
                }
                else{
                    OC.Core.Crypto.Hash hash = new OC.Core.Crypto.Hash();
                    String clave = hash.Sha512(textBoxPassword.Text.Trim());
                    socioNuevo.password = clave;
                }
                
                socioNuevo.comunidades = ComunidadORM.SelectComunidad((int)comboBoxComunity.SelectedValue);

                if (comboBoxComunity.SelectedItem != null)
                {
                    socioNuevo.id_comunidad = (int)comboBoxComunity.SelectedValue;
                }

                if (!modificar)
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
                        MessageBox.Show(Strings.modifiedPartnert, Strings.modified, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }
        
        private void FormSocio_Load(object sender, EventArgs e)
        {
            comunidades = ComunidadORM.SelectAllComunidades();
            //Creo una copia que no tenga ninguna relacion con la base de datos, con los nombres en el idioma ya
            //cambiado para usar este porque si usaba el que tiene relacion con la bd, magicamente se cambiaba
            //en la base de datos
            comunidadesOriginal = (from c in comunidades
                               let a = new comunidades() { id = c.id, nombre = GestorIdiomas.getComunidad(c.nombre)}
                               select a).ToList();
            cambiarIdioma();
            bindingSourceComunidades.DataSource = comunidadesOriginal;
            
            //buttonSave.Location = new System.Drawing.Point(97, 224);
            if (!(bool)FormLogin.socioLogin.estatal)
            {
                checkBoxState.Enabled = false;
                checkBoxState.Visible = false;
                comboBoxComunity.Enabled = false;
                checkBoxState.Visible = false;
            }
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
                comboBoxComunity.SelectedValue = socio.id_comunidad;
            }
        }

        public void cambiarIdioma()
        {
            
            labelPhone.Text = Strings.phone;
            labelName.Text = Strings.name;
            labelLastName.Text = Strings.lastName;
            labelEmail.Text = Strings.email;
            labelPassword.Text = Strings.password;
            labelComunidad.Text = Strings.community;
            labelPassword2.Text = Strings.password2;
            buttonSave.Text = Strings.save;
            checkBoxActive.Text = Strings.active;
            checkBoxState.Text = Strings.state;
            checkBoxAdministrator.Text = Strings.admin;

            if (!modificar)
            {
                this.Text = Strings.partner;
            }
            else
            {
                this.Text = Strings.modifyPartner;
            }
            
        }

        private void checkBoxAdministrator_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxAdministrator.Checked)
            {
                if ((bool)FormLogin.socioLogin.estatal)
                {
                    checkBoxState.Visible = true;
                }
                //labelComunidad.Visible = true;
                //comboBoxComunity.Visible = true;
                //buttonSave.Location = new System.Drawing.Point(97, 251);
            }
            else
            {

                if ((bool)FormLogin.socioLogin.estatal)
                {
                    checkBoxState.Visible = false;
                }
                //labelComunidad.Visible = false;
                //comboBoxComunity.Visible = false;
                //buttonSave.Location = new System.Drawing.Point(97, 224);
            }
        }
    }
}
