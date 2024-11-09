using System.Windows.Forms;

namespace WindowsForms
{
    partial class DocentesCursosDetalle
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
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            cancelarButton = new Button();
            DocenteLabel = new Label();
            CursoLabel = new Label();
            cargoLabel = new Label();
            cargoTextBox = new TextBox();
            docenteComboBoxInput = new ComboBox();
            cursoComboBoxInput = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(226, 197);
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
            cancelarButton.Location = new Point(327, 197);
            cancelarButton.Margin = new Padding(2, 1, 2, 1);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(81, 22);
            cancelarButton.TabIndex = 3;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // DocenteLabel
            // 
            DocenteLabel.AutoSize = true;
            DocenteLabel.Location = new Point(24, 58);
            DocenteLabel.Margin = new Padding(2, 0, 2, 0);
            DocenteLabel.Name = "DocenteLabel";
            DocenteLabel.Size = new Size(51, 15);
            DocenteLabel.TabIndex = 5;
            DocenteLabel.Text = "Docente";
            // 
            // CursoLabel
            // 
            CursoLabel.Location = new Point(24, 24);
            CursoLabel.Margin = new Padding(2, 0, 2, 0);
            CursoLabel.Name = "CursoLabel";
            CursoLabel.Size = new Size(48, 15);
            CursoLabel.TabIndex = 1;
            CursoLabel.Text = "Curso";
            // 
            // cargoLabel
            // 
            cargoLabel.AutoSize = true;
            cargoLabel.Location = new Point(24, 95);
            cargoLabel.Margin = new Padding(2, 0, 2, 0);
            cargoLabel.Name = "cargoLabel";
            cargoLabel.Size = new Size(65, 15);
            cargoLabel.TabIndex = 9;
            cargoLabel.Text = "Tipo Cargo";
            // 
            // cargoTextBox
            // 
            cargoTextBox.Location = new Point(131, 95);
            cargoTextBox.Margin = new Padding(2, 1, 2, 1);
            cargoTextBox.Name = "cargoTextBox";
            cargoTextBox.Size = new Size(110, 23);
            cargoTextBox.TabIndex = 10;
            // 
            // docenteComboBoxInput
            // 
            docenteComboBoxInput.FormattingEnabled = true;
            docenteComboBoxInput.Location = new Point(131, 58);
            docenteComboBoxInput.Name = "docenteComboBoxInput";
            docenteComboBoxInput.Size = new Size(121, 23);
            docenteComboBoxInput.TabIndex = 24;
            // 
            // cursoComboBoxInput
            // 
            cursoComboBoxInput.FormattingEnabled = true;
            cursoComboBoxInput.Location = new Point(131, 16);
            cursoComboBoxInput.Name = "cursoComboBoxInput";
            cursoComboBoxInput.Size = new Size(121, 23);
            cursoComboBoxInput.TabIndex = 25;
            // 
            // DocentesCursosDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 244);
            Controls.Add(cursoComboBoxInput);
            Controls.Add(docenteComboBoxInput);
            Controls.Add(cargoTextBox);
            Controls.Add(cargoLabel);
            Controls.Add(CursoLabel);
            Controls.Add(DocenteLabel);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Margin = new Padding(2, 1, 2, 1);
            Name = "DocentesCursosDetalle";
            Text = "DocenteCurso";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label DocenteLabel;
        private Label CursoLabel;
        private TextBox cargoTextBox;
        private Label cargoLabel;
        private ComboBox docenteComboBoxInput;
        private ComboBox cursoComboBoxInput;
    }
}