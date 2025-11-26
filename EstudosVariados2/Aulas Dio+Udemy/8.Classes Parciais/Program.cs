using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; //Para alterar minha cultura

namespace Modulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aula sobre classe parcial
            Pessoas p1 = new Pessoas();
            p1.nome = "Romario";
            p1.Apresentar();

            //Aula sobre formatãção de números
            decimal valorMoneario = 82.40M;
            Console.WriteLine($"Valor monetário sem formatação:  {valorMoneario}");
            Console.WriteLine($"Valor monetário com formatação:  {valorMoneario:C}"); //: indica formatação, C de "currency"
            //Nesta ocasião ele captou as especificações da minha região para formatar (brasil)
            Console.WriteLine($"Valor monetário com formatação:  {valorMoneario:C}");

            //Alterando informações de cultura (veja a alteração no cabeçalho dos using
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Console.WriteLine($"Valor monetário com formatação:  {valorMoneario:C}");
            //Agora defini minha cultura para en-US, então ele entenderá que a minha moeda é dolar.
            //Porém essa alteração é para todo o sistema, então não é muito recomendavel este meio.

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
            Console.WriteLine($"Valor monetário com formatação:  {valorMoneario:C}");
            //retornei a moeda BR
            Console.WriteLine(valorMoneario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            //Alterei apenas este trecho do código para dolar.
            Console.WriteLine(valorMoneario.ToString("C1"));//O numero a frente do C estipula as casas decimais.
            Console.WriteLine(valorMoneario.ToString("N1"));//O N indica um número.
            double porcentagem = .3421;
            Console.WriteLine(porcentagem.ToString("P"));//Agora formatamos para %.
            int teste = 123456;
            Console.WriteLine(teste.ToString("##-##-##"));//Agora criamos uma formatação personalizada.

            //Formatando datas
            DateTime data = DateTime.Now;
            //Pega a data do sistema, porém, se estiver em nuvem, pode estar em fuso-horário diferente.
            //Exemplo de formatações
            Console.WriteLine("Data sem formatação: " + data);
            Console.WriteLine("Exibindo apenas a data: " + data.ToString("dd/MM/yyyy"));
            Console.WriteLine("Exibindo apenas a hora: " + data.ToString("HH:mm"));
            //outro meio
            Console.WriteLine(data.ToShortDateString()); // apenas data
            Console.WriteLine(data.ToShortTimeString()); // apenas hora

            

            DateTime data2 = DateTime.Parse("17/04/2022 18:00"); //Se o parse der erro, o programa encerra.
            string data3 = "2022-08-08 18:00"; // forneci uma data com formato US.
            DateTime.TryParseExact(data3, "yyyy-MM-dd", //Estamos tentando converter um formato de data.
                //eu forneci o formato dela em yyyy-MM-dd
                CultureInfo.InvariantCulture, //Aqui estou dizendo que a informação da culta é indiferente.
                DateTimeStyles.None, //Estilos de localização
                out data2); //Saída
            //
            Console.WriteLine(data3);






            Console.ReadKey();

        }
    }
}
