using ScreenSound.Modelos;

Banda ira = new Banda("Ira!");
ira.AdicionarNota(10);
ira.AdicionarNota(8);
ira.AdicionarNota(6);
Banda beatles = new Banda("The Beatles");


Dictionary<string, Banda> bandasRegistradas = new()
{
    { ira.Nome, ira },
    { beatles.Nome, beatles }
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
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
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
                RegistrarAlbum();
                break;
            case 3:
                MostrarBandasRegistradas();
                break;
            case 4:
                AvaliarUmaBanda();
                break;
            case 5:
                ExibirDetalhes();
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
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} já está registrada!");
    }

    PausarExecucao();
    ExibirOpcoesDoMenu();
}

void RegistrarAlbum()
{
    LimparConsole();
    ExibirTituloDaOpcao("Registro de álbuns");

    Console.Write("Digite a banda cujo álbum deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write("Agora digite o título do álbum: ");
        string tituloAlbum = Console.ReadLine()!;

        Banda banda = bandasRegistradas[nomeDaBanda];
        banda.AdicionarAlbum(new Album(tituloAlbum));

        Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");

        PausarExecucao();
    }
    else
    {
        InserirNovaLinha();
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
    }

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
        Banda banda = bandasRegistradas[nomeDaBanda];
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        if (int.TryParse(Console.ReadLine(), out int nota))
        {
            banda.AdicionarNota(nota);
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

void ExibirDetalhes()
{
    LimparConsole();
    ExibirTituloDaOpcao("Exibir detalhes da banda");

    Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Banda banda = bandasRegistradas[nomeDaBanda];
        if (banda.Media > 0)
        {
            Console.WriteLine($"A média da banda {nomeDaBanda} é {banda.Media}.");
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} ainda não possui avaliações.");
        }

        /**
        * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
        */
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
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