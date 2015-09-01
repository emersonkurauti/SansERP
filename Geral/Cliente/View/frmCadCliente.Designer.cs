namespace SansERP.Geral.Cliente.View
{
    partial class frmCadCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblcdCliente = new System.Windows.Forms.Label();
            this.cdCliente = new KuraFrameWork.Componentes_Visuais.ucTextBoxNumero();
            this.flTpPessoa = new System.Windows.Forms.GroupBox();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.pnTopo = new System.Windows.Forms.Panel();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.ucEnderecoTelefoneEmail = new KuraFrameWork.Componentes_Visuais.ucEnderecoTelefoneEmail();
            this.ucCadClienteJuridica = new SansERP.Geral.Cliente.View.ucCadClienteJuridica();
            this.ucCadClienteFisica = new SansERP.Geral.Cliente.View.ucCadClienteFisica();
            this.pnFiltro.SuspendLayout();
            this.pnForm.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tcCadastro.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            this.flTpPessoa.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnForm
            // 
            this.pnForm.Controls.Add(this.pnBottom);
            this.pnForm.Controls.Add(this.ucCadClienteJuridica);
            this.pnForm.Controls.Add(this.flTpPessoa);
            this.pnForm.Controls.Add(this.cdCliente);
            this.pnForm.Controls.Add(this.lblcdCliente);
            this.pnForm.Controls.Add(this.ucCadClienteFisica);
            this.pnForm.Controls.Add(this.pnTopo);
            this.pnForm.Size = new System.Drawing.Size(670, 401);
            this.pnForm.Controls.SetChildIndex(this.pnTopo, 0);
            this.pnForm.Controls.SetChildIndex(this.ucCadClienteFisica, 0);
            this.pnForm.Controls.SetChildIndex(this.btnPrevious, 0);
            this.pnForm.Controls.SetChildIndex(this.btnFirst, 0);
            this.pnForm.Controls.SetChildIndex(this.btnLast, 0);
            this.pnForm.Controls.SetChildIndex(this.btnNext, 0);
            this.pnForm.Controls.SetChildIndex(this.lblcdCliente, 0);
            this.pnForm.Controls.SetChildIndex(this.cdCliente, 0);
            this.pnForm.Controls.SetChildIndex(this.flTpPessoa, 0);
            this.pnForm.Controls.SetChildIndex(this.ucCadClienteJuridica, 0);
            this.pnForm.Controls.SetChildIndex(this.pnBottom, 0);
            // 
            // btnLimparFiltro
            // 
            this.btnLimparFiltro.Location = new System.Drawing.Point(0, -29);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Size = new System.Drawing.Size(88, 0);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Size = new System.Drawing.Size(88, 0);
            // 
            // tcCadastro
            // 
            this.tcCadastro.Size = new System.Drawing.Size(684, 433);
            // 
            // pnGridFiltro
            // 
            this.pnGridFiltro.Size = new System.Drawing.Size(580, 0);
            // 
            // tpFormulario
            // 
            this.tpFormulario.Size = new System.Drawing.Size(676, 407);
            // 
            // lblcdCliente
            // 
            this.lblcdCliente.AutoSize = true;
            this.lblcdCliente.Location = new System.Drawing.Point(3, 18);
            this.lblcdCliente.Name = "lblcdCliente";
            this.lblcdCliente.Size = new System.Drawing.Size(46, 13);
            this.lblcdCliente.TabIndex = 12;
            this.lblcdCliente.Text = "Código :";
            // 
            // cdCliente
            // 
            this.cdCliente.AceitaEspaco = true;
            this.cdCliente.CampoDesabilitado = false;
            this.cdCliente.CampoObrigatorio = false;
            this.cdCliente.Location = new System.Drawing.Point(6, 34);
            this.cdCliente.MensagemCampoObrigatorio = null;
            this.cdCliente.Name = "cdCliente";
            this.cdCliente.Size = new System.Drawing.Size(100, 20);
            this.cdCliente.TabIndex = 13;
            // 
            // flTpPessoa
            // 
            this.flTpPessoa.Controls.Add(this.rbJuridica);
            this.flTpPessoa.Controls.Add(this.rbFisica);
            this.flTpPessoa.Location = new System.Drawing.Point(112, 18);
            this.flTpPessoa.Name = "flTpPessoa";
            this.flTpPessoa.Size = new System.Drawing.Size(138, 36);
            this.flTpPessoa.TabIndex = 15;
            this.flTpPessoa.TabStop = false;
            this.flTpPessoa.Text = "Tipo de Pessoa";
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Location = new System.Drawing.Point(66, 13);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(63, 17);
            this.rbJuridica.TabIndex = 1;
            this.rbJuridica.TabStop = true;
            this.rbJuridica.Text = "Jurídica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            this.rbJuridica.CheckedChanged += new System.EventHandler(this.rbJuridica_CheckedChanged);
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Location = new System.Drawing.Point(6, 13);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(54, 17);
            this.rbFisica.TabIndex = 0;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Física";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // pnTopo
            // 
            this.pnTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopo.Location = new System.Drawing.Point(0, 0);
            this.pnTopo.Name = "pnTopo";
            this.pnTopo.Size = new System.Drawing.Size(666, 57);
            this.pnTopo.TabIndex = 17;
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.ucEnderecoTelefoneEmail);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBottom.Location = new System.Drawing.Point(0, 252);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(666, 145);
            this.pnBottom.TabIndex = 18;
            // 
            // ucEnderecoTelefoneEmail
            // 
            this.ucEnderecoTelefoneEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucEnderecoTelefoneEmail.Location = new System.Drawing.Point(6, 3);
            this.ucEnderecoTelefoneEmail.MinimumSize = new System.Drawing.Size(0, 125);
            this.ucEnderecoTelefoneEmail.Name = "ucEnderecoTelefoneEmail";
            this.ucEnderecoTelefoneEmail.Size = new System.Drawing.Size(657, 139);
            this.ucEnderecoTelefoneEmail.TabIndex = 0;
            // 
            // ucCadClienteJuridica
            // 
            this.ucCadClienteJuridica.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucCadClienteJuridica.Location = new System.Drawing.Point(0, 135);
            this.ucCadClienteJuridica.Name = "ucCadClienteJuridica";
            this.ucCadClienteJuridica.Size = new System.Drawing.Size(666, 117);
            this.ucCadClienteJuridica.TabIndex = 19;
            // 
            // ucCadClienteFisica
            // 
            this.ucCadClienteFisica.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucCadClienteFisica.Location = new System.Drawing.Point(0, 57);
            this.ucCadClienteFisica.Name = "ucCadClienteFisica";
            this.ucCadClienteFisica.Size = new System.Drawing.Size(666, 78);
            this.ucCadClienteFisica.TabIndex = 16;
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 480);
            this.Name = "frmCadCliente";
            this.Text = "Cadastro de Cliente";
            this.TpCorrente = this.tpFormulario;
            this.pnFiltro.ResumeLayout(false);
            this.pnForm.ResumeLayout(false);
            this.pnForm.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.tcCadastro.ResumeLayout(false);
            this.tpFormulario.ResumeLayout(false);
            this.flTpPessoa.ResumeLayout(false);
            this.flTpPessoa.PerformLayout();
            this.pnBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KuraFrameWork.Componentes_Visuais.ucTextBoxNumero cdCliente;
        private System.Windows.Forms.Label lblcdCliente;
        private System.Windows.Forms.GroupBox flTpPessoa;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.RadioButton rbJuridica;
        private ucCadClienteFisica ucCadClienteFisica;
        private System.Windows.Forms.Panel pnTopo;
        private System.Windows.Forms.Panel pnBottom;
        private ucCadClienteJuridica ucCadClienteJuridica;
        private KuraFrameWork.Componentes_Visuais.ucEnderecoTelefoneEmail ucEnderecoTelefoneEmail;
    }
}
