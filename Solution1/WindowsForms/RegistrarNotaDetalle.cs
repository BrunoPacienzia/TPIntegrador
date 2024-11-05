using Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class RegistrarNotaDetalle : Form
    {
        public RegistrarNotaDetalle()
        {
            InitializeComponent();
        }

        private AlumnoInscripcion alumnoInscripccion;

        public AlumnoInscripcion AlumnoInscripcion
        {
            get { return alumnoInscripccion; }
            set
            {
                alumnoInscripccion = value;
                this.SetAlumnoInscripcion();
            }
        }

        //Probablemente un Enum seria mas apropiado        
        public bool EditMode { get; set; } = false;

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            AlumnoInscripcionApiClient client = new AlumnoInscripcionApiClient();

            if (this.ValidateAlumnoInscripcion())
            {
               
                this.AlumnoInscripcion.Nota = Int32.Parse(this.notaTextBox.Text);


                if (this.EditMode)
                {
                    await AlumnoInscripcionApiClient.UpdateAsync(this.AlumnoInscripcion);
                }
                else
                {
                    await AlumnoInscripcionApiClient.AddAsync(this.AlumnoInscripcion);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetAlumnoInscripcion()
        {
            this.notaTextBox.Text = "";

        }

        private bool ValidateAlumnoInscripcion()
        {
            bool isValid = true;

            errorProvider.SetError(notaTextBox, string.Empty);

            if (!this.notaTextBox.Text.All(char.IsDigit))
            {
                isValid = false;
                errorProvider.SetError(notaTextBox, "La nota solo puede contener numeros");
            }
           


            if (this.notaTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(notaTextBox, "Requerido");
            }


            return isValid;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
