namespace GeradorDeTestes.ModuloQuestao
{
    public class Alternativas
    {

        public List<string> AlternativasErradas { get; set; }
        public List<string> Resposta {  get; set; }

        public Alternativas(List<string> alternativasErradas, List<string> resposta)
        {
            this.AlternativasErradas = alternativasErradas;
            Resposta = resposta;
        }
    }
}
