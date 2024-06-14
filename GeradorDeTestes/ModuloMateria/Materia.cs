using eAgenda.ConsoleApp.Compartilhado;
using GeradorDeTestes.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.ModuloMateria
{
    public class Materia : EntidadeBase
    {

        public string Nome {  get; set; }
        public Disciplina Disciplina {  get; set; }
        public string Serie { get; set; }


        public Materia(string nome,Disciplina disciplina, string serie)
        {
            Nome = nome;
            Disciplina = disciplina;
            Serie = serie;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (string.IsNullOrEmpty(Serie.Trim()))
                erros.Add("O campo \"serie\" é obrigatório");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Materia materia = (Materia)novoRegistro;

            Nome= materia.Nome;
            Disciplina = materia.Disciplina;
            Serie = materia.Serie;
        }

        public override string ToString()
        {
            return $"{Nome}, {Serie}";
        }

    }
}
