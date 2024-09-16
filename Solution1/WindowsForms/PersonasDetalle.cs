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
    public partial class PersonasDetalle : Form
    {
        public PersonasDetalle()
        {
            InitializeComponent();
        }

        private Persona persona;

        public Persona Persona
        {
            get { return persona; }
            set
            {
                persona = value;
                this.SetPersona();
            }
        }

        //Probablemente un Enum seria mas apropiado        
        public bool EditMode { get; set; } = false;

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            PersonaApiClient client = new PersonaApiClient();

            if (this.ValidatePersona())
            {
                this.Persona.Nombre = nombreTextBox.Text;
                this.Persona.Apellido = apellidoTextBox.Text;
                this.Persona.IdPlan = Int32.Parse(idPlanTextBox.Text);
                this.Persona.Email = emailTextBox.Text;
                this.Persona.TipoPersona = Int32.Parse(tipoPersonaTextBox.Text);
                this.Persona.Telefono = telefonoTextBox.Text;
                this.Persona.Direccion = direccionTextBox.Text;
                this.Persona.Legajo = Int32.Parse(legajoTextBox.Text);
                this.Persona.FechaNacimiento = dateTimePicker1.Value;

                if (this.EditMode)
                {
                    await PersonaApiClient.UpdateAsync(this.Persona);
                }
                else
                {
                    await PersonaApiClient.AddAsync(this.Persona);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetPersona()
        {
            this.nombreTextBox.Text = this.Persona.Nombre;
            this.apellidoTextBox.Text = this.Persona.Apellido;
            this.idPlanTextBox.Text = this.Persona.IdPlan.ToString();
            this.emailTextBox.Text = this.Persona.Email;
            this.tipoPersonaTextBox.Text = this.Persona.TipoPersona.ToString();
            this.telefonoTextBox.Text = this.Persona.Telefono;
            this.direccionTextBox.Text = this.Persona.Direccion ;
            this.legajoTextBox.Text = this.Persona.Legajo.ToString();
            if (this.Persona.FechaNacimiento == DateTime.MinValue)
            {
                // Handle the case where the DateTime is not initialized
                this.dateTimePicker1.Value = DateTime.Now; // or set it to a valid default
            }
            else {this.dateTimePicker1.Value = this.Persona.FechaNacimiento; }
            
        }

        private bool ValidatePersona()
        {
            bool isValid = true;

            errorProvider.SetError(nombreTextBox, string.Empty);

            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(nombreTextBox, "Requerido");
            }


            if (this.apellidoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(apellidoTextBox, "Requerido");
            }


            if (this.direccionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(direccionTextBox, "Requerido");
            }

            if (this.emailTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(emailTextBox, "Requerido");
            }

            if (this.idPlanTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(idPlanTextBox, "Requerido");
            }

            if (this.legajoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(legajoTextBox, "Requerido");
            }

            if (this.telefonoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(telefonoTextBox, "Requerido");
            }

            if (this.tipoPersonaTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(tipoPersonaTextBox, "Requerido");

            }

            return isValid;
        }

        private void PersonasDetalle_Load(object sender, EventArgs e)
        {

        }

        private void idPlanTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void telefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tipoPersonaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
