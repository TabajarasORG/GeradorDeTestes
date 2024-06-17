using eAgenda.WinApp.Compartilhado;
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
    public class ControladorTeste : ControladorBase
    {
        private RepositorioTeste repositorio;
        private TabelaTeste tabelaTeste;
        private RepositorioDisciplina repositorioDisciplina;
        private RepositorioMateria repositorioMateria;
        
        public ControladorTeste (RepositorioTeste repositorio,RepositorioMateria repositorioMateria,RepositorioDisciplina repositorioDisciplina)
        {
            this.repositorio = repositorio;
            this.repositorioMateria = repositorioMateria; 
            this.repositorioDisciplina = repositorioDisciplina;
        }


        public override string TipoCadastro => "Teste";

        public override string ToolTipAdicionar => "Cadastrar novo TESTE";

        public override string ToolTipEditar => "Editar um TESTE";

        public override string ToolTipExcluir => "Excluir um TESTE";

        public override void Adicionar()
        {
            TelaTesteForm telaTeste = new();

            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            List<Materia> materias = repositorioMateria.SelecionarTodos();

            telaTeste.CarregarDisciplina(disciplinas);
            telaTeste.CarregarMateria(materias);

            DialogResult resultado = telaTeste.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Teste novoTeste = telaTeste.Teste;

            repositorio.Cadastrar(novoTeste);

            CarregarTeste();
        }

        public override void Editar()
        {
            TelaTesteForm telaTeste = new();

            List<Disciplina> disciplinas = new List<Disciplina>();
            List<Materia> materias = new List<Materia>();

            telaTeste.CarregarDisciplina(disciplinas);
            telaTeste.CarregarMateria(materias);

            int idSelecionado = tabelaTeste.ObterRegistroSelecionado();

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
