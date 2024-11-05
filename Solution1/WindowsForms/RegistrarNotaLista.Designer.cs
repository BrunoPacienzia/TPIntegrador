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
            alumnoInscripccionesDataGridView = new DataGridView();
            modificarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)alumnoInscripccionesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // alumnoInscripccionesDataGridView
            // 
            alumnoInscripccionesDataGridView.AllowUserToOrderColumns = true;
            alumnoInscripccionesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            alumnoInscripccionesDataGridView.Location = new Point(21, 18);
            alumnoInscripccionesDataGridView.Margin = new Padding(2, 1, 2, 1);
            alumnoInscripccionesDataGridView.MultiSelect = false;
            alumnoInscripccionesDataGridView.Name = "alumnoInscripccionesDataGridView";
            alumnoInscripccionesDataGridView.ReadOnly = true;
            alumnoInscripccionesDataGridView.RowHeadersWidth = 82;
            alumnoInscripccionesDataGridView.RowTemplate.Height = 41;
            alumnoInscripccionesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            alumnoInscripccionesDataGridView.Size = new Size(751, 270);
            alumnoInscripccionesDataGridView.TabIndex = 0;
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
            Controls.Add(alumnoInscripccionesDataGridView);
            Margin = new Padding(2, 1, 2, 1);
            Name = "RegistrarNotaLista";
            Text = "AlumnoInscripciones";
            Load += AlumnoInscripciones_Load;
            ((System.ComponentModel.ISupportInitialize)alumnoInscripccionesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView alumnoInscripccionesDataGridView;
        private Button modificarButton;

    }
}