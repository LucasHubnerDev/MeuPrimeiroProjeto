// Screen Sound

// Declarando uma variável do tipo string para armazenar a mensagem de boas-vindas.
// Em C#, toda variável precisa possuir um tipo definido.
// Neste caso:
// - string → tipo da variável
// - messageWelcome → nome da variável
// - "Boas vindas ao:" → valor atribuído

// O padrão camelCase é utilizado para nomear variáveis.
// Nesse padrão, a primeira palavra começa com letra minúscula
// e as próximas palavras começam com letra maiúscula.
// Exemplo: messageWelcome.
string messageWelcome = "Boas vindas ao:";

// O padrão PascalCase é utilizado para nomear métodos.
// Nesse padrão, todas as palavras começam com letra maiúscula.
// Exemplo: ExibirMensagemBoasVindas.

// O tipo void indica que o método não retorna nenhum valor.
// Ou seja, ele apenas executa instruções.
void ExibirMensagemBoasVindas()
{
    // Este método exibe uma mensagem de boas-vindas no console.

    // A variável messageWelcome pode ser acessada em qualquer parte
    // do código após sua declaração.

    // Console.WriteLine(stars);
    // Console.WriteLine(messageWelcome);
    // Console.WriteLine(stars);

    // O símbolo @ antes da string cria uma string verbatim.
    // Isso faz com que o texto seja interpretado exatamente como foi escrito,
    // sem necessidade de utilizar caracteres de escape.
    // Muito útil para textos com múltiplas linhas ou ASCII Art.
    Console.WriteLine(@"
██████╗░███████╗░█████╗░██████╗░  ░██████╗███████╗░█████╗░
██╔══██╗██╔════╝██╔══██╗██╔══██╗  ██╔════╝██╔════╝██╔══██╗
██║░░██║█████╗░░███████║██║░░██║  ╚█████╗░█████╗░░██║░░╚═╝
██║░░██║██╔══╝░░██╔══██║██║░░██║  ░╚═══██╗██╔══╝░░██║░░██╗
██████╔╝███████╗██║░░██║██████╔╝  ██████╔╝███████╗╚█████╔╝
╚═════╝░╚══════╝╚═╝░░╚═╝╚═════╝░  ╚═════╝░╚══════╝░╚════╝░");
}

string nome = "Lucas";
string sobrenome = "Hubner";

// A interpolação de strings é representada pelo símbolo $.
// Ela permite inserir variáveis diretamente dentro do texto usando {}.
Console.WriteLine($"Olá, {nome} {sobrenome}! {messageWelcome}");

void ExibirOpcoesMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    // Console.Write exibe o texto sem quebrar a linha.
    // Assim, o usuário pode digitar na mesma linha da mensagem.
    Console.Write("\nDigite a opção desejada: ");

    // Console.ReadLine() captura o texto digitado pelo usuário.

    // Convert.ToInt16 converte o valor digitado para o tipo short (Int16).

    // O operador ! é chamado de "null-forgiving operator".
    // Ele informa ao compilador que o valor não será nulo.
    // Isso é necessário porque Console.ReadLine() pode retornar null.
    int opcao = Convert.ToInt16(Console.ReadLine()!);

    // Estrutura condicional switch.
    // Ela é utilizada para executar diferentes blocos de código
    // com base no valor da variável opcao.
    switch (opcao)
    {
        case 1:
            Console.WriteLine("registro de banda");
            break;

        case 2:
            Console.WriteLine("bandas");
            break;

        case 3:
            Console.WriteLine("feedback");
            break;

        case 4:
            Console.WriteLine("Média das bandas");
            break;

        case 0:
            Console.WriteLine("Encerrando o programa");
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

// Chama o método responsável por exibir a mensagem de boas-vindas.
ExibirMensagemBoasVindas();

// Chama o método responsável por exibir as opções do menu.
ExibirOpcoesMenu();