
namespace AutoCheck.ConsoleApp.Models
{
    public class Carro : Veiculo
    {
        public int QuantidadeDePortas { get; set; }

        public Carro(string marca, string modelo, int ano, int quilometragem, int quantidadeDePortas)
            : base(marca, modelo, ano, quilometragem)
        {
            this.QuantidadeDePortas = quantidadeDePortas;
        }

        public override List<string> ObterChecklistObrigatorio()
        {
            var checklist = base.ObterChecklistObrigatorio();
            checklist.Add("Estepe e Macaco");
            checklist.Add("Triângulo de Sinalização");
            checklist.Add("Ar Condicionado Funcional");
            return checklist;
        }
        
    }
}