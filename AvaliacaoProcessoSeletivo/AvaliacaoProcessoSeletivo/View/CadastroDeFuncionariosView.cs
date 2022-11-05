using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Biblioteca utilizada para fazer a conexão com o Banco de Dados
using System.Data.SqlClient;

namespace AvaliacaoProcessoSeletivo.View
{
    public partial class CadastroDeFuncionariosView : Form
    {
        //Responsável por fazer a conexão com o servidor.
        SqlConnection conexao = new SqlConnection("Server=DESKTOP-577E646\\SQLEXPRESS;Database=db_Funcionarios;User Id =sa; Password=S&nh4DBFunc1on4rios");

        //Responsável por fazer as instruções no SqlServer.
        SqlCommand comando;


        int numero = 1;

        //String que vai receber os Scripts a serem executados no banco de dados.
        string strSQL;

        public CadastroDeFuncionariosView()
        {
            InitializeComponent();
        }

        //Essse método especifica onde a tela ficará em relação aos pixels determinados.
        private void CadastroDeFuncionarios_Load(object sender, EventArgs e)
        {
            painelCadastroFuncionarios.Location = new Point(this.Width / 2 - 370, this.Height / 2 - 200);
        }

        //Esse método é executado após o usuário clicar no botão "Incluir",
        //e o mesmo limpa todos os dados dentro das textBox.
        private void button_Incluir_Click_1(object sender, EventArgs e)
        {

            textBox_Nome.Text = "";
            maskedTextBox_CPF.Text = "";
            textBox_Endereco.Text = "";
            textBox_Email.Text = "";
            maskedTextBox_Telefone.Text = "";

        }

        //Esse método é executado após o usuário clicar no botão "Excluir",
        //E o mesmo faz a exclusão dos dados dentro do banco de dados a partir das informações
        //que estão armazenadas dentro das textBox.
        private void button_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                //Instancia a conexão com o banco de dados.
                conexao.Open();

                //Essa variável atribui qual script será realizado dentro do banco de dados
                //onde o mesmo realiza a exclusão dos dados de cada linha e coluna respectiva
                //utilizando o CPF como parâmetro principal.            

                strSQL = "DELETE FROM tbl_InformacoesFuncionarios WHERE ID_Funcionario IN (SELECT ID_Funcionario FROM tbl_InformacoesFuncionarios WHERE CPF = @CPF)";

                //Nessa linha, será instanciado a variável com o script constituinte junto a conexão ao 
                //banco de dados.
                comando = new SqlCommand(strSQL, conexao);

                //Irá realizar a adição do dado em específico a @CPF
                comando.Parameters.AddWithValue("@CPF", SqlDbType.VarChar).Value = maskedTextBox_CPF.Text;


                //Irá executar o comando delimitado dentro de strSQL desse método.
                comando.ExecuteNonQuery();

                //Irá apresentar uma caixa de mensagem ao usuário mostrando que os dados foram
                //excluídos do banco de dados. 
                MessageBox.Show("Dados excluídos com sucesso!");
            }

            //Caso ocorra algum erro, irá me retornar o erro em específico.
            catch (Exception erro)
            {
                //Irá apresentar uma caixa de mensagem ao usuário mostrando o erro acontecido
                MessageBox.Show(erro.Message);
            }

