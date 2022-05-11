using solid_ocp_folha_pagamento.Model;

namespace solid_ocp_folha_pagamento.Servico
{
    public class FolhaPagamento
    {
        protected decimal _saldo;

        public void Calcular(Funcionario funcionario)
        {
            if (funcionario is ContratoClt)
            {
                _saldo = ((ContratoClt) funcionario).Salario();
            }
            else if(funcionario is ContratoEstagio)
            {
                _saldo = ((ContratoEstagio)funcionario).BolsaAuxilio();
            }
        }

        public decimal Saldo()
        {
            return _saldo;
        }
    }
}
