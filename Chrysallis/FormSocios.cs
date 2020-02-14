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
    public partial class FormSocios : Form
    {
        public FormSocios()
        {
            InitializeComponent();
        }

        private void FormSocios_Load(object sender, EventArgs e)
        {
            buttonAgregarSocio.Text = Idiomas.Strings.addPartner;
            this.Text = Idiomas.Strings.partner;
        }

        private void buttonAgregarSocio_Click(object sender, EventArgs e)
        {
            FormSocio formSocio = new FormSocio();
            formSocio.ShowDialog();
        }
    }
}
