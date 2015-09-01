namespace SansERP.Geral.Cliente.View
{
    partial class ucCadClienteJuridica
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
            this.lblnmFantasiaCliente = new System.Windows.Forms.Label();
            this.lblnmRazaoSocialCliente = new System.Windows.Forms.Label();
            this.lgLogoCliente = new System.Windows.Forms.PictureBox();
            this.lblnuCNPJCliente = new System.Windows.Forms.Label();
            this.lblnuInscricaoEstadualCliente = new System.Windows.Forms.Label();
            this.nuInscricaoEstadualCliente = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.nuCNPJCliente = new KuraFrameWork.Componentes_Visuais.ucTextBoxMaskCNPJ();
            this.nmRazaoSocialCliente = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.nmFantasiaCliente = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lgLogoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnmFantasiaCliente
            // 
            this.lblnmFantasiaCliente.AutoSize = true;
            this.lblnmFantasiaCliente.Location = new System.Drawing.Point(3, 0);
            this.lblnmFantasiaCliente.Name = "lblnmFantasiaCliente";
            this.lblnmFantasiaCliente.Size = new System.Drawing.Size(88, 13);
            this.lblnmFantasiaCliente.TabIndex = 0;
            this.lblnmFantasiaCliente.Text = "*Nome Fantasia :";
            // 
            // lblnmRazaoSocialCliente
            // 
            this.lblnmRazaoSocialCliente.AutoSize = true;
            this.lblnmRazaoSocialCliente.Location = new System.Drawing.Point(3, 39);
            this.lblnmRazaoSocialCliente.Name = "lblnmRazaoSocialCliente";
            this.lblnmRazaoSocialCliente.Size = new System.Drawing.Size(80, 13);
            this.lblnmRazaoSocialCliente.TabIndex = 2;
            this.lblnmRazaoSocialCliente.Text = "*Razão Social :";
            // 
            // lgLogoCliente
            // 
            this.lgLogoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lgLogoCliente.Location = new System.Drawing.Point(444, 16);
            this.lgLogoCliente.Name = "lgLogoCliente";
            this.lgLogoCliente.Size = new System.Drawing.Size(143, 99);
            this.lgLogoCliente.TabIndex = 4;
            this.lgLogoCliente.TabStop = false;
            // 
            // lblnuCNPJCliente
            // 
            this.lblnuCNPJCliente.AutoSize = true;
            this.lblnuCNPJCliente.Location = new System.Drawing.Point(3, 78);
            this.lblnuCNPJCliente.Name = "lblnuCNPJCliente";
            this.lblnuCNPJCliente.Size = new System.Drawing.Size(44, 13);
            this.lblnuCNPJCliente.TabIndex = 5;
            this.lblnuCNPJCliente.Text = "*CNPJ :";
            // 
            // lblnuInscricaoEstadualCliente
            // 
            this.lblnuInscricaoEstadualCliente.AutoSize = true;
            this.lblnuInscricaoEstadualCliente.Location = new System.Drawing.Point(154, 78);
            this.lblnuInscricaoEstadualCliente.Name = "lblnuInscricaoEstadualCliente";
            this.lblnuInscricaoEstadualCliente.Size = new System.Drawing.Size(100, 13);
            this.lblnuInscricaoEstadualCliente.TabIndex = 7;
            this.lblnuInscricaoEstadualCliente.Text = "Inscrição Estadual :";
            // 
            // nuInscricaoEstadualCliente
            // 
            this.nuInscricaoEstadualCliente.AceitaEspaco = true;
            this.nuInscricaoEstadualCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nuInscricaoEstadualCliente.CampoDesabilitado = false;
            this.nuInscricaoEstadualCliente.CampoObrigatorio = false;
            this.nuInscricaoEstadualCliente.Location = new System.Drawing.Point(157, 94);
            this.nuInscricaoEstadualCliente.MensagemCampoObrigatorio = null;
            this.nuInscricaoEstadualCliente.Name = "nuInscricaoEstadualCliente";
            this.nuInscricaoEstadualCliente.Size = new System.Drawing.Size(281, 20);
            this.nuInscricaoEstadualCliente.TabIndex = 8;
            // 
            // nuCNPJCliente
            // 
            this.nuCNPJCliente.CampoObrigatorio = false;
            this.nuCNPJCliente.Location = new System.Drawing.Point(6, 94);
            this.nuCNPJCliente.Mask = "99,999,999/9999-99";
            this.nuCNPJCliente.MensagemCampoObrigatorio = null;
            this.nuCNPJCliente.Name = "nuCNPJCliente";
            this.nuCNPJCliente.Size = new System.Drawing.Size(142, 20);
            this.nuCNPJCliente.TabIndex = 6;
            // 
            // nmRazaoSocialCliente
            // 
            this.nmRazaoSocialCliente.AceitaEspaco = true;
            this.nmRazaoSocialCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nmRazaoSocialCliente.CampoDesabilitado = false;
            this.nmRazaoSocialCliente.CampoObrigatorio = true;
            this.nmRazaoSocialCliente.Location = new System.Drawing.Point(6, 55);
            this.nmRazaoSocialCliente.MensagemCampoObrigatorio = "Informe a razão social do Cliente.";
            this.nmRazaoSocialCliente.Name = "nmRazaoSocialCliente";
            this.nmRazaoSocialCliente.Size = new System.Drawing.Size(432, 20);
            this.nmRazaoSocialCliente.TabIndex = 3;
            // 
            // nmFantasiaCliente
            // 
            this.nmFantasiaCliente.AceitaEspaco = true;
            this.nmFantasiaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nmFantasiaCliente.CampoDesabilitado = false;
            this.nmFantasiaCliente.CampoObrigatorio = true;
            this.nmFantasiaCliente.Location = new System.Drawing.Point(6, 16);
            this.nmFantasiaCliente.MensagemCampoObrigatorio = "Informe o nome fantasia do Cliente.";
            this.nmFantasiaCliente.Name = "nmFantasiaCliente";
            this.nmFantasiaCliente.Size = new System.Drawing.Size(432, 20);
            this.nmFantasiaCliente.TabIndex = 1;
            // 
            // ucCadClienteJuridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nuInscricaoEstadualCliente);
            this.Controls.Add(this.lblnuInscricaoEstadualCliente);
            this.Controls.Add(this.nuCNPJCliente);
            this.Controls.Add(this.lblnuCNPJCliente);
            this.Controls.Add(this.lgLogoCliente);
            this.Controls.Add(this.nmRazaoSocialCliente);
            this.Controls.Add(this.lblnmRazaoSocialCliente);
            this.Controls.Add(this.nmFantasiaCliente);
            this.Controls.Add(this.lblnmFantasiaCliente);
            this.Name = "ucCadClienteJuridica";
            this.Size = new System.Drawing.Size(590, 118);
            ((System.ComponentModel.ISupportInitialize)(this.lgLogoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnmFantasiaCliente;
        private KuraFrameWork.Componentes_Visuais.ucTextBox nmFantasiaCliente;
        private System.Windows.Forms.Label lblnmRazaoSocialCliente;
        private KuraFrameWork.Componentes_Visuais.ucTextBox nmRazaoSocialCliente;
        private System.Windows.Forms.PictureBox lgLogoCliente;
        private System.Windows.Forms.Label lblnuCNPJCliente;
        private KuraFrameWork.Componentes_Visuais.ucTextBoxMaskCNPJ nuCNPJCliente;
        private System.Windows.Forms.Label lblnuInscricaoEstadualCliente;
        private KuraFrameWork.Componentes_Visuais.ucTextBox nuInscricaoEstadualCliente;
    }
}
