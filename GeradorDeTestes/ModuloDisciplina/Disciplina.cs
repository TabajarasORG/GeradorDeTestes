﻿using eAgenda.ConsoleApp.Compartilhado;
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

        public Disciplina()
        {
            
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
            foreach (Disciplina d in disciplinas)
                if (d.Nome == Nome)
                    return true;

            return false;
        }

        public override string ToString()
        {
            return Nome.ToTitleCase();
        }
    }
}
