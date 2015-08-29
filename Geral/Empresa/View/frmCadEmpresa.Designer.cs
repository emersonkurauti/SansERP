namespace SansERP.Geral.Empresa.View
{
    partial class frmCadEmpresa
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
            this.lblcdEmpresa = new System.Windows.Forms.Label();
            this.cdEmpresa = new KuraFrameWork.Componentes_Visuais.ucTextBoxNumero();
            this.lblnmFantasia = new System.Windows.Forms.Label();
            this.ucTextBox1 = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lblnmRazaoSocial = new System.Windows.Forms.Label();
            this.nmRazaoSocial = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lgLogoEmpresa = new System.Windows.Forms.PictureBox();
            this.lblnuCNPJ = new System.Windows.Forms.Label();
            this.nuCNPJ = new KuraFrameWork.Componentes_Visuais.ucTextBoxMaskCNPJ();
            this.lblnuInscricaoEstadual = new System.Windows.Forms.Label();
            this.nuIncricaoEstadual = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.ucEnderecoTelefoneEmail1 = new KuraFrameWork.Componentes_Visuais.ucEnderecoTelefoneEmail();
            this.pnFiltro.SuspendLayout();
            this.pnForm.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tcCadastro.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lgLogoEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // pnForm
            // 
            this.pnForm.Controls.Add(this.ucEnderecoTelefoneEmail1);
            this.pnForm.Controls.Add(this.nuIncricaoEstadual);
            this.pnForm.Controls.Add(this.lblnuInscricaoEstadual);
            this.pnForm.Controls.Add(this.nuCNPJ);
            this.pnForm.Controls.Add(this.lblnuCNPJ);
            this.pnForm.Controls.Add(this.lgLogoEmpresa);
            this.pnForm.Controls.Add(this.nmRazaoSocial);
            this.pnForm.Controls.Add(this.lblnmRazaoSocial);
            this.pnForm.Controls.Add(this.ucTextBox1);
            this.pnForm.Controls.Add(this.lblnmFantasia);
            this.pnForm.Controls.Add(this.cdEmpresa);
            this.pnForm.Controls.Add(this.lblcdEmpresa);
            this.pnForm.Size = new System.Drawing.Size(670, 338);
            this.pnForm.Controls.SetChildIndex(this.btnPrevious, 0);
            this.pnForm.Controls.SetChildIndex(this.btnFirst, 0);
            this.pnForm.Controls.SetChildIndex(this.btnLast, 0);
            this.pnForm.Controls.SetChildIndex(this.btnNext, 0);
            this.pnForm.Controls.SetChildIndex(this.lblcdEmpresa, 0);
            this.pnForm.Controls.SetChildIndex(this.cdEmpresa, 0);
            this.pnForm.Controls.SetChildIndex(this.lblnmFantasia, 0);
            this.pnForm.Controls.SetChildIndex(this.ucTextBox1, 0);
            this.pnForm.Controls.SetChildIndex(this.lblnmRazaoSocial, 0);
            this.pnForm.Controls.SetChildIndex(this.nmRazaoSocial, 0);
            this.pnForm.Controls.SetChildIndex(this.lgLogoEmpresa, 0);
            this.pnForm.Controls.SetChildIndex(this.lblnuCNPJ, 0);
            this.pnForm.Controls.SetChildIndex(this.nuCNPJ, 0);
            this.pnForm.Controls.SetChildIndex(this.lblnuInscricaoEstadual, 0);
            this.pnForm.Controls.SetChildIndex(this.nuIncricaoEstadual, 0);
            this.pnForm.Controls.SetChildIndex(this.ucEnderecoTelefoneEmail1, 0);
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
            this.tcCadastro.Size = new System.Drawing.Size(684, 370);
            // 
            // pnGridFiltro
            // 
            this.pnGridFiltro.Size = new System.Drawing.Size(580, 0);
            // 
            // tpFormulario
            // 
            this.tpFormulario.Size = new System.Drawing.Size(676, 344);
            // 
            // lblcdEmpresa
            // 
            this.lblcdEmpresa.AutoSize = true;
            this.lblcdEmpresa.Location = new System.Drawing.Point(3, 18);
            this.lblcdEmpresa.Name = "lblcdEmpresa";
            this.lblcdEmpresa.Size = new System.Drawing.Size(46, 13);
            this.lblcdEmpresa.TabIndex = 12;
            this.lblcdEmpresa.Text = "Código :";
            // 
            // cdEmpresa
            // 
            this.cdEmpresa.AceitaEspaco = true;
            this.cdEmpresa.CampoDesabilitado = false;
            this.cdEmpresa.CampoObrigatorio = false;
            this.cdEmpresa.Location = new System.Drawing.Point(6, 34);
            this.cdEmpresa.MensagemCampoObrigatorio = null;
            this.cdEmpresa.Name = "cdEmpresa";
            this.cdEmpresa.Size = new System.Drawing.Size(100, 20);
            this.cdEmpresa.TabIndex = 13;
            // 
            // lblnmFantasia
            // 
            this.lblnmFantasia.AutoSize = true;
            this.lblnmFantasia.Location = new System.Drawing.Point(3, 57);
            this.lblnmFantasia.Name = "lblnmFantasia";
            this.lblnmFantasia.Size = new System.Drawing.Size(88, 13);
            this.lblnmFantasia.TabIndex = 14;
            this.lblnmFantasia.Text = "*Nome Fantasia :";
            // 
            // ucTextBox1
            // 
            this.ucTextBox1.AceitaEspaco = true;
            this.ucTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucTextBox1.CampoDesabilitado = false;
            this.ucTextBox1.CampoObrigatorio = false;
            this.ucTextBox1.Location = new System.Drawing.Point(6, 73);
            this.ucTextBox1.MensagemCampoObrigatorio = null;
            this.ucTextBox1.Name = "ucTextBox1";
            this.ucTextBox1.Size = new System.Drawing.Size(456, 20);
            this.ucTextBox1.TabIndex = 15;
            // 
            // lblnmRazaoSocial
            // 
            this.lblnmRazaoSocial.AutoSize = true;
            this.lblnmRazaoSocial.Location = new System.Drawing.Point(3, 96);
            this.lblnmRazaoSocial.Name = "lblnmRazaoSocial";
            this.lblnmRazaoSocial.Size = new System.Drawing.Size(80, 13);
            this.lblnmRazaoSocial.TabIndex = 16;
            this.lblnmRazaoSocial.Text = "*Razão Social :";
            // 
            // nmRazaoSocial
            // 
            this.nmRazaoSocial.AceitaEspaco = true;
            this.nmRazaoSocial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nmRazaoSocial.CampoDesabilitado = false;
            this.nmRazaoSocial.CampoObrigatorio = false;
            this.nmRazaoSocial.Location = new System.Drawing.Point(6, 112);
            this.nmRazaoSocial.MensagemCampoObrigatorio = null;
            this.nmRazaoSocial.Name = "nmRazaoSocial";
            this.nmRazaoSocial.Size = new System.Drawing.Size(456, 20);
            this.nmRazaoSocial.TabIndex = 17;
            // 
            // lgLogoEmpresa
            // 
            this.lgLogoEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lgLogoEmpresa.Location = new System.Drawing.Point(468, 73);
            this.lgLogoEmpresa.Name = "lgLogoEmpresa";
            this.lgLogoEmpresa.Size = new System.Drawing.Size(195, 98);
            this.lgLogoEmpresa.TabIndex = 18;
            this.lgLogoEmpresa.TabStop = false;
            // 
            // lblnuCNPJ
            // 
            this.lblnuCNPJ.AutoSize = true;
            this.lblnuCNPJ.Location = new System.Drawing.Point(3, 135);
            this.lblnuCNPJ.Name = "lblnuCNPJ";
            this.lblnuCNPJ.Size = new System.Drawing.Size(44, 13);
            this.lblnuCNPJ.TabIndex = 19;
            this.lblnuCNPJ.Text = "*CNPJ :";
            // 
            // nuCNPJ
            // 
            this.nuCNPJ.CampoObrigatorio = false;
            this.nuCNPJ.Location = new System.Drawing.Point(6, 151);
            this.nuCNPJ.Mask = "99,999,999/9999-99";
            this.nuCNPJ.MensagemCampoObrigatorio = null;
            this.nuCNPJ.Name = "nuCNPJ";
            this.nuCNPJ.Size = new System.Drawing.Size(127, 20);
            this.nuCNPJ.TabIndex = 20;
            // 
            // lblnuInscricaoEstadual
            // 
            this.lblnuInscricaoEstadual.AutoSize = true;
            this.lblnuInscricaoEstadual.Location = new System.Drawing.Point(139, 135);
            this.lblnuInscricaoEstadual.Name = "lblnuInscricaoEstadual";
            this.lblnuInscricaoEstadual.Size = new System.Drawing.Size(100, 13);
            this.lblnuInscricaoEstadual.TabIndex = 21;
            this.lblnuInscricaoEstadual.Text = "Inscrição Estadual :";
            // 
            // nuIncricaoEstadual
            // 
            this.nuIncricaoEstadual.AceitaEspaco = true;
            this.nuIncricaoEstadual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nuIncricaoEstadual.CampoDesabilitado = false;
            this.nuIncricaoEstadual.CampoObrigatorio = false;
            this.nuIncricaoEstadual.Location = new System.Drawing.Point(142, 151);
            this.nuIncricaoEstadual.MensagemCampoObrigatorio = null;
            this.nuIncricaoEstadual.Name = "nuIncricaoEstadual";
            this.nuIncricaoEstadual.Size = new System.Drawing.Size(320, 20);
            this.nuIncricaoEstadual.TabIndex = 22;
            // 
            // ucEnderecoTelefoneEmail1
            // 
            this.ucEnderecoTelefoneEmail1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucEnderecoTelefoneEmail1.Location = new System.Drawing.Point(6, 177);
            this.ucEnderecoTelefoneEmail1.MinimumSize = new System.Drawing.Size(0, 125);
            this.ucEnderecoTelefoneEmail1.Name = "ucEnderecoTelefoneEmail1";
            this.ucEnderecoTelefoneEmail1.Size = new System.Drawing.Size(657, 154);
            this.ucEnderecoTelefoneEmail1.TabIndex = 23;
            // 
            // frmCadEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 417);
            this.Name = "frmCadEmpresa";
            this.Text = "Cadastro de Empresa";
            this.TpCorrente = this.tpFormulario;
            this.pnFiltro.ResumeLayout(false);
            this.pnForm.ResumeLayout(false);
            this.pnForm.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.tcCadastro.ResumeLayout(false);
            this.tpFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lgLogoEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KuraFrameWork.Componentes_Visuais.ucTextBoxNumero cdEmpresa;
        private System.Windows.Forms.Label lblcdEmpresa;
        private KuraFrameWork.Componentes_Visuais.ucTextBox nmRazaoSocial;
        private System.Windows.Forms.Label lblnmRazaoSocial;
        private KuraFrameWork.Componentes_Visuais.ucTextBox ucTextBox1;
        private System.Windows.Forms.Label lblnmFantasia;
        private System.Windows.Forms.PictureBox lgLogoEmpresa;
        private System.Windows.Forms.Label lblnuCNPJ;
        private KuraFrameWork.Componentes_Visuais.ucTextBoxMaskCNPJ nuCNPJ;
        private KuraFrameWork.Componentes_Visuais.ucTextBox nuIncricaoEstadual;
        private System.Windows.Forms.Label lblnuInscricaoEstadual;
        private KuraFrameWork.Componentes_Visuais.ucEnderecoTelefoneEmail ucEnderecoTelefoneEmail1;
    }
}
