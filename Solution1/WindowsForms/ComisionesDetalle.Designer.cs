using System.Windows.Forms;

namespace WindowsForms
{
    partial class ComisionesDetalle
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
            descripcionTextBox = new TextBox();
            descripcionLabel = new Label();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            cancelarButton = new Button();
            anioEspecialidadLabel = new Label();
            idPlanLabel = new Label();
            anioEspecialidadTextBox = new TextBox();
            idPlanTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // descripcionTextBox
            // 
            descripcionTextBox.Location = new Point(131, 21);
            descripcionTextBox.Margin = new Padding(2, 1, 2, 1);
            descripcionTextBox.Name = "descripcionTextBox";
            descripcionTextBox.Size = new Size(110, 23);
            descripcionTextBox.TabIndex = 0;
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
            // anioEspecialidadLabel
            // 
            anioEspecialidadLabel.AutoSize = true;
            anioEspecialidadLabel.Location = new Point(24, 92);
            anioEspecialidadLabel.Margin = new Padding(2, 0, 2, 0);
            anioEspecialidadLabel.Name = "anioEspecialidadLabel";
            anioEspecialidadLabel.Size = new Size(97, 15);
            anioEspecialidadLabel.TabIndex = 4;
            anioEspecialidadLabel.Text = "Año Especialidad";
            // 
            // idPlanLabel
            // 
            idPlanLabel.AutoSize = true;
            idPlanLabel.Location = new Point(24, 58);
            idPlanLabel.Margin = new Padding(2, 0, 2, 0);
            idPlanLabel.Name = "idPlanLabel";
            idPlanLabel.Size = new Size(40, 15);
            idPlanLabel.TabIndex = 5;
            idPlanLabel.Text = "idPlan";
            // 
            // anioEspecialidadTextBox
            // 
            anioEspecialidadTextBox.Location = new Point(131, 58);
            anioEspecialidadTextBox.Margin = new Padding(2, 1, 2, 1);
            anioEspecialidadTextBox.Name = "anioEspecialidadTextBox";
            anioEspecialidadTextBox.Size = new Size(110, 23);
            anioEspecialidadTextBox.TabIndex = 8;
            anioEspecialidadTextBox.KeyPress += anioEspecialidadTextBox_KeyPress;
            // 
            // idPlanTextBox
            // 
            idPlanTextBox.Location = new Point(131, 92);
            idPlanTextBox.Margin = new Padding(2, 1, 2, 1);
            idPlanTextBox.Name = "idPlanTextBox";
            idPlanTextBox.Size = new Size(110, 23);
            idPlanTextBox.TabIndex = 11;
            idPlanTextBox.KeyPress += idPlanTextBox_KeyPress;
            // 
            // ComisionesDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 244);
            Controls.Add(idPlanTextBox);
            Controls.Add(descripcionTextBox);
            Controls.Add(descripcionLabel);
            Controls.Add(anioEspecialidadLabel);
            Controls.Add(idPlanLabel);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(anioEspecialidadTextBox);
            Margin = new Padding(2, 1, 2, 1);
            Name = "ComisionesDetalle";
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
        private Label anioEspecialidadLabel;
        private Label idPlanLabel;
        private TextBox descripcionTextBox;
        private TextBox anioEspecialidadTextBox;
        private TextBox idPlanTextBox;
    }
}