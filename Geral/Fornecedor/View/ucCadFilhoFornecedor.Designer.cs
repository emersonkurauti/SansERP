namespace SansERP.Geral.Fornecedor.View
{
    partial class ucCadFilhoFornecedor
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
            this.tpProdutos = new System.Windows.Forms.TabPage();
            this.ucProdutos = new KuraFrameWork.Componentes_Visuais.ucCadastroFilho();
            this.tcFilhos.SuspendLayout();
            this.tpEnderecos.SuspendLayout();
            this.tpTelefones.SuspendLayout();
            this.tpProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcFilhos
            // 
            this.tcFilhos.Controls.Add(this.tpProdutos);
            this.tcFilhos.Controls.SetChildIndex(this.tpProdutos, 0);
            this.tcFilhos.Controls.SetChildIndex(this.tpTelefones, 0);
            this.tcFilhos.Controls.SetChildIndex(this.tpEnderecos, 0);
            // 
            // tpTelefones
            // 
            this.tpTelefones.Size = new System.Drawing.Size(562, 99);
            // 
            // ucTelefones
            // 
            this.ucTelefones.Size = new System.Drawing.Size(556, 93);
            // 
            // ucEmails
            // 
            this.ucEmails.Size = new System.Drawing.Size(556, 93);
            // 
            // tpProdutos
            // 
            this.tpProdutos.Controls.Add(this.ucProdutos);
            this.tpProdutos.Location = new System.Drawing.Point(4, 22);
            this.tpProdutos.Name = "tpProdutos";
            this.tpProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.tpProdutos.Size = new System.Drawing.Size(562, 99);
            this.tpProdutos.TabIndex = 3;
            this.tpProdutos.Text = "Produtos";
            this.tpProdutos.UseVisualStyleBackColor = true;
            // 
            // ucProdutos
            // 
            this.ucProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProdutos.Location = new System.Drawing.Point(3, 3);
            this.ucProdutos.Name = "ucProdutos";
            this.ucProdutos.Size = new System.Drawing.Size(556, 93);
            this.ucProdutos.TabIndex = 0;
            // 
            // ucCadFilhoFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "ucCadFilhoFornecedor";
            this.tcFilhos.ResumeLayout(false);
            this.tpEnderecos.ResumeLayout(false);
            this.tpTelefones.ResumeLayout(false);
            this.tpProdutos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpProdutos;
        private KuraFrameWork.Componentes_Visuais.ucCadastroFilho ucProdutos;
    }
}
