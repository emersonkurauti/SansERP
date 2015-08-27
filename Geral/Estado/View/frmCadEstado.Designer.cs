namespace SansERP.Geral.Estado.View
{
    partial class frmCadEstado
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
            this.lblcdEstado = new System.Windows.Forms.Label();
            this.cdEstado = new KuraFrameWork.Componentes_Visuais.ucTextBoxNumero();
            this.lblnmEstado = new System.Windows.Forms.Label();
            this.nmEstado = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.deSiglaEstado = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lbldeSiglaEstado = new System.Windows.Forms.Label();
            this.ucConsPais = new SansERP.Geral.Pais.View.ucConsPais();
            this.pnFiltro.SuspendLayout();
            this.pnForm.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tcCadastro.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnForm
            // 
            this.pnForm.Controls.Add(this.ucConsPais);
            this.pnForm.Controls.Add(this.lbldeSiglaEstado);
            this.pnForm.Controls.Add(this.deSiglaEstado);
            this.pnForm.Controls.Add(this.nmEstado);
            this.pnForm.Controls.Add(this.lblnmEstado);
            this.pnForm.Controls.Add(this.cdEstado);
            this.pnForm.Controls.Add(this.lblcdEstado);
            this.pnForm.Controls.SetChildIndex(this.btnPrevious, 0);
            this.pnForm.Controls.SetChildIndex(this.btnFirst, 0);
            this.pnForm.Controls.SetChildIndex(this.btnLast, 0);
            this.pnForm.Controls.SetChildIndex(this.btnNext, 0);
            this.pnForm.Controls.SetChildIndex(this.lblcdEstado, 0);
            this.pnForm.Controls.SetChildIndex(this.cdEstado, 0);
            this.pnForm.Controls.SetChildIndex(this.lblnmEstado, 0);
            this.pnForm.Controls.SetChildIndex(this.nmEstado, 0);
            this.pnForm.Controls.SetChildIndex(this.deSiglaEstado, 0);
            this.pnForm.Controls.SetChildIndex(this.lbldeSiglaEstado, 0);
            this.pnForm.Controls.SetChildIndex(this.ucConsPais, 0);
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
            // lblcdEstado
            // 
            this.lblcdEstado.AutoSize = true;
            this.lblcdEstado.Location = new System.Drawing.Point(3, 18);
            this.lblcdEstado.Name = "lblcdEstado";
            this.lblcdEstado.Size = new System.Drawing.Size(46, 13);
            this.lblcdEstado.TabIndex = 12;
            this.lblcdEstado.Text = "Código :";
            // 
            // cdEstado
            // 
            this.cdEstado.AceitaEspaco = true;
            this.cdEstado.CampoDesabilitado = false;
            this.cdEstado.CampoObrigatorio = false;
            this.cdEstado.Location = new System.Drawing.Point(6, 34);
            this.cdEstado.MensagemCampoObrigatorio = null;
            this.cdEstado.Name = "cdEstado";
            this.cdEstado.Size = new System.Drawing.Size(100, 20);
            this.cdEstado.TabIndex = 13;
            // 
            // lblnmEstado
            // 
            this.lblnmEstado.AutoSize = true;
            this.lblnmEstado.Location = new System.Drawing.Point(3, 57);
            this.lblnmEstado.Name = "lblnmEstado";
            this.lblnmEstado.Size = new System.Drawing.Size(45, 13);
            this.lblnmEstado.TabIndex = 14;
            this.lblnmEstado.Text = "*Nome :";
            // 
            // nmEstado
            // 
            this.nmEstado.AceitaEspaco = true;
            this.nmEstado.CampoDesabilitado = false;
            this.nmEstado.CampoObrigatorio = true;
            this.nmEstado.Location = new System.Drawing.Point(6, 73);
            this.nmEstado.MensagemCampoObrigatorio = "Informe o nome do Estado.";
            this.nmEstado.Name = "nmEstado";
            this.nmEstado.Size = new System.Drawing.Size(190, 20);
            this.nmEstado.TabIndex = 15;
            // 
            // deSiglaEstado
            // 
            this.deSiglaEstado.AceitaEspaco = true;
            this.deSiglaEstado.CampoDesabilitado = false;
            this.deSiglaEstado.CampoObrigatorio = false;
            this.deSiglaEstado.Location = new System.Drawing.Point(202, 73);
            this.deSiglaEstado.MensagemCampoObrigatorio = "Informe a sigla do Estado.";
            this.deSiglaEstado.Name = "deSiglaEstado";
            this.deSiglaEstado.Size = new System.Drawing.Size(40, 20);
            this.deSiglaEstado.TabIndex = 16;
            // 
            // lbldeSiglaEstado
            // 
            this.lbldeSiglaEstado.AutoSize = true;
            this.lbldeSiglaEstado.Location = new System.Drawing.Point(199, 57);
            this.lbldeSiglaEstado.Name = "lbldeSiglaEstado";
            this.lbldeSiglaEstado.Size = new System.Drawing.Size(31, 13);
            this.lbldeSiglaEstado.TabIndex = 17;
            this.lbldeSiglaEstado.Text = "*UF :";
            // 
            // ucConsPais
            // 
            this.ucConsPais.bCadastrar = true;
            this.ucConsPais.bMudouCodigo = false;
            this.ucConsPais.CampoObrigatorio = true;
            this.ucConsPais.cdRegistro = 0;
            this.ucConsPais.deRegistro = null;
            this.ucConsPais.Location = new System.Drawing.Point(6, 99);
            this.ucConsPais.MensagemCampoObrigatorio = "Selecione o país.";
            this.ucConsPais.Name = "ucConsPais";
            this.ucConsPais.objCon = null;
            this.ucConsPais.Rotulo = "País :";
            this.ucConsPais.Size = new System.Drawing.Size(236, 36);
            this.ucConsPais.TabIndex = 18;
            this.ucConsPais.TelaConsulta = null;
            this.ucConsPais.tfrmConsulta = null;
            this.ucConsPais.tobjCa = null;
            // 
            // frmCadEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 367);
            this.Name = "frmCadEstado";
            this.Text = "Cadastro de Estado";
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

        private KuraFrameWork.Componentes_Visuais.ucTextBoxNumero cdEstado;
        private System.Windows.Forms.Label lblcdEstado;
        private System.Windows.Forms.Label lblnmEstado;
        private KuraFrameWork.Componentes_Visuais.ucTextBox nmEstado;
        private KuraFrameWork.Componentes_Visuais.ucTextBox deSiglaEstado;
        private System.Windows.Forms.Label lbldeSiglaEstado;
        private Pais.View.ucConsPais ucConsPais;
    }
}
