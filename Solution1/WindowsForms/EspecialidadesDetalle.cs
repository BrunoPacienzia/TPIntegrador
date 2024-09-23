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
    public partial class EspecialidadesDetalle : Form
    {
        public EspecialidadesDetalle()
        {
            InitializeComponent();
        }

        private Especialidad especialidad;

        public Especialidad Especialidad
        {
            get { return especialidad; }
            set
            {
                especialidad = value;
                this.SetEspecialidad();
            }
        }

        //Probablemente un Enum seria mas apropiado        
        public bool EditMode { get; set; } = false;

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            EspecialidadApiClient client = new EspecialidadApiClient();

            if (this.ValidateEspecialidad())
            {
                this.Especialidad.Descripcion = descripcionTextBox.Text;


                if (this.EditMode)
                {
                    await EspecialidadApiClient.UpdateAsync(this.Especialidad);
                }
                else
                {
                    await EspecialidadApiClient.AddAsync(this.Especialidad);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetEspecialidad()
        {
            this.descripcionTextBox.Text = this.Especialidad.Descripcion;
        }

        private bool ValidateEspecialidad()
        {
            bool isValid = true;

            errorProvider.SetError(descripcionTextBox, string.Empty);

            if (this.descripcionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(descripcionTextBox, "Requerido");
            }

            return isValid;
        }

        private void EspecialidadesDetalle_Load(object sender, EventArgs e)
        {

        }

    }
}
