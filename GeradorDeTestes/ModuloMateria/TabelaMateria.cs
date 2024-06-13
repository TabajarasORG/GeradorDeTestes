using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.ModuloMateria
{
    public partial class TabelaMateria : UserControl
    {
        public TabelaMateria()
        {
            InitializeComponent();

            materiaGridView.Columns.AddRange(GerarColunas());

            materiaGridView.ConfigurarGridSomenteLeitura();
            materiaGridView.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Materia> materias)
        {
            materiaGridView.Rows.Clear();

            foreach (Materia materia in materias)
            {
                materiaGridView.Rows.Add
                    (
                    materia.Id,
                    materia.Nome,
                    materia.Disciplina,
                    materia.Serie
                    );
            }
        }

        public int ObterRegistroSelecionado() 
        {
            return materiaGridView.SelecionarId();
        }

        private static DataGridViewColumn[] GerarColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn {DataPropertyName = "id", HeaderText = "Id"},
                new DataGridViewTextBoxColumn { DataPropertyName = "nome", HeaderText = "Nome"},
                new DataGridViewTextBoxColumn {DataPropertyName = "disciplina", HeaderText = "Disciplina"},
                new DataGridViewTextBoxColumn {DataPropertyName = "serie", HeaderText = "Serie"},
            };
        }
    }
}
