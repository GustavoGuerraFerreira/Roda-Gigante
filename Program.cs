﻿using Roda_Gigante.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roda_Gigante.Classes;
namespace Roda_Gigante
{
    class Program
    {
        static void Main(string[] args)
        {
            RodaGigante roda = new RodaGigante(); // Criando nova roda gigante
            Adulto paulo = new Adulto("Paulo", 42); // Adulto com o nome Paulo
                                                    // Filhos do Paulo
            Crianca joao = new Crianca("Joao", 5, paulo); // Nova criança cujo pai é Paulo
            Crianca maria = new Crianca("Maria", 12, paulo); // Esta é a filha do Paulo
                                                             // Crianca sem pai definido
            Crianca pedro = new Crianca("Pedro", 13);
            Crianca henrique = new Crianca("Henrique", 10);

            roda.Embarcar(2, joao, maria); // ERRO: João é menor de 12 e o pai não está junto
            roda.Embarcar(2, joao, paulo); // OK: Agora o pai está junto
            roda.Embarcar(3, maria); // OK: Maria já tem 12 anos e pode andar sozinha
            roda.Embarcar(13, pedro); // OK: O Pedro vai sozinho
            roda.Embarcar(16, henrique);//ERRO: henrique é menor de 12 anos e não sabemos quem é o pai (deve ser o Silvio, mas ele não assumiu!)
            roda.Status();

            Console.ReadKey();
        }
    }
}
