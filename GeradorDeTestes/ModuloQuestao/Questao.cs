using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.Compartilhado;
using GeradorDeTestes.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.ModuloQuestao
{
    public class Questao : EntidadeBase
    {

        public /*Materia*/string Materia { get; set; }
        public string Enunciado { get; set; }
        public List<Alternativa> Alternativas { get; set; }

        public Questao(string materia, string enunciado, List<Alternativa> alternativas)
        {
            Materia = materia;
            Enunciado = enunciado;
            Alternativas = alternativas;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Questao questao = (Questao)novoRegistro;

            Materia = questao.Materia;
            Enunciado = questao.Enunciado;
            Alternativas = questao.Alternativas;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            //if (Materia == null)
            //    erros.Add("O campo \"nome\" é obrigatório");

            return erros;
        }

        public override string ToString()
        {
            return Materia.ToTitleCase();
        }
    }
}
