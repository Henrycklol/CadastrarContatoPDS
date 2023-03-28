using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfCadastrarContato.RegrasDeNegocio
{
    internal class Contato
    {
        public string nome { get; set; }
        public string sexo { get; set; }
        public DateTime datanasc { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
    }
}
