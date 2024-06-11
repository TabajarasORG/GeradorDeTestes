namespace GeradorDeTestes.ModuloDisciplina
{
    partial class TelaDisciplinaForm
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
            txtId = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 24);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(81, 21);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(44, 27);
            txtId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 57);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 0;
            label2.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(81, 54);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(179, 27);
            txtNome.TabIndex = 1;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(81, 101);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(99, 36);
            btnGravar.TabIndex = 2;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(186, 101);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 36);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaDisciplinaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 162);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaDisciplinaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Disciplina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtNome;
        private Button btnGravar;
        private Button btnCancelar;
    }
}