using eAgenda.ConsoleApp.Compartilhado;
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
        public string Disciplina {  get; set; }
        public string Serie { get; set; }


        public Materia(string nome,string disciplina, string serie)
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
            Serie = materia.Serie;
        }

        public override string ToString()
        {
            return $"id: {Id}, Nome: {Nome}, Serie: {Serie}";
        }

    }
}
