using System;
using solid_ocp_folha_pagamento.Model;
using solid_ocp_folha_pagamento.Servico;

namespace solid_ocp_folha_pagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var folhaPagamento = new FolhaPagamento();
            
            var contratoClt = new ContratoClt();
            folhaPagamento.Calcular(contratoClt);
            Console.WriteLine($"Contrato CLT: {folhaPagamento.Saldo().ToString("C")}");

            var contratoEstagio = new ContratoEstagio();
            folhaPagamento.Calcular(contratoEstagio);
            Console.WriteLine($"Contrato Estágio: {folhaPagamento.Saldo().ToString("C")}");

            Console.ReadKey();
        }
    }
}
