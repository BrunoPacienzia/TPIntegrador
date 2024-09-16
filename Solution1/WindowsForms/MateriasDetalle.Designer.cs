
namespace WindowsForms
{
    partial class MateriasDetalle
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
            nombreTextBox = new TextBox();
            nombreLabel = new Label();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            cancelarButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            hsSemanalesTextBox = new TextBox();
            hsTotalesTextBox = new TextBox();
            descripcionTextBox = new TextBox();
            idPlanTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(131, 21);
            nombreTextBox.Margin = new Padding(2, 1, 2, 1);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(110, 23);
            nombreTextBox.TabIndex = 0;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(24, 24);
            nombreLabel.Margin = new Padding(2, 0, 2, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(51, 15);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 92);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 4;
            label1.Text = "HsTotales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 58);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 5;
            label2.Text = "HsSemanales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 127);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 6;
            label3.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 157);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "IdPlan";
            // 
            // hsSemanalesTextBox
            // 
            hsSemanalesTextBox.Location = new Point(131, 55);
            hsSemanalesTextBox.Margin = new Padding(2, 1, 2, 1);
            hsSemanalesTextBox.Name = "hsSemanalesTextBox";
            hsSemanalesTextBox.Size = new Size(110, 23);
            hsSemanalesTextBox.TabIndex = 8;
            hsSemanalesTextBox.KeyPress += hsSemanalesTextBox_KeyPress;
            // 
            // hsTotalesTextBox
            // 
            hsTotalesTextBox.Location = new Point(131, 89);
            hsTotalesTextBox.Margin = new Padding(2, 1, 2, 1);
            hsTotalesTextBox.Name = "hsTotalesTextBox";
            hsTotalesTextBox.Size = new Size(110, 23);
            hsTotalesTextBox.TabIndex = 9;
            hsTotalesTextBox.KeyPress += hsTotalesTextBox_KeyPress;
            // 
            // descripcionTextBox
            // 
            descripcionTextBox.Location = new Point(131, 124);
            descripcionTextBox.Margin = new Padding(2, 1, 2, 1);
            descripcionTextBox.Name = "descripcionTextBox";
            descripcionTextBox.Size = new Size(110, 23);
            descripcionTextBox.TabIndex = 10;
            // 
            // idPlanTextBox
            // 
            idPlanTextBox.Location = new Point(131, 154);
            idPlanTextBox.Margin = new Padding(2, 1, 2, 1);
            idPlanTextBox.Name = "idPlanTextBox";
            idPlanTextBox.Size = new Size(110, 23);
            idPlanTextBox.TabIndex = 11;
            idPlanTextBox.KeyPress += idPlanTextBox_KeyPress;
            // 
            // MateriasDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 244);
            Controls.Add(idPlanTextBox);
            Controls.Add(descripcionTextBox);
            Controls.Add(hsTotalesTextBox);
            Controls.Add(hsSemanalesTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(nombreLabel);
            Controls.Add(nombreTextBox);
            Margin = new Padding(2, 1, 2, 1);
            Name = "MateriasDetalle";
            Text = "Materia";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombreTextBox;
        private Label nombreLabel;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox descripcionTextBox;
        private TextBox hsTotalesTextBox;
        private TextBox hsSemanalesTextBox;
        private TextBox idPlanTextBox;
    }
}