using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Roda_Gigante.Classes
{
   class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
