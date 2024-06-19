using eAgenda.WinApp.Compartilhado;
using GeradorDeTestes.Compartilhado;
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
    public class ControladorTeste : ControladorBase, IControladorDuplicar, IControladorVisualizar
    {
        private RepositorioTeste repositorio;
        private TabelaTeste tabelaTeste;
        private RepositorioDisciplina repositorioDisciplina;
        private RepositorioMateria repositorioMateria;
        private RepositorioQuestao repositorioQuestao;
        
        public ControladorTeste (RepositorioTeste repositorio,RepositorioMateria repositorioMateria,RepositorioDisciplina repositorioDisciplina, RepositorioQuestao repositorioQuestao)
        {
            this.repositorio = repositorio;
            this.repositorioMateria = repositorioMateria; 
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioQuestao = repositorioQuestao;
        }


        public override string TipoCadastro => "Teste";

        public override string ToolTipAdicionar => "Cadastrar novo TESTE";

        public override string ToolTipEditar => "Editar um TESTE";

        public override string ToolTipExcluir => "Excluir um TESTE";

        public string ToolTipDuplicarTeste => "Duplicar um TESTE";

        public string ToolTipVisualizarTeste => "Visualizar um TESTE";

        public override void Adicionar()
        {
            TelaTesteForm telaTeste = new TelaTesteForm(repositorio.SelecionarTodos());

            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            List<Materia> materias = repositorioMateria.SelecionarTodos();
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            telaTeste.CarregarDisciplina(disciplinas);
            telaTeste.CarregarMateria(materias);
            telaTeste.CarregarQuestao(questoes);

            DialogResult resultado = telaTeste.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Teste novoTeste = telaTeste.Teste;

            repositorio.Cadastrar(novoTeste);

            CarregarTeste();
        }

        public override void Editar()
        {
            int idSelecionado = tabelaTeste.ObterRegistroSelecionado();

            TelaTesteForm telaTeste = new TelaTesteForm(repositorio.SelecionarTodos(), idSelecionado);

            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            List<Materia> materias = repositorioMateria.SelecionarTodos();
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            telaTeste.CarregarDisciplina(disciplinas);
            telaTeste.CarregarMateria(materias);
            telaTeste.CarregarQuestao(questoes);


            if (idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um registro",
                   "Atenção",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                   );
                return;
            }

            telaTeste.Teste = repositorio.SelecionarPorId(idSelecionado);

            DialogResult resultado = telaTeste.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Teste testeEditado = telaTeste.Teste;

            repositorio.Editar(idSelecionado, testeEditado);

            CarregarTeste();
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaTeste.ObterRegistroSelecionado();
            Teste testeSelecionado = repositorio.SelecionarPorId(idSelecionado);

            if (idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um registro",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                return;
            }

            DialogResult resposta = MessageBox.Show(
             $"Você deseja realmente excluir o registro \"{testeSelecionado.Titulo}\"?",
             "Confirmar Exclusão",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning
         );

            if (resposta != DialogResult.Yes)
                return;

            repositorio.Excluir(testeSelecionado.Id);

            CarregarTeste();

        }

        public void DuplicarTeste()
        {
            int idSelecionado = tabelaTeste.ObterRegistroSelecionado();

            TelaTesteForm telaTeste = new TelaTesteForm(repositorio.SelecionarTodos(), idSelecionado);

            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            List<Materia> materias = repositorioMateria.SelecionarTodos();
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            telaTeste.CarregarDisciplina(disciplinas);
            telaTeste.CarregarMateria(materias);
            telaTeste.CarregarQuestao(questoes);


            if (idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um registro",
                   "Atenção",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                   );
                return;
            }

            telaTeste.Teste = repositorio.SelecionarPorId(idSelecionado);

            DialogResult resultado = telaTeste.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Teste novoTeste = telaTeste.Teste;

            repositorio.Cadastrar(novoTeste);

            CarregarTeste();
        }
        public void VisualizarTeste()
        {
            int idSelecionado = tabelaTeste.ObterRegistroSelecionado();
            Teste testeSelecionado = repositorio.SelecionarPorId(idSelecionado);

            if (testeSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um registro",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                return;
            }

            TelaVisualizarTesteForm telaVisualizarTeste = new TelaVisualizarTesteForm(testeSelecionado);

            DialogResult resultado = telaVisualizarTeste.ShowDialog();

            if(resultado != DialogResult.OK) 
                return;

            //CarregarTeste();
        }

        private void CarregarTeste()
        {
            List<Teste> testes = repositorio.SelecionarTodos();

            tabelaTeste.AtualizarRegistros(testes);
        }

        public override UserControl ObterListagem()
        {
            if(tabelaTeste == null)
                tabelaTeste = new TabelaTeste();

            CarregarTeste();

            return tabelaTeste;
        }

    }
}
