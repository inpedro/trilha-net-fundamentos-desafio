using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamento.Models
{
    public class Estacionamento
    {
        //declara os valores de cada input para calculo e metodo List<> para armezenar.
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            // recebe os valores de classes privadas acima.
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
        //digitar void informação.
        public void AdcionarVeiculo()
        {
            //Mensagem para digitar o veiculo.
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            //Pedir para o usuário digitar a placa e armazenar na variavél placa
            Console.WriteLine("Digite a placa:");
            string placa = Console.ReadLine();
            Console.WriteLine("Digite o preço/Hora: ");
            precoPorHora = Convert.ToDecimal(Console.ReadLine());

            //verifica se o veiculo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veiculo permaneceu estacionado: ");

                //TODO: pedir para o usuário digitar a quantidade de horas que o veiculo permaneceu estacionado,
                int horas = Convert.ToInt32(Console.ReadLine());
                //TODO: Realizar o seguinte calculo: "precoInicial + precoPorHora * horas para variavel valorTotal
                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa);
                Console.WriteLine($"O veiculo {placa} e ficou estacionado {horas}Horas e o preço total de : R${valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se a placa está correta!");

            }
        }
        public void ListarVeiculos()
        {
            // verifica se há veiculos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veiculos estacionados são: ");
                //TODO: realizar um laço de rep. para exibir os veiculos estacionados
                //implemente aqui.
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}