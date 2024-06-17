using GeradorDeTestes.ModuloDisciplina;
using GeradorDeTestes.ModuloMateria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.ModuloTeste
{
    public partial class TelaTesteForm : Form
    {
        private Teste teste;
        public Teste Teste
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtTitulo.Text = value.Titulo;
                cmbDisciplina.Text = value.Disciplina.ToString();
                cmbMateria.Text = value.Materia.ToString();
                numQtdQuestoes.Value = value.QuantidadeQuestoes;
            }

            get { return teste; }
        }


        public TelaTesteForm()
        {
            InitializeComponent();
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

            foreach (Materia materia in materias)
            {
                cmbMateria.Items.Add(materia);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            Disciplina disciplina = (Disciplina)cmbDisciplina.SelectedItem;
            Materia materia = (Materia)cmbMateria.SelectedItem;
            int qtdQuestoes = (int)numQtdQuestoes.Value;



            teste = new Teste(titulo,disciplina,materia, qtdQuestoes);
        }

       
    }
}
