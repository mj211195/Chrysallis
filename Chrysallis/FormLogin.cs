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

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.ShowDialog();
        }
    }
}
