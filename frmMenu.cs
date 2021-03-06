﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using KuraFrameWork.Banco;

namespace SansERP
{
    public partial class frmMenu : KuraFrameWork.Formularios.ucMenuBasico
    {
        private ArrayList alIntSeqTelas = new ArrayList();
        private ArrayList alTelas = new ArrayList();

        /*private coUsuarios _objUsuario;
        public coUsuarios objUsuario
        {
            get { return _objUsuario; }
            set { _objUsuario = value; }
        }*/

        /// <summary>
        /// Construtor do menu
        /// </summary>
        public frmMenu()
        {
            InitializeComponent();
            
            /*_objUsuario = objUsuario;*/

            csBanco objBanco = csBanco.Instance;
            /*objBanco.cdUsuario = _objUsuario.cdUsuario;*/
        }

        /// <summary>
        /// Carrega items de menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMenu_Load(object sender, EventArgs e)
        {
            ItemMenuStrip();
            ItemToolStrip();
        }

        /// <summary>
        /// Adiciona o nome do formulário na lista para pesquisa rápida
        /// </summary>
        /// <param name="nmTipoForm"></param>
        public void AddListTela(string nmTipoForm)
        {
            Type tipo;
            System.Windows.Forms.Form form;

            tipo = Type.GetType(nmTipoForm);

            form = (System.Windows.Forms.Form)Activator.CreateInstance(tipo);
            alTelas.Add(form.Text);
        }

        /// <summary>
        /// Adiciona items de menu
        /// </summary>
        public override void ItemMenuStrip()
        {
            AddListTela("SansERP.Geral.Pais.View.frmCadPais");
            AddListTela("SansERP.Geral.Estado.View.frmCadEstado");
            AddListTela("SansERP.Geral.Cidade.View.frmCadCidade");
            AddListTela("SansERP.Geral.TipoTelefone.View.frmCadTipoTelefone");
            AddListTela("SansERP.Geral.TipoEndereco.View.frmCadTipoEndereco");
            AddListTela("SansERP.Geral.TipoEndereco.View.frmCadTipoEndereco");
            AddListTela("SansERP.Geral.TipoProduto.View.frmCadTipoProduto");
            AddListTela("SansERP.Geral.MarcaProduto.View.frmCadMarcaProduto");
            AddListTela("SansERP.Geral.Fabricante.View.frmCadFabricante");
            AddListTela("SansERP.Geral.OperadoraTelefonica.View.frmCadOperadoraTelefonica");
            AddListTela("SansERP.Geral.Empresa.View.frmCadEmpresa");
            AddListTela("SansERP.Geral.Fornecedor.View.frmCadFornecedor");
            AddListTela("SansERP.Geral.Cliente.View.frmCadCliente");
            AddListTela("SansERP.Geral.Produto.View.frmCadProduto");
            AddListTela("SansERP.Geral.TipoCalculo.View.frmCadTipoCalculo");
            //AddListTela("appRelatorios.frmGerenciadorRPT,appRelatorios");

            ToolStripMenuItem menuCadastros = RetornarItemMenuCriado(menuStrip, "&Cadastros", null, null, "btnCadastros");
            CriarSubItemMenu(menuCadastros, "&País...", null, ItemMenu_onClick, "SansERP.Geral.Pais.View.frmCadPais");
            CriarSubItemMenu(menuCadastros, "&Estado...", null, ItemMenu_onClick, "SansERP.Geral.Estado.View.frmCadEstado");
            CriarSubItemMenu(menuCadastros, "&Cidade...", null, ItemMenu_onClick, "SansERP.Geral.Cidade.View.frmCadCidade");
            CriarSubItemMenu(menuCadastros, "&Tipo de Telefone...", null, ItemMenu_onClick, "SansERP.Geral.TipoTelefone.View.frmCadTipoTelefone");
            CriarSubItemMenu(menuCadastros, "&Tipo de Endereço...", null, ItemMenu_onClick, "SansERP.Geral.TipoEndereco.View.frmCadTipoEndereco");
            CriarSubItemMenu(menuCadastros, "&Tipo de Produto...", null, ItemMenu_onClick, "SansERP.Geral.TipoProduto.View.frmCadTipoProduto");
            CriarSubItemMenu(menuCadastros, "&Marca de Produto...", null, ItemMenu_onClick, "SansERP.Geral.MarcaProduto.View.frmCadMarcaProduto");
            CriarSubItemMenu(menuCadastros, "&Fabricante...", null, ItemMenu_onClick, "SansERP.Geral.Fabricante.View.frmCadFabricante");
            CriarSubItemMenu(menuCadastros, "&Operadora Telefônica...", null, ItemMenu_onClick, "SansERP.Geral.OperadoraTelefonica.View.frmCadOperadoraTelefonica");
            CriarSubItemMenu(menuCadastros, "&Empresa...", null, ItemMenu_onClick, "SansERP.Geral.Empresa.View.frmCadEmpresa");
            CriarSubItemMenu(menuCadastros, "&Fornecedor...", null, ItemMenu_onClick, "SansERP.Geral.Fornecedor.View.frmCadFornecedor");
            CriarSubItemMenu(menuCadastros, "&Cliente...", null, ItemMenu_onClick, "SansERP.Geral.Cliente.View.frmCadCliente");
            CriarSubItemMenu(menuCadastros, "&Produto...", null, ItemMenu_onClick, "SansERP.Geral.Produto.View.frmCadProduto");
            CriarSubItemMenu(menuCadastros, "&Tipo de Cálculo...", null, ItemMenu_onClick, "SansERP.Geral.TipoCalculo.View.frmCadTipoCalculo");

            /*if (_objUsuario.flTpUsuario == csConstantes.cGestor)
            {
                ToolStripMenuItem menuRelatorios = RetornarItemMenuCriado(menuStrip, "&Gerenciador de Relatórios", null, ItemMenu_onClick, "appRelatorios.frmGerenciadorRPT,appRelatorios");
            }*/

            AddItemMenu(menuStrip, "&Sair", null, btnSair_onClick, "btnSair");
        }

