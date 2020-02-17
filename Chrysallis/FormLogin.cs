using Chrysallis.BD;
using ComboxExtended;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chrysallis
{
    public partial class FormLogin : Form
    {
        ComboBoxItem itemCatalan = new ComboBoxItem(Idiomas.Strings.catalan, new Bitmap(Chrysallis.Properties.Resources.catalan));
        ComboBoxItem itemSpanish = new ComboBoxItem(Idiomas.Strings.spanish, new Bitmap(Chrysallis.Properties.Resources.espanol));
        ComboBoxItem itemEnglish = new ComboBoxItem(Idiomas.Strings.english, new Bitmap(Chrysallis.Properties.Resources.UK));
        Boolean cerradoPropio = false;
        public FormLogin()
        {
            InitializeComponent();
            
            cargarImagedComboBox();
            cambiarIdioma("");
            imagedComboBoxIdiomas.SelectedIndex = 0;
        }

        private void buttonIngles_Click(object sender, EventArgs e)
        {
            cambiarIdioma("en-US");
        }

        private void cambiarIdioma(String idioma)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(idioma);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(idioma);
            labelUsuario.Text = Idiomas.Strings.user;
            labelContrasenya.Text = Idiomas.Strings.password;
            buttonEntrar.Text = Idiomas.Strings.login;
            itemCatalan.Value = Idiomas.Strings.catalan;
            itemSpanish.Value = Idiomas.Strings.spanish;
            itemEnglish.Value = Idiomas.Strings.english;
            this.Text = Idiomas.Strings.login;
        }

        private void buttonCatalan_Click(object sender, EventArgs e)
        {
            cambiarIdioma("");
        }

        private void buttonSpanish_Click(object sender, EventArgs e)
        {
            cambiarIdioma("es");
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
            String dni = textBoxUsuario.Text.ToString();
            String password = textBoxContrasenya.Text.ToString();
            if (dni.Trim().Equals("") || password.Trim().Equals(""))
            {
                MessageBox.Show("Usuari i/o contraseña vacios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                socios socio = SocioORM.loginSocio(dni, password);
                if (socio != null)
                {
                    cerradoPropio = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
