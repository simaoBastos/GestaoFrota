using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFrota.Models
{
    public  class Caminhao(string placa, string modelo, int ano, decimal valorDiariaBase, double capacidadeCargaKg) : Veiculo(placa, modelo, ano, valorDiariaBase)
    {
        public double CapacidadeCargaKg { get; set; } = capacidadeCargaKg;
        public override decimal CalcularCustoAluguel(int dias)
        {
            decimal custoBase = ValorDiariaBase* dias;
            decimal taxaCarga = (decimal)(CapacidadeCargaKg /1000.0) * 50m * dias;
            return custoBase +(custoBase * 0.20m) + taxaCarga; //20% seguro + taxa de carga
        }

    }
}
