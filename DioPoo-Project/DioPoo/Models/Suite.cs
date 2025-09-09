namespace DioPoo.Models
{
    public class Suite
    {
        public string TipoSuite { get; set; }
        public decimal ValorDiaria { get; set; }
        public int Capacidade { get; set; }
        public Suite(string tipoSuite, decimal valorDiaria, int capacidade)
        {
            TipoSuite = tipoSuite;
            ValorDiaria = valorDiaria;
            Capacidade = capacidade;
        }
    }
}
