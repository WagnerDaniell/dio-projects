class Carro
{
    public string Placa { get; set; }
}

class Program
{
    public static double valorFixo;
    public static double valorHora;
    public static List<Carro> carrosEstacionados = new List<Carro>();

    public static void Main(string[] args)
    {

        Console.WriteLine("Informe o Valor Fixo:");
        valorFixo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor hora do estacionamento:");
        valorHora = Convert.ToDouble(Console.ReadLine());

        if(valorFixo <= 0 || valorHora <= 0)
        {
            Console.WriteLine("Valores devem ser maiores que zero.");
            return;
        }

        menu();
    }

    public static void menu()
    {
        Console.WriteLine("1 - Cadastrar Carro no Estacionamento.");
        Console.WriteLine("2 - Consultar Carros no Estacionamento.");
        Console.WriteLine("3 - Remover Carro do Estacionamento.");
        Console.WriteLine("4 - Sair.");

        int opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                cadastrarCarro();
                break;
            case 2:
                consultarCarros();
                break;
            case 3:
                removerCarro();
                break;
            case 4:
                Console.WriteLine("Saindo do programa...");
                Environment.Exit(0);
                break;
        }
    }


    public static void cadastrarCarro()
    {
        Console.WriteLine("Digite a placa do carro:");
        string placa = Console.ReadLine();

        var verificarCarro = carrosEstacionados.FirstOrDefault(c => c.Placa == placa);

        if (verificarCarro != null)
        { 
            Console.WriteLine("Carro já cadastrado.");
        }

        var carroNovo = new Carro {Placa = placa};

        carrosEstacionados.Add(carroNovo);

        Console.WriteLine("Carro adicionado!");

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
        menu();
    }

    public static void consultarCarros()
    {
        if(carrosEstacionados.Count == 0)
        {
            Console.WriteLine("Nenhum carro cadastrado.");
        }
        else
        {
            foreach(var carro in carrosEstacionados)
            {
                Console.WriteLine($"Carros cadastrados: {carro.Placa}");
            }
        }

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
        menu();
    }

    public static void removerCarro()
    {
        Console.WriteLine("Digite a placa do carro a ser removido:");
        string placa = Console.ReadLine();

        var carroRemover = carrosEstacionados.FirstOrDefault(c => c.Placa == placa);
        if(carroRemover == null)
        {
            Console.WriteLine("Carro não encontrado.");
            menu();
            return;
        }
        Console.WriteLine("Digite a quantidade de horas que o carro ficou estacionado:");
        int horas = Convert.ToInt32(Console.ReadLine());

        double valorTotal = valorFixo + (valorHora * horas);

        carrosEstacionados.Remove(carroRemover);
        Console.WriteLine($"O carro {placa} foi removido. O valor total foi de: R$ {valorTotal}");

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
        menu();
    }
}