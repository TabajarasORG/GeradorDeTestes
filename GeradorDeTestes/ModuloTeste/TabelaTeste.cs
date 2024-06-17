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

namespace GeradorDeTestes.ModuloTeste
{
    public partial class TabelaTeste : UserControl
    {
        public TabelaTeste()
        {
            InitializeComponent();

            dataGridTeste.Columns.AddRange(GerarColunas());

            dataGridTeste.ConfigurarGridSomenteLeitura();
            dataGridTeste.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Teste> testes)
        {
            dataGridTeste.Rows.Clear();

            foreach (Teste teste in testes)
            {
                dataGridTeste.Rows.Add
                    (
                    teste.Id,
                    teste.Titulo,
                    teste.Disciplina,
                    teste.Materia,
                    teste.QuantidadeQuestoes
                    );
            }
        }

        public int ObterRegistroSelecionado()
        {
            return dataGridTeste.SelecionarId();
        }


        private static DataGridViewColumn[] GerarColunas()
        {
            return new DataGridViewColumn[]
            {
                 new DataGridViewTextBoxColumn {DataPropertyName = "id", HeaderText = "Id"},
                 new DataGridViewTextBoxColumn { DataPropertyName = "titulo", HeaderText = "Titulo"},
                 new DataGridViewTextBoxColumn {DataPropertyName = "disciplina", HeaderText = "Disciplina"},
                 new DataGridViewTextBoxColumn {DataPropertyName = "materia", HeaderText = "Materia"},
                 new DataGridViewTextBoxColumn {DataPropertyName = "quantidade", HeaderText = "Quantidade"},
            };
        }

    }
}
