using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioZoológico
{
    class Shows
    {
        public decimal IngressosShows(Entidades.Clientes cliente)
        {
            decimal valorIngresso = 0;
            decimal valorFinalIngresso = 0;
            while (true) {
                Console.WriteLine("Selecione o numero especificando o show que participou:");
                Console.WriteLine("1- Show do Leão\n2- Show da Zebra\n3-Show do Macaco\n4- Show dos Pinguins");
                int show = int.Parse(Console.ReadLine());

                switch (show)
                {
                    case 1:
                        valorIngresso = 80m;
                        if (cliente.Idade < 18)
                            valorIngresso = valorIngresso / 2;
                        break;
                    case 2:
                        valorIngresso = 50m;
                        if (cliente.Idade < 18)
                            valorIngresso = valorIngresso / 2;
                        break;
                    case 3:
                        valorIngresso = 55m;
                        if (cliente.Idade < 18)
                            valorIngresso = valorIngresso / 2;
                        break;
                    case 4:
                        valorIngresso = 30m;
                        if (cliente.Idade < 18)
                            valorIngresso = valorIngresso / 2;
                        break;

                }

                 valorFinalIngresso += valorIngresso;

                Console.WriteLine("Assistiu mais algum show? S / N");
                string continuacao = Console.ReadLine();
                if ( continuacao == "n" || continuacao == "N")
                     break;
            

            }
            return valorFinalIngresso;
        }
    }
}
