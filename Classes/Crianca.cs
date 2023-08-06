using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roda_Gigante.Classes
{
    class Crianca : Pessoa
    {
        public Adulto Pai { get; set; }
        public Crianca(string nome, int idade, Adulto pai = null) : base(nome, idade)
        {
            Pai = pai;
        }
    }
}
