using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roda_Gigante.Classes
{
    internal class Gondola
    {
        private List<Pessoa> passageiros;

        public Gondola()
        {
            passageiros = new List<Pessoa>();
        }

        public bool EstaLivre()
        {
            return passageiros.Count == 0;
        }

        public void Embarcar(params Pessoa[] pessoas)
        {
            passageiros.AddRange(pessoas);
        }

        public override string ToString()
        {
            if (EstaLivre())
            {
                return "(vazia)";
            }
            else if (passageiros.Count == 1)
            {
                return "Somente " + passageiros[0].Nome;
            }
            else
            {
                string descricao = "";
                foreach (Pessoa pessoa in passageiros)
                {
                    descricao += pessoa.Nome + " e ";
                }
                return descricao.TrimEnd(' ', 'e');
            }
        }
    }
}
