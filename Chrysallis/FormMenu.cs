﻿using System;
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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            cambiarIdioma();
        }

        public void cambiarIdioma()
        {
            buttonAdministrarSocios.Text = Idiomas.Strings.managePartners;
            buttonAdministrarEventos.Text = Idiomas.Strings.manageEvents;
        }

        private void buttonAdministrarSocios_Click(object sender, EventArgs e)
        {
            FormSocios formSocios = new FormSocios();
            formSocios.ShowDialog();
        }
    }
}
