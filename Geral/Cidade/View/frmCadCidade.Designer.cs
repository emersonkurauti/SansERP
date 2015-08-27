namespace SansERP.Geral.Cidade.View
{
    partial class frmCadCidade
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
            this.lblcdCidade = new System.Windows.Forms.Label();
            this.cdCidade = new KuraFrameWork.Componentes_Visuais.ucTextBoxNumero();
            this.nmCidade = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lblnmCidade = new System.Windows.Forms.Label();
            this.cdEstado = new SansERP.Geral.Estado.View.ucConsEstado();
            this.pnFiltro.SuspendLayout();
            this.pnForm.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tcCadastro.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnForm
            // 
            this.pnForm.Controls.Add(this.cdEstado);
            this.pnForm.Controls.Add(this.lblnmCidade);
            this.pnForm.Controls.Add(this.nmCidade);
            this.pnForm.Controls.Add(this.cdCidade);
            this.pnForm.Controls.Add(this.lblcdCidade);
            this.pnForm.Controls.SetChildIndex(this.btnPrevious, 0);
            this.pnForm.Controls.SetChildIndex(this.btnFirst, 0);
            this.pnForm.Controls.SetChildIndex(this.btnLast, 0);
            this.pnForm.Controls.SetChildIndex(this.btnNext, 0);
            this.pnForm.Controls.SetChildIndex(this.lblcdCidade, 0);
            this.pnForm.Controls.SetChildIndex(this.cdCidade, 0);
            this.pnForm.Controls.SetChildIndex(this.nmCidade, 0);
            this.pnForm.Controls.SetChildIndex(this.lblnmCidade, 0);
            this.pnForm.Controls.SetChildIndex(this.cdEstado, 0);
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
            // lblcdCidade
            // 
            this.lblcdCidade.AutoSize = true;
            this.lblcdCidade.Location = new System.Drawing.Point(3, 18);
            this.lblcdCidade.Name = "lblcdCidade";
            this.lblcdCidade.Size = new System.Drawing.Size(46, 13);
            this.lblcdCidade.TabIndex = 12;
            this.lblcdCidade.Text = "Código :";
            // 
            // cdCidade
            // 
            this.cdCidade.AceitaEspaco = true;
            this.cdCidade.CampoDesabilitado = false;
            this.cdCidade.CampoObrigatorio = false;
            this.cdCidade.Location = new System.Drawing.Point(6, 34);
            this.cdCidade.MensagemCampoObrigatorio = null;
            this.cdCidade.Name = "cdCidade";
            this.cdCidade.Size = new System.Drawing.Size(100, 20);
            this.cdCidade.TabIndex = 13;
            // 
            // nmCidade
            // 
            this.nmCidade.AceitaEspaco = true;
            this.nmCidade.CampoDesabilitado = false;
            this.nmCidade.CampoObrigatorio = true;
            this.nmCidade.Location = new System.Drawing.Point(6, 73);
            this.nmCidade.MensagemCampoObrigatorio = "Informe o nome da Cidade.";
            this.nmCidade.Name = "nmCidade";
            this.nmCidade.Size = new System.Drawing.Size(369, 20);
            this.nmCidade.TabIndex = 14;
            // 
            // lblnmCidade
            // 
            this.lblnmCidade.AutoSize = true;
            this.lblnmCidade.Location = new System.Drawing.Point(3, 57);
            this.lblnmCidade.Name = "lblnmCidade";
            this.lblnmCidade.Size = new System.Drawing.Size(45, 13);
            this.lblnmCidade.TabIndex = 15;
            this.lblnmCidade.Text = "*Nome :";
            // 
            // cdEstado
            // 
            this.cdEstado.bCadastrar = true;
            this.cdEstado.bMudouCodigo = false;
            this.cdEstado.CampoObrigatorio = false;
            this.cdEstado.cdRegistro = 0;
            this.cdEstado.deRegistro = null;
            this.cdEstado.Location = new System.Drawing.Point(381, 57);
            this.cdEstado.MensagemCampoObrigatorio = null;
            this.cdEstado.Name = "cdEstado";
            this.cdEstado.objCon = null;
            this.cdEstado.Rotulo = "*Estado :";
            this.cdEstado.Size = new System.Drawing.Size(282, 36);
            this.cdEstado.TabIndex = 16;
            this.cdEstado.TelaConsulta = null;
            this.cdEstado.tfrmConsulta = null;
            this.cdEstado.tobjCa = null;
            // 
            // frmCadCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 367);
            this.Name = "frmCadCidade";
            this.Text = "Cadastro de Cidade";
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

        private System.Windows.Forms.Label lblcdCidade;
        private System.Windows.Forms.Label lblnmCidade;
        private KuraFrameWork.Componentes_Visuais.ucTextBox nmCidade;
        private KuraFrameWork.Componentes_Visuais.ucTextBoxNumero cdCidade;
        private Estado.View.ucConsEstado cdEstado;
    }
}
