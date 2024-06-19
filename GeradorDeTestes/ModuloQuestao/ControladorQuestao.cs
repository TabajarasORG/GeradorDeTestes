using eAgenda.WinApp.Compartilhado;
using GeradorDeTestes.ModuloDisciplina;
using GeradorDeTestes.ModuloMateria;

namespace GeradorDeTestes.ModuloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        private RepositorioQuestao repositorioQuestao;
        private TabelaQuestaoControl tabelaQuestao;
        private RepositorioMateria repositorioMateria;

        public ControladorQuestao(RepositorioQuestao repositorio, RepositorioMateria repositorioMateria)
        {
            this.repositorioQuestao = repositorio;
            this.repositorioMateria = repositorioMateria;
        }
        public override string TipoCadastro => "Questões";

        public override string ToolTipAdicionar => "Cadastrar um nova QUESTÃO";

        public override string ToolTipEditar => "Editar uma QUESTÃO existente";

        public override string ToolTipExcluir => "Excluir uma QUESTÃO existente";


        public override void Adicionar()
        {
            TelaQuestaoForm telaQuestao = new TelaQuestaoForm(/*repositorioQuestao.SelecionarTodos()*/);

            List<Materia> materias = repositorioMateria.SelecionarTodos();

            telaQuestao.CarregarMaterias(materias);

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

            List<Materia> materias = repositorioMateria.SelecionarTodos();

            telaQuestao.CarregarMaterias(materias);

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
