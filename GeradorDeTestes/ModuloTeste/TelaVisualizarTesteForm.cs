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
    public partial class TelaVisualizarTesteForm : Form
    {
        private Teste testeSelecionado;

        public TelaVisualizarTesteForm(Teste testeSelecionado)
        {
            InitializeComponent();

            this.testeSelecionado = testeSelecionado;

            lblTitulo.Text = testeSelecionado.Titulo;
            lblDisciplina.Text = testeSelecionado.Disciplina.Nome;
            lblMateria.Text = testeSelecionado.Materia.Nome;
            CarregarQuestoes(testeSelecionado);
        }

        private void CarregarQuestoes(Teste testeSelecionado)
        {
            foreach (var questao in testeSelecionado.Questoes)
            {
                listQuestoes.Items.Add(questao);
            }
        }
    }
}
