using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.Compartilhado;
using GeradorDeTestes.ModuloMateria;

namespace GeradorDeTestes.ModuloDisciplina
{
    public class Disciplina : EntidadeBase
    {

        public string Nome { get; set; }

        public List<Materia> Materias { get; set; }

        public Disciplina(string nome)
        {
            Nome = nome;
            Materias = new List<Materia>();
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Disciplina disciplina = (Disciplina)novoRegistro;

            Nome = disciplina.Nome;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");
            
            return erros;
        }

        public bool ExisteDisciplina(List<Disciplina> disciplinas)
        {
            var disciplina = disciplinas.Where(d => d.Nome == Nome).FirstOrDefault();
            
            return disciplina != null;
        }

        public override string ToString()
        {
            return Nome.ToTitleCase();
        }
    }
}
