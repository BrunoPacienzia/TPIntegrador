namespace WindowsForms
{
    partial class RegistrarNotaLista
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
            alumnoInscripcionesDataGridView = new DataGridView();
            modificarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)alumnoInscripcionesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // alumnoInscripcionesDataGridView
            // 
            alumnoInscripcionesDataGridView.AllowUserToOrderColumns = true;
            alumnoInscripcionesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            alumnoInscripcionesDataGridView.Location = new Point(21, 18);
            alumnoInscripcionesDataGridView.Margin = new Padding(2, 1, 2, 1);
            alumnoInscripcionesDataGridView.MultiSelect = false;
            alumnoInscripcionesDataGridView.Name = "alumnoInscripcionesDataGridView";
            alumnoInscripcionesDataGridView.ReadOnly = true;
            alumnoInscripcionesDataGridView.RowHeadersWidth = 82;
            alumnoInscripcionesDataGridView.RowTemplate.Height = 41;
            alumnoInscripcionesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            alumnoInscripcionesDataGridView.Size = new Size(751, 270);
            alumnoInscripcionesDataGridView.TabIndex = 0;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(663, 305);
            modificarButton.Margin = new Padding(2, 1, 2, 1);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(109, 22);
            modificarButton.TabIndex = 3;
            modificarButton.Text = "Modificar Nota";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // RegistrarNotaLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 402);
            Controls.Add(modificarButton);
            Controls.Add(alumnoInscripcionesDataGridView);
            Margin = new Padding(2, 1, 2, 1);
            Name = "RegistrarNotaLista";
            Text = "AlumnoInscripciones";
            Load += AlumnoInscripciones_Load;
            ((System.ComponentModel.ISupportInitialize)alumnoInscripcionesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView alumnoInscripcionesDataGridView;
        private Button modificarButton;

    }
}