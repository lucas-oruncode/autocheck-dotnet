
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

        public string ClassificarVeiculo(double percentualAprovacao)
        {
            if (percentualAprovacao >= 90)
            {
                return "Aprovado com Excelência";
            }
            else if (percentualAprovacao < 60)
            {
                return "Reprovado na Vistoria";
            }
            else
            {
                return "Aprovado com Apontamentos";
            }
        }

        public List<ItemVistoria> ObterItensCriticos(Veiculo veiculo)
        {
            List<ItemVistoria> itensCriticos = new List<ItemVistoria>();

            foreach (var item in veiculo.VistoriaRealizada)
            {
                if (item.Status == "Ruim")
                {
                    itensCriticos.Add(item);
                }
            }

            return itensCriticos;
        }

        public List<ItemVistoria> ObterItensAtencao(Veiculo veiculo)
        {
            List<ItemVistoria> itensAtencao = new List<ItemVistoria>();

            foreach (var item in veiculo.VistoriaRealizada)
            {
                if (item.Status == "Regular")
                {
                    itensAtencao.Add(item);
                }
            }

            return itensAtencao;
        }

        public string GerarRecomendacao(ItemVistoria item)
        {
            if (item.Status == "Ruim")
            {
                return $"{item.Nome}: reparo/troca obrigatório antes da liberação.";
            }

            return $"{item.Nome}: revisão preventiva recomendada.";
        }
    }
}