namespace SansERP.Geral.TipoEndereco.View
{
    partial class frmCadTipoEndereco
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
            this.lblcdTipoEndereco = new System.Windows.Forms.Label();
            this.cdTipoEndereco = new KuraFrameWork.Componentes_Visuais.ucTextBoxNumero();
            this.lbldeTipoEndereco = new System.Windows.Forms.Label();
            this.deTipoEndereco = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.pnFiltro.SuspendLayout();
            this.pnForm.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tcCadastro.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnForm
            // 
            this.pnForm.Controls.Add(this.deTipoEndereco);
            this.pnForm.Controls.Add(this.lbldeTipoEndereco);
            this.pnForm.Controls.Add(this.cdTipoEndereco);
            this.pnForm.Controls.Add(this.lblcdTipoEndereco);
            this.pnForm.Controls.SetChildIndex(this.btnPrevious, 0);
            this.pnForm.Controls.SetChildIndex(this.btnFirst, 0);
            this.pnForm.Controls.SetChildIndex(this.btnLast, 0);
            this.pnForm.Controls.SetChildIndex(this.btnNext, 0);
            this.pnForm.Controls.SetChildIndex(this.lblcdTipoEndereco, 0);
            this.pnForm.Controls.SetChildIndex(this.cdTipoEndereco, 0);
            this.pnForm.Controls.SetChildIndex(this.lbldeTipoEndereco, 0);
            this.pnForm.Controls.SetChildIndex(this.deTipoEndereco, 0);
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
            // lblcdTipoEndereco
            // 
            this.lblcdTipoEndereco.AutoSize = true;
            this.lblcdTipoEndereco.Location = new System.Drawing.Point(3, 18);
            this.lblcdTipoEndereco.Name = "lblcdTipoEndereco";
            this.lblcdTipoEndereco.Size = new System.Drawing.Size(46, 13);
            this.lblcdTipoEndereco.TabIndex = 12;
            this.lblcdTipoEndereco.Text = "Código :";
            // 
            // cdTipoEndereco
            // 
            this.cdTipoEndereco.AceitaEspaco = true;
            this.cdTipoEndereco.CampoDesabilitado = false;
            this.cdTipoEndereco.CampoObrigatorio = false;
            this.cdTipoEndereco.Location = new System.Drawing.Point(6, 34);
            this.cdTipoEndereco.MensagemCampoObrigatorio = null;
            this.cdTipoEndereco.Name = "cdTipoEndereco";
            this.cdTipoEndereco.Size = new System.Drawing.Size(100, 20);
            this.cdTipoEndereco.TabIndex = 13;
            // 
            // lbldeTipoEndereco
            // 
            this.lbldeTipoEndereco.AutoSize = true;
            this.lbldeTipoEndereco.Location = new System.Drawing.Point(3, 57);
            this.lbldeTipoEndereco.Name = "lbldeTipoEndereco";
            this.lbldeTipoEndereco.Size = new System.Drawing.Size(65, 13);
            this.lbldeTipoEndereco.TabIndex = 14;
            this.lbldeTipoEndereco.Text = "*Descrição :";
            // 
            // deTipoEndereco
            // 
            this.deTipoEndereco.AceitaEspaco = true;
            this.deTipoEndereco.CampoDesabilitado = false;
            this.deTipoEndereco.CampoObrigatorio = false;
            this.deTipoEndereco.Location = new System.Drawing.Point(6, 73);
            this.deTipoEndereco.MensagemCampoObrigatorio = null;
            this.deTipoEndereco.Name = "deTipoEndereco";
            this.deTipoEndereco.Size = new System.Drawing.Size(290, 20);
            this.deTipoEndereco.TabIndex = 15;
            // 
            // frmCadTipoEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 367);
            this.Name = "frmCadTipoEndereco";
            this.Text = "Cadastro de Tipo de Endereço";
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

        private KuraFrameWork.Componentes_Visuais.ucTextBox deTipoEndereco;
        private System.Windows.Forms.Label lbldeTipoEndereco;
        private KuraFrameWork.Componentes_Visuais.ucTextBoxNumero cdTipoEndereco;
        private System.Windows.Forms.Label lblcdTipoEndereco;
    }
}
