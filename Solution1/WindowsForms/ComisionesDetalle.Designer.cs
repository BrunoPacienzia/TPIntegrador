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
            PlanLabel = new Label();
            anioEspecialidadTextBox = new TextBox();
            planComboBoxInput = new ComboBox();
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
            // PlanLabel
            // 
            PlanLabel.AutoSize = true;
            PlanLabel.Location = new Point(24, 58);
            PlanLabel.Margin = new Padding(2, 0, 2, 0);
            PlanLabel.Name = "PlanLabel";
            PlanLabel.Size = new Size(30, 15);
            PlanLabel.TabIndex = 5;
            PlanLabel.Text = "Plan";
            // 
            // anioEspecialidadTextBox
            // 
            anioEspecialidadTextBox.Location = new Point(131, 92);
            anioEspecialidadTextBox.Margin = new Padding(2, 1, 2, 1);
            anioEspecialidadTextBox.Name = "anioEspecialidadTextBox";
            anioEspecialidadTextBox.Size = new Size(110, 23);
            anioEspecialidadTextBox.TabIndex = 11;
            anioEspecialidadTextBox.KeyPress += idPlanTextBox_KeyPress;
            // 
            // planComboBoxInput
            // 
            planComboBoxInput.FormattingEnabled = true;
            planComboBoxInput.Location = new Point(131, 58);
            planComboBoxInput.Name = "planComboBoxInput";
            planComboBoxInput.Size = new Size(121, 23);
            planComboBoxInput.TabIndex = 17;
            // 
            // ComisionesDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 244);
            Controls.Add(planComboBoxInput);
            Controls.Add(anioEspecialidadTextBox);
            Controls.Add(descripcionTextBox);
            Controls.Add(descripcionLabel);
            Controls.Add(anioEspecialidadLabel);
            Controls.Add(PlanLabel);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
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
        private Label PlanLabel;
        private TextBox descripcionTextBox;
        private TextBox anioEspecialidadTextBox;
        private ComboBox planComboBoxInput;
    }
}