namespace SansERP.Geral.Produto.View
{
    partial class frmCadProduto
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
            this.lblcdProduto = new System.Windows.Forms.Label();
            this.cdProduto = new KuraFrameWork.Componentes_Visuais.ucTextBoxNumero();
            this.lblnmProduto = new System.Windows.Forms.Label();
            this.nmProduto = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lbldeProduto = new System.Windows.Forms.Label();
            this.deProduto = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lblqtProduto = new System.Windows.Forms.Label();
            this.qtProduto = new KuraFrameWork.Componentes_Visuais.ucTextBoxNumero();
            this.lblvlUnitario = new System.Windows.Forms.Label();
            this.vlUnitario = new KuraFrameWork.Componentes_Visuais.ucTextBoxMask();
            this.cdTipoCalculo = new SansERP.Geral.TipoCalculo.View.ucConsTipoCalculo();
            this.ucCadFilhoProduto = new SansERP.Geral.Produto.View.ucCadFilhoProduto();
            this.pnFiltro.SuspendLayout();
            this.pnForm.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tcCadastro.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnForm
            // 
            this.pnForm.Controls.Add(this.cdTipoCalculo);
            this.pnForm.Controls.Add(this.ucCadFilhoProduto);
            this.pnForm.Controls.Add(this.vlUnitario);
            this.pnForm.Controls.Add(this.lblvlUnitario);
            this.pnForm.Controls.Add(this.qtProduto);
            this.pnForm.Controls.Add(this.lblqtProduto);
            this.pnForm.Controls.Add(this.deProduto);
            this.pnForm.Controls.Add(this.lbldeProduto);
            this.pnForm.Controls.Add(this.nmProduto);
            this.pnForm.Controls.Add(this.lblnmProduto);
            this.pnForm.Controls.Add(this.cdProduto);
            this.pnForm.Controls.Add(this.lblcdProduto);
            this.pnForm.Size = new System.Drawing.Size(670, 343);
            this.pnForm.Controls.SetChildIndex(this.btnPrevious, 0);
            this.pnForm.Controls.SetChildIndex(this.btnFirst, 0);
            this.pnForm.Controls.SetChildIndex(this.btnLast, 0);
            this.pnForm.Controls.SetChildIndex(this.btnNext, 0);
            this.pnForm.Controls.SetChildIndex(this.lblcdProduto, 0);
            this.pnForm.Controls.SetChildIndex(this.cdProduto, 0);
            this.pnForm.Controls.SetChildIndex(this.lblnmProduto, 0);
            this.pnForm.Controls.SetChildIndex(this.nmProduto, 0);
            this.pnForm.Controls.SetChildIndex(this.lbldeProduto, 0);
            this.pnForm.Controls.SetChildIndex(this.deProduto, 0);
            this.pnForm.Controls.SetChildIndex(this.lblqtProduto, 0);
            this.pnForm.Controls.SetChildIndex(this.qtProduto, 0);
            this.pnForm.Controls.SetChildIndex(this.lblvlUnitario, 0);
            this.pnForm.Controls.SetChildIndex(this.vlUnitario, 0);
            this.pnForm.Controls.SetChildIndex(this.ucCadFilhoProduto, 0);
            this.pnForm.Controls.SetChildIndex(this.cdTipoCalculo, 0);
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
            // tcCadastro
            // 
            this.tcCadastro.Size = new System.Drawing.Size(684, 375);
            // 
            // pnGridFiltro
            // 
            this.pnGridFiltro.Size = new System.Drawing.Size(580, 0);
            // 
            // tpFormulario
            // 
            this.tpFormulario.Size = new System.Drawing.Size(676, 349);
            // 
            // lblcdProduto
            // 
            this.lblcdProduto.AutoSize = true;
            this.lblcdProduto.Location = new System.Drawing.Point(3, 18);
            this.lblcdProduto.Name = "lblcdProduto";
            this.lblcdProduto.Size = new System.Drawing.Size(46, 13);
            this.lblcdProduto.TabIndex = 12;
            this.lblcdProduto.Text = "Código :";
            // 
            // cdProduto
            // 
            this.cdProduto.AceitaEspaco = true;
            this.cdProduto.CampoDesabilitado = false;
            this.cdProduto.CampoObrigatorio = false;
            this.cdProduto.Location = new System.Drawing.Point(6, 34);
            this.cdProduto.MensagemCampoObrigatorio = null;
            this.cdProduto.Name = "cdProduto";
            this.cdProduto.Size = new System.Drawing.Size(100, 20);
            this.cdProduto.TabIndex = 13;
            // 
            // lblnmProduto
            // 
            this.lblnmProduto.AutoSize = true;
            this.lblnmProduto.Location = new System.Drawing.Point(3, 57);
            this.lblnmProduto.Name = "lblnmProduto";
            this.lblnmProduto.Size = new System.Drawing.Size(45, 13);
            this.lblnmProduto.TabIndex = 14;
            this.lblnmProduto.Text = "*Nome :";
            // 
            // nmProduto
            // 
            this.nmProduto.AceitaEspaco = true;
            this.nmProduto.CampoDesabilitado = false;
            this.nmProduto.CampoObrigatorio = true;
            this.nmProduto.Location = new System.Drawing.Point(6, 73);
            this.nmProduto.MensagemCampoObrigatorio = "Informe o nome do Produto.";
            this.nmProduto.Name = "nmProduto";
            this.nmProduto.Size = new System.Drawing.Size(301, 20);
            this.nmProduto.TabIndex = 15;
            // 
            // lbldeProduto
            // 
            this.lbldeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldeProduto.AutoSize = true;
            this.lbldeProduto.Location = new System.Drawing.Point(313, 57);
            this.lbldeProduto.Name = "lbldeProduto";
            this.lbldeProduto.Size = new System.Drawing.Size(61, 13);
            this.lbldeProduto.TabIndex = 16;
            this.lbldeProduto.Text = "Descrição :";
            // 
            // deProduto
            // 
            this.deProduto.AceitaEspaco = true;
            this.deProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.deProduto.CampoDesabilitado = false;
            this.deProduto.CampoObrigatorio = false;
            this.deProduto.Location = new System.Drawing.Point(316, 73);
            this.deProduto.MensagemCampoObrigatorio = null;
            this.deProduto.Name = "deProduto";
            this.deProduto.Size = new System.Drawing.Size(347, 20);
            this.deProduto.TabIndex = 17;
            // 
            // lblqtProduto
            // 
            this.lblqtProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblqtProduto.AutoSize = true;
            this.lblqtProduto.Location = new System.Drawing.Point(454, 96);
            this.lblqtProduto.Name = "lblqtProduto";
            this.lblqtProduto.Size = new System.Drawing.Size(68, 13);
            this.lblqtProduto.TabIndex = 18;
            this.lblqtProduto.Text = "Quantidade :";
            // 
            // qtProduto
            // 
            this.qtProduto.AceitaEspaco = true;
            this.qtProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.qtProduto.CampoDesabilitado = false;
            this.qtProduto.CampoObrigatorio = false;
            this.qtProduto.Location = new System.Drawing.Point(457, 112);
            this.qtProduto.MensagemCampoObrigatorio = null;
            this.qtProduto.Name = "qtProduto";
            this.qtProduto.Size = new System.Drawing.Size(101, 20);
            this.qtProduto.TabIndex = 19;
            // 
            // lblvlUnitario
            // 
            this.lblvlUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblvlUnitario.AutoSize = true;
            this.lblvlUnitario.Location = new System.Drawing.Point(561, 96);
            this.lblvlUnitario.Name = "lblvlUnitario";
            this.lblvlUnitario.Size = new System.Drawing.Size(64, 13);
            this.lblvlUnitario.TabIndex = 20;
            this.lblvlUnitario.Text = "Vl. Unitário :";
            // 
            // vlUnitario
            // 
            this.vlUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vlUnitario.CampoObrigatorio = false;
            this.vlUnitario.Location = new System.Drawing.Point(564, 112);
            this.vlUnitario.MensagemCampoObrigatorio = null;
            this.vlUnitario.Name = "vlUnitario";
            this.vlUnitario.Size = new System.Drawing.Size(99, 20);
            this.vlUnitario.TabIndex = 21;
            // 
            // cdTipoCalculo
            // 
            this.cdTipoCalculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cdTipoCalculo.bCadastrar = true;
            this.cdTipoCalculo.bMudouCodigo = false;
            this.cdTipoCalculo.CampoObrigatorio = true;
            this.cdTipoCalculo.cdRegistro = 0;
            this.cdTipoCalculo.deRegistro = null;
            this.cdTipoCalculo.Location = new System.Drawing.Point(6, 96);
            this.cdTipoCalculo.MensagemCampoObrigatorio = "Selecione o tipo de cálculo do Produto.";
            this.cdTipoCalculo.Name = "cdTipoCalculo";
            this.cdTipoCalculo.objCon = null;
            this.cdTipoCalculo.Rotulo = "*Tipo de Cálculo :";
            this.cdTipoCalculo.Size = new System.Drawing.Size(442, 36);
            this.cdTipoCalculo.TabIndex = 23;
            this.cdTipoCalculo.TelaConsulta = null;
            this.cdTipoCalculo.tfrmConsulta = null;
            this.cdTipoCalculo.tobjCa = null;
            // 
            // ucCadFilhoProduto
            // 
            this.ucCadFilhoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucCadFilhoProduto.Location = new System.Drawing.Point(6, 138);
            this.ucCadFilhoProduto.Name = "ucCadFilhoProduto";
            this.ucCadFilhoProduto.Size = new System.Drawing.Size(657, 198);
            this.ucCadFilhoProduto.TabIndex = 22;
            // 
            // frmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 422);
            this.Name = "frmCadProduto";
            this.Text = "Cadastro de Produto";
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

        private KuraFrameWork.Componentes_Visuais.ucTextBoxNumero cdProduto;
        private System.Windows.Forms.Label lblcdProduto;
        private KuraFrameWork.Componentes_Visuais.ucTextBox deProduto;
        private System.Windows.Forms.Label lbldeProduto;
        private KuraFrameWork.Componentes_Visuais.ucTextBox nmProduto;
        private System.Windows.Forms.Label lblnmProduto;
        private System.Windows.Forms.Label lblqtProduto;
        private KuraFrameWork.Componentes_Visuais.ucTextBoxNumero qtProduto;
        private System.Windows.Forms.Label lblvlUnitario;
        private KuraFrameWork.Componentes_Visuais.ucTextBoxMask vlUnitario;
        private ucCadFilhoProduto ucCadFilhoProduto;
        private TipoCalculo.View.ucConsTipoCalculo cdTipoCalculo;
    }
}
