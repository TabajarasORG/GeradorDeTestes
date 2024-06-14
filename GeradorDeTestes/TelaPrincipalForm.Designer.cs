namespace GeradorDeTestes
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            geradorDeTestesToolStripMenuItem = new ToolStripMenuItem();
            disciplinaToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            lblTipoCadastro = new ToolStripLabel();
            statusStrip1 = new StatusStrip();
            statusLabelPrincipal = new ToolStripStatusLabel();
            pnlRegistros = new Panel();
            materiaToolStripMenuItem = new ToolStripMenuItem();
            questõesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { geradorDeTestesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // geradorDeTestesToolStripMenuItem
            // 
            geradorDeTestesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { disciplinaToolStripMenuItem, materiaToolStripMenuItem });
            geradorDeTestesToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            geradorDeTestesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { disciplinaToolStripMenuItem, questõesToolStripMenuItem });
            geradorDeTestesToolStripMenuItem.Name = "geradorDeTestesToolStripMenuItem";
            geradorDeTestesToolStripMenuItem.Size = new Size(140, 24);
            geradorDeTestesToolStripMenuItem.Text = "Gerador de Testes";
            // 
            // disciplinaToolStripMenuItem
            // 
            disciplinaToolStripMenuItem.Name = "disciplinaToolStripMenuItem";
            disciplinaToolStripMenuItem.Size = new Size(180, 24);
            disciplinaToolStripMenuItem.Text = "Disciplina";
            disciplinaToolStripMenuItem.Click += disciplinaToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator1, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 41);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Enabled = false;
            btnAdicionar.Image = Properties.Resources.btnAdicionar;
            btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Padding = new Padding(5);
            btnAdicionar.Size = new Size(38, 38);
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = Properties.Resources.btnEditar;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(5);
            btnEditar.Size = new Size(38, 38);
            btnEditar.Text = "toolStripButton2";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Image = Properties.Resources.btnExcluir;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(5);
            btnExcluir.Size = new Size(38, 38);
            btnExcluir.Text = "toolStripButton3";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 41);
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(39, 38);
            lblTipoCadastro.Text = "Tipo";
            // 
            // statusStrip1
            // 
            statusStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabelPrincipal });
            statusStrip1.Location = new Point(0, 425);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 25);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelPrincipal
            // 
            statusLabelPrincipal.Name = "statusLabelPrincipal";
            statusLabelPrincipal.Size = new Size(185, 20);
            statusLabelPrincipal.Text = "Visualizando 0 registro(s)...";
            // 
            // pnlRegistros
            // 
            pnlRegistros.Dock = DockStyle.Fill;
            pnlRegistros.Location = new Point(0, 69);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(800, 356);
            pnlRegistros.TabIndex = 3;
            // 
            // materiaToolStripMenuItem
            // 
            materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            materiaToolStripMenuItem.Size = new Size(180, 24);
            materiaToolStripMenuItem.Text = "Materia";
            materiaToolStripMenuItem.Click += materiaToolStripMenuItem_Click;
            // 
            // questõesToolStripMenuItem
            // 
            questõesToolStripMenuItem.Name = "questõesToolStripMenuItem";
            questõesToolStripMenuItem.Size = new Size(180, 22);
            questõesToolStripMenuItem.Text = "Questões";
            questõesToolStripMenuItem.Click += questõesToolStripMenuItem_Click;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlRegistros);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerador de Testes";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem geradorDeTestesToolStripMenuItem;
        private ToolStripMenuItem disciplinaToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lblTipoCadastro;
        private StatusStrip statusStrip1;
        private Panel pnlRegistros;
        private ToolStripStatusLabel statusLabelPrincipal;
        private ToolStripMenuItem materiaToolStripMenuItem;
        private ToolStripMenuItem questõesToolStripMenuItem;
    }
}
