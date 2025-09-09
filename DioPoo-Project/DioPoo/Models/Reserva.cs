namespace DioPoo.Models
{
    public class Reserva
    {
        public Suite Suite { get; set; }
        public List<Pessoa> Hospedes { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasreservados)
        {
            DiasReservados = diasreservados;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            var quantHospedes = hospedes.Count;

            if (quantHospedes <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception($"A capacidade da suíte é de {Suite.Capacidade} hóspedes. Você tentou cadastrar {quantHospedes} hóspedes.");
            }
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Regra: 10% de desconto para reservas com 10 ou mais dias
            decimal valor = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados >= 10)
            {
                valor -= valor * 0.10M;
            }
            return valor;
        }

    }
}
