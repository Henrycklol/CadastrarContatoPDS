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
    /// Lógica interna para janelaListarContato.xaml
    /// </summary>
    public partial class janelaListarContato : Window
    {

        private MySqlConnection _conexao;

        public janelaListarContato()
        {
            InitializeComponent();

            CarregarListaContato();
        }

        private void ConexaoBD()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3306";

            _conexao = new MySqlConnection(conexaoString);
            _conexao.Open();

        }

        public void CarregarListaContato()
        {
            // tentativa DE GPT

            ConexaoBD();

            try
            {

                string query = "select * from contato";
                var comando = new MySqlCommand(query, _conexao);
                var reader = comando.ExecuteReader();
                var lista = new List<Contato>();
                while (reader.Read()) {

                    Contato contato = new Contato();

                        contato.nome = reader.GetString(1);
                        contato.email = reader.GetString(4);
                        contato.datanasc = reader.GetDateTime(2);
                        contato.telefone = reader.GetString(5);
                        contato.sexo = reader.GetString(3);

                    lista.Add(contato);
                }

                dgListarContato.ItemsSource = lista;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Você é um fracasso total.");
            }
        }
    } }
