using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFrota.Models
{
    public class Carro(string placa, string modelo, int ano, decimal valorDiariaBase, int quantidadePortas) : Veiculo(placa, modelo, ano, valorDiariaBase)
    {
        public int QuantidadePortas { get; set; } = quantidadePortas;
        public override decimal CalcularCustoAluguel(int dias)
        {
            decimal custoBase = ValorDiariaBase * dias;
            return custoBase + (custoBase * 0.10m);
        }
        public override string ObterDescricao() => $"{base.ObterDescricao()} | Portas: {QuantidadePortas}";
    }
}
