using GeradorDeTestes.ModuloDisciplina;
using GeradorDeTestes.ModuloMateria;
using GeradorDeTestes.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.ModuloTeste
{
    public partial class TelaTesteForm : Form
    {
        private Teste teste;

        private List<Teste> testes;

        private int? idSelecionado;

        public List<Materia> copiaMaterias { get; set; }

        public List<Questao> copiaQuestoes { get; set; }

        public Teste Teste
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtTitulo.Text = value.Titulo;
                cmbDisciplina.Text = value.Disciplina.ToString();
                cmbMateria.Text = value.Materia.ToString();
                numQtdQuestoes.Value = value.QuantidadeQuestoes;
                numQtdQuestoes.Maximum = numQtdQuestoes.Maximum;
            }

            get { return teste; }
        }


        public TelaTesteForm(List<Teste> testes, int? idSelecionado = null)
        {
            InitializeComponent();
            numQtdQuestoes.Maximum = 0;
            this.testes = testes;
            this.idSelecionado = idSelecionado;
        }

        public void CarregarDisciplina(List<Disciplina> disciplinas)
        {
            cmbDisciplina.Items.Clear();

            foreach (Disciplina disciplina in disciplinas)
            {
                cmbDisciplina.Items.Add(disciplina);
            }
        }

        public void CarregarMateria(List<Materia> materias)
        {
            cmbMateria.Items.Clear();

            copiaMaterias = materias;
        }

        public void CarregarQuestao(List<Questao> questoes)
        {
            copiaQuestoes = questoes;
        }

        public List<Questao> questoes = new List<Questao>();

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            Disciplina disciplina = (Disciplina)cmbDisciplina.SelectedItem;
            Materia materia = (Materia)cmbMateria.SelectedItem;
            int qtdQuestoes = (int)numQtdQuestoes.Value;

            teste = new Teste(titulo, disciplina, materia, qtdQuestoes, questoes);

            List<string> erros = teste.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

            if (teste.ExisteTeste(testes, idSelecionado))
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Já existe uma disciplina com esse nome!");

                DialogResult = DialogResult.None;
            }
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            listQuestoes.Items.Clear();
            Materia materia = (Materia)cmbMateria.SelectedItem;
            var Aleatorio = new Random();
            var questoesAleatorias = new List<Questao>();

            if (checkRecuperacao.Checked)
            {
                Disciplina disciplina = (Disciplina)cmbDisciplina.SelectedItem;
                questoesAleatorias = copiaQuestoes
                    .Where(q => q.Materia != null && q.Materia.Disciplina != null && q.Materia.Disciplina.Id == disciplina.Id)
                    .OrderBy(q => Aleatorio.Next())
                    .ToList();
            }
            else
            {
                questoesAleatorias = copiaQuestoes.Where(q => q.Materia != null && q.Materia.Id == materia.Id).OrderBy(q => Aleatorio.Next()).ToList();
            }


            for (int i = 0; i < (int)numQtdQuestoes.Value; i++)
            {
                listQuestoes.Items.Add(questoesAleatorias[i]);
                questoes.Add(questoesAleatorias[i]);
            }
        }

        private void cmbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            listQuestoes.Items.Clear();
            cmbMateria.Items.Clear();
            cmbMateria.Text = "";
            Disciplina disciplina = (Disciplina)cmbDisciplina.SelectedItem;

            foreach (Materia materia in copiaMaterias)
            {
                if (materia.Disciplina != null && materia.Disciplina.Id == disciplina.Id)
                {
                    cmbMateria.Items.Add(materia);
                }
            }
        }

        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Materia materia = (Materia)cmbMateria.SelectedItem;
            var questoesFiltradas = copiaQuestoes.Where(q => q.Materia != null && q.Materia.Id == materia.Id).ToList();
            numQtdQuestoes.Maximum = questoesFiltradas.Count;
        }

        private void checkRecuperacao_CheckedChanged(object sender, EventArgs e)
        {
            listQuestoes.Items.Clear();
            var questoesFiltradas = new List<Questao>();
            if (checkRecuperacao.Checked)
            {
                Disciplina disciplina = (Disciplina)cmbDisciplina.SelectedItem;
                questoesFiltradas = copiaQuestoes
                    .Where(q => q.Materia != null && q.Materia.Disciplina != null && q.Materia.Disciplina.Id == disciplina.Id).ToList();
            }
            else
            {
                Materia materia = (Materia)cmbMateria.SelectedItem;
                questoesFiltradas = copiaQuestoes.Where(q => q.Materia != null && q.Materia.Id == materia.Id).ToList();
            }
            numQtdQuestoes.Maximum = questoesFiltradas.Count;
        }
    }
}
