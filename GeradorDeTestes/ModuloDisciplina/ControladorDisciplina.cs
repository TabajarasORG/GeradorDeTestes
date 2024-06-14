using eAgenda.WinApp.Compartilhado;
using GeradorDeTestes.ModuloMateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.ModuloDisciplina
{
    internal class ControladorDisciplina : ControladorBase
    {
        private RepositorioDisciplina repositorioDisciplina;
        private TabelaDisciplinaControl tabelaDisciplina;
        private RepositorioMateria repositorioMateria;

        public ControladorDisciplina(RepositorioDisciplina repositorio, RepositorioMateria repositorioMateria)
        {
            this.repositorioDisciplina = repositorio;
            this.repositorioMateria = repositorioMateria;
        }

        public override string TipoCadastro { get { return "Disciplina"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um nova disciplina"; } }

        public override string ToolTipEditar { get { return "Editar uma disciplina existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma disciplina existente"; } }

        public override void Adicionar()
        {
            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm(repositorioDisciplina.SelecionarTodos());

            DialogResult resultado = telaDisciplina.ShowDialog();

            //fazer o if em direção ao erro(ou seja em caso de erro)
            if (resultado != DialogResult.OK)
                return;

            Disciplina novaDisciplina = telaDisciplina.Disciplina;


            repositorioDisciplina.Cadastrar(novaDisciplina);

            CarregarDisciplinas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro\"{novaDisciplina.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm(repositorioDisciplina.SelecionarTodos());

            int idSelecionado = tabelaDisciplina.ObterRegistroSelecionado();

            Disciplina disciplinaSelecionada =
                repositorioDisciplina.SelecionarPorId(idSelecionado);

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaDisciplina.Disciplina = disciplinaSelecionada;

            DialogResult resultado = telaDisciplina.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Disciplina disciplinaEditada = telaDisciplina.Disciplina;

            repositorioDisciplina.Editar(disciplinaSelecionada.Id, disciplinaEditada);

            CarregarDisciplinas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro\"{disciplinaEditada.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaDisciplina.ObterRegistroSelecionado();

            Disciplina disciplinaSelecionada =
                repositorioDisciplina.SelecionarPorId(idSelecionado);

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (disciplinaSelecionada.Materias.Count > 0)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação com uma materia vinculada a disciplina.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{disciplinaSelecionada.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioDisciplina.Excluir(disciplinaSelecionada.Id);

            CarregarDisciplinas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro\"{disciplinaSelecionada.Nome}\" foi excluído com sucesso!");
        }

        

        private void CarregarDisciplinas()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();

            tabelaDisciplina.AtualizarRegistros(disciplinas);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaDisciplina == null)
                tabelaDisciplina = new TabelaDisciplinaControl();

            CarregarDisciplinas();

            return tabelaDisciplina;
        }
    }
}
