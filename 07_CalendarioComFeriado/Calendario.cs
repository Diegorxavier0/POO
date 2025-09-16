using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_CalendarioComFeriado
{
    internal class Calendario
    {
        // Variáveis privadas da classe
        private int ano;                       // Armazena o ano do calendário
        private int mes;                       // Armazena o mês do calendário
        private DateTime primeiroDiaMes;       // Representa o primeiro dia do mês
        private int[,] calendario;             // Matriz 6x7 para armazenar os dias (6 semanas, 7 dias por semana)

        // Construtor: recebe o ano e mês como parâmetros
        public Calendario(int ano, int mes)
        {
            this.ano = ano;                    // Salva o ano informado
            this.mes = mes;                    // Salva o mês informado
            primeiroDiaMes = new DateTime(ano, mes, 1);  // Define o primeiro dia do mês
            calendario = new int[6, 7];        // Cria a matriz do calendário (máx. 6 semanas em um mês)
            gerarCalendario();                 // Chama o método que preenche a matriz com os dias
        }

        // Método que gera o calendário (preenche a matriz com os dias do mês)
        private void gerarCalendario()
        {
            int diasDoMes = DateTime.DaysInMonth(ano, mes);  // Quantidade de dias no mês
            int diaSemanaInicio = (int)primeiroDiaMes.DayOfWeek; // Qual dia da semana começa (0 = domingo, 1 = segunda, etc.)
            int dia = 1;  // Começa com o primeiro dia do mês

            // Preenche a matriz do calendário
            for (int semana = 0; semana < 6; semana++) // Percorre até 6 semanas
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++) // Percorre os 7 dias da semana
                {
                    // Se estamos na primeira semana e ainda não chegou no dia que começa o mês → coloca vazio (0)
                    if (semana == 0 && diaSemana < diaSemanaInicio)
                    {
                        calendario[semana, diaSemana] = 0;
                    }
                    // Caso ainda tenha dias válidos no mês → coloca o número do dia
                    else if (dia <= diasDoMes)
                    {
                        calendario[semana, diaSemana] = dia;
                        dia++; // Avança para o próximo dia
                    }
                }
            }
        }

        // Método que imprime o calendário formatado no console
        public void ImprimirCalendario()
        {
            Console.WriteLine($"\nCalendário de " +
                                $"{primeiroDiaMes.ToString("MMMM")} de {ano}");

            // Cabeçalho com os dias da semana
            Console.WriteLine("DOM\tSEG\tTER\tQUA\tQUI\tSEX\tSAB");

            // Recupera os feriados do mês atual
            Feriado[] diasFeriados = RetornaFeriados();
            //bool ehFeriado;

            // Impressão do calendário
            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if (calendario[semana, diaSemana] != 0) // Só imprime se houver um dia válido
                    {
                       /* ehFeriado = false;

                        // Verifica se o dia é feriado
                        for (int posicaoFeriados = 0; posicaoFeriados < diasFeriados.Length; posicaoFeriados++)
                        {
                            if (diasFeriados[posicaoFeriados] != null &&
                                diasFeriados[posicaoFeriados].Dia == calendario[semana, diaSemana])
                            {
                                ehFeriado = true;
                                break; // Achou, não precisa continuar procurando
                            }
                        }*/

                        // Se for feriado ou domingo → pinta em vermelho
                       // if (ehFeriado || diaSemana == 0)
                        if (diasFeriados.Any( feriado => feriado != null && feriado.Dia== calendario[semana,diaSemana])||
                            diaSemana == 0) 
                            Console.ForegroundColor = ConsoleColor.Red;

                        // Imprime o número do dia com 2 dígitos (01, 02, ...)
                        Console.Write(calendario[semana, diaSemana].ToString("D2") + "\t");

                        // Reseta a cor para não afetar os próximos dias
                        Console.ResetColor();
                    }
                    else
                    {
                        // Espaço em branco para dias que não existem no calendário
                        Console.Write("\t");
                    }
                }
                Console.WriteLine(); // Quebra de linha no final da semana
            }

            // Impressão da lista de feriados
            Console.Write("\nFeriados: ");
            foreach (Feriado diaFeriado in diasFeriados)
            {
                if (diaFeriado != null)
                    Console.Write($"{diaFeriado.Dia:D2}-{diaFeriado.Descricao} \t");
            }
        }

        // Retorna os feriados de um determinado mês do ano
        private Feriado[] RetornaFeriados()
        {
            Feriado[] feriados = new Feriado[15]; // Vetor para armazenar até 15 feriados
            int indice = 0;

            // Feriados fixos (datas que não mudam)
            if (mes == 1) feriados[indice++] = new Feriado(1, "Confraternização Universal");
            else if (mes == 4)
            {
                feriados[indice++] = new Feriado(4, "Aniversário da Cidade");
                feriados[indice++] = new Feriado(21, "Tiradentes");
            }
            else if (mes == 5) feriados[indice++] = new Feriado(1, "Dia do Trabalho");
            else if (mes == 7) feriados[indice++] = new Feriado(9, "Revolução Constitucionalista de SP");
            else if (mes == 9) feriados[indice++] = new Feriado(7, "Independência do Brasil");
            else if (mes == 10) feriados[indice++] = new Feriado(12, "Nossa Senhora Aparecida");
            else if (mes == 11)
            {
                feriados[indice++] = new Feriado(2, "Finados");
                feriados[indice++] = new Feriado(15, "Proclamação da Republica");
                feriados[indice++] = new Feriado(20, "Consciência Negra");
            }
            else if (mes == 12)
            {
                feriados[indice++] = new Feriado(8, "Padroeira da Cidade");
                feriados[indice++] = new Feriado(25, "Natal");
            }

            // Feriados móveis (dependem da data da Páscoa)
            DateTime domingoDePascoa = DomingoDePascoa();
            DateTime carnaval = domingoDePascoa.AddDays(-47);
            DateTime sextaFeiraSanta = domingoDePascoa.AddDays(-2);
            DateTime CorpuChrist = domingoDePascoa.AddDays(60);

            if (domingoDePascoa.Month == mes)
                feriados[indice++] = new Feriado(domingoDePascoa.Day, "Páscoa");

            if (carnaval.Month == mes)
                feriados[indice++] = new Feriado(carnaval.Day, "Carnaval");

            if (sextaFeiraSanta.Month == mes)
                feriados[indice++] = new Feriado(sextaFeiraSanta.Day, "Sexta Feira Santa");

            if (CorpuChrist.Month == mes)
                feriados[indice++] = new Feriado(CorpuChrist.Day, "Corpus Christi");

            return feriados;
        }

        // Algoritmo para calcular a data do Domingo de Páscoa
        private DateTime DomingoDePascoa()
        {
            DateTime domingoDePascoa;
            int X = 0, Y = 0, a, b, c, d, g, dia, mes;

            // Ajustes de acordo com a faixa de ano
            if (ano <= 1699) { X = 22; Y = 2; }
            else if (ano <= 1799) { X = 23; Y = 3; }
            else if (ano <= 1899) { X = 24; Y = 4; }
            else if (ano <= 2099) { X = 24; Y = 5; }
            else if (ano <= 2199) { X = 24; Y = 6; }
            else if (ano <= 2299) { X = 24; Y = 7; }

            // Cálculo matemático para determinar a data da Páscoa
            a = ano % 19;
            b = ano % 4;
            c = ano % 7;
            d = (19 * a + X) % 30;
            g = (2 * b + 4 * c + 6 * d + Y) % 7;

            if ((d + g) > 9)
            {
                dia = (d + g - 9);
                mes = 4; // Abril
            }
            else
            {
                dia = (d + g + 22);
                mes = 3; // Março
            }

            domingoDePascoa = new DateTime(ano, mes, dia);
            return domingoDePascoa;
        }
    }
}
