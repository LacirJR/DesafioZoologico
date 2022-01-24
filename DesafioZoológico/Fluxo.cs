using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioZoológico
{
    class Fluxo
    {
        public void Zoologico()
        {
            var listaClientes = new List<Entidades.Clientes>();
            decimal valorIngressoZoologico = 50m;
            while (true)
            {
                var cliente = new Entidades.Clientes();
                cliente.IngressoZoologico = valorIngressoZoologico;
                Console.Write("Digite seu RG: ");
                cliente.Cpf = Console.ReadLine()
                    .Replace(".","")
                    .Replace("-","")
                    .Replace(" ","")
                    .Replace("/", "");

                Console.Write("Digite seu nome: ");
                cliente.Nome = Console.ReadLine();

                Console.Write("Digite sua idade: ");
                cliente.Idade = short.Parse(Console.ReadLine());
                if (cliente.Idade < 18)
                {
                    cliente.IngressoZoologico = valorIngressoZoologico / 2;
                }


                Console.WriteLine("Assistiu algum show? S / N");
                string resposta = Console.ReadLine();
                if(resposta == "S" || resposta == "s")
                {
                    Shows show = new();
                    cliente.IngressosShows = show.IngressosShows(cliente);
                }
                else if (resposta == "N" || resposta == "n")
                {
                    cliente.IngressosShows = 0m;
                }
                else { }

                listaClientes.Add(cliente);

                Console.WriteLine("Deseja adicionar algum cliente? S / N");
                 resposta = Console.ReadLine();
                if (resposta == "N" || resposta == "n")
                {
                    decimal ingressosShow = 0m;
                    decimal ingressosZoo = 0m;
                    foreach (var clientes in listaClientes)

                    {
                        Console.WriteLine("O Cliente" + clientes.Nome + " de: " + clientes.Idade + " anos com o CPF: " + clientes.Cpf + ". Pagou: R$" +
                            clientes.IngressoZoologico + " de entrada no zoológico e R$" + clientes.IngressosShows + " com shows.");
                        ingressosZoo += clientes.IngressoZoologico;
                        ingressosShow += clientes.IngressosShows;
                    

                    }

                    Console.WriteLine("O Zoológico faturou R$" + ingressosZoo + " com entradas e R$" + ingressosShow + " com ingressos em shows.");
                    break;
                }
            }

           
              
        }
    }
}
