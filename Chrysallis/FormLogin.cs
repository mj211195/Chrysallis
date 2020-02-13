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
        public FormLogin()
        {
            InitializeComponent();
            imagedComboBoxIdiomas.Items.Add(new ComboBoxItem(Idiomas.Strings.catalan, new Bitmap(Chrysallis.Properties.Resources.catalan)));
            imagedComboBoxIdiomas.Items.Add(new ComboBoxItem(Idiomas.Strings.spanish, new Bitmap(Chrysallis.Properties.Resources.español)));
            imagedComboBoxIdiomas.Items.Add(new ComboBoxItem(Idiomas.Strings.english, new Bitmap(Chrysallis.Properties.Resources.UK)));
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
            buttonCatalan.Text = Idiomas.Strings.catalan;
            buttonIngles.Text = Idiomas.Strings.english;
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
    }
}
