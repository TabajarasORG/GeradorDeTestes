namespace GeradorDeTestes.ModuloTeste
{
    partial class TelaVisualizarTesteForm
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
            label1 = new Label();
            lblTitulo = new Label();
            label2 = new Label();
            lblDisciplina = new Label();
            label4 = new Label();
            lblMateria = new Label();
            groupBox1 = new GroupBox();
            listQuestoes = new ListBox();
            btnFechar = new Button();
            btnPDF = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 20);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Titulo: ";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblTitulo.Location = new Point(95, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(70, 20);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "[ Titulo ]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 0;
            label2.Text = "Disciplina:";
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblDisciplina.Location = new Point(95, 50);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(96, 20);
            lblDisciplina.TabIndex = 1;
            lblDisciplina.Text = "[ Disciplina ]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 81);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 0;
            label4.Text = "Matéria:";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblMateria.Location = new Point(95, 81);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(83, 20);
            lblMateria.TabIndex = 1;
            lblMateria.Text = "[ Matéria ]";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listQuestoes);
            groupBox1.Location = new Point(12, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 319);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas:";
            // 
            // listQuestoes
            // 
            listQuestoes.Dock = DockStyle.Fill;
            listQuestoes.FormattingEnabled = true;
            listQuestoes.ItemHeight = 20;
            listQuestoes.Location = new Point(3, 23);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.Size = new Size(384, 293);
            listQuestoes.TabIndex = 0;
            // 
            // btnFechar
            // 
            btnFechar.DialogResult = DialogResult.Cancel;
            btnFechar.Location = new Point(279, 449);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(120, 39);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnPDF
            // 
            btnPDF.DialogResult = DialogResult.OK;
            btnPDF.Location = new Point(12, 454);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(120, 39);
            btnPDF.TabIndex = 4;
            btnPDF.Text = "Gerar PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // TelaVisualizarTesteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 505);
            Controls.Add(btnPDF);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            Controls.Add(lblMateria);
            Controls.Add(label4);
            Controls.Add(lblDisciplina);
            Controls.Add(label2);
            Controls.Add(lblTitulo);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaVisualizarTesteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Visualização de Teste";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTitulo;
        private Label label2;
        private Label lblDisciplina;
        private Label label4;
        private Label lblMateria;
        private GroupBox groupBox1;
        private ListBox listQuestoes;
        private Button btnFechar;
        private Button btnPDF;
    }
}