namespace GeradorDeTestes.ModuloTeste
{
    partial class TabelaTeste
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridTeste = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridTeste).BeginInit();
            SuspendLayout();
            // 
            // dataGridTeste
            // 
            dataGridTeste.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTeste.Dock = DockStyle.Fill;
            dataGridTeste.Location = new Point(0, 0);
            dataGridTeste.Name = "dataGridTeste";
            dataGridTeste.Size = new Size(450, 345);
            dataGridTeste.TabIndex = 0;
            // 
            // TabelaTeste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridTeste);
            Name = "TabelaTeste";
            Size = new Size(450, 345);
            ((System.ComponentModel.ISupportInitialize)dataGridTeste).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridTeste;
    }
}
