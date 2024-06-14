using eAgenda.WinApp.Compartilhado;
using GeradorDeTestes.ModuloDisciplina;

namespace GeradorDeTestes.ModuloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        private RepositorioQuestao repositorioQuestao;
        private TabelaQuestaoControl tabelaQuestao;

        public ControladorQuestao(RepositorioQuestao repositorio)
        {
            this.repositorioQuestao = repositorio;
        }
        public override string TipoCadastro { get { return "Questões"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um nova questão"; } }

        public override string ToolTipEditar { get { return "Editar uma questão existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma questão existente"; } }


        public override void Adicionar()
        {
            TelaQuestaoForm telaQuestao = new TelaQuestaoForm(/*repositorioQuestao.SelecionarTodos()*/);

            DialogResult resultado = telaQuestao.ShowDialog();

            //fazer o if em direção ao erro(ou seja em caso de erro)
            if (resultado != DialogResult.OK)
                return;

            Questao novaQuestao = telaQuestao.Questao;


            repositorioQuestao.Cadastrar(novaQuestao);

            CarregarQuestoes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro\"{novaQuestao.Materia}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaQuestaoForm telaQuestao = new TelaQuestaoForm(/*repositorioQuestao.SelecionarTodos()*/);

            int idSelecionado = tabelaQuestao.ObterRegistroSelecionado();

            Questao questaoSelecionada =
                repositorioQuestao.SelecionarPorId(idSelecionado);



            if (questaoSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaQuestao.Questao = questaoSelecionada;

            DialogResult resultado = telaQuestao.ShowDialog();

            if (resultado != DialogResult.OK)
                return;



            Questao questaoEditada = telaQuestao.Questao;

            repositorioQuestao.Editar(questaoSelecionada.Id, questaoEditada);

            CarregarQuestoes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro\"{questaoEditada.Materia}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaQuestao.ObterRegistroSelecionado();

            Questao questaoSelecionada =
                repositorioQuestao.SelecionarPorId(idSelecionado);

            if (questaoSelecionada == null)
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
                $"Você deseja realmente excluir o registro \"{questaoSelecionada.Materia}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioQuestao.Excluir(questaoSelecionada.Id);

            CarregarQuestoes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro\"{questaoSelecionada.Materia}\" foi excluído com sucesso!");
        }

        private void CarregarQuestoes()
        {
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            tabelaQuestao.AtualizarRegistros(questoes);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaQuestao == null)
                tabelaQuestao = new TabelaQuestaoControl();

            CarregarQuestoes();

            return tabelaQuestao;
        }
    }
}
