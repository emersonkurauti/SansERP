namespace SansERP.Geral.TipoProduto.View
{
    partial class frmCadTipoProduto
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
            this.lblcdTipoProduto = new System.Windows.Forms.Label();
            this.cdTipoProduto = new KuraFrameWork.Componentes_Visuais.ucTextBoxNumero();
            this.lbldeTipoProduto = new System.Windows.Forms.Label();
            this.deTipoProduto = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.pnFiltro.SuspendLayout();
            this.pnForm.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tcCadastro.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnForm
            // 
            this.pnForm.Controls.Add(this.deTipoProduto);
            this.pnForm.Controls.Add(this.lbldeTipoProduto);
            this.pnForm.Controls.Add(this.cdTipoProduto);
            this.pnForm.Controls.Add(this.lblcdTipoProduto);
            this.pnForm.Controls.SetChildIndex(this.btnPrevious, 0);
            this.pnForm.Controls.SetChildIndex(this.btnFirst, 0);
            this.pnForm.Controls.SetChildIndex(this.btnLast, 0);
            this.pnForm.Controls.SetChildIndex(this.btnNext, 0);
            this.pnForm.Controls.SetChildIndex(this.lblcdTipoProduto, 0);
            this.pnForm.Controls.SetChildIndex(this.cdTipoProduto, 0);
            this.pnForm.Controls.SetChildIndex(this.lbldeTipoProduto, 0);
            this.pnForm.Controls.SetChildIndex(this.deTipoProduto, 0);
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
            // lblcdTipoProduto
            // 
            this.lblcdTipoProduto.AutoSize = true;
            this.lblcdTipoProduto.Location = new System.Drawing.Point(3, 18);
            this.lblcdTipoProduto.Name = "lblcdTipoProduto";
            this.lblcdTipoProduto.Size = new System.Drawing.Size(46, 13);
            this.lblcdTipoProduto.TabIndex = 12;
            this.lblcdTipoProduto.Text = "Código :";
            // 
            // cdTipoProduto
            // 
            this.cdTipoProduto.AceitaEspaco = true;
            this.cdTipoProduto.CampoDesabilitado = false;
            this.cdTipoProduto.CampoObrigatorio = false;
            this.cdTipoProduto.Location = new System.Drawing.Point(6, 34);
            this.cdTipoProduto.MensagemCampoObrigatorio = null;
            this.cdTipoProduto.Name = "cdTipoProduto";
            this.cdTipoProduto.Size = new System.Drawing.Size(100, 20);
            this.cdTipoProduto.TabIndex = 13;
            // 
            // lbldeTipoProduto
            // 
            this.lbldeTipoProduto.AutoSize = true;
            this.lbldeTipoProduto.Location = new System.Drawing.Point(3, 57);
            this.lbldeTipoProduto.Name = "lbldeTipoProduto";
            this.lbldeTipoProduto.Size = new System.Drawing.Size(65, 13);
            this.lbldeTipoProduto.TabIndex = 14;
            this.lbldeTipoProduto.Text = "*Descrição :";
            // 
            // deTipoProduto
            // 
            this.deTipoProduto.AceitaEspaco = true;
            this.deTipoProduto.CampoDesabilitado = false;
            this.deTipoProduto.CampoObrigatorio = true;
            this.deTipoProduto.Location = new System.Drawing.Point(6, 73);
            this.deTipoProduto.MensagemCampoObrigatorio = "Informe  a descrição do Tipo de Produto.";
            this.deTipoProduto.Name = "deTipoProduto";
            this.deTipoProduto.Size = new System.Drawing.Size(312, 20);
            this.deTipoProduto.TabIndex = 15;
            // 
            // frmCadTipoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 367);
            this.Name = "frmCadTipoProduto";
            this.Text = "Cadastro de Tipo de Produto";
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

        private KuraFrameWork.Componentes_Visuais.ucTextBoxNumero cdTipoProduto;
        private System.Windows.Forms.Label lblcdTipoProduto;
        private KuraFrameWork.Componentes_Visuais.ucTextBox deTipoProduto;
        private System.Windows.Forms.Label lbldeTipoProduto;
    }
}
