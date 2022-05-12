using solid_ocp_folha_pagamento.Model.Interfaces;

namespace solid_ocp_folha_pagamento.Servico
{
    public class FolhaPagamento
    {
        protected double _saldo;

        public void Calcular(IRemuneracao remuneracao) => _saldo = remuneracao.CalcularRemuneracao();
        
        public double ObterRemuneracao() => _saldo;
    }
}
