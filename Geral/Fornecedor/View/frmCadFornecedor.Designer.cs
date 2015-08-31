namespace SansERP.Geral.Fornecedor.View
{
    partial class frmCadFornecedor
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
            this.lblcdFornecedor = new System.Windows.Forms.Label();
            this.ucTextBoxNumero1 = new KuraFrameWork.Componentes_Visuais.ucTextBoxNumero();
            this.lblnmFantasiaFornecedor = new System.Windows.Forms.Label();
            this.nmFantasiaFornecedor = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lblnmRazaoSocial = new System.Windows.Forms.Label();
            this.nmRazaoSocial = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lgLogoFornecedor = new System.Windows.Forms.PictureBox();
            this.lblnuCNPJ = new System.Windows.Forms.Label();
            this.nuCNPJ = new KuraFrameWork.Componentes_Visuais.ucTextBoxMaskCNPJ();
            this.lblnuInscricaoEstadual = new System.Windows.Forms.Label();
            this.nuInscricaoEstadual = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.ucCadFilhoFornecedor = new SansERP.Geral.Fornecedor.View.ucCadFilhoFornecedor();
            this.pnFiltro.SuspendLayout();
            this.pnForm.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tcCadastro.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lgLogoFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // pnForm
            // 
            this.pnForm.Controls.Add(this.ucCadFilhoFornecedor);
            this.pnForm.Controls.Add(this.nuInscricaoEstadual);
            this.pnForm.Controls.Add(this.lblnuInscricaoEstadual);
            this.pnForm.Controls.Add(this.nuCNPJ);
            this.pnForm.Controls.Add(this.lblnuCNPJ);
            this.pnForm.Controls.Add(this.lgLogoFornecedor);
            this.pnForm.Controls.Add(this.nmRazaoSocial);
            this.pnForm.Controls.Add(this.lblnmRazaoSocial);
            this.pnForm.Controls.Add(this.nmFantasiaFornecedor);
            this.pnForm.Controls.Add(this.lblnmFantasiaFornecedor);
            this.pnForm.Controls.Add(this.ucTextBoxNumero1);
            this.pnForm.Controls.Add(this.lblcdFornecedor);
            this.pnForm.Size = new System.Drawing.Size(670, 340);
            this.pnForm.Controls.SetChildIndex(this.btnPrevious, 0);
            this.pnForm.Controls.SetChildIndex(this.btnFirst, 0);
            this.pnForm.Controls.SetChildIndex(this.btnLast, 0);
            this.pnForm.Controls.SetChildIndex(this.btnNext, 0);
            this.pnForm.Controls.SetChildIndex(this.lblcdFornecedor, 0);
            this.pnForm.Controls.SetChildIndex(this.ucTextBoxNumero1, 0);
            this.pnForm.Controls.SetChildIndex(this.lblnmFantasiaFornecedor, 0);
            this.pnForm.Controls.SetChildIndex(this.nmFantasiaFornecedor, 0);
            this.pnForm.Controls.SetChildIndex(this.lblnmRazaoSocial, 0);
            this.pnForm.Controls.SetChildIndex(this.nmRazaoSocial, 0);
            this.pnForm.Controls.SetChildIndex(this.lgLogoFornecedor, 0);
            this.pnForm.Controls.SetChildIndex(this.lblnuCNPJ, 0);
            this.pnForm.Controls.SetChildIndex(this.nuCNPJ, 0);
            this.pnForm.Controls.SetChildIndex(this.lblnuInscricaoEstadual, 0);
            this.pnForm.Controls.SetChildIndex(this.nuInscricaoEstadual, 0);
            this.pnForm.Controls.SetChildIndex(this.ucCadFilhoFornecedor, 0);
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
            this.tcCadastro.Size = new System.Drawing.Size(684, 372);
            // 
            // pnGridFiltro
            // 
            this.pnGridFiltro.Size = new System.Drawing.Size(580, 0);
            // 
            // tpFormulario
            // 
            this.tpFormulario.Size = new System.Drawing.Size(676, 346);
            // 
            // lblcdFornecedor
            // 
            this.lblcdFornecedor.AutoSize = true;
            this.lblcdFornecedor.Location = new System.Drawing.Point(3, 18);
            this.lblcdFornecedor.Name = "lblcdFornecedor";
            this.lblcdFornecedor.Size = new System.Drawing.Size(46, 13);
            this.lblcdFornecedor.TabIndex = 12;
            this.lblcdFornecedor.Text = "Código :";
            // 
            // ucTextBoxNumero1
            // 
            this.ucTextBoxNumero1.AceitaEspaco = true;
            this.ucTextBoxNumero1.CampoDesabilitado = false;
            this.ucTextBoxNumero1.CampoObrigatorio = false;
            this.ucTextBoxNumero1.Location = new System.Drawing.Point(6, 34);
            this.ucTextBoxNumero1.MensagemCampoObrigatorio = null;
            this.ucTextBoxNumero1.Name = "ucTextBoxNumero1";
            this.ucTextBoxNumero1.Size = new System.Drawing.Size(100, 20);
            this.ucTextBoxNumero1.TabIndex = 13;
            // 
            // lblnmFantasiaFornecedor
            // 
            this.lblnmFantasiaFornecedor.AutoSize = true;
            this.lblnmFantasiaFornecedor.Location = new System.Drawing.Point(3, 57);
            this.lblnmFantasiaFornecedor.Name = "lblnmFantasiaFornecedor";
            this.lblnmFantasiaFornecedor.Size = new System.Drawing.Size(88, 13);
            this.lblnmFantasiaFornecedor.TabIndex = 14;
            this.lblnmFantasiaFornecedor.Text = "*Nome Fantasia :";
            // 
            // nmFantasiaFornecedor
            // 
            this.nmFantasiaFornecedor.AceitaEspaco = true;
            this.nmFantasiaFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nmFantasiaFornecedor.CampoDesabilitado = false;
            this.nmFantasiaFornecedor.CampoObrigatorio = true;
            this.nmFantasiaFornecedor.Location = new System.Drawing.Point(6, 73);
            this.nmFantasiaFornecedor.MensagemCampoObrigatorio = "Informe o nome fantasia do Fornecedor.";
            this.nmFantasiaFornecedor.Name = "nmFantasiaFornecedor";
            this.nmFantasiaFornecedor.Size = new System.Drawing.Size(517, 20);
            this.nmFantasiaFornecedor.TabIndex = 15;
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
            this.nmRazaoSocial.CampoObrigatorio = true;
            this.nmRazaoSocial.Location = new System.Drawing.Point(6, 112);
            this.nmRazaoSocial.MensagemCampoObrigatorio = "Informe a razão social do Fornecedor.";
            this.nmRazaoSocial.Name = "nmRazaoSocial";
            this.nmRazaoSocial.Size = new System.Drawing.Size(517, 20);
            this.nmRazaoSocial.TabIndex = 17;
            // 
            // lgLogoFornecedor
            // 
            this.lgLogoFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lgLogoFornecedor.Location = new System.Drawing.Point(531, 73);
            this.lgLogoFornecedor.Name = "lgLogoFornecedor";
            this.lgLogoFornecedor.Size = new System.Drawing.Size(134, 98);
            this.lgLogoFornecedor.TabIndex = 18;
            this.lgLogoFornecedor.TabStop = false;
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
            this.nuCNPJ.CampoObrigatorio = true;
            this.nuCNPJ.Location = new System.Drawing.Point(6, 151);
            this.nuCNPJ.Mask = "99,999,999/9999-99";
            this.nuCNPJ.MensagemCampoObrigatorio = "Informe o CNPJ do Fornecedor.";
            this.nuCNPJ.Name = "nuCNPJ";
            this.nuCNPJ.Size = new System.Drawing.Size(141, 20);
            this.nuCNPJ.TabIndex = 20;
            // 
            // lblnuInscricaoEstadual
            // 
            this.lblnuInscricaoEstadual.AutoSize = true;
            this.lblnuInscricaoEstadual.Location = new System.Drawing.Point(153, 135);
            this.lblnuInscricaoEstadual.Name = "lblnuInscricaoEstadual";
            this.lblnuInscricaoEstadual.Size = new System.Drawing.Size(100, 13);
            this.lblnuInscricaoEstadual.TabIndex = 21;
            this.lblnuInscricaoEstadual.Text = "Inscrição Estadual :";
            // 
            // nuInscricaoEstadual
            // 
            this.nuInscricaoEstadual.AceitaEspaco = true;
            this.nuInscricaoEstadual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nuInscricaoEstadual.CampoDesabilitado = false;
            this.nuInscricaoEstadual.CampoObrigatorio = false;
            this.nuInscricaoEstadual.Location = new System.Drawing.Point(156, 151);
            this.nuInscricaoEstadual.MensagemCampoObrigatorio = null;
            this.nuInscricaoEstadual.Name = "nuInscricaoEstadual";
            this.nuInscricaoEstadual.Size = new System.Drawing.Size(367, 20);
            this.nuInscricaoEstadual.TabIndex = 22;
            // 
            // ucCadFilhoFornecedor
            // 
            this.ucCadFilhoFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucCadFilhoFornecedor.Location = new System.Drawing.Point(6, 177);
            this.ucCadFilhoFornecedor.MinimumSize = new System.Drawing.Size(0, 125);
            this.ucCadFilhoFornecedor.Name = "ucCadFilhoFornecedor";
            this.ucCadFilhoFornecedor.Size = new System.Drawing.Size(657, 156);
            this.ucCadFilhoFornecedor.TabIndex = 23;
            // 
            // frmCadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 419);
            this.Name = "frmCadFornecedor";
            this.Text = "Cadastro de Fornecedor";
            this.TpCorrente = this.tpFormulario;
            this.pnFiltro.ResumeLayout(false);
            this.pnForm.ResumeLayout(false);
            this.pnForm.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.tcCadastro.ResumeLayout(false);
            this.tpFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lgLogoFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KuraFrameWork.Componentes_Visuais.ucTextBoxNumero ucTextBoxNumero1;
        private System.Windows.Forms.Label lblcdFornecedor;
        private System.Windows.Forms.Label lblnuInscricaoEstadual;
        private KuraFrameWork.Componentes_Visuais.ucTextBoxMaskCNPJ nuCNPJ;
        private System.Windows.Forms.Label lblnuCNPJ;
        private System.Windows.Forms.PictureBox lgLogoFornecedor;
        private KuraFrameWork.Componentes_Visuais.ucTextBox nmRazaoSocial;
        private System.Windows.Forms.Label lblnmRazaoSocial;
        private KuraFrameWork.Componentes_Visuais.ucTextBox nmFantasiaFornecedor;
        private System.Windows.Forms.Label lblnmFantasiaFornecedor;
        private KuraFrameWork.Componentes_Visuais.ucTextBox nuInscricaoEstadual;
        private ucCadFilhoFornecedor ucCadFilhoFornecedor;
    }
}
