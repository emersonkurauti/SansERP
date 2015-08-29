namespace SansERP.Geral.OperadoraTelefonica.View
{
    partial class frmCadOperadoraTelefonica
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
            this.lblcdOperadoraTelefonica = new System.Windows.Forms.Label();
            this.ucTextBoxNumero1 = new KuraFrameWork.Componentes_Visuais.ucTextBoxNumero();
            this.lblnmOperadoraTelefonica = new System.Windows.Forms.Label();
            this.nmOperadoraTelefonica = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.pnFiltro.SuspendLayout();
            this.pnForm.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tcCadastro.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnForm
            // 
            this.pnForm.Controls.Add(this.nmOperadoraTelefonica);
            this.pnForm.Controls.Add(this.lblnmOperadoraTelefonica);
            this.pnForm.Controls.Add(this.ucTextBoxNumero1);
            this.pnForm.Controls.Add(this.lblcdOperadoraTelefonica);
            this.pnForm.Controls.SetChildIndex(this.btnPrevious, 0);
            this.pnForm.Controls.SetChildIndex(this.btnFirst, 0);
            this.pnForm.Controls.SetChildIndex(this.btnLast, 0);
            this.pnForm.Controls.SetChildIndex(this.btnNext, 0);
            this.pnForm.Controls.SetChildIndex(this.lblcdOperadoraTelefonica, 0);
            this.pnForm.Controls.SetChildIndex(this.ucTextBoxNumero1, 0);
            this.pnForm.Controls.SetChildIndex(this.lblnmOperadoraTelefonica, 0);
            this.pnForm.Controls.SetChildIndex(this.nmOperadoraTelefonica, 0);
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
            // lblcdOperadoraTelefonica
            // 
            this.lblcdOperadoraTelefonica.AutoSize = true;
            this.lblcdOperadoraTelefonica.Location = new System.Drawing.Point(3, 18);
            this.lblcdOperadoraTelefonica.Name = "lblcdOperadoraTelefonica";
            this.lblcdOperadoraTelefonica.Size = new System.Drawing.Size(46, 13);
            this.lblcdOperadoraTelefonica.TabIndex = 12;
            this.lblcdOperadoraTelefonica.Text = "Código :";
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
            // lblnmOperadoraTelefonica
            // 
            this.lblnmOperadoraTelefonica.AutoSize = true;
            this.lblnmOperadoraTelefonica.Location = new System.Drawing.Point(3, 57);
            this.lblnmOperadoraTelefonica.Name = "lblnmOperadoraTelefonica";
            this.lblnmOperadoraTelefonica.Size = new System.Drawing.Size(45, 13);
            this.lblnmOperadoraTelefonica.TabIndex = 14;
            this.lblnmOperadoraTelefonica.Text = "*Nome :";
            // 
            // nmOperadoraTelefonica
            // 
            this.nmOperadoraTelefonica.AceitaEspaco = true;
            this.nmOperadoraTelefonica.CampoDesabilitado = false;
            this.nmOperadoraTelefonica.CampoObrigatorio = false;
            this.nmOperadoraTelefonica.Location = new System.Drawing.Point(6, 73);
            this.nmOperadoraTelefonica.MensagemCampoObrigatorio = null;
            this.nmOperadoraTelefonica.Name = "nmOperadoraTelefonica";
            this.nmOperadoraTelefonica.Size = new System.Drawing.Size(288, 20);
            this.nmOperadoraTelefonica.TabIndex = 15;
            // 
            // frmCadOperadoraTelefonica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 367);
            this.Name = "frmCadOperadoraTelefonica";
            this.Text = "Cadastro de Operadora Telefônica";
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

        private KuraFrameWork.Componentes_Visuais.ucTextBox nmOperadoraTelefonica;
        private System.Windows.Forms.Label lblnmOperadoraTelefonica;
        private KuraFrameWork.Componentes_Visuais.ucTextBoxNumero ucTextBoxNumero1;
        private System.Windows.Forms.Label lblcdOperadoraTelefonica;
    }
}
