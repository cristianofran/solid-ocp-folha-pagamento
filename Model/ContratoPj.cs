using solid_ocp_folha_pagamento.Model.Interfaces;

namespace solid_ocp_folha_pagamento.Model
{
    public class ContratoPj : IRemuneracao
    {
        public double CalcularRemuneracao() => 1200 * 2;
    }
}
