using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoProcessoSeletivo.View
{
    public partial class MDIParentPrincipalView : Form
    {

        public MDIParentPrincipalView()
        {
            InitializeComponent();
        }

        //Esse método faz a chamada da tela Cadastro de funcionários
        private void CadastrarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroDeFuncionariosView p = new();
            p.MdiParent = this;
            p.Show();
        }

        //Esse método faz a chamada da tela Cadastro de funcionários
        private void CalcularFolhaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculoFolhaPagamentoView p = new();
            p.MdiParent = this;
            p.Show();
        }

    }
}
