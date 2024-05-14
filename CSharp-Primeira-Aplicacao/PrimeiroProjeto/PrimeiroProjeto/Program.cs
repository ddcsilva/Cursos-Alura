Dictionary<string, List<int>> bandasRegistradas = new()
{
    { "Linkin Park", new List<int> { 10, 8, 6 } },
    { "The Beatles", new List<int>() }
};

const string Logo = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
";

void ExibirLogo()
{
    Console.WriteLine(Logo);
}

void ExibirMensagemDeBoasVindas()
{
    ExibirLogo();
    Console.WriteLine("Bem-vindo ao Screen Sound, o seu aplicativo de avaliação de bandas!");
}

void ExibirOpcoesDoMenu()
{
    LimparConsole();
    ExibirMensagemDeBoasVindas();
    InserirNovaLinha();

    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    InserirNovaLinha();
    Console.Write("Digite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    if (int.TryParse(opcaoEscolhida, out int opcaoEscolhidaNumerica))
    {
        switch (opcaoEscolhidaNumerica)
        {
            case 1:
                RegistrarBanda();
                break;
            case 2:
                MostrarBandasRegistradas();
                break;
            case 3:
                AvaliarUmaBanda();
                break;
            case 4:
                ExibirMedia();
                break;
            case 0:
                Console.WriteLine("Obrigado por utilizar o Screen Sound! Até a próxima!");
                break;
            default:
                Console.WriteLine("Opção inválida! Tente novamente.");
                PausarExecucao();
                ExibirOpcoesDoMenu();
                break;
        }
    }
    else
    {
        Console.WriteLine("Entrada inválida! Digite um número.");
        PausarExecucao();
        ExibirOpcoesDoMenu();
    }
}

void RegistrarBanda()
{
    LimparConsole();
    ExibirTituloDaOpcao("Registro das bandas");

    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (!bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        bandasRegistradas.Add(nomeDaBanda, new List<int>());
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} já está registrada!");
    }

    PausarExecucao();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    LimparConsole();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    InserirNovaLinha();
    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();

    ExibirOpcoesDoMenu();
}

void AvaliarUmaBanda()
{
    LimparConsole();
    ExibirTituloDaOpcao("Avaliar banda");

    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        if (int.TryParse(Console.ReadLine(), out int nota))
        {
            bandasRegistradas[nomeDaBanda].Add(nota);
            InserirNovaLinha();
            Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}!");
        }
        else
        {
            Console.WriteLine("Nota inválida! Deve ser um número inteiro.");
        }
    }
    else
    {
        InserirNovaLinha();
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
    }

    PausarExecucao();
    ExibirOpcoesDoMenu();
}

void ExibirMedia()
{
    LimparConsole();
    ExibirTituloDaOpcao("Exibir média da banda");

    Console.Write("Digite o nome da banda que deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        if (notasDaBanda.Count > 0)
        {
            Console.WriteLine($"A média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} ainda não possui avaliações.");
        }
    }
    else
    {
        InserirNovaLinha();
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
    }

    InserirNovaLinha();
    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();

    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void LimparConsole()
{
    Console.Clear();
}

void InserirNovaLinha()
{
    Console.WriteLine();
}

void PausarExecucao()
{
    Thread.Sleep(2000);
}

ExibirOpcoesDoMenu();