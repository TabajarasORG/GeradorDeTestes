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
        private Teste teste;

        public Teste Teste 
        { 
            get 
            { 
                return teste; 
            }
            set
            {
                this.teste = value;
            }
        }
        public TelaVisualizarTesteForm(Teste testeSelecionado)
        {
            InitializeComponent();

            Teste = testeSelecionado;

            lblTitulo.Text = testeSelecionado.Titulo;
            lblDisciplina.Text = testeSelecionado.Disciplina.Nome;
            lblMateria.Text = testeSelecionado.Materia.Nome;
            //foreach (var questao in testeSelecionado.)
            //{
            //    listQuestoes.Items.Add(questao.Texto);
            //}
        }
    }
}
