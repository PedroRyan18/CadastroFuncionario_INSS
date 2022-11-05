using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AvaliacaoProcessoSeletivo.Model
{
    internal class Conexao
    {
        string strSQL = @"Server=DESKTOP-577E646\SQLEXPRESS;Database=db_Funcionarios;User Id=sa;Password=S&nh4DBFunc1on4rios";
        string sql = "INSERT INTO tbl_InformacoesFuncionarios (Nome,CPF,Endereco,Email,Telefone) VALUES ('Gabriel Gatao','12312312312'," +
                     "'Casa da Mãe Joana','Teste@teste','31998765432')";

        SqlConnection conexao = new SqlConnection();


    }
}
