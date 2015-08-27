namespace SansERP.Geral.TipoTelefone.View
{
    partial class frmCadTipoTelefone
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
            this.lblcdTipoTelefone = new System.Windows.Forms.Label();
            this.cdTipoTelefone = new KuraFrameWork.Componentes_Visuais.ucTextBoxNumero();
            this.lbldeTipoTelefone = new System.Windows.Forms.Label();
            this.deTipoTelefone = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.pnFiltro.SuspendLayout();
            this.pnForm.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tcCadastro.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnForm
            // 
            this.pnForm.Controls.Add(this.deTipoTelefone);
            this.pnForm.Controls.Add(this.lbldeTipoTelefone);
            this.pnForm.Controls.Add(this.cdTipoTelefone);
            this.pnForm.Controls.Add(this.lblcdTipoTelefone);
            this.pnForm.Controls.SetChildIndex(this.btnPrevious, 0);
            this.pnForm.Controls.SetChildIndex(this.btnFirst, 0);
            this.pnForm.Controls.SetChildIndex(this.btnLast, 0);
            this.pnForm.Controls.SetChildIndex(this.btnNext, 0);
            this.pnForm.Controls.SetChildIndex(this.lblcdTipoTelefone, 0);
            this.pnForm.Controls.SetChildIndex(this.cdTipoTelefone, 0);
            this.pnForm.Controls.SetChildIndex(this.lbldeTipoTelefone, 0);
            this.pnForm.Controls.SetChildIndex(this.deTipoTelefone, 0);
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
            // lblcdTipoTelefone
            // 
            this.lblcdTipoTelefone.AutoSize = true;
            this.lblcdTipoTelefone.Location = new System.Drawing.Point(3, 18);
            this.lblcdTipoTelefone.Name = "lblcdTipoTelefone";
            this.lblcdTipoTelefone.Size = new System.Drawing.Size(46, 13);
            this.lblcdTipoTelefone.TabIndex = 12;
            this.lblcdTipoTelefone.Text = "Código :";
            // 
            // cdTipoTelefone
            // 
            this.cdTipoTelefone.AceitaEspaco = true;
            this.cdTipoTelefone.CampoDesabilitado = false;
            this.cdTipoTelefone.CampoObrigatorio = false;
            this.cdTipoTelefone.Location = new System.Drawing.Point(6, 34);
            this.cdTipoTelefone.MensagemCampoObrigatorio = null;
            this.cdTipoTelefone.Name = "cdTipoTelefone";
            this.cdTipoTelefone.Size = new System.Drawing.Size(100, 20);
            this.cdTipoTelefone.TabIndex = 13;
            // 
            // lbldeTipoTelefone
            // 
            this.lbldeTipoTelefone.AutoSize = true;
            this.lbldeTipoTelefone.Location = new System.Drawing.Point(3, 57);
            this.lbldeTipoTelefone.Name = "lbldeTipoTelefone";
            this.lbldeTipoTelefone.Size = new System.Drawing.Size(65, 13);
            this.lbldeTipoTelefone.TabIndex = 14;
            this.lbldeTipoTelefone.Text = "*Descrição :";
            // 
            // deTipoTelefone
            // 
            this.deTipoTelefone.AceitaEspaco = true;
            this.deTipoTelefone.CampoDesabilitado = false;
            this.deTipoTelefone.CampoObrigatorio = false;
            this.deTipoTelefone.Location = new System.Drawing.Point(6, 73);
            this.deTipoTelefone.MensagemCampoObrigatorio = null;
            this.deTipoTelefone.Name = "deTipoTelefone";
            this.deTipoTelefone.Size = new System.Drawing.Size(278, 20);
            this.deTipoTelefone.TabIndex = 15;
            // 
            // frmCadTipoTelefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 367);
            this.Name = "frmCadTipoTelefone";
            this.Text = "Cadastro de Tipo de Telefone";
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

        private KuraFrameWork.Componentes_Visuais.ucTextBoxNumero cdTipoTelefone;
        private System.Windows.Forms.Label lblcdTipoTelefone;
        private KuraFrameWork.Componentes_Visuais.ucTextBox deTipoTelefone;
        private System.Windows.Forms.Label lbldeTipoTelefone;
    }
}
