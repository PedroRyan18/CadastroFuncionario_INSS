namespace AvaliacaoProcessoSeletivo.View
{
    partial class MDIParentPrincipalView
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParentPrincipalView));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastrarFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCalcularFolhaDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(834, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastrarFuncionarioToolStripMenuItem,
            this.MenuCalcularFolhaDePagamentoToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(61, 20);
            this.fileMenu.Text = "&Arquivo";
            // 
            // MenuCadastrarFuncionarioToolStripMenuItem
            // 
            this.MenuCadastrarFuncionarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("MenuCadastrarFuncionarioToolStripMenuItem.Image")));
            this.MenuCadastrarFuncionarioToolStripMenuItem.Name = "MenuCadastrarFuncionarioToolStripMenuItem";
            this.MenuCadastrarFuncionarioToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.MenuCadastrarFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.MenuCadastrarFuncionarioToolStripMenuItem.Text = "Cadastrar Funcionário";
            this.MenuCadastrarFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.CadastrarFuncionarioToolStripMenuItem_Click);
            // 
            // MenuCalcularFolhaDePagamentoToolStripMenuItem
            // 
            this.MenuCalcularFolhaDePagamentoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("MenuCalcularFolhaDePagamentoToolStripMenuItem.Image")));
            this.MenuCalcularFolhaDePagamentoToolStripMenuItem.Name = "MenuCalcularFolhaDePagamentoToolStripMenuItem";
            this.MenuCalcularFolhaDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.MenuCalcularFolhaDePagamentoToolStripMenuItem.Text = "Calcular Folha de Pagamento";
            this.MenuCalcularFolhaDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.CalcularFolhaDePagamentoToolStripMenuItem_Click);
            // 
            // MDIParentPrincipalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MDIParentPrincipalView";
            this.Text = "Menu";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem MenuCadastrarFuncionarioToolStripMenuItem;
        private ToolStripMenuItem MenuCalcularFolhaDePagamentoToolStripMenuItem;
    }
}



