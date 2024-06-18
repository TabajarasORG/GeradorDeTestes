namespace GeradorDeTestes.ModuloTeste
{
    partial class TelaTesteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaTesteForm));
            txtTitulo = new TextBox();
            lblTitulo = new Label();
            lblDisciplina = new Label();
            lblMateria = new Label();
            cmbDisciplina = new ComboBox();
            cmbMateria = new ComboBox();
            lblQtdQuestoes = new Label();
            numQtdQuestoes = new NumericUpDown();
            checkRecuperacao = new CheckBox();
            bgQuestoesSelecionadas = new GroupBox();
            listQuestoes = new ListBox();
            btnSortear = new Button();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numQtdQuestoes).BeginInit();
            bgQuestoesSelecionadas.SuspendLayout();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(92, 54);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(309, 27);
            txtTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(39, 57);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(47, 20);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Titulo";
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisciplina.Location = new Point(12, 93);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(74, 20);
            lblDisciplina.TabIndex = 2;
            lblDisciplina.Text = "Disciplina";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMateria.Location = new Point(26, 133);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(60, 20);
            lblMateria.TabIndex = 3;
            lblMateria.Text = "Materia";
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDisciplina.FormattingEnabled = true;
            cmbDisciplina.ImeMode = ImeMode.NoControl;
            cmbDisciplina.Location = new Point(92, 90);
            cmbDisciplina.Name = "cmbDisciplina";
            cmbDisciplina.Size = new Size(200, 28);
            cmbDisciplina.TabIndex = 4;
            cmbDisciplina.SelectedIndexChanged += cmbDisciplina_SelectedIndexChanged;
            // 
            // cmbMateria
            // 
            cmbMateria.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(92, 130);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(200, 28);
            cmbMateria.TabIndex = 5;
            cmbMateria.SelectedIndexChanged += cmbMateria_SelectedIndexChanged;
            // 
            // lblQtdQuestoes
            // 
            lblQtdQuestoes.AutoSize = true;
            lblQtdQuestoes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQtdQuestoes.Location = new Point(312, 93);
            lblQtdQuestoes.Name = "lblQtdQuestoes";
            lblQtdQuestoes.Size = new Size(102, 20);
            lblQtdQuestoes.TabIndex = 6;
            lblQtdQuestoes.Text = "Qtd. Questoes";
            // 
            // numQtdQuestoes
            // 
            numQtdQuestoes.Location = new Point(420, 95);
            numQtdQuestoes.Name = "numQtdQuestoes";
            numQtdQuestoes.Size = new Size(44, 23);
            numQtdQuestoes.TabIndex = 7;
            // 
            // checkRecuperacao
            // 
            checkRecuperacao.AutoSize = true;
            checkRecuperacao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkRecuperacao.Location = new Point(312, 130);
            checkRecuperacao.Name = "checkRecuperacao";
            checkRecuperacao.Size = new Size(176, 24);
            checkRecuperacao.TabIndex = 8;
            checkRecuperacao.Text = "Prova de Recuperacao";
            checkRecuperacao.UseVisualStyleBackColor = true;
            checkRecuperacao.CheckedChanged += checkRecuperacao_CheckedChanged;
            // 
            // bgQuestoesSelecionadas
            // 
            bgQuestoesSelecionadas.Controls.Add(listQuestoes);
            bgQuestoesSelecionadas.Controls.Add(btnSortear);
            bgQuestoesSelecionadas.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bgQuestoesSelecionadas.Location = new Point(12, 194);
            bgQuestoesSelecionadas.Name = "bgQuestoesSelecionadas";
            bgQuestoesSelecionadas.Size = new Size(469, 282);
            bgQuestoesSelecionadas.TabIndex = 9;
            bgQuestoesSelecionadas.TabStop = false;
            bgQuestoesSelecionadas.Text = "Questoes Selecionadas";
            // 
            // listQuestoes
            // 
            listQuestoes.Dock = DockStyle.Bottom;
            listQuestoes.FormattingEnabled = true;
            listQuestoes.ItemHeight = 20;
            listQuestoes.Location = new Point(3, 75);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.Size = new Size(463, 204);
            listQuestoes.TabIndex = 2;
            // 
            // btnSortear
            // 
            btnSortear.Location = new Point(6, 26);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(156, 40);
            btnSortear.TabIndex = 1;
            btnSortear.Text = "Sortear Questoes";
            btnSortear.UseVisualStyleBackColor = true;
            btnSortear.Click += btnSortear_Click;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGravar.Location = new Point(312, 500);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 34);
            btnGravar.TabIndex = 10;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(400, 500);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 34);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(92, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(82, 27);
            txtId.TabIndex = 12;
            txtId.Visible = false;
            // 
            // TelaTesteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 546);
            Controls.Add(txtId);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(bgQuestoesSelecionadas);
            Controls.Add(checkRecuperacao);
            Controls.Add(numQtdQuestoes);
            Controls.Add(lblQtdQuestoes);
            Controls.Add(cmbMateria);
            Controls.Add(cmbDisciplina);
            Controls.Add(lblMateria);
            Controls.Add(lblDisciplina);
            Controls.Add(lblTitulo);
            Controls.Add(txtTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaTesteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaTesteForm";
            ((System.ComponentModel.ISupportInitialize)numQtdQuestoes).EndInit();
            bgQuestoesSelecionadas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private Label lblTitulo;
        private Label lblDisciplina;
        private Label lblMateria;
        private ComboBox cmbDisciplina;
        private ComboBox cmbMateria;
        private Label lblQtdQuestoes;
        private NumericUpDown numQtdQuestoes;
        private CheckBox checkRecuperacao;
        private GroupBox bgQuestoesSelecionadas;
        private Button btnSortear;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtId;
        private ListBox listQuestoes;
    }
}