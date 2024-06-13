﻿using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        private RepositorioMateria repositorioMateria;
        private TabelaMateria tabelaMateria;

        public ControladorMateria(RepositorioMateria repositorio)
        {
            this.repositorioMateria = repositorio;
        }

        public override string TipoCadastro => "Materia";

        public override string ToolTipAdicionar => "Cadastrar uma nova MATERIA";

        public override string ToolTipEditar => "Editar uma MATERIA";

        public override string ToolTipExcluir => "Excluir uma MATERIA";

        public override void Adicionar()
        {
            TelaMateriaForm telaMateria = new TelaMateriaForm();

            DialogResult resultado = telaMateria.ShowDialog();

            if(resultado != DialogResult.OK)
                return;

            Materia novaMateria = telaMateria.Materia;

            repositorioMateria.Cadastrar(novaMateria);

            CarregarMateria();
        }

        public override void Editar()
        {
            TelaMateriaForm telaMateria = new TelaMateriaForm();

            int idSelecionado = tabelaMateria.ObterRegistroSelecionado();

            if(idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um registro",
                   "Atenção",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                   );
                return;
            }

            telaMateria.Materia = repositorioMateria.SelecionarPorId(idSelecionado);

            DialogResult resultado = telaMateria.ShowDialog();

            if (resultado != DialogResult.OK)
                return; 

            Materia materiaEditada = telaMateria.Materia;

            repositorioMateria.Editar(idSelecionado, materiaEditada);

            CarregarMateria();
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaMateria.ObterRegistroSelecionado();

            if (idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um registro",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                return;
            }

            DialogResult resposta = MessageBox.Show(
              $"Você realmente deseja excluir \"{idSelecionado}\"?  ",
              "Confirmar Exclusão",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning
              );

            if (resposta != DialogResult.Yes)
                return;

            repositorioMateria.Excluir(idSelecionado);

            CarregarMateria();
        }


        private void CarregarMateria()
        {
            List<Materia> clientes = repositorioMateria.SelecionarTodos();

            tabelaMateria.AtualizarRegistros(clientes);
        }

        public override UserControl ObterListagem()
        {
            if(tabelaMateria == null)
                tabelaMateria = new TabelaMateria();

            CarregarMateria();

            return tabelaMateria;
        }
    }
}
