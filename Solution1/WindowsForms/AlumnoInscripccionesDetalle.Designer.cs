namespace WindowsForms
{
    partial class AlumnoInscripccionesDetalle
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
            components = new System.ComponentModel.Container();
            condicionTextBox = new TextBox();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            cancelarButton = new Button();
            condicionLabel = new Label();
            label6 = new Label();
            AlumnoIdLabel = new Label();
            notaLabel = new Label();
            notaTextBox = new TextBox();
            label2 = new Label();
            CursoLabel = new Label();
            alumnoComboBoxInput = new ComboBox();
            cursoComboBoxInput = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // condicionTextBox
            // 
            condicionTextBox.Location = new Point(131, 21);
            condicionTextBox.Margin = new Padding(2, 1, 2, 1);
            condicionTextBox.Name = "condicionTextBox";
            condicionTextBox.Size = new Size(110, 23);
            condicionTextBox.TabIndex = 0;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(100, 229);
            aceptarButton.Margin = new Padding(2, 1, 2, 1);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(81, 22);
            aceptarButton.TabIndex = 2;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(232, 229);
            cancelarButton.Margin = new Padding(2, 1, 2, 1);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(81, 22);
            cancelarButton.TabIndex = 3;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // condicionLabel
            // 
            condicionLabel.AutoSize = true;
            condicionLabel.Location = new Point(24, 29);
            condicionLabel.Margin = new Padding(2, 0, 2, 0);
            condicionLabel.Name = "condicionLabel";
            condicionLabel.Size = new Size(62, 15);
            condicionLabel.TabIndex = 13;
            condicionLabel.Text = "Condicion";
            condicionLabel.Click += label5_Click;
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 21;
            // 
            // AlumnoIdLabel
            // 
            AlumnoIdLabel.AutoSize = true;
            AlumnoIdLabel.Location = new Point(24, 65);
            AlumnoIdLabel.Margin = new Padding(2, 0, 2, 0);
            AlumnoIdLabel.Name = "AlumnoIdLabel";
            AlumnoIdLabel.Size = new Size(50, 15);
            AlumnoIdLabel.TabIndex = 17;
            AlumnoIdLabel.Text = "Alumno";
            // 
            // notaLabel
            // 
            notaLabel.AutoSize = true;
            notaLabel.Location = new Point(24, 126);
            notaLabel.Margin = new Padding(2, 0, 2, 0);
            notaLabel.Name = "notaLabel";
            notaLabel.Size = new Size(33, 15);
            notaLabel.TabIndex = 20;
            notaLabel.Text = "Nota";
            // 
            // notaTextBox
            // 
            notaTextBox.Location = new Point(131, 123);
            notaTextBox.Margin = new Padding(2, 1, 2, 1);
            notaTextBox.Name = "notaTextBox";
            notaTextBox.Size = new Size(110, 23);
            notaTextBox.TabIndex = 19;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // CursoLabel
            // 
            CursoLabel.AutoSize = true;
            CursoLabel.Location = new Point(24, 97);
            CursoLabel.Margin = new Padding(2, 0, 2, 0);
            CursoLabel.Name = "CursoLabel";
            CursoLabel.Size = new Size(38, 15);
            CursoLabel.TabIndex = 22;
            CursoLabel.Text = "Curso";
            // 
            // alumnoComboBoxInput
            // 
            alumnoComboBoxInput.FormattingEnabled = true;
            alumnoComboBoxInput.Location = new Point(131, 57);
            alumnoComboBoxInput.Name = "alumnoComboBoxInput";
            alumnoComboBoxInput.Size = new Size(121, 23);
            alumnoComboBoxInput.TabIndex = 23;
            // 
            // cursoComboBoxInput
            // 
            cursoComboBoxInput.FormattingEnabled = true;
            cursoComboBoxInput.Location = new Point(131, 89);
            cursoComboBoxInput.Name = "cursoComboBoxInput";
            cursoComboBoxInput.Size = new Size(121, 23);
            cursoComboBoxInput.TabIndex = 24;
            // 
            // AlumnoInscripccionesDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 299);
            Controls.Add(cursoComboBoxInput);
            Controls.Add(alumnoComboBoxInput);
            Controls.Add(CursoLabel);
            Controls.Add(label2);
            Controls.Add(notaLabel);
            Controls.Add(notaTextBox);
            Controls.Add(AlumnoIdLabel);
            Controls.Add(label6);
            Controls.Add(condicionLabel);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(condicionTextBox);
            Margin = new Padding(2, 1, 2, 1);
            Name = "AlumnoInscripccionesDetalle";
            Text = "AlumnoInscripccion";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox condicionTextBox;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label condicionLabel;
        private Label label6;
        private Label AlumnoIdLabel;
        private Label notaLabel;
        private TextBox notaTextBox;
        private Label label2;
        private Label CursoLabel;
        private ComboBox cursoComboBoxInput;
        private ComboBox alumnoComboBoxInput;
    }
}