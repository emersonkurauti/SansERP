namespace SansERP.Geral.MarcaProduto.View
{
    partial class frmCadMarcaProduto
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
            this.lblcdMarcaProduto = new System.Windows.Forms.Label();
            this.cdMarcaProduto = new KuraFrameWork.Componentes_Visuais.ucTextBoxNumero();
            this.lblnmMarcaProduto = new System.Windows.Forms.Label();
            this.nmMarcaProduto = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.pnFiltro.SuspendLayout();
            this.pnForm.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tcCadastro.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnForm
            // 
            this.pnForm.Controls.Add(this.nmMarcaProduto);
            this.pnForm.Controls.Add(this.lblnmMarcaProduto);
            this.pnForm.Controls.Add(this.cdMarcaProduto);
            this.pnForm.Controls.Add(this.lblcdMarcaProduto);
            this.pnForm.Controls.SetChildIndex(this.btnPrevious, 0);
            this.pnForm.Controls.SetChildIndex(this.btnFirst, 0);
            this.pnForm.Controls.SetChildIndex(this.btnLast, 0);
            this.pnForm.Controls.SetChildIndex(this.btnNext, 0);
            this.pnForm.Controls.SetChildIndex(this.lblcdMarcaProduto, 0);
            this.pnForm.Controls.SetChildIndex(this.cdMarcaProduto, 0);
            this.pnForm.Controls.SetChildIndex(this.lblnmMarcaProduto, 0);
            this.pnForm.Controls.SetChildIndex(this.nmMarcaProduto, 0);
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
            // lblcdMarcaProduto
            // 
            this.lblcdMarcaProduto.AutoSize = true;
            this.lblcdMarcaProduto.Location = new System.Drawing.Point(3, 18);
            this.lblcdMarcaProduto.Name = "lblcdMarcaProduto";
            this.lblcdMarcaProduto.Size = new System.Drawing.Size(46, 13);
            this.lblcdMarcaProduto.TabIndex = 12;
            this.lblcdMarcaProduto.Text = "Código :";
            // 
            // cdMarcaProduto
            // 
            this.cdMarcaProduto.AceitaEspaco = true;
            this.cdMarcaProduto.CampoDesabilitado = false;
            this.cdMarcaProduto.CampoObrigatorio = false;
            this.cdMarcaProduto.Location = new System.Drawing.Point(6, 34);
            this.cdMarcaProduto.MensagemCampoObrigatorio = null;
            this.cdMarcaProduto.Name = "cdMarcaProduto";
            this.cdMarcaProduto.Size = new System.Drawing.Size(100, 20);
            this.cdMarcaProduto.TabIndex = 13;
            // 
            // lblnmMarcaProduto
            // 
            this.lblnmMarcaProduto.AutoSize = true;
            this.lblnmMarcaProduto.Location = new System.Drawing.Point(3, 57);
            this.lblnmMarcaProduto.Name = "lblnmMarcaProduto";
            this.lblnmMarcaProduto.Size = new System.Drawing.Size(45, 13);
            this.lblnmMarcaProduto.TabIndex = 14;
            this.lblnmMarcaProduto.Text = "*Nome :";
            // 
            // nmMarcaProduto
            // 
            this.nmMarcaProduto.AceitaEspaco = true;
            this.nmMarcaProduto.CampoDesabilitado = false;
            this.nmMarcaProduto.CampoObrigatorio = true;
            this.nmMarcaProduto.Location = new System.Drawing.Point(6, 73);
            this.nmMarcaProduto.MensagemCampoObrigatorio = "Informe o nome da Marca.";
            this.nmMarcaProduto.Name = "nmMarcaProduto";
            this.nmMarcaProduto.Size = new System.Drawing.Size(316, 20);
            this.nmMarcaProduto.TabIndex = 15;
            // 
            // frmCadMarcaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 367);
            this.Name = "frmCadMarcaProduto";
            this.Text = "Cadastro de Marca de Produtos";
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

        private KuraFrameWork.Componentes_Visuais.ucTextBox nmMarcaProduto;
        private System.Windows.Forms.Label lblnmMarcaProduto;
        private KuraFrameWork.Componentes_Visuais.ucTextBoxNumero cdMarcaProduto;
        private System.Windows.Forms.Label lblcdMarcaProduto;
    }
}
