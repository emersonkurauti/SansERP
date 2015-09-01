namespace SansERP.Geral.Cliente.View
{
    partial class ucCadClienteFisica
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnmPessoaFisica = new System.Windows.Forms.Label();
            this.lblnuCPF = new System.Windows.Forms.Label();
            this.lblnuRG = new System.Windows.Forms.Label();
            this.lbldtNascPessoaFisica = new System.Windows.Forms.Label();
            this.dtNascPessoaFisica = new System.Windows.Forms.DateTimePicker();
            this.nuRG = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.nuCPF = new KuraFrameWork.Componentes_Visuais.ucTextBoxMaskCPF();
            this.nmPessoaFisica = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.SuspendLayout();
            // 
            // lblnmPessoaFisica
            // 
            this.lblnmPessoaFisica.AutoSize = true;
            this.lblnmPessoaFisica.Location = new System.Drawing.Point(3, 0);
            this.lblnmPessoaFisica.Name = "lblnmPessoaFisica";
            this.lblnmPessoaFisica.Size = new System.Drawing.Size(45, 13);
            this.lblnmPessoaFisica.TabIndex = 0;
            this.lblnmPessoaFisica.Text = "*Nome :";
            // 
            // lblnuCPF
            // 
            this.lblnuCPF.AutoSize = true;
            this.lblnuCPF.Location = new System.Drawing.Point(116, 39);
            this.lblnuCPF.Name = "lblnuCPF";
            this.lblnuCPF.Size = new System.Drawing.Size(37, 13);
            this.lblnuCPF.TabIndex = 2;
            this.lblnuCPF.Text = "*CPF :";
            // 
            // lblnuRG
            // 
            this.lblnuRG.AutoSize = true;
            this.lblnuRG.Location = new System.Drawing.Point(238, 39);
            this.lblnuRG.Name = "lblnuRG";
            this.lblnuRG.Size = new System.Drawing.Size(29, 13);
            this.lblnuRG.TabIndex = 4;
            this.lblnuRG.Text = "RG :";
            // 
            // lbldtNascPessoaFisica
            // 
            this.lbldtNascPessoaFisica.AutoSize = true;
            this.lbldtNascPessoaFisica.Location = new System.Drawing.Point(3, 39);
            this.lbldtNascPessoaFisica.Name = "lbldtNascPessoaFisica";
            this.lbldtNascPessoaFisica.Size = new System.Drawing.Size(110, 13);
            this.lbldtNascPessoaFisica.TabIndex = 6;
            this.lbldtNascPessoaFisica.Text = "Data de Nascimento :";
            // 
            // dtNascPessoaFisica
            // 
            this.dtNascPessoaFisica.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascPessoaFisica.Location = new System.Drawing.Point(6, 55);
            this.dtNascPessoaFisica.Name = "dtNascPessoaFisica";
            this.dtNascPessoaFisica.Size = new System.Drawing.Size(104, 20);
            this.dtNascPessoaFisica.TabIndex = 7;
            // 
            // nuRG
            // 
            this.nuRG.AceitaEspaco = true;
            this.nuRG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nuRG.CampoDesabilitado = false;
            this.nuRG.CampoObrigatorio = false;
            this.nuRG.Location = new System.Drawing.Point(241, 55);
            this.nuRG.MensagemCampoObrigatorio = null;
            this.nuRG.Name = "nuRG";
            this.nuRG.Size = new System.Drawing.Size(346, 20);
            this.nuRG.TabIndex = 5;
            // 
            // nuCPF
            // 
            this.nuCPF.CampoObrigatorio = true;
            this.nuCPF.Location = new System.Drawing.Point(116, 55);
            this.nuCPF.Mask = "999,999,999-AA";
            this.nuCPF.MensagemCampoObrigatorio = "Informe o CPF do Cliente.";
            this.nuCPF.Name = "nuCPF";
            this.nuCPF.Size = new System.Drawing.Size(119, 20);
            this.nuCPF.TabIndex = 3;
            // 
            // nmPessoaFisica
            // 
            this.nmPessoaFisica.AceitaEspaco = true;
            this.nmPessoaFisica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nmPessoaFisica.CampoDesabilitado = false;
            this.nmPessoaFisica.CampoObrigatorio = false;
            this.nmPessoaFisica.Location = new System.Drawing.Point(6, 16);
            this.nmPessoaFisica.MensagemCampoObrigatorio = null;
            this.nmPessoaFisica.Name = "nmPessoaFisica";
            this.nmPessoaFisica.Size = new System.Drawing.Size(581, 20);
            this.nmPessoaFisica.TabIndex = 1;
            // 
            // ucCadClienteFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtNascPessoaFisica);
            this.Controls.Add(this.lbldtNascPessoaFisica);
            this.Controls.Add(this.nuRG);
            this.Controls.Add(this.lblnuRG);
            this.Controls.Add(this.nuCPF);
            this.Controls.Add(this.lblnuCPF);
            this.Controls.Add(this.nmPessoaFisica);
            this.Controls.Add(this.lblnmPessoaFisica);
            this.Name = "ucCadClienteFisica";
            this.Size = new System.Drawing.Size(590, 78);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnmPessoaFisica;
        private KuraFrameWork.Componentes_Visuais.ucTextBox nmPessoaFisica;
        private System.Windows.Forms.Label lblnuCPF;
        private KuraFrameWork.Componentes_Visuais.ucTextBoxMaskCPF nuCPF;
        private System.Windows.Forms.Label lblnuRG;
        private KuraFrameWork.Componentes_Visuais.ucTextBox nuRG;
        private System.Windows.Forms.Label lbldtNascPessoaFisica;
        private System.Windows.Forms.DateTimePicker dtNascPessoaFisica;
    }
}
