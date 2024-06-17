namespace GeradorDeTestes.ModuloMateria
{
    partial class TelaMateriaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMateriaForm));
            txtId = new TextBox();
            lblId = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            cmbDisciplina = new ComboBox();
            lblDisciplina = new Label();
            gbSerie = new GroupBox();
            rbSegundaSerie = new RadioButton();
            rbPrimeiraSerie = new RadioButton();
            btnGravar = new Button();
            btnCancelar = new Button();
            gbSerie.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(111, 58);
            txtId.Name = "txtId";
            txtId.Size = new Size(121, 27);
            txtId.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(83, 61);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 1;
            lblId.Text = "id";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(111, 105);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(336, 27);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(55, 108);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDisciplina.FormattingEnabled = true;
            cmbDisciplina.Location = new Point(111, 148);
            cmbDisciplina.Name = "cmbDisciplina";
            cmbDisciplina.Size = new Size(121, 28);
            cmbDisciplina.TabIndex = 2;
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisciplina.Location = new Point(31, 151);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(74, 20);
            lblDisciplina.TabIndex = 4;
            lblDisciplina.Text = "Disciplina";
            // 
            // gbSerie
            // 
            gbSerie.Controls.Add(rbSegundaSerie);
            gbSerie.Controls.Add(rbPrimeiraSerie);
            gbSerie.Location = new Point(111, 194);
            gbSerie.Name = "gbSerie";
            gbSerie.Size = new Size(121, 60);
            gbSerie.TabIndex = 5;
            gbSerie.TabStop = false;
            gbSerie.Text = "Serie";
            // 
            // rbSegundaSerie
            // 
            rbSegundaSerie.AutoSize = true;
            rbSegundaSerie.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbSegundaSerie.Location = new Point(74, 22);
            rbSegundaSerie.Name = "rbSegundaSerie";
            rbSegundaSerie.Size = new Size(41, 24);
            rbSegundaSerie.TabIndex = 1;
            rbSegundaSerie.Text = "2ª";
            rbSegundaSerie.UseVisualStyleBackColor = true;
            // 
            // rbPrimeiraSerie
            // 
            rbPrimeiraSerie.AutoSize = true;
            rbPrimeiraSerie.Checked = true;
            rbPrimeiraSerie.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbPrimeiraSerie.Location = new Point(6, 22);
            rbPrimeiraSerie.Name = "rbPrimeiraSerie";
            rbPrimeiraSerie.Size = new Size(41, 24);
            rbPrimeiraSerie.TabIndex = 0;
            rbPrimeiraSerie.TabStop = true;
            rbPrimeiraSerie.Text = "1ª";
            rbPrimeiraSerie.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGravar.Location = new Point(401, 303);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(110, 28);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(525, 303);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 28);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaMateriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 343);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(gbSerie);
            Controls.Add(lblDisciplina);
            Controls.Add(cmbDisciplina);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaMateriaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Materias";
            gbSerie.ResumeLayout(false);
            gbSerie.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label lblId;
        private TextBox txtNome;
        private Label lblNome;
        private ComboBox cmbDisciplina;
        private Label lblDisciplina;
        private GroupBox gbSerie;
        private RadioButton rbSegundaSerie;
        private RadioButton rbPrimeiraSerie;
        private Button btnGravar;
        private Button btnCancelar;
    }
}