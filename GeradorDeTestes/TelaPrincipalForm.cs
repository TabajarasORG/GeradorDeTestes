using eAgenda.WinApp.Compartilhado;
using GeradorDeTestes.Compartilhado;
using GeradorDeTestes.ModuloDisciplina;
using GeradorDeTestes.ModuloMateria;
using GeradorDeTestes.ModuloQuestao;
using GeradorDeTestes.ModuloTeste;

namespace GeradorDeTestes
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;

        RepositorioDisciplina repositorioDisciplina;
        RepositorioMateria repositorioMateria;
        RepositorioQuestao repositorioQuestao;
        RepositorioTeste repositorioTeste;

        public static TelaPrincipalForm Instancia { get; private set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();
            lblTipoCadastro.Text = string.Empty;

            Instancia = this;

            repositorioDisciplina = new RepositorioDisciplina();
            repositorioMateria = new RepositorioMateria();
            repositorioQuestao = new RepositorioQuestao();
            repositorioTeste = new RepositorioTeste();
        }

        public void AtualizarRodape(string texto)
        {
            statusLabelPrincipal.Text = texto;
        }

        private void disciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDisciplina(repositorioDisciplina, repositorioMateria);

            ConfigurarTelaPrincipal(controlador);
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorMateria(repositorioMateria, repositorioDisciplina);

            ConfigurarTelaPrincipal(controlador);
        }

        private void questõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorQuestao(repositorioQuestao, repositorioMateria);

            ConfigurarTelaPrincipal(controlador);
        }

        private void testesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTeste(repositorioTeste, repositorioMateria, repositorioDisciplina, repositorioQuestao);

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
        private void btnDuplicar_Click(object sender, EventArgs e)
        {
            if(controlador is IControladorDuplicar controladorDuplicar)
                controladorDuplicar.DuplicarTeste();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if(controlador is IControladorVisualizar controladorVisualizar)
                controladorVisualizar.VisualizarTeste();
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

            btnDuplicar.Enabled = controladorSelecionado is IControladorDuplicar;
            btnVisualizar.Enabled = controladorSelecionado is IControladorVisualizar;

            ConfigurarToolTips(controladorSelecionado);
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;

            if (controladorSelecionado is IControladorDuplicar controladorDuplicar)
                btnDuplicar.ToolTipText = controladorDuplicar.ToolTipDuplicarTeste;

            if (controladorSelecionado is IControladorVisualizar controladorVisualizar)
                btnVisualizar.ToolTipText = controladorVisualizar.ToolTipVisualizarTeste;
        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemObjeto = controladorSelecionado.ObterListagem();
            listagemObjeto.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemObjeto);

        }

    }
