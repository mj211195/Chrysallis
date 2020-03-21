using Chrysallis.BD;
using Chrysallis.Idiomas;
using ComboxExtended;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Chrysallis
{
    public partial class FormLogin : Form
    {
        ComboBoxItem itemCatalan = new ComboBoxItem(Strings.catalan, new Bitmap(Properties.Resources.catalan));
        ComboBoxItem itemSpanish = new ComboBoxItem(Strings.spanish, new Bitmap(Properties.Resources.espanol));
        ComboBoxItem itemEnglish = new ComboBoxItem(Strings.english, new Bitmap(Properties.Resources.UK));
        Boolean cerradoPropio = false;
        public static socios socioLogin = null;
        public FormLogin()
        {
            InitializeComponent();
            
            cargarImagedComboBox();
            cambiarIdioma("");
            imagedComboBoxIdiomas.SelectedIndex = 0;
        }

        private void cambiarIdioma(String idioma)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(idioma);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(idioma);
            labelUser.Text = Strings.partner;
            labelPassword.Text = Strings.password;
            buttonEntrar.Text = Strings.login;
            itemCatalan.Value = Strings.catalan;
            itemSpanish.Value = Strings.spanish;
            itemEnglish.Value = Strings.english;
            this.Text = Strings.login;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            cambiarIdioma("");


        }
        
        private void cargarImagedComboBox()
        {
            imagedComboBoxIdiomas.Items.Add(itemCatalan);
            imagedComboBoxIdiomas.Items.Add(itemSpanish);
            imagedComboBoxIdiomas.Items.Add(itemEnglish);
        }

        private void imagedComboBoxIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imagedComboBoxIdiomas.SelectedItem != null)
            {
                switch (imagedComboBoxIdiomas.SelectedIndex)
                {
                    case 0:
                        cambiarIdioma("");
                        break;
                    case 1:
                        cambiarIdioma("es");
                        break;
                    case 2:
                        cambiarIdioma("en-US");
                        break;
                }
            }
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            String dni = textBoxUser.Text.ToString();
            String password = textBoxPassword.Text.ToString();
            if (dni.Trim().Equals("") || password.Trim().Equals(""))
            {
                MessageBox.Show(Strings.partnerPasswordEmpty, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OC.Core.Crypto.Hash hash = new OC.Core.Crypto.Hash();
                String clave = hash.Sha512(password);
                Boolean correcto = true;
                socioLogin = SocioORM.LoginSocio(dni, clave, ref correcto);
                if (socioLogin != null)
                {
                    cerradoPropio = true;
                    this.Close();
                }
                else if(correcto)
                {
                    MessageBox.Show(Strings.wrongCredentials, Strings.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cerradoPropio)
            {
                Application.Exit();
            }
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.PasswordChar == '*')
            {
                textBoxPassword.PasswordChar = '\0';
            }else if (textBoxPassword.PasswordChar == '\0')
            {
                textBoxPassword.PasswordChar = '*';
            }
        }
    }
}
