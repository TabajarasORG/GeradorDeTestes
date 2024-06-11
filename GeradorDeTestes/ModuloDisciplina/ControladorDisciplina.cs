using eAgenda.WinApp.Compartilhado;
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

        public ControladorDisciplina(RepositorioDisciplina repositorio)
        {
            this.repositorioDisciplina = repositorio;
        }

        public override string TipoCadastro { get { return "Disciplina"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um nova disciplina"; } }

        public override string ToolTipEditar { get { return "Editar uma disciplina existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma disciplina existente"; } }

        public override void Adicionar()
        {
            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm();

            DialogResult resultado = telaDisciplina.ShowDialog();

            //fazer o if em direção ao erro(ou seja em caso de erro)
            if (resultado != DialogResult.OK)
                return;

            Disciplina novaDisciplina = telaDisciplina.Disciplina;


            repositorioDisciplina.Cadastrar(novaDisciplina);

            CarregarItens();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro\"{novaDisciplina.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm();

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

            CarregarItens();

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

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{disciplinaSelecionada.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioDisciplina.Excluir(disciplinaSelecionada.Id);

            CarregarItens();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro\"{disciplinaSelecionada.Nome}\" foi excluído com sucesso!");
        }

        private void CarregarItens()
        {
            List<Disciplina> itens = repositorioDisciplina.SelecionarTodos();

            tabelaDisciplina.AtualizarRegistros(itens);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaDisciplina == null)
                tabelaDisciplina = new TabelaDisciplinaControl();

            CarregarItens();

            return tabelaDisciplina;
        }
    }
}