            //Irá finalizar a conexão ao banco de dados.
            finally
            {
                conexao.Close();
            }
        }

        //Esse método é executado após o usuário clicar no botão "Salvar",
        //E o mesmo faz a implementação dos dados dentro do banco de dados a partir
        //das informações que estão armazenadas dentro das textBox.
        private void button_Salvar_Click(object sender, EventArgs e)
        {
            try
            {

                //Essa variável atribui qual script será realizado dentro do banco de dados
                //onde o mesmo realiza implementação dos dados as linhas da tabela.
                strSQL = "INSERT INTO tbl_InformacoesFuncionarios(Nome,CPF,Endereco,Email,Telefone) VALUES (@Nome,@CPF,@Endereco,@Email,@Telefone)";

                //Nessa linha, será instanciado a variável com o script constituinte junto a conexão ao 
                //banco de dados.
                comando = new SqlCommand(strSQL, conexao);

                //Irá realizar a adição dos dados de cada textBox a cada parâmetro respectivo
                comando.Parameters.AddWithValue("@Nome", SqlDbType.VarChar).Value = textBox_Nome.Text;
                comando.Parameters.AddWithValue("@CPF", SqlDbType.VarChar).Value = maskedTextBox_CPF.Text;
                comando.Parameters.AddWithValue("@Endereco", SqlDbType.VarChar).Value = textBox_Endereco.Text;
                comando.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = textBox_Email.Text;
                comando.Parameters.AddWithValue("@Telefone", SqlDbType.VarChar).Value = maskedTextBox_Telefone.Text;

                //Irá realizar a conexão com o banco de dados
                conexao.Open();

                //Irá executar o comando delimitado dentro de strSQL desse método.
                comando.ExecuteNonQuery();

                //Irá apresentar uma caixa de mensagem ao usuário mostrando que os dados foram inseridos
                MessageBox.Show("Dados inseridos com sucesso!");
            }

            //Caso ocorra algum erro, irá me retornar o erro em específico.
            catch (SqlException erro)
            {
                //Irá apresentar uma caixa de mensagem ao usuário mostrando o erro acontecido
                MessageBox.Show(erro.Message);
            }

            //Irá finalizar a conexão ao banco de dados.
            finally
            {
                conexao.Close();
            }
        }

        //Esse método é executado após o usuário clicar no botão "<<",
        //E o mesmo faz a busca dos dados do primeiro funcionário cadastrado.
        private void button_PrimeiroFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                //Irá realizar a conexão com o banco de dados
                conexao.Open();

                //Essa variável atribui qual script será realizado dentro do banco de dados
                //onde o mesmo irá buscar so dados do primeiro usuário.
                strSQL = "SELECT Nome, CPF, Endereco, Email, Telefone FROM tbl_InformacoesFuncionarios WHERE ID_Funcionario = (SELECT MIN(ID_Funcionario) FROM tbl_InformacoesFuncionarios)";

                //Nessa linha, será instanciado a variável com o script constituinte junto a conexão ao 
                //banco de dados.
                comando = new(strSQL, conexao);

                //Recupera as linhas dos dados dentro da tabela tbl_InformacoesFuncionarios
                SqlDataReader srd = comando.ExecuteReader();

                //Essa estrutura de repetição vai ler todos os valores dos campos da tabela
                while (srd.Read())
                {
                    textBox_Nome.Text = srd.GetValue(0).ToString();
                    maskedTextBox_CPF.Text = srd.GetValue(1).ToString();
                    textBox_Endereco.Text = srd.GetValue(2).ToString();
                    textBox_Email.Text = srd.GetValue(3).ToString();
                    maskedTextBox_Telefone.Text = srd.GetValue(4).ToString();
                }

                //Finaliza a conexão com o banco de dados
                conexao.Close();
            }

            //Caso ocorra algum erro, irá me retornar o erro em específico.
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        //Esse método é executado após o usuário clicar no botão "<<",
        //E o mesmo faz a busca dos dados do primeiro funcionário cadastrado.
        private void button_UltimoFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                //Irá realizar a conexão com o banco de dados
                conexao.Open();

                //Essa variável atribui qual script será realizado dentro do banco de dados
                //onde o mesmo irá buscar so dados do primeiro usuário.
                strSQL = "SELECT Nome, CPF, Endereco, Email, Telefone FROM tbl_InformacoesFuncionarios WHERE ID_Funcionario = (SELECT MAX(ID_Funcionario) FROM tbl_InformacoesFuncionarios)";

                //Nessa linha, será instanciado a variável com o script constituinte junto a conexão ao 
                //banco de dados.
                comando = new(strSQL, conexao);

                //Recupera as linhas dos dados dentro da tabela tbl_InformacoesFuncionarios
                SqlDataReader srd = comando.ExecuteReader();

                //Essa estrutura de repetição vai ler todos os dados da tabela.
                while (srd.Read())
                {
                    textBox_Nome.Text = srd.GetValue(0).ToString();
                    maskedTextBox_CPF.Text = srd.GetValue(1).ToString();
                    textBox_Endereco.Text = srd.GetValue(2).ToString();
                    textBox_Email.Text = srd.GetValue(3).ToString();
                    maskedTextBox_Telefone.Text = srd.GetValue(4).ToString();
                }

                //Finaliza a conexão com o banco de dados
                conexao.Close();
            }

            //Caso ocorra algum erro, irá me retornar o erro em específico.
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button_ProximoFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                //Irá realizar a conexão com o banco de dados
                conexao.Open();

                //Essa variável atribui qual script será realizado dentro do banco de dados
                //onde o mesmo irá buscar so dados do primeiro usuário.
                strSQL = "SELECT Nome, CPF, Endereco, Email, Telefone FROM tbl_InformacoesFuncionarios WHERE ID_Funcionario = " + numero + "";

                //Nessa linha, será instanciado a variável com o script constituinte junto a conexão ao 
                //banco de dados.
                comando = new(strSQL, conexao);

                //Recupera as linhas dos dados dentro da tabela tbl_InformacoesFuncionarios
                SqlDataReader srd = comando.ExecuteReader();

                //Essa estrutura de repetição vai ler todos os dados da tabela.
                while (srd.Read())
                {
                    textBox_Nome.Text = srd.GetValue(0).ToString();
                    maskedTextBox_CPF.Text = srd.GetValue(1).ToString();
                    textBox_Endereco.Text = srd.GetValue(2).ToString();
                    textBox_Email.Text = srd.GetValue(3).ToString();
                    maskedTextBox_Telefone.Text = srd.GetValue(4).ToString();
                }

                //Finaliza a conexão com o banco de dados
                conexao.Close();

                //Irá incrementar a cada vez que o o botão for acionado
                numero++;
            }

            //Caso ocorra algum erro, irá me retornar o erro em específico.
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button_VoltarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                //Irá realizar a conexão com o banco de dados
                conexao.Open();

                //Essa variável atribui qual script será realizado dentro do banco de dados
                //onde o mesmo irá buscar so dados do primeiro usuário.
                strSQL = "SELECT Nome, CPF, Endereco, Email, Telefone FROM tbl_InformacoesFuncionarios WHERE ID_Funcionario = " + numero + "";

                //Nessa linha, será instanciado a variável com o script constituinte junto a conexão ao 
                //banco de dados.
                comando = new(strSQL, conexao);

                //Recupera as linhas dos dados dentro da tabela tbl_InformacoesFuncionarios
                SqlDataReader srd = comando.ExecuteReader();

                //Essa estrutura de repetição vai ler todos os dados da tabela.
                while (srd.Read())
                {
                    textBox_Nome.Text = srd.GetValue(0).ToString();
                    maskedTextBox_CPF.Text = srd.GetValue(1).ToString();
                    textBox_Endereco.Text = srd.GetValue(2).ToString();
                    textBox_Email.Text = srd.GetValue(3).ToString();
                    maskedTextBox_Telefone.Text = srd.GetValue(4).ToString();
                }
                //Finaliza a conexão com o banco de dados
                conexao.Close();

                //Irá decrementar a cada vez que o o botão for acionado
                numero--;
            }

            //Caso ocorra algum erro, irá me retornar o erro em específico.
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        //Abaixo possui os métodos que não serão utilizados
        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }
        private void painelCadastroFuncionarios_Paint(object sender, PaintEventArgs e)
        {

        }
        private void maskedTextBox_CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }

}

