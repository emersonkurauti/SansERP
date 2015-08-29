namespace SansERP.Geral.Fabricante.View
{
    partial class frmCadFabricante
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
            this.lblcdFabricante = new System.Windows.Forms.Label();
            this.ucTextBoxNumero1 = new KuraFrameWork.Componentes_Visuais.ucTextBoxNumero();
            this.lblnmFabricante = new System.Windows.Forms.Label();
            this.nmFabricante = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.pnFiltro.SuspendLayout();
            this.pnForm.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tcCadastro.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnForm
            // 
            this.pnForm.Controls.Add(this.nmFabricante);
            this.pnForm.Controls.Add(this.lblnmFabricante);
            this.pnForm.Controls.Add(this.ucTextBoxNumero1);
            this.pnForm.Controls.Add(this.lblcdFabricante);
            this.pnForm.Controls.SetChildIndex(this.btnPrevious, 0);
            this.pnForm.Controls.SetChildIndex(this.btnFirst, 0);
            this.pnForm.Controls.SetChildIndex(this.btnLast, 0);
            this.pnForm.Controls.SetChildIndex(this.btnNext, 0);
            this.pnForm.Controls.SetChildIndex(this.lblcdFabricante, 0);
            this.pnForm.Controls.SetChildIndex(this.ucTextBoxNumero1, 0);
            this.pnForm.Controls.SetChildIndex(this.lblnmFabricante, 0);
            this.pnForm.Controls.SetChildIndex(this.nmFabricante, 0);
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
            // lblcdFabricante
            // 
            this.lblcdFabricante.AutoSize = true;
            this.lblcdFabricante.Location = new System.Drawing.Point(3, 18);
            this.lblcdFabricante.Name = "lblcdFabricante";
            this.lblcdFabricante.Size = new System.Drawing.Size(46, 13);
            this.lblcdFabricante.TabIndex = 12;
            this.lblcdFabricante.Text = "Código :";
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
            // lblnmFabricante
            // 
            this.lblnmFabricante.AutoSize = true;
            this.lblnmFabricante.Location = new System.Drawing.Point(3, 57);
            this.lblnmFabricante.Name = "lblnmFabricante";
            this.lblnmFabricante.Size = new System.Drawing.Size(45, 13);
            this.lblnmFabricante.TabIndex = 14;
            this.lblnmFabricante.Text = "*Nome :";
            // 
            // nmFabricante
            // 
            this.nmFabricante.AceitaEspaco = true;
            this.nmFabricante.CampoDesabilitado = false;
            this.nmFabricante.CampoObrigatorio = true;
            this.nmFabricante.Location = new System.Drawing.Point(6, 73);
            this.nmFabricante.MensagemCampoObrigatorio = "Informe o nome do Fabricante.";
            this.nmFabricante.Name = "nmFabricante";
            this.nmFabricante.Size = new System.Drawing.Size(305, 20);
            this.nmFabricante.TabIndex = 15;
            // 
            // frmCadFabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 367);
            this.Name = "frmCadFabricante";
            this.Text = "Cadastro de Fabricante";
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

        private KuraFrameWork.Componentes_Visuais.ucTextBoxNumero ucTextBoxNumero1;
        private System.Windows.Forms.Label lblcdFabricante;
        private KuraFrameWork.Componentes_Visuais.ucTextBox nmFabricante;
        private System.Windows.Forms.Label lblnmFabricante;
    }
}
