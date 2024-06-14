namespace GeradorDeTestes.ModuloMateria
{
    partial class TabelaMateria
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
            materiaGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)materiaGridView).BeginInit();
            SuspendLayout();
            // 
            // materiaGridView
            // 
            materiaGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            materiaGridView.Dock = DockStyle.Fill;
            materiaGridView.Location = new Point(0, 0);
            materiaGridView.Name = "materiaGridView";
            materiaGridView.Size = new Size(564, 401);
            materiaGridView.TabIndex = 0;
            // 
            // TabelaMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materiaGridView);
            Name = "TabelaMateria";
            Size = new Size(564, 401);
            ((System.ComponentModel.ISupportInitialize)materiaGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView materiaGridView;
    }
}
