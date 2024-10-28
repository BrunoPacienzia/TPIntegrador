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
            idCursoTextBox = new TextBox();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            cancelarButton = new Button();
            idDocenteLabel = new Label();
            idDocenteTextBox = new TextBox();
            idCursoLabel = new Label();
            cargoLabel = new Label();
            cargoTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // idCursoTextBox
            // 
            idCursoTextBox.Location = new Point(131, 21);
            idCursoTextBox.Margin = new Padding(2, 1, 2, 1);
            idCursoTextBox.Name = "idCursoTextBox";
            idCursoTextBox.Size = new Size(110, 23);
            idCursoTextBox.TabIndex = 0;
            idCursoTextBox.KeyPress += idCursoTextBox_KeyPress;
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
            // idDocenteLabel
            // 
            idDocenteLabel.AutoSize = true;
            idDocenteLabel.Location = new Point(24, 58);
            idDocenteLabel.Margin = new Padding(2, 0, 2, 0);
            idDocenteLabel.Name = "idDocenteLabel";
            idDocenteLabel.Size = new Size(61, 15);
            idDocenteLabel.TabIndex = 5;
            idDocenteLabel.Text = "idDocente";
            // 
            // idDocenteTextBox
            // 
            idDocenteTextBox.Location = new Point(131, 58);
            idDocenteTextBox.Margin = new Padding(2, 1, 2, 1);
            idDocenteTextBox.Name = "idDocenteTextBox";
            idDocenteTextBox.Size = new Size(110, 23);
            idDocenteTextBox.TabIndex = 8;
            idDocenteTextBox.KeyPress += idDocenteTextBox_KeyPress;
            // 
            // idCursoLabel
            // 
            idCursoLabel.Location = new Point(24, 24);
            idCursoLabel.Margin = new Padding(2, 0, 2, 0);
            idCursoLabel.Name = "idCursoLabel";
            idCursoLabel.Size = new Size(48, 15);
            idCursoLabel.TabIndex = 1;
            idCursoLabel.Text = "IdCurso";
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
            // DocentesCursosDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 244);
            Controls.Add(cargoTextBox);
            Controls.Add(cargoLabel);
            Controls.Add(idCursoTextBox);
            Controls.Add(idCursoLabel);
            Controls.Add(idDocenteLabel);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(idDocenteTextBox);
            Margin = new Padding(2, 1, 2, 1);
            Name = "DocentesCursosDetalle";
            Text = "Materia";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label idDocenteLabel;
        private Label idCursoLabel;
        private TextBox idCursoTextBox;
        private TextBox idDocenteTextBox;
        private TextBox cargoTextBox;
        private Label cargoLabel;
    }
}