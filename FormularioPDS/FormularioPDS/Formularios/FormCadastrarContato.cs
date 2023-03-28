using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormularioPDS.Regra_de_Negocios;
using System.IO;
using FormularioPDS.Formularios;
//JAMAIS  ESQUEÇA DESSE INFELIZ
using MySql.Data.MySqlClient;
// esse mesmo

namespace FormularioPDS.Formularios
{
    public partial class FormCadastrarContato : Form
    {
        private MySqlConnection _conexao;

        Contato contato = new Contato();

        



        public FormCadastrarContato()
        {
            InitializeComponent();
            //data show
            ConexaoBD();

            dtpDatanasc.Format = DateTimePickerFormat.Custom;
            dtpDatanasc.CustomFormat = "yyyy-MM-dd";

        }
        // a coisa mais crucial da sua vida
        private void ConexaoBD()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3306";

            _conexao = new MySqlConnection(conexaoString);
            _conexao.Open();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (edNome.Text != "" && edSexo.Text != "" && dtpDatanasc.Text != "" && edTelefone.Text != "" && edEmail.Text != "")
            {
                try
                {
                    var nome = edNome.Text;
                    var email = edEmail.Text;
                    var dataNasc = dtpDatanasc.Text;
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

                    MessageBox.Show("SALVO COM SUCESSO INFELIZ");

                    
                }
                catch (Exception ex)
                {

                }
            }


            else
            {
                MessageBox.Show("I'M BUSY YOU MOTHERFUCKER");
            }

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {

        }

        private void edNome_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void edSexo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void edNasc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void edEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void edTelefone_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
