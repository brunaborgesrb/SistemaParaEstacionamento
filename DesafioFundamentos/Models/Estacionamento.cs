namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Pedir para o usuário digitar uma placa e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            // Lê a entrada do usuário para obter a placa
            string placa = Console.ReadLine();

            // Adiciona a placa à lista de veículos
            veiculos.Add(placa);

            // Exibir uma mensagem confirmando que o veículo foi adicionado
            Console.WriteLine($"Veículo com placa {placa} adicionado com sucesso à lista.");

        }

        public void RemoverVeiculo()
        {
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = "";

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

            // Lê a entrada do usuário para obter a quantidade de horas
            if (int.TryParse(Console.ReadLine(), out int horas) && horas >= 0)
            {

            // Define os valores de preço inicial e preço por hora (ajuste conforme necessário)
            Console.WriteLine("Digite o preço inicial:");
            if (decimal.TryParse(Console.ReadLine(), out decimal precoInicial))
            {
                
            Console.WriteLine("Digite o preço por hora:");
            if (decimal.TryParse(Console.ReadLine(), out decimal precoPorHora))
            {
            // Calcula o valor total
            decimal valorTotal = precoInicial + precoPorHora * horas;

            // Remove a placa digitada da lista de veículos
            veiculos.Remove(placa.ToUpper());

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }

            else
            {
            Console.WriteLine("Quantidade de horas inválida. Certifique-se de digitar um valor inteiro não negativo.");
            }
        }
            else
            {
        Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Laço de repetição, exibindo os veículos estacionados
                foreach (var veiculo in veiculos)
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
