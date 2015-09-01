namespace SansERP.Geral.Produto.View
{
    partial class ucCadFilhoProduto
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
            this.tcFilhoProduto = new System.Windows.Forms.TabControl();
            this.tpFornecedor = new System.Windows.Forms.TabPage();
            this.tpFabricante = new System.Windows.Forms.TabPage();
            this.tpTipoProduto = new System.Windows.Forms.TabPage();
            this.ucCadastroFilhoFornecedor = new KuraFrameWork.Componentes_Visuais.ucCadastroFilho();
            this.ucCadastroFilhoFabricante = new KuraFrameWork.Componentes_Visuais.ucCadastroFilho();
            this.ucCadastroFilhoTipoProduto = new KuraFrameWork.Componentes_Visuais.ucCadastroFilho();
            this.ucConsFornecedor = new SansERP.Geral.Fornecedor.View.ucConsFornecedor();
            this.ucConsFabricante = new SansERP.Geral.Fabricante.View.ucConsFabricante();
            this.ucConsTipoProduto = new SansERP.Geral.TipoProduto.View.ucConsTipoProduto();
            this.tcFilhoProduto.SuspendLayout();
            this.tpFornecedor.SuspendLayout();
            this.tpFabricante.SuspendLayout();
            this.tpTipoProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcFilhoProduto
            // 
            this.tcFilhoProduto.Controls.Add(this.tpFornecedor);
            this.tcFilhoProduto.Controls.Add(this.tpFabricante);
            this.tcFilhoProduto.Controls.Add(this.tpTipoProduto);
            this.tcFilhoProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcFilhoProduto.Location = new System.Drawing.Point(0, 0);
            this.tcFilhoProduto.Name = "tcFilhoProduto";
            this.tcFilhoProduto.SelectedIndex = 0;
            this.tcFilhoProduto.Size = new System.Drawing.Size(510, 235);
            this.tcFilhoProduto.TabIndex = 0;
            // 
            // tpFornecedor
            // 
            this.tpFornecedor.Controls.Add(this.ucCadastroFilhoFornecedor);
            this.tpFornecedor.Controls.Add(this.ucConsFornecedor);
            this.tpFornecedor.Location = new System.Drawing.Point(4, 22);
            this.tpFornecedor.Name = "tpFornecedor";
            this.tpFornecedor.Padding = new System.Windows.Forms.Padding(3);
            this.tpFornecedor.Size = new System.Drawing.Size(502, 209);
            this.tpFornecedor.TabIndex = 0;
            this.tpFornecedor.Text = "Fornecedor";
            this.tpFornecedor.UseVisualStyleBackColor = true;
            // 
            // tpFabricante
            // 
            this.tpFabricante.Controls.Add(this.ucConsFabricante);
            this.tpFabricante.Controls.Add(this.ucCadastroFilhoFabricante);
            this.tpFabricante.Location = new System.Drawing.Point(4, 22);
            this.tpFabricante.Name = "tpFabricante";
            this.tpFabricante.Padding = new System.Windows.Forms.Padding(3);
            this.tpFabricante.Size = new System.Drawing.Size(502, 209);
            this.tpFabricante.TabIndex = 2;
            this.tpFabricante.Text = "Fabricante";
            this.tpFabricante.UseVisualStyleBackColor = true;
            // 
            // tpTipoProduto
            // 
            this.tpTipoProduto.Controls.Add(this.ucCadastroFilhoTipoProduto);
            this.tpTipoProduto.Controls.Add(this.ucConsTipoProduto);
            this.tpTipoProduto.Location = new System.Drawing.Point(4, 22);
            this.tpTipoProduto.Name = "tpTipoProduto";
            this.tpTipoProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tpTipoProduto.Size = new System.Drawing.Size(502, 209);
            this.tpTipoProduto.TabIndex = 1;
            this.tpTipoProduto.Text = "Tipo Produto";
            this.tpTipoProduto.UseVisualStyleBackColor = true;
            // 
            // ucCadastroFilhoFornecedor
            // 
            this.ucCadastroFilhoFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucCadastroFilhoFornecedor.Location = new System.Drawing.Point(6, 48);
            this.ucCadastroFilhoFornecedor.Name = "ucCadastroFilhoFornecedor";
            this.ucCadastroFilhoFornecedor.Size = new System.Drawing.Size(490, 155);
            this.ucCadastroFilhoFornecedor.TabIndex = 1;
            // 
            // ucCadastroFilhoFabricante
            // 
            this.ucCadastroFilhoFabricante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucCadastroFilhoFabricante.Location = new System.Drawing.Point(6, 48);
            this.ucCadastroFilhoFabricante.Name = "ucCadastroFilhoFabricante";
            this.ucCadastroFilhoFabricante.Size = new System.Drawing.Size(490, 155);
            this.ucCadastroFilhoFabricante.TabIndex = 0;
            // 
            // ucCadastroFilhoTipoProduto
            // 
            this.ucCadastroFilhoTipoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucCadastroFilhoTipoProduto.Location = new System.Drawing.Point(6, 48);
            this.ucCadastroFilhoTipoProduto.Name = "ucCadastroFilhoTipoProduto";
            this.ucCadastroFilhoTipoProduto.Size = new System.Drawing.Size(490, 155);
            this.ucCadastroFilhoTipoProduto.TabIndex = 1;
            // 
            // ucConsFornecedor
            // 
            this.ucConsFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucConsFornecedor.bCadastrar = false;
            this.ucConsFornecedor.bMudouCodigo = false;
            this.ucConsFornecedor.CampoObrigatorio = false;
            this.ucConsFornecedor.cdRegistro = 0;
            this.ucConsFornecedor.deRegistro = null;
            this.ucConsFornecedor.Location = new System.Drawing.Point(6, 6);
            this.ucConsFornecedor.MensagemCampoObrigatorio = null;
            this.ucConsFornecedor.Name = "ucConsFornecedor";
            this.ucConsFornecedor.objCon = null;
            this.ucConsFornecedor.Rotulo = "Nome Fantasia :";
            this.ucConsFornecedor.Size = new System.Drawing.Size(490, 36);
            this.ucConsFornecedor.TabIndex = 0;
            this.ucConsFornecedor.TelaConsulta = null;
            this.ucConsFornecedor.tfrmConsulta = null;
            this.ucConsFornecedor.tobjCa = null;
            // 
            // ucConsFabricante
            // 
            this.ucConsFabricante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucConsFabricante.bCadastrar = false;
            this.ucConsFabricante.bMudouCodigo = false;
            this.ucConsFabricante.CampoObrigatorio = false;
            this.ucConsFabricante.cdRegistro = 0;
            this.ucConsFabricante.deRegistro = null;
            this.ucConsFabricante.Location = new System.Drawing.Point(6, 6);
            this.ucConsFabricante.MensagemCampoObrigatorio = null;
            this.ucConsFabricante.Name = "ucConsFabricante";
            this.ucConsFabricante.objCon = null;
            this.ucConsFabricante.Rotulo = "Nome :";
            this.ucConsFabricante.Size = new System.Drawing.Size(490, 36);
            this.ucConsFabricante.TabIndex = 1;
            this.ucConsFabricante.TelaConsulta = null;
            this.ucConsFabricante.tfrmConsulta = null;
            this.ucConsFabricante.tobjCa = null;
            // 
            // ucConsTipoProduto
            // 
            this.ucConsTipoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucConsTipoProduto.bCadastrar = false;
            this.ucConsTipoProduto.bMudouCodigo = false;
            this.ucConsTipoProduto.CampoObrigatorio = false;
            this.ucConsTipoProduto.cdRegistro = 0;
            this.ucConsTipoProduto.deRegistro = "";
            this.ucConsTipoProduto.Location = new System.Drawing.Point(6, 6);
            this.ucConsTipoProduto.MensagemCampoObrigatorio = null;
            this.ucConsTipoProduto.Name = "ucConsTipoProduto";
            this.ucConsTipoProduto.objCon = null;
            this.ucConsTipoProduto.Rotulo = "Tipo de Produto :";
            this.ucConsTipoProduto.Size = new System.Drawing.Size(490, 36);
            this.ucConsTipoProduto.TabIndex = 0;
            this.ucConsTipoProduto.TelaConsulta = null;
            this.ucConsTipoProduto.tfrmConsulta = null;
            this.ucConsTipoProduto.tobjCa = null;
            // 
            // ucCadFilhoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcFilhoProduto);
            this.Name = "ucCadFilhoProduto";
            this.Size = new System.Drawing.Size(510, 235);
            this.tcFilhoProduto.ResumeLayout(false);
            this.tpFornecedor.ResumeLayout(false);
            this.tpFabricante.ResumeLayout(false);
            this.tpTipoProduto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tcFilhoProduto;
        public System.Windows.Forms.TabPage tpFornecedor;
        public System.Windows.Forms.TabPage tpTipoProduto;
        public System.Windows.Forms.TabPage tpFabricante;
        public Fornecedor.View.ucConsFornecedor ucConsFornecedor;
        public KuraFrameWork.Componentes_Visuais.ucCadastroFilho ucCadastroFilhoFornecedor;
        public Fabricante.View.ucConsFabricante ucConsFabricante;
        public KuraFrameWork.Componentes_Visuais.ucCadastroFilho ucCadastroFilhoFabricante;
        public TipoProduto.View.ucConsTipoProduto ucConsTipoProduto;
        public KuraFrameWork.Componentes_Visuais.ucCadastroFilho ucCadastroFilhoTipoProduto;

    }
}
