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

                foreach (var item in value.Alternativas)
                {
                    item.Correta = false;
                    clbAlternativas.Items.Add(item);
                }
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
            
            MenosDeDuasAlternativas();
            SemRespostaSelecionada();
            MaisDeUmaResposta();

            if (clbAlternativas.CheckedItems.Count > 0)
            {
                Alternativa alternativa = (Alternativa)clbAlternativas.CheckedItems[0];
                alternativa.Correta = true;
            }

            List<Alternativa> alternativasSelecionadas = clbAlternativas.Items.Cast<Alternativa>().ToList();

            questao = new Questao(materia, enunciado, alternativasSelecionadas);

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
                Alternativa alternativa = new Alternativa(letra, txtResposta.Text);
                clbAlternativas.Items.Add(alternativa);
                letra++;
            }
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (clbAlternativas.SelectedItem != null) 
            {
                clbAlternativas.Items.Remove(clbAlternativas.SelectedItem);
            }

            ReordenarAlternativas();
        }

        private void ReordenarAlternativas()
        {
            var itensTeporarios = new List<Alternativa>();

            foreach (Alternativa item in clbAlternativas.Items)
            {
                itensTeporarios.Add(item);
            }

            clbAlternativas.Items.Clear();

            letra = 'A';
            foreach (var item in itensTeporarios)
            {
                Alternativa alternativa = new Alternativa(letra, txtResposta.Text);
                clbAlternativas.Items.Add(alternativa);
                letra++;
            }
        }

        private void SemRespostaSelecionada()
        {
            if (clbAlternativas.CheckedItems.Count <= 0)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação pois nenhuma alternativa foi definida como resposta.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                DialogResult = DialogResult.None;
                return;
            }
        }

        private void MaisDeUmaResposta()
        {
            if (clbAlternativas.CheckedItems.Count > 1)
            {
                MessageBox.Show(
                    "Não é possível selecionar mais de uma alternativa como resposta.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                DialogResult = DialogResult.None;
                return;
            }
        }

        private void MenosDeDuasAlternativas()
        {
            if (clbAlternativas.Items.Count < 2)
            {
                MessageBox.Show(
                    "No mimnimo duas alternativas devem ser configuradas.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                DialogResult = DialogResult.None;
                return;
            }
        }

    }
}
