namespace GeradorDeTestes.ModuloDisciplina
{
    public partial class TelaDisciplinaForm : Form
    {
        private Disciplina disciplina;

        public Disciplina Disciplina
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
            }
            get
            {
                return disciplina;
            }
        }
        public TelaDisciplinaForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            disciplina = new Disciplina(nome);

            List<string> erros = disciplina.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
