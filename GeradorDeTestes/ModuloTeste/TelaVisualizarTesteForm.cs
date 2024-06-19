using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeradorDeTestes.ModuloQuestao;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;

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

        private void btnPDF_Click(object sender, EventArgs e)
        {
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
   
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(value: 2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(20));


                    page.Header()
                    .AlignCenter()
                    .Text($"Prova de {lblMateria.Text}");

                    page.Content()
                     .PaddingVertical(value: 1, Unit.Centimetre)
                     .DefaultTextStyle(x => x.FontSize(15))

                     .Column(x =>
                     {
                         x.Item()
                     .Text($"Disciplina: {lblDisciplina.Text}");

                         x.Item()
                     .Text($"Titulo: {lblTitulo.Text}");

                         x.Item()
                         .DefaultTextStyle(x => x.FontSize(20))
                          .PaddingTop(value: 1, Unit.Centimetre)
                         .Text("Questoes");

                         for(int i = 0; i < listQuestoes.Items.Count; i++)
                         {
                             x.Item()
                            .Text($"{listQuestoes.Items[i]}");
                         }

                     });

                    page.Footer()
                    .AlignCenter()
                    .Text("texto de teste");
                });
            }).GeneratePdfAndShow();
        }


    }
}
