using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using wpfCadastrarContato.Janelas;
using wpfCadastrarContato.RegrasDeNegocio;

namespace wpfCadastrarContato.Janelas
{
    /// <summary>
    /// Lógica interna para janelaCadastrarContato.xaml
    /// </summary>
    public partial class janelaCadastrarContato : Window
    {
        private MySqlConnection _conexao;
        
        public janelaCadastrarContato()
        {
            InitializeComponent();
            ConexaoBD();


        }

        //CONEXAO COM O BD
        
        private void ConexaoBD()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3306";

            _conexao = new MySqlConnection(conexaoString);
            _conexao.Open();
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            if (edNome.Text != "" && edSexo.Text != "" && dtpNascimento.Text != "" && edTelefone.Text != "" && edEmail.Text != "")
            {
                try
                {
                    var nome = edNome.Text;
                    var email = edEmail.Text;
                    var dataNasc = Convert.ToDateTime(dtpNascimento.Text).ToString("yyyy-MM-dd");
                    var telefone = edTelefone.Text;
                    var sexo = edSexo.Text;

                    var sql = "insert into contato (nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (@_nome, @_dataNasc, @_sexo, @_email, @_telefone)";
                    var comando = new MySqlCommand(sql, _conexao);

                    comando.Parameters.AddWithValue("@_nome", nome);
                    comando.Parameters.AddWithValue("@_email", email);
                    comando.Parameters.AddWithValue("@_dataNasc", dataNasc);
                    comando.Parameters.AddWithValue("@_telefone", telefone);
                    comando.Parameters.AddWithValue("@_sexo", sexo);

                    comando.ExecuteNonQuery();

                    _conexao.Close();

                    MessageBox.Show("CALVO COM CUCEGO INFELIZ");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("FOI DESGRAÇA");
                }
            }


            else
            {
                MessageBox.Show("I'M BUSY YOU MOTHERFUCKER");
            }
        }

        private void edNome_TextChanged()
        {

        }
    }
}
