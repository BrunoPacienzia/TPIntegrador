using System.Windows.Forms;

namespace WindowsForms
{
    partial class CursosDetalle
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
            idMateriaTextBox = new TextBox();
            cupoTextBox = new TextBox();
            anioCalendarioTextBox = new TextBox();
            idComisionTextBox = new TextBox();
            descripcionTextBox = new TextBox();
            idComisionLabel = new Label();
            anioCalendarioLabel = new Label();
            descripcionLabel = new Label();
            idMateriaLabel = new Label();
            cupoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(216, 248);
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
            cancelarButton.Location = new Point(322, 248);
            cancelarButton.Margin = new Padding(2, 1, 2, 1);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(81, 22);
            cancelarButton.TabIndex = 3;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // idMateriaTextBox
            // 
            idMateriaTextBox.Location = new Point(131, 102);
            idMateriaTextBox.Margin = new Padding(2, 1, 2, 1);
            idMateriaTextBox.Name = "idMateriaTextBox";
            idMateriaTextBox.Size = new Size(110, 23);
            idMateriaTextBox.TabIndex = 14;
            idMateriaTextBox.KeyPress += idMateriaTextBox_KeyPress;
            // 
            // cupoTextBox
            // 
            cupoTextBox.Location = new Point(131, 177);
            cupoTextBox.Margin = new Padding(2, 1, 2, 1);
            cupoTextBox.Name = "cupoTextBox";
            cupoTextBox.Size = new Size(110, 23);
            cupoTextBox.TabIndex = 18;
            cupoTextBox.KeyPress += cupoTextBox_KeyPress;
            // 
            // anioCalendarioTextBox
            // 
            anioCalendarioTextBox.Location = new Point(131, 58);
            anioCalendarioTextBox.Margin = new Padding(2, 1, 2, 1);
            anioCalendarioTextBox.Name = "anioCalendarioTextBox";
            anioCalendarioTextBox.Size = new Size(110, 23);
            anioCalendarioTextBox.TabIndex = 8;
            anioCalendarioTextBox.KeyPress += anioCalendarioTextBox_KeyPress;
            // 
            // idComisionTextBox
            // 
            idComisionTextBox.Location = new Point(131, 141);
            idComisionTextBox.Margin = new Padding(2, 1, 2, 1);
            idComisionTextBox.Name = "idComisionTextBox";
            idComisionTextBox.Size = new Size(110, 23);
            idComisionTextBox.TabIndex = 15;
            idComisionTextBox.KeyPress += idComisionTextBox_KeyPress;
            // 
            // descripcionTextBox
            // 
            descripcionTextBox.Location = new Point(131, 21);
            descripcionTextBox.Margin = new Padding(2, 1, 2, 1);
            descripcionTextBox.Name = "descripcionTextBox";
            descripcionTextBox.Size = new Size(110, 23);
            descripcionTextBox.TabIndex = 0;
            // 
            // idComisionLabel
            // 
            idComisionLabel.AutoSize = true;
            idComisionLabel.Location = new Point(24, 144);
            idComisionLabel.Margin = new Padding(2, 0, 2, 0);
            idComisionLabel.Name = "idComisionLabel";
            idComisionLabel.Size = new Size(68, 15);
            idComisionLabel.TabIndex = 13;
            idComisionLabel.Text = "idComision";
            // 
            // anioCalendarioLabel
            // 
            anioCalendarioLabel.AutoSize = true;
            anioCalendarioLabel.Location = new Point(24, 66);
            anioCalendarioLabel.Margin = new Padding(2, 0, 2, 0);
            anioCalendarioLabel.Name = "anioCalendarioLabel";
            anioCalendarioLabel.Size = new Size(89, 15);
            anioCalendarioLabel.TabIndex = 4;
            anioCalendarioLabel.Text = "Año Calendario";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new Point(24, 24);
            descripcionLabel.Margin = new Padding(2, 0, 2, 0);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new Size(69, 15);
            descripcionLabel.TabIndex = 1;
            descripcionLabel.Text = "Descripcion";
            // 
            // idMateriaLabel
            // 
            idMateriaLabel.AutoSize = true;
            idMateriaLabel.Location = new Point(24, 105);
            idMateriaLabel.Margin = new Padding(2, 0, 2, 0);
            idMateriaLabel.Name = "idMateriaLabel";
            idMateriaLabel.Size = new Size(57, 15);
            idMateriaLabel.TabIndex = 16;
            idMateriaLabel.Text = "idMateria";
            // 
            // cupoLabel
            // 
            cupoLabel.AutoSize = true;
            cupoLabel.Location = new Point(25, 180);
            cupoLabel.Margin = new Padding(2, 0, 2, 0);
            cupoLabel.Name = "cupoLabel";
            cupoLabel.Size = new Size(34, 15);
            cupoLabel.TabIndex = 19;
            cupoLabel.Text = "cupo";
            // 
            // CursosDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 357);
            Controls.Add(cupoLabel);
            Controls.Add(cupoTextBox);
            Controls.Add(idMateriaLabel);
            Controls.Add(idMateriaTextBox);
            Controls.Add(idComisionTextBox);
            Controls.Add(descripcionTextBox);
            Controls.Add(anioCalendarioTextBox);
            Controls.Add(descripcionLabel);
            Controls.Add(anioCalendarioLabel);
            Controls.Add(idComisionLabel);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Margin = new Padding(2, 1, 2, 1);
            Name = "CursosDetalle";
            Text = "Materia";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        
        private Label descripcionLabel;
        private Label anioCalendarioLabel;
        private Label idComisionLabel;
        private Label cupoLabel;
        private Label idMateriaLabel;


        private TextBox descripcionTextBox;
        private TextBox anioCalendarioTextBox;
        private TextBox idComisionTextBox;
        private TextBox idMateriaTextBox;
        private TextBox cupoTextBox;
    }
}