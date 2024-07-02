﻿using eAgenda.ConsoleApp.Compartilhado;
using GeradorDeTestes.ModuloMateria;

namespace GeradorDeTestes.ModuloQuestao
{
    public class Questao : EntidadeBase
    {

        public Materia Materia { get; set; }
        public string Enunciado { get; set; }
        public List<Alternativa> Alternativas { get; set; }

        public Questao(Materia materia, string enunciado, List<Alternativa> alternativas)
        {
            Materia = materia;
            Enunciado = enunciado;
            Alternativas = alternativas;
        }

        public Questao()
        {
            
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

            if (Materia == null)
                erros.Add("O campo \"nome\" é obrigatório");


            return erros;
        }

        public override string ToString()
        {
            return $"{Enunciado}";
        }
    }
}
