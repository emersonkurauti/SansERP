using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SansERP.Geral.Cliente.View
{
    public partial class frmCadCliente : KuraFrameWork.Formularios.ucCadastroBasicoNormal
    {
        public frmCadCliente()
        {
            InitializeComponent();
            Inicializar();

            ucCadClienteJuridica.Visible = true;
            rbJuridica.Checked = true;
        }

        private void Inicializar()
        {
            ucCadClienteFisica.Visible = false;
            ucCadClienteJuridica.Visible = false;
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            Inicializar();
            ucCadClienteJuridica.Visible = true;
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            Inicializar();
            ucCadClienteFisica.Visible = true;
        }
    }
}
