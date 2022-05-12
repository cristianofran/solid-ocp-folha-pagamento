using solid_ocp_folha_pagamento.Model.Interfaces;

namespace solid_ocp_folha_pagamento.Model
{
    public class ContratoEstagio : IRemuneracao
    {
        public double CalcularRemuneracao() => 600;
    }
}