        /// <summary>
        /// Adiciona botões com imagens
        /// </summary>
        public override void ItemToolStrip()
        {
            //AddToolStripItem(tsMenu, SansERP.Properties.Resources. , btnSair_onClick, "btnSair");
        }

        /// <summary>
        /// Método para abrir as as telas do menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void ItemMenu_onClick(object sender, EventArgs e)
        {
            Type tipo = Type.GetType(((ToolStripMenuItem)sender).Name);

            if (!VerificaTelaAberta(((ToolStripMenuItem)sender).Name))
            {
                System.Windows.Forms.Form form = (System.Windows.Forms.Form)Activator.CreateInstance(tipo);

                for (int i = 0; i < menuTelas.Items.Count; i++)
                    menuTelas.Items[i].BackColor = Color.White;

                AtualizaIndiceTelas();
                alIntSeqTelas.Add(0);

                ToolStripMenuItem ItemMenuTela = RetornarItemMenuCriado(menuTelas, form.Text, null, ItemMenuTela_onClick, ((ToolStripMenuItem)sender).Name);
                ItemMenuTela.BackColor = Color.LightGray;

                form.FormClosed += new FormClosedEventHandler(ActiveMdiChild_FormClosed);
                form.MdiParent = this;
                form.Show();
            }
        }

