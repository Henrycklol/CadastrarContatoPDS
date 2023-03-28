using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormularioPDS.Formularios;
using System.IO;
using FormularioPDS.Regra_de_Negocios;
using MySql.Data.MySqlClient;

namespace FormularioPDS.Formularios
{
    public partial class FormListarContato : Form
    {

        private MySqlConnection _conexao;
        public FormListarContato()
        {
            InitializeComponent();

            CarregarListaContato();
            
            //ACHO QUE TÁ CERTO

            
        }

        public void CarregarListaContato()
        {
            // tentativa DE GPT

            ConexaoBDAgain();

            try
            {
                DataTable tabela = new DataTable();


                MySqlCommand cmd = new MySqlCommand("select * from contato", _conexao);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                adaptador.Fill(tabela);



                tabela.Columns.Remove("id_con");
                tabela.Columns["nome_con"].ColumnName = "Nome";
                tabela.Columns["data_nasc_con"].ColumnName = "Nascimento";
                tabela.Columns["sexo_con"].ColumnName = "Sexo";
                tabela.Columns["email_con"].ColumnName = "Email";
                tabela.Columns["telefone_con"].ColumnName = "Telefone";

                dgvListarContato.DataSource = tabela;
            }

            catch (Exception ex)
            {

            }
        }

        private void ConexaoBDAgain()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3306";

            _conexao = new MySqlConnection(conexaoString);
            _conexao.Open();

        }
    }
}
