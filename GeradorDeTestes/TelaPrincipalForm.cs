using eAgenda.WinApp.Compartilhado;
using GeradorDeTestes.ModuloDisciplina;
using GeradorDeTestes.ModuloMateria;
using GeradorDeTestes.ModuloQuestao;

namespace GeradorDeTestes
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;

        RepositorioDisciplina repositorioDisciplina;
        RepositorioMateria repositorioMateria;
        RepositorioQuestao repositorioQuestao;

        public static TelaPrincipalForm Instancia { get; private set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();
            lblTipoCadastro.Text = string.Empty;

            Instancia = this;

            repositorioDisciplina = new RepositorioDisciplina();
            repositorioMateria = new RepositorioMateria();
            repositorioQuestao = new RepositorioQuestao();
            CadastrarRegistrosTeste();
        }

        public void AtualizarRodape(string texto)
        {
            statusLabelPrincipal.Text = texto;
        }

        private void disciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDisciplina(repositorioDisciplina);

            ConfigurarTelaPrincipal(controlador);
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorMateria(repositorioMateria,repositorioDisciplina);

            ConfigurarTelaPrincipal(controlador);
        }

        private void questõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorQuestao(repositorioQuestao);

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            lblTipoCadastro.Text = "Cadastro de " + controladorSelecionado.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is ControladorBase;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;

            ConfigurarToolTips(controladorSelecionado);
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;
        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemObjeto = controladorSelecionado.ObterListagem();
            listagemObjeto.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemObjeto);
        }

        private void CadastrarRegistrosTeste()
        {

            List<Disciplina> disciplinas = new List<Disciplina>()
            {
                new("Matematica"),
                new("Português"),
                new("Geografia")
            };
            repositorioDisciplina.CadastrarVarios(disciplinas);
        }

    }
}
