using GeradorDeTestes.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GeradorDeTestes.ModuloQuestao
{
    public partial class TelaQuestaoForm : Form
    {
        private Questao questao;

        private List<Questao> questoes;

        public Questao Questao
        {
            set
            {
                cmbMateria.SelectedItem = value.Materia.ToString();
                txtEnunciado.Text = value.Enunciado;
                txtResposta.Text = value.Alternativas.Resposta.ToString();
            }
            get
            {
                return questao;
            }
        }

        public TelaQuestaoForm()
        {
            InitializeComponent();
        }

        public Char letra = 'A';

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string materia = cmbMateria.Text;
            string enunciado = txtEnunciado.Text;

            List<string> alternativasErradas = [];
            string[] separador = [];
            List<string> respostas = [];

            
            foreach (string s in clbAlternativas.Items)
            {
                separador = s.Split("> ");

                foreach (string i in clbAlternativas.CheckedItems)
                {
                    if (i == s)
                        respostas.Add(separador[1]);

                    else
                        alternativasErradas.Add(separador[1]);
                } 
            }
            Alternativas alternativas = new(alternativasErradas, respostas);
            
            questao = new Questao(materia, enunciado, alternativas);

            //como fazer um if que verifica se tem itens estão marcados em um checklistbox
            List<string> erros = Questao.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (clbAlternativas.Items.Count == 0)
                letra = 'A';

            if (clbAlternativas.Items.Count == 5)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação pois o limite de questões já foi atingido.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            else
            {
                string resposta = ($"({letra}) -> {txtResposta.Text}");
                clbAlternativas.Items.Add(resposta);
                letra++;
            }
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {
            var slecionaItens = new List<object>();

            foreach (var item in clbAlternativas.CheckedItems)
            {
                slecionaItens.Add(item);
            }

            foreach (var item in slecionaItens)
            {
                clbAlternativas.Items.Remove(item);
            }

            //if (clbAlternativas.CheckedItems)
                ReordenarAlternativas();
        }

        private void ReordenarAlternativas()
        {
            var itensTeporarios = new List<string>();

            foreach (var item in clbAlternativas.Items)
            {
                itensTeporarios.Add(item.ToString());
            }

            clbAlternativas.Items.Clear();

            letra = 'A';
            foreach (var item in itensTeporarios)
            {
                string resposta = $"({letra}) ->{item.Substring(6)}";
                clbAlternativas.Items.Add(resposta);
                letra++;
            }
        }


    }
}
