namespace SansERP.Geral.Pais.View
{
    partial class frmCadPais
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
            this.lblcdPais = new System.Windows.Forms.Label();
            this.cdPais = new KuraFrameWork.Componentes_Visuais.ucTextBoxNumero();
            this.lblnmPais = new System.Windows.Forms.Label();
            this.ucTextBox1 = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.deSiglaPais = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lbldeSiglaPais = new System.Windows.Forms.Label();
            this.pnFiltro.SuspendLayout();
            this.pnForm.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tcCadastro.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnForm
            // 
            this.pnForm.Controls.Add(this.deSiglaPais);
            this.pnForm.Controls.Add(this.lbldeSiglaPais);
            this.pnForm.Controls.Add(this.ucTextBox1);
            this.pnForm.Controls.Add(this.lblnmPais);
            this.pnForm.Controls.Add(this.cdPais);
            this.pnForm.Controls.Add(this.lblcdPais);
            this.pnForm.Controls.SetChildIndex(this.btnPrevious, 0);
            this.pnForm.Controls.SetChildIndex(this.btnFirst, 0);
            this.pnForm.Controls.SetChildIndex(this.btnLast, 0);
            this.pnForm.Controls.SetChildIndex(this.btnNext, 0);
            this.pnForm.Controls.SetChildIndex(this.lblcdPais, 0);
            this.pnForm.Controls.SetChildIndex(this.cdPais, 0);
            this.pnForm.Controls.SetChildIndex(this.lblnmPais, 0);
            this.pnForm.Controls.SetChildIndex(this.ucTextBox1, 0);
            this.pnForm.Controls.SetChildIndex(this.lbldeSiglaPais, 0);
            this.pnForm.Controls.SetChildIndex(this.deSiglaPais, 0);
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
            // lblcdPais
            // 
            this.lblcdPais.AutoSize = true;
            this.lblcdPais.Location = new System.Drawing.Point(3, 18);
            this.lblcdPais.Name = "lblcdPais";
            this.lblcdPais.Size = new System.Drawing.Size(46, 13);
            this.lblcdPais.TabIndex = 12;
            this.lblcdPais.Text = "Código :";
            // 
            // cdPais
            // 
            this.cdPais.AceitaEspaco = true;
            this.cdPais.CampoDesabilitado = false;
            this.cdPais.CampoObrigatorio = false;
            this.cdPais.Location = new System.Drawing.Point(6, 34);
            this.cdPais.MensagemCampoObrigatorio = null;
            this.cdPais.Name = "cdPais";
            this.cdPais.Size = new System.Drawing.Size(100, 20);
            this.cdPais.TabIndex = 13;
            // 
            // lblnmPais
            // 
            this.lblnmPais.AutoSize = true;
            this.lblnmPais.Location = new System.Drawing.Point(3, 57);
            this.lblnmPais.Name = "lblnmPais";
            this.lblnmPais.Size = new System.Drawing.Size(45, 13);
            this.lblnmPais.TabIndex = 14;
            this.lblnmPais.Text = "*Nome :";
            // 
            // ucTextBox1
            // 
            this.ucTextBox1.AceitaEspaco = true;
            this.ucTextBox1.CampoDesabilitado = false;
            this.ucTextBox1.CampoObrigatorio = true;
            this.ucTextBox1.Location = new System.Drawing.Point(6, 73);
            this.ucTextBox1.MensagemCampoObrigatorio = "Informe o nome do País.";
            this.ucTextBox1.Name = "ucTextBox1";
            this.ucTextBox1.Size = new System.Drawing.Size(182, 20);
            this.ucTextBox1.TabIndex = 15;
            // 
            // deSiglaPais
            // 
            this.deSiglaPais.AceitaEspaco = true;
            this.deSiglaPais.CampoDesabilitado = false;
            this.deSiglaPais.CampoObrigatorio = true;
            this.deSiglaPais.Location = new System.Drawing.Point(194, 73);
            this.deSiglaPais.MensagemCampoObrigatorio = "Informe a sigla do País.";
            this.deSiglaPais.Name = "deSiglaPais";
            this.deSiglaPais.Size = new System.Drawing.Size(63, 20);
            this.deSiglaPais.TabIndex = 17;
            // 
            // lbldeSiglaPais
            // 
            this.lbldeSiglaPais.AutoSize = true;
            this.lbldeSiglaPais.Location = new System.Drawing.Point(191, 57);
            this.lbldeSiglaPais.Name = "lbldeSiglaPais";
            this.lbldeSiglaPais.Size = new System.Drawing.Size(40, 13);
            this.lbldeSiglaPais.TabIndex = 16;
            this.lbldeSiglaPais.Text = "*Sigla :";
            // 
            // frmCadPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 367);
            this.Name = "frmCadPais";
            this.Text = "Cadastro de País";
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

        private KuraFrameWork.Componentes_Visuais.ucTextBoxNumero cdPais;
        private System.Windows.Forms.Label lblcdPais;
        private System.Windows.Forms.Label lblnmPais;
        private KuraFrameWork.Componentes_Visuais.ucTextBox deSiglaPais;
        private System.Windows.Forms.Label lbldeSiglaPais;
        private KuraFrameWork.Componentes_Visuais.ucTextBox ucTextBox1;
    }
}
