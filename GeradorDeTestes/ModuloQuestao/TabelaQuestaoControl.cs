using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.Compartilhado;
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

namespace GeradorDeTestes.ModuloQuestao
{
    public partial class TabelaQuestaoControl : UserControl
    {
        public TabelaQuestaoControl()
        {
            InitializeComponent();

            gridQuestao.Columns.AddRange(GerarColunas());

            gridQuestao.ConfigurarGridSomenteLeitura();
            gridQuestao.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Questao> questao)
        {
            gridQuestao.Rows.Clear();

            foreach (Questao i in questao)
            {
                Alternativa alternativa = i.Alternativas.Find(a => a.Correta == true);
                gridQuestao.Rows.Add(i.Id, i.Materia, i.Enunciado, alternativa);
            }
        }

        public int ObterRegistroSelecionado()
        {
            return gridQuestao.SelecionarId();
        }

        private DataGridViewColumn[] GerarColunas()
        {
            return new DataGridViewColumn[]
                        {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Materia", HeaderText = "Materia" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Enunciado", HeaderText = "Enunciado" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Resposta", HeaderText = "Resposta" }
                        };
        }
    }
}
