using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class Periodo
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public void ExibirPeriodo(PeriodoEnum opcao)
        {
            ObterPeriodo(opcao);
            Console.WriteLine($"Data Inicio: {DataInicio.ToString("d")}\nData Fim: {DataFim.ToString("d")}");
        }

        public void ObterPeriodo(PeriodoEnum periodo)
        {

            switch (periodo)
            {
                case PeriodoEnum.Ontem:
                    DataInicio = DateTime.Today.AddDays(-1);
                    DataFim = DateTime.Today.AddDays(-1);
                    break;

                case PeriodoEnum.Hoje:
                     DataInicio = DateTime.Today;
                     DataFim = DateTime.Today;
                    break;

                case PeriodoEnum.EstaSemana:
                    var primeiroDiaSemana = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
                    DataInicio = primeiroDiaSemana;
                    DataFim = primeiroDiaSemana.AddDays(6);
                    break;

                case PeriodoEnum.EsteMes:
                     DataInicio = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 01);
                     DataFim = DateTime.Today;
                    break;

                case PeriodoEnum.UtimosTrintaDias:
                     DataInicio = DateTime.Today.AddDays(-30);
                     DataFim = DateTime.Today;

                    break;

                case PeriodoEnum.MesAnterior:
                    var dataFimMesAnt = new DateTime(DateTime.Today.AddDays(-DateTime.Today.Day).Year, DateTime.Today.Month, 01).AddDays(-1);
                    var dataInicioMesAnt = dataFimMesAnt.AddMonths(0).AddDays(-dataFimMesAnt.Day + 1);
                    DataInicio = dataInicioMesAnt;
                    DataFim = dataFimMesAnt;
                    break;

                case PeriodoEnum.UltimosTresMeses:
                    var dataFimTresMeses = new DateTime(DateTime.Today.AddDays(-DateTime.Today.Day).Year, DateTime.Today.Month, 01).AddDays(-1);
                    var dataInicioTresMeses = dataFimTresMeses.AddMonths(-2).AddDays(-dataFimTresMeses.Day + 1);
                     DataInicio = dataInicioTresMeses;
                     DataFim = dataFimTresMeses;
                    break;

                case PeriodoEnum.UltimosSeisMeses:
                    var dataFimSeisMeses = new DateTime(DateTime.Today.AddDays(-DateTime.Today.Day).Year, DateTime.Today.Month, 01).AddDays(-1);
                    var dataInicioSeisMeses = dataFimSeisMeses.AddMonths(-5).AddDays(-dataFimSeisMeses.Day + 1);
                     DataInicio = dataInicioSeisMeses;
                     DataFim = dataFimSeisMeses;

                    break;

                case PeriodoEnum.EsteAno:
                     DataInicio = new DateTime(DateTime.Today.AddYears(0).Year, 1, 1);
                     DataFim = DateTime.Today;

                    break;

                case PeriodoEnum.AnoPassado:
                     DataInicio = new DateTime(DateTime.Today.AddYears(-1).Year, 1, 1);
                     DataFim = new DateTime(DateTime.Today.AddYears(-1).Year, 12, 31);
                    break;

                default:
                    break;
            }
        }

    }
}






