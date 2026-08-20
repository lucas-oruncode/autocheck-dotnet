
using AutoCheck.ConsoleApp.Models;

namespace AutoCheck.ConsoleApp.Services
{
    public class MotorVistoria
    {
        public int ConverterStatusEmPontos(string status)
        {
            switch (status)
            {
                case "Bom":
                    return 10;
                case "Regular":
                    return 5;
                default:
                    return 0;
            }
        }

        public int CalcularPontuacaoObtida(Veiculo veiculo)
        {
            int pontuacaoObtida = 0;

            foreach (var item in veiculo.VistoriaRealizada)
            {
                pontuacaoObtida += ConverterStatusEmPontos(item.Status);
            }

            return pontuacaoObtida;
        }

        public int CalcularPontuacaoMaxima(Veiculo veiculo)
        {
            return veiculo.VistoriaRealizada.Count * 10;
        }

        public double CalcularPercentualAprovacao(int pontuacaoObtida, int pontuacaoMaxima)
        {
            return ((double)pontuacaoObtida / pontuacaoMaxima) * 100;
        }


    }
}