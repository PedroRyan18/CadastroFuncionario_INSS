using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Biblioteca que utilizei para conectar ao banco de dados
using System.Data.SqlClient;



namespace AvaliacaoProcessoSeletivo.View
{
    public partial class CalculoFolhaPagamentoView : Form
    {
        public CalculoFolhaPagamentoView()
        {
            InitializeComponent();
        }

        //Realiza a alocação da tela de folha de pagamento referente a altura largura da tela
        private void CalculoFolhaPagamento_Load(object sender, EventArgs e)
        {
            painelFolhaPagamento.Location = new Point(this.Width / 2 - 370, this.Height / 2 - 200);
        }

        //Esse método faz o cálculo do salário bruto, desconto do INSS e salário líquido.
        private void button_Calcular_Click(object sender, EventArgs e)
        {
            //Essa condição verifica se as informações das textBox são nulas
            //e se for, irá apresentar na tela o texto "Preencha os Campos".
            if (textBox_HorasTrabalhadas.Text == "" && textBox_SalarioHora.Text == "")
            {
                MessageBox.Show("Preencha os campos");
            }

            //Essa condição verifica se a informação da textBox_HorasTrabalhadas é nula
            //e se for, irá apresentar na tela o texto "Preencha as horas trabalhadas".
            else if (textBox_HorasTrabalhadas.Text == "")
            {
                MessageBox.Show("Preencha as horas trabalhadas.");
                textBox_HorasTrabalhadas.Focus();
            }

            //Essa condição verifica se a informação da textBox_SalarioHora é nula
            //e se for, irá apresentar na tela o texto "Preencha o Salário por hora.".
            else if (textBox_SalarioHora.Text == "")
            {
                MessageBox.Show("Preencha o salário por hora.");
                textBox_SalarioHora.Focus();
            }

            //Caso passe por todas as condições acima, o programa acessar o método contasRealizadas.
            else
            {
                //Chamada do método ContasRealizadas.
                contasRealizadas();
            }
        }

        //Esse método realiza o cálculo do salário bruto, e consequentemente realiza as
        //demais contas para retornar o valor do desconto do INSS e salário líquido a partir
        //dos dados armazenados dentro das textBox_HorasTrabalhadas/SalárioHOra.
        private void contasRealizadas()
        {
            //Variáveis declaradas que serão utilizadas dentro do programa.
            double salarioLiquido, salarioBruto, descontoINSS, primeiroValor, segundoValor;

            //Atribuição dos dados da textBox_HorasTrabalhadas e armazenadas na variável
            //primeiroValor.
            primeiroValor = Double.Parse(textBox_HorasTrabalhadas.Text);

            //Atribuição dos dados da textBox_SalarioHora e armazenadas na variável
            //segundoValor.
            segundoValor = Double.Parse(textBox_SalarioHora.Text);

            //Esse comando irá realizar o cálculo do salário bruto.
            salarioBruto = primeiroValor * segundoValor;

            //Atribui o resultado do salário bruto a textBox_salarioBruto
            textBox_SalarioBruto.Text = Convert.ToString(salarioBruto, CultureInfo.InvariantCulture);

            //Essa condição irá verificar se o salario
            if (salarioBruto < 100)
            {
                textBox_DescontoINSS.Text = "0";
            }

            //Essa condição irá validar se o salário bruto é maior que 99 e menor que 101.
            else if (salarioBruto > 99 && salarioBruto < 201)
            {
                //fórmula que irá calcular os 10% do valor do INSS referente ao salário bruto.
                descontoINSS = salarioBruto * 0.1;

                //Atribuiçao do resultado a textBox_DescontoINSS.
                textBox_DescontoINSS.Text = Convert.ToString(descontoINSS);

                //Cálculo que resulta no valor do salário líquido.
                salarioLiquido = salarioBruto - descontoINSS;

                //Atribuiçao do resultado a textBox_SalarioLiquido.
                textBox_SalarioLiquido.Text = Convert.ToString(salarioLiquido, CultureInfo.InvariantCulture);
            }
            else if (salarioBruto > 200)
            {
                //fórmula que irá calcular os 20% do valor do INSS referente ao salário bruto
                descontoINSS = salarioBruto * 0.2;

                //Atribuiçao do resultado a textBox_DescontoINSS.
                textBox_DescontoINSS.Text = Convert.ToString(descontoINSS);

                //Cálculo que resulta no valor do salário líquido
                salarioLiquido = salarioBruto - descontoINSS;

                //Atribuiçao do resultado a textBox_SalarioLiquido.
                textBox_SalarioLiquido.Text = Convert.ToString(salarioLiquido, CultureInfo.InvariantCulture);
            }
            //Caso aconteça algum erro, irá apresentar a menságem "Erro!"
            else
            {
                MessageBox.Show("Erro!");
            }
        }

        //Esse método irá mostrar dentro da comboBox os valores retornados da consulta ao banco de dados
        private void comboBox_Funcionarios_MouseDown(object sender, MouseEventArgs e)
        {
            //Variável que terá armazenado o script a ser executado dentro do banco de dados.
            string strSQL;

            //Responsável por fazer a conexão com o servidor.
            SqlConnection conexao = new("Server=DESKTOP-577E646\\SQLEXPRESS;Database=db_Funcionarios;User Id =sa; Password=S&nh4DBFunc1on4rios");

            //Essa linha abre a conexão com o banco de dados.
            conexao.Open();

            //Aqui será armazenado o comando que será executado dentro do banco de dados durante a consulta.
            strSQL = "SELECT Nome From tbl_InformacoesFuncionarios";

            //Dentro dessa procídule, instanciei a variável strSQL e a conexão com o banco de dados.
            SqlCommand comando = new(strSQL, conexao);

            //SqlDataReader leitorFuncionario irá executar os parâmetros de comando
            //e retornar os dados
            SqlDataReader leitorFuncionario = comando.ExecuteReader();

            //Essa procídule recebeu a variável tabelaFuncionário,
            //pois ela representará a tabela
            DataTable tabelaFuncionario = new();

            //Durante esse processo, a variável irá utilizar o .Load para carregar os dados
            //que serão buscados do leitorFuncionario para tabelaFuncionario.
            tabelaFuncionario.Load(leitorFuncionario);

            //Irá repsetentar em forma de linhas dentro a tabela
            DataRow linha = tabelaFuncionario.NewRow();

            //cria uma linha vazia
            linha["Nome"] = "";

            //Irá inserir linhas começando pelo índice 0
            tabelaFuncionario.Rows.InsertAt(linha, 0);

            //A comboBox_Funciinários irá receber a tabela de funcionários
            comboBox_Funcionarios.DataSource = tabelaFuncionario;

            //A comboBox_Funcionários irá receber os dados da coluna Nome.
            comboBox_Funcionarios.ValueMember = "Nome";

            //A comboBox_Funcionários irá mostrar os dados da coluna Nome que foram resgatados anteriormente.
            comboBox_Funcionarios.DisplayMember = "Nome";

            //Fecha a conexão.
            conexao.Close();
        }

        //Métodos não utilizados.
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label_SalarioBruto_Click(object sender, EventArgs e)
        {

        }

        private void label_DescontoINSS_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_Funcionarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
