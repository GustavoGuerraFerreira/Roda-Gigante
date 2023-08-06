using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roda_Gigante.Classes
{
    class RodaGigante
    {
        private Gondola[] gondolas;

        public RodaGigante()
        {
            gondolas = new Gondola[18];
            for (int i = 0; i < 18; i++)
            {
                gondolas[i] = new Gondola();
            }
        }

        public void Embarcar(int numeroGondola, params Pessoa[] pessoas)
        {
            Gondola gondola = gondolas[numeroGondola - 1];

            if (gondola.EstaLivre())
            {
                if (ValidarEmbarque(pessoas))
                {
                    gondola.Embarcar(pessoas);
                }
               
            }
            else
            {
                Console.WriteLine($"ERRO: A gôndola {numeroGondola} já está ocupada.");
            }
        }

        private bool ValidarEmbarque(Pessoa[] pessoas)
        {
            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa is Crianca crianca)
                {
                    if (crianca.Idade < 12)
                    {
                        if (crianca.Pai == null)
                        {
                            Console.WriteLine($"ERRO: {crianca.Nome} é menor de 12 anos e não sabemos quem é o pai (deve ser o Silvio, mas ele não assumiu!)");
                            return false;
                        }
                        else
                        {
                            bool paiPresente = false;
                            foreach (Pessoa p in pessoas)
                            {
                                if (p is Adulto adulto && adulto == crianca.Pai)
                                {
                                    paiPresente = true;
                                    break;
                                }
                            }
                            if (paiPresente)
                            {
                                Console.WriteLine("Ok: agora o pai está junto");
                            }
                            if (!paiPresente)
                            {
                                Console.WriteLine($"ERRO: {crianca.Nome} é menor de 12 e o pai não está junto.");
                                return false;
                            }
                        }
                    }
                    else if (crianca.Idade == 12)
                    {
                        Console.WriteLine($"OK: {crianca.Nome} já tem 12 anos e pode andar sozinho(a).");
                    }
                    else
                    {
                        Console.WriteLine($"OK: {crianca.Nome} vai sozinho(a).");
                    }
                }
                
            }

            return true;
        }
        public void Status()
        {
            Console.WriteLine("Gôndola Status");
            Console.WriteLine("-----------------------");
            for (int i = 0; i < 18; i++)
            {
                Console.WriteLine($"{i + 1} {gondolas[i].ToString()}");
            }
        }
    }
}
