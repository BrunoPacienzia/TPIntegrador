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
        public class TipoPersona
        {
            public int Codigo { get; set; }
            public string Desc { get; set; }

            public TipoPersona(int codigo, string desc)
            {
                Codigo = codigo;
                Desc = desc;
            }
        }

        IEnumerable<Plan> planes = [];

        public PersonasDetalle()
        {
            InitializeComponent();
            LoadTiposPlanes();
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
       
        public bool EditMode { get; set; } = false;

        private async void LoadTiposPlanes()
        {
            IEnumerable<Plan> planes = await PlanApiClient.GetAllAsync();
            this.planes = planes;
            this.planComboBoxInput.DataSource = planes;
            this.planComboBoxInput.DisplayMember = "Descripcion";
            this.planComboBoxInput.ValueMember = "PlanId";

            this.planComboBoxInput.DropDownStyle = ComboBoxStyle.DropDownList;

            TipoPersona alumno = new TipoPersona(0, "Alumno");
            TipoPersona docente = new TipoPersona(1, "Docente");

            IEnumerable<TipoPersona> tipoPersona = new List<TipoPersona> { alumno, docente };

            this.tipoPersonaComboBox.DataSource = tipoPersona;
            this.tipoPersonaComboBox.DisplayMember = "Desc";
            this.tipoPersonaComboBox.ValueMember = "Codigo";

            this.planComboBoxInput.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            PersonaApiClient client = new PersonaApiClient();

            if (this.ValidatePersona())
            {
                this.Persona.Nombre = nombreTextBox.Text;
                this.Persona.Apellido = apellidoTextBox.Text;
                this.Persona.Email = emailTextBox.Text;
                if (!EditMode)
                {
                    this.Persona.TipoPersona = (int)tipoPersonaComboBox.SelectedValue;
                }
                this.Persona.Telefono = telefonoTextBox.Text;
                this.Persona.Direccion = direccionTextBox.Text;
                this.Persona.Legajo = Int32.Parse(legajoTextBox.Text);
                this.Persona.FechaNacimiento = dateTimePicker1.Value;

                var selectedId = (int)this.planComboBoxInput.SelectedValue;

                this.Persona.Plan = (Plan)this.planes.FirstOrDefault(p => p.PlanId == selectedId);

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
            this.emailTextBox.Text = this.Persona.Email;

            if (this.tipoPersonaComboBox.Items.Count > 0 && this.Persona.TipoPersona != 0)
            {
                this.tipoPersonaComboBox.SelectedValue = this.Persona.TipoPersona;
            }

            if (EditMode)
            {
                tipoPersonaComboBox.Enabled = false;
            }

            this.telefonoTextBox.Text = this.Persona.Telefono;
            this.direccionTextBox.Text = this.Persona.Direccion ;
            this.legajoTextBox.Text = this.Persona.Legajo.ToString();
            if (this.Persona.FechaNacimiento == DateTime.MinValue)
            {
                this.dateTimePicker1.Value = DateTime.Now; 
            }
            else {this.dateTimePicker1.Value = this.Persona.FechaNacimiento; }

            if (this.Persona.Plan != null)
            {
                this.planComboBoxInput.SelectedValue = this.Persona.Plan.PlanId;
            }

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

            if (this.planComboBoxInput.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(planComboBoxInput, "Requerido");
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
