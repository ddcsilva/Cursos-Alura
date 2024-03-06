// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesMenu()
{
    Console.WriteLine("");
    Console.WriteLine("Digite a opção desejada:");
    Console.WriteLine("1 - Registrar uma banda");
    Console.WriteLine("2 - Exibir todas as bandas");
    Console.WriteLine("3 - Avaliar uma banda");
    Console.WriteLine("4 - Exibir a média de uma banda");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("");
    Console.Write("Digite a opção: ");

    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        case 2:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        case 3:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        case 4:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        case 0:
            Console.WriteLine("Tchau! =)");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesMenu();