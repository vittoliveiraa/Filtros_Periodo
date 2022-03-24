using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de períodos");
            Console.WriteLine("");

            Console.WriteLine(" 0 - Ontem");
            Console.WriteLine(" 1 - Hoje");
            Console.WriteLine(" 2 - Esta Semana");
            Console.WriteLine(" 3 - Este Mês");
            Console.WriteLine(" 4 - Útimos 30 dias");
            Console.WriteLine(" 5 - Mês anterior");
            Console.WriteLine(" 6 - Últimos 3 meses");
            Console.WriteLine(" 7 - Últimos 6 meses");
            Console.WriteLine(" 8 - Este Ano");
            Console.WriteLine(" 9 - Ano Passado");
            Console.WriteLine("");
            Console.Write("Digite qual período você deseja: ");
            
            int opcao = int.Parse(Console.ReadLine());

            var periodo = new Periodo();

            periodo.ExibirPeriodo((PeriodoEnum)opcao);

            periodo.ExibirPeriodo(PeriodoEnum.EsteAno);
            
            
            

        }
    }
}
