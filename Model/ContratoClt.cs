﻿using solid_ocp_folha_pagamento.Model.Interfaces;

namespace solid_ocp_folha_pagamento.Model
{
    public class ContratoClt : IRemuneracao
    {
        public double CalcularRemuneracao() => 1200;
    }
}
