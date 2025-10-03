using System;
using System.Collections.Generic;
using System.Linq;


namespace _17_Calendario
{
    internal class Calendario
    {
        private int ano;
        private Mes mes;
        private DateTime primeiroDiaMes;
        private int[,] calendario;

        public Calendario(int ano, Mes mes)
        {
            this.ano = ano;
            this.mes = mes;
            primeiroDiaMes = new DateTime(ano, (int)mes, 1);
            calendario = new int[6, 7];
            gerarCalendario();
        }

        private void gerarCalendario()
        {
            int diasDoMes = DateTime.DaysInMonth(ano, (int)mes);
            int diaSemanaInicio = (int)primeiroDiaMes.DayOfWeek;
            int dia = 1;

            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if (semana == 0 && diaSemana < diaSemanaInicio)
                    {
                        calendario[semana, diaSemana] = 0;
                    }
                    else if (dia <= diasDoMes)
                    {
                        calendario[semana, diaSemana] = dia;
                        dia++;
                    }
                }
            }
        }

        public void ImprimirCalendario()
        {
            Console.WriteLine($"\nCalendário de {primeiroDiaMes.ToString("MMMM")} de {ano}");
            Console.WriteLine("DOM\tSEG\tTER\tQUA\tQUI\tSEX\tSAB");

            List<Feriado> diasFeriados = RetornaFeriados();

            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if (calendario[semana, diaSemana] != 0)
                    {
                        if (diasFeriados.Any(feriado => feriado != null && feriado.Dia == calendario[semana, diaSemana])
    ||                   (DiaDaSemana)diaSemana == DiaDaSemana.Domingo)

                            Console.ForegroundColor = ConsoleColor.Red;

                        Console.Write(calendario[semana, diaSemana].ToString("D2") + "\t");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }

            Console.Write("\nFeriados: ");
            foreach (Feriado diaFeriado in diasFeriados)
            {
                if (diaFeriado != null)
                    Console.Write($"{diaFeriado.Dia:D2}-{diaFeriado.Descricao} \t");
            }
            Console.WriteLine();
        }

        private List<Feriado> RetornaFeriados()
        {
            List<Feriado> feriados = new List<Feriado>();

            if (mes == Mes.Janeiro) feriados.Add(new Feriado(1, "Confraternização Universal"));
            else if (mes == Mes.Abril)
            {
                feriados.Add(new Feriado(4, "Aniversário da Cidade"));
                feriados.Add(new Feriado(21, "Tiradentes"));
            }
            else if (mes == Mes.Maio) feriados.Add(new Feriado(1, "Dia do Trabalho"));
            else if (mes == Mes.Julho) feriados.Add(new Feriado(9, "Revolução Constitucionalista de SP"));
            else if (mes == Mes.Setembro) feriados.Add(new Feriado(7, "Independência do Brasil"));
            else if (mes == Mes.Outubro) feriados.Add(new Feriado(12, "Nossa Senhora Aparecida"));
            else if (mes == Mes.Novembro)
            {
                feriados.Add(new Feriado(2, "Finados"));
                feriados.Add(new Feriado(15, "Proclamação da Republica"));
                feriados.Add(new Feriado(20, "Conciência Negra"));
            }
            else if (mes == Mes.Dezembro)
            {
                feriados.Add(new Feriado(8, "Padroeira da Cidade"));
                feriados.Add(new Feriado(25, "Natal"));
            }

            DateTime domingoDePascoa = DomingoDePascoa();
            DateTime carnaval = domingoDePascoa.AddDays(-47);
            DateTime sextaFeiraSanta = domingoDePascoa.AddDays(-2);
            DateTime corpusChristi = domingoDePascoa.AddDays(60);

            if ((Mes)domingoDePascoa.Month == mes) feriados.Add(new Feriado(domingoDePascoa.Day, "Páscoa"));
            if ((Mes)carnaval.Month == mes) feriados.Add(new Feriado(carnaval.Day, "Carnaval"));
            if ((Mes)sextaFeiraSanta.Month == mes) feriados.Add(new Feriado(sextaFeiraSanta.Day, "Sexta Feira Santa"));
            if ((Mes)corpusChristi.Month == mes) feriados.Add(new Feriado(corpusChristi.Day, "Corpus Christi"));

            // ⚡ Aqui foi a única mudança real: ordenar os feriados pelo dia
            feriados.Sort();

            return feriados;
        }

        private DateTime DomingoDePascoa()
        {
            int X = 24, Y = 5, a, b, c, d, g, dia, mes;

            if (ano <= 1699) { X = 22; Y = 2; }
            else if (ano <= 1799) { X = 23; Y = 3; }
            else if (ano <= 1899) { X = 24; Y = 4; }
            else if (ano <= 2099) { X = 24; Y = 5; }
            else if (ano <= 2199) { X = 24; Y = 6; }
            else if (ano <= 2299) { X = 24; Y = 7; }

            a = ano % 19;
            b = ano % 4;
            c = ano % 7;
            d = (19 * a + X) % 30;
            g = (2 * b + 4 * c + 6 * d + Y) % 7;

            if ((d + g) > 9)
            {
                dia = d + g - 9;
                mes = 4;
            }
            else
            {
                dia = d + g + 22;
                mes = 3;
            }

            return new DateTime(ano, mes, dia);
        }
    }
}
