using estacionamento.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o preço/Hora: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

//instancia a classe Estacionamento, ja com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirmenu = true;


//realiza o loop while
while (exibirmenu)
{
    Console.Clear();
    Console.WriteLine("Digite a opção:");
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar Veículo");
    Console.WriteLine("4 - Encerrar Sistema");

    switch (Console.ReadLine())
    {
        case "1": es.AdcionarVeiculo(); break;
        case "2": es.RemoverVeiculo(); break;
        case "3": es.ListarVeiculos(); break;
        case "4": exibirmenu = false; break;
        default: Console.WriteLine("Opção Invalida"); break;
    }
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();

}
Console.WriteLine("O Programa se encerrou!");