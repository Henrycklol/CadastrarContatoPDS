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
using FormularioPDS.Formularios;

namespace FormularioPDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrarContato_Click(object sender, EventArgs e)
        {
            new FormCadastrarContato().ShowDialog();
        }

        private void btListarContato_Click(object sender, EventArgs e)
        {
            new FormListarContato().ShowDialog();
        }
    }
}