        /// <summary>
        /// Verifica se a tela está aberta
        /// </summary>
        /// <param name="nmTela"></param>
        /// <returns></returns>
        public bool VerificaTelaAberta(string nmTela)
        {
            for (int i = 0; i < menuTelas.Items.Count; i++)
            {
                if (menuTelas.Items[i].Name.Equals(nmTela))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Atualiza os indices da sequência de abertura das telas
        /// </summary>
        /// <param name="bAdd"></param>
        private void AtualizaIndiceTelas(bool bAdd = true)
        {
            if (bAdd)
                for (int i = 0; i < alIntSeqTelas.Count; i++)
                    alIntSeqTelas[i] = (Convert.ToInt32(alIntSeqTelas[i].ToString()) + 1).ToString();
            else
                for (int i = 0; i < alIntSeqTelas.Count; i++)
                    alIntSeqTelas[i] = (Convert.ToInt32(alIntSeqTelas[i].ToString()) - 1).ToString();
        }

        /// <summary>
        /// Remaneja os indices para que mantenha a sequênci de abertura das telas atualizado
        /// </summary>
        /// <param name="nmTela"></param>
        public void RemanejaIndiceTela(string nmTela)
        {
            int IndAnterior = 0, pos0 = 0;

            for (int i = 0; i < menuTelas.Items.Count; i++)
                if ((menuTelas.Items[i].Name).Replace("appRelatorios.", "").Replace(",appRelatorios", "").Replace("SansERP.Geral.View.", "").Equals(nmTela))
                {
                    IndAnterior = Convert.ToInt32(alIntSeqTelas[i].ToString());
                    pos0 = i;
                }

            for (int i = 0; i < alIntSeqTelas.Count; i++)
                if (Convert.ToInt32(alIntSeqTelas[i].ToString()) < IndAnterior)
                    alIntSeqTelas[i] = (Convert.ToInt32(alIntSeqTelas[i].ToString()) + 1).ToString();

            alIntSeqTelas[pos0] = 0;
        }

        /// <summary>
        /// Evento de fechar um MdiChild
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            AtualizaIndiceTelas(false);

            for (int i = 0; i < menuTelas.Items.Count; i++)
            {
                if ((menuTelas.Items[i].Name).Replace("appRelatorios.", "").Replace(",appRelatorios", "").Replace("SansERP.Geral.Pais.View.", "").Equals(((Form)sender).Name) ||
                    (menuTelas.Items[i].Name).Replace("appRelatorios.", "").Replace(",appRelatorios", "").Replace("SansERP.Geral.Estado.View.", "").Equals(((Form)sender).Name) ||
                    (menuTelas.Items[i].Name).Replace("appRelatorios.", "").Replace(",appRelatorios", "").Replace("SansERP.Geral.Cidade.View.", "").Equals(((Form)sender).Name) ||
                    (menuTelas.Items[i].Name).Replace("appRelatorios.", "").Replace(",appRelatorios", "").Replace("SansERP.Geral.TipoTelefone.View.", "").Equals(((Form)sender).Name) ||
                    (menuTelas.Items[i].Name).Replace("appRelatorios.", "").Replace(",appRelatorios", "").Replace("SansERP.Geral.TipoEndereco.View.", "").Equals(((Form)sender).Name) ||
                    (menuTelas.Items[i].Name).Replace("appRelatorios.", "").Replace(",appRelatorios", "").Replace("SansERP.Geral.MarcaProduto.View.", "").Equals(((Form)sender).Name) ||
                    (menuTelas.Items[i].Name).Replace("appRelatorios.", "").Replace(",appRelatorios", "").Replace("SansERP.Geral.TipoProduto.View.", "").Equals(((Form)sender).Name) ||
                    (menuTelas.Items[i].Name).Replace("appRelatorios.", "").Replace(",appRelatorios", "").Replace("SansERP.Geral.Fabricante.View.", "").Equals(((Form)sender).Name) ||
                    (menuTelas.Items[i].Name).Replace("appRelatorios.", "").Replace(",appRelatorios", "").Replace("SansERP.Geral.OperadoraTelefonica.View.", "").Equals(((Form)sender).Name) ||
                    (menuTelas.Items[i].Name).Replace("appRelatorios.", "").Replace(",appRelatorios", "").Replace("SansERP.Geral.Empresa.View.", "").Equals(((Form)sender).Name) ||
                    (menuTelas.Items[i].Name).Replace("appRelatorios.", "").Replace(",appRelatorios", "").Replace("SansERP.Geral.Fornecedor.View.", "").Equals(((Form)sender).Name) ||
                    (menuTelas.Items[i].Name).Replace("appRelatorios.", "").Replace(",appRelatorios", "").Replace("SansERP.Geral.Cliente.View.", "").Equals(((Form)sender).Name) ||
                    (menuTelas.Items[i].Name).Replace("appRelatorios.", "").Replace(",appRelatorios", "").Replace("SansERP.Geral.Produto.View.", "").Equals(((Form)sender).Name) ||
                    (menuTelas.Items[i].Name).Replace("appRelatorios.", "").Replace(",appRelatorios", "").Replace("SansERP.Geral.TipoCalculo.View.", "").Equals(((Form)sender).Name))
                {
                    menuTelas.Items.RemoveAt(i);
                    alIntSeqTelas.RemoveAt(i);
                }
            }

            for (int i = 0; i < alIntSeqTelas.Count; i++)
                if (Convert.ToInt32(alIntSeqTelas[i].ToString()) == 0)
                    menuTelas.Items[i].BackColor = Color.LightGray;
        }

        /// <summary>
        /// Evento disparado ao clicar em um menu de tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ItemMenuTela_onClick(object sender, EventArgs e)
        {
            Type tipo = Type.GetType(((ToolStripMenuItem)sender).Name);

            Form[] formMDI = MdiChildren;

            foreach (Form frm in formMDI)
                if (frm.Name.Equals(tipo.Name))
                    frm.Activate();

            for (int i = 0; i < menuTelas.Items.Count; i++)
            {
                if ((menuTelas.Items[i].Name).Replace("appRelatorios.", "").Replace(",appRelatorios", "").Replace("SansERP.Geral.View.", "").Equals(tipo.Name))
                    menuTelas.Items[i].BackColor = Color.LightGray;
                else
                    menuTelas.Items[i].BackColor = Color.White;
            }

            RemanejaIndiceTela(tipo.Name);
        }
    }
}
