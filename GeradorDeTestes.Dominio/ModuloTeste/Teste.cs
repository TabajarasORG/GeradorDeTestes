using eAgenda.ConsoleApp.Compartilhado;
using GeradorDeTestes.ModuloDisciplina;
using GeradorDeTestes.ModuloMateria;
using GeradorDeTestes.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.ModuloTeste
{
    public class Teste : EntidadeBase
    {

        public string Titulo { get; set; }

        public Disciplina Disciplina { get; set; }

        public Materia Materia { get; set; }

        public int QuantidadeQuestoes { get; set; }

        public List<Questao> Questoes { get; set; }

        public Teste(string titulo, Disciplina disciplina, Materia materia, int quantidadeQuestoes, List<Questao> questoes)
        {
            Titulo = titulo;
            Disciplina = disciplina;
            Materia = materia;
            QuantidadeQuestoes = quantidadeQuestoes;
            Questoes = questoes;
        }

        public Teste()
        {
           
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Teste teste = (Teste) novoRegistro;

            Titulo = teste.Titulo;
            Disciplina = teste.Disciplina;
            Materia = teste.Materia;
            QuantidadeQuestoes = teste.QuantidadeQuestoes;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Titulo.Trim()))
                erros.Add("O campo \"titulo\" é obrigatório");
            return erros;
        }

        public bool ExisteTeste(List<Teste> testes, int? id)
        {
            var teste = testes.Where(d => d.Titulo == Titulo && d.Id != id).FirstOrDefault();

            return teste != null;
        }

        public override string ToString()
        {
            return $"{Titulo}, {Disciplina}, {Materia}, {QuantidadeQuestoes}";
        }
    }
}
