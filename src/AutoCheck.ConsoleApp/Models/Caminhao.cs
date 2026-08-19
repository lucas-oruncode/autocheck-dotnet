
namespace AutoCheck.ConsoleApp.Models
{
    public class Caminhao : Veiculo
    {
        public double CapacidadeDeCarga { get; set; }
        public int QuantidadeDeEixos { get; set; }

        public Caminhao(string marca, string modelo, int ano, int quilometragem, double capacidadeDeCarga, int quantidadeDeEixos)
            : base(marca, modelo, ano, quilometragem)
        {
            this.CapacidadeDeCarga = capacidadeDeCarga;
            this.QuantidadeDeEixos = quantidadeDeEixos;
        }

        public override List<string> ObterChecklistObrigatorio()
        {
            var checklist = base.ObterChecklistObrigatorio();
            checklist.Add("Tacógrafo");
            checklist.Add("Sistema de Freios a Ar");
            checklist.Add("Trava e Lona da Caçamba");
            return checklist;
        }        
    }
}