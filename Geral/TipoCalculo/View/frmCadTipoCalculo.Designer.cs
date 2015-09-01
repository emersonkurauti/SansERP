namespace SansERP.Geral.TipoCalculo.View
{
    partial class frmCadTipoCalculo
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
            this.lblcdTipoCalculo = new System.Windows.Forms.Label();
            this.cdTipoCalculo = new KuraFrameWork.Componentes_Visuais.ucTextBoxNumero();
            this.lbldeTipoCalculo = new System.Windows.Forms.Label();
            this.deTipoCalculo = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lblsgSiglaTipoCalculo = new System.Windows.Forms.Label();
            this.sgSiglaTipoCalculo = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lbldeFormulaTipoCalculo = new System.Windows.Forms.Label();
            this.deFormulaTipoCalculo = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.pnFiltro.SuspendLayout();
            this.pnForm.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tcCadastro.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnForm
            // 
            this.pnForm.Controls.Add(this.deFormulaTipoCalculo);
            this.pnForm.Controls.Add(this.lbldeFormulaTipoCalculo);
            this.pnForm.Controls.Add(this.sgSiglaTipoCalculo);
            this.pnForm.Controls.Add(this.lblsgSiglaTipoCalculo);
            this.pnForm.Controls.Add(this.deTipoCalculo);
            this.pnForm.Controls.Add(this.lbldeTipoCalculo);
            this.pnForm.Controls.Add(this.cdTipoCalculo);
            this.pnForm.Controls.Add(this.lblcdTipoCalculo);
            this.pnForm.Controls.SetChildIndex(this.btnPrevious, 0);
            this.pnForm.Controls.SetChildIndex(this.btnFirst, 0);
            this.pnForm.Controls.SetChildIndex(this.btnLast, 0);
            this.pnForm.Controls.SetChildIndex(this.btnNext, 0);
            this.pnForm.Controls.SetChildIndex(this.lblcdTipoCalculo, 0);
            this.pnForm.Controls.SetChildIndex(this.cdTipoCalculo, 0);
            this.pnForm.Controls.SetChildIndex(this.lbldeTipoCalculo, 0);
            this.pnForm.Controls.SetChildIndex(this.deTipoCalculo, 0);
            this.pnForm.Controls.SetChildIndex(this.lblsgSiglaTipoCalculo, 0);
            this.pnForm.Controls.SetChildIndex(this.sgSiglaTipoCalculo, 0);
            this.pnForm.Controls.SetChildIndex(this.lbldeFormulaTipoCalculo, 0);
            this.pnForm.Controls.SetChildIndex(this.deFormulaTipoCalculo, 0);
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
            // pnGridFiltro
            // 
            this.pnGridFiltro.Size = new System.Drawing.Size(580, 0);
            // 
            // lblcdTipoCalculo
            // 
            this.lblcdTipoCalculo.AutoSize = true;
            this.lblcdTipoCalculo.Location = new System.Drawing.Point(3, 18);
            this.lblcdTipoCalculo.Name = "lblcdTipoCalculo";
            this.lblcdTipoCalculo.Size = new System.Drawing.Size(46, 13);
            this.lblcdTipoCalculo.TabIndex = 12;
            this.lblcdTipoCalculo.Text = "Código :";
            // 
            // cdTipoCalculo
            // 
            this.cdTipoCalculo.AceitaEspaco = true;
            this.cdTipoCalculo.CampoDesabilitado = false;
            this.cdTipoCalculo.CampoObrigatorio = false;
            this.cdTipoCalculo.Location = new System.Drawing.Point(6, 34);
            this.cdTipoCalculo.MensagemCampoObrigatorio = null;
            this.cdTipoCalculo.Name = "cdTipoCalculo";
            this.cdTipoCalculo.Size = new System.Drawing.Size(100, 20);
            this.cdTipoCalculo.TabIndex = 13;
            // 
            // lbldeTipoCalculo
            // 
            this.lbldeTipoCalculo.AutoSize = true;
            this.lbldeTipoCalculo.Location = new System.Drawing.Point(3, 57);
            this.lbldeTipoCalculo.Name = "lbldeTipoCalculo";
            this.lbldeTipoCalculo.Size = new System.Drawing.Size(65, 13);
            this.lbldeTipoCalculo.TabIndex = 14;
            this.lbldeTipoCalculo.Text = "*Descrição :";
            // 
            // deTipoCalculo
            // 
            this.deTipoCalculo.AceitaEspaco = true;
            this.deTipoCalculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.deTipoCalculo.CampoDesabilitado = false;
            this.deTipoCalculo.CampoObrigatorio = true;
            this.deTipoCalculo.Location = new System.Drawing.Point(6, 73);
            this.deTipoCalculo.MensagemCampoObrigatorio = "Informe a descrição do Tipo de Cálculo.";
            this.deTipoCalculo.Name = "deTipoCalculo";
            this.deTipoCalculo.Size = new System.Drawing.Size(514, 20);
            this.deTipoCalculo.TabIndex = 15;
            // 
            // lblsgSiglaTipoCalculo
            // 
            this.lblsgSiglaTipoCalculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsgSiglaTipoCalculo.AutoSize = true;
            this.lblsgSiglaTipoCalculo.Location = new System.Drawing.Point(526, 57);
            this.lblsgSiglaTipoCalculo.Name = "lblsgSiglaTipoCalculo";
            this.lblsgSiglaTipoCalculo.Size = new System.Drawing.Size(40, 13);
            this.lblsgSiglaTipoCalculo.TabIndex = 16;
            this.lblsgSiglaTipoCalculo.Text = "*Sigla :";
            // 
            // sgSiglaTipoCalculo
            // 
            this.sgSiglaTipoCalculo.AceitaEspaco = true;
            this.sgSiglaTipoCalculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sgSiglaTipoCalculo.CampoDesabilitado = false;
            this.sgSiglaTipoCalculo.CampoObrigatorio = true;
            this.sgSiglaTipoCalculo.Location = new System.Drawing.Point(529, 73);
            this.sgSiglaTipoCalculo.MensagemCampoObrigatorio = "Informe a sigla do Tipo de Cálculo.";
            this.sgSiglaTipoCalculo.Name = "sgSiglaTipoCalculo";
            this.sgSiglaTipoCalculo.Size = new System.Drawing.Size(134, 20);
            this.sgSiglaTipoCalculo.TabIndex = 17;
            // 
            // lbldeFormulaTipoCalculo
            // 
            this.lbldeFormulaTipoCalculo.AutoSize = true;
            this.lbldeFormulaTipoCalculo.Location = new System.Drawing.Point(3, 96);
            this.lbldeFormulaTipoCalculo.Name = "lbldeFormulaTipoCalculo";
            this.lbldeFormulaTipoCalculo.Size = new System.Drawing.Size(54, 13);
            this.lbldeFormulaTipoCalculo.TabIndex = 18;
            this.lbldeFormulaTipoCalculo.Text = "*Fórmula :";
            // 
            // deFormulaTipoCalculo
            // 
            this.deFormulaTipoCalculo.AceitaEspaco = true;
            this.deFormulaTipoCalculo.CampoDesabilitado = false;
            this.deFormulaTipoCalculo.CampoObrigatorio = true;
            this.deFormulaTipoCalculo.Location = new System.Drawing.Point(6, 112);
            this.deFormulaTipoCalculo.MensagemCampoObrigatorio = "Informe a fórmula do Tipo de Cálculo.";
            this.deFormulaTipoCalculo.Name = "deFormulaTipoCalculo";
            this.deFormulaTipoCalculo.Size = new System.Drawing.Size(206, 20);
            this.deFormulaTipoCalculo.TabIndex = 19;
            // 
            // frmCadTipoCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 367);
            this.Name = "frmCadTipoCalculo";
            this.Text = "Cadastro de Tipo de Cálculo";
            this.TpCorrente = this.tpFormulario;
            this.pnFiltro.ResumeLayout(false);
            this.pnForm.ResumeLayout(false);
            this.pnForm.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.tcCadastro.ResumeLayout(false);
            this.tpFormulario.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcdTipoCalculo;
        private KuraFrameWork.Componentes_Visuais.ucTextBoxNumero cdTipoCalculo;
        private KuraFrameWork.Componentes_Visuais.ucTextBox deTipoCalculo;
        private System.Windows.Forms.Label lbldeTipoCalculo;
        private System.Windows.Forms.Label lblsgSiglaTipoCalculo;
        private KuraFrameWork.Componentes_Visuais.ucTextBox sgSiglaTipoCalculo;
        private KuraFrameWork.Componentes_Visuais.ucTextBox deFormulaTipoCalculo;
        private System.Windows.Forms.Label lbldeFormulaTipoCalculo;
    }
}
