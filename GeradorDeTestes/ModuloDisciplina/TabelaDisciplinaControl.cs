using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.ModuloDisciplina
{
    public partial class TabelaDisciplinaControl : UserControl
    {
        public TabelaDisciplinaControl()
        {
            InitializeComponent();

            gridDisciplina.Columns.AddRange(GerarColunas());

            gridDisciplina.ConfigurarGridSomenteLeitura();
            gridDisciplina.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Disciplina> disciplina)
        {
            gridDisciplina.Rows.Clear();

            foreach (Disciplina i in disciplina)
                gridDisciplina.Rows.Add(i.Id, i.Nome.ToTitleCase());
        }

        public int ObterRegistroSelecionado()
        {
            return gridDisciplina.SelecionarId();
        }

        private DataGridViewColumn[] GerarColunas()
        {
            return new DataGridViewColumn[]
                        {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" }
                        };
        }
    }
}
