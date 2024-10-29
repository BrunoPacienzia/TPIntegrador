using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Domain.Model;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class PlanesDetalle : Form
    {
        private Plan plan;

        IEnumerable<Especialidad> especialidades = [];

        public Plan Plan
        {
            get { return plan; }
            set
            {
                plan = value;
                this.SetPlan();
            }
        }
        public PlanesDetalle()
        {
            InitializeComponent();
            LoadTiposEspecialidades();
        }

        private async void LoadTiposEspecialidades()
        {
            IEnumerable<Especialidad> especialidades = await EspecialidadApiClient.GetAllAsync();
            this.especialidades = especialidades;
            this.especialidadComboBoxInput.DataSource = especialidades;
            this.especialidadComboBoxInput.DisplayMember = "Descripcion";
            this.especialidadComboBoxInput.ValueMember = "Id";

            this.especialidadComboBoxInput.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        //Probablemente un Enum seria mas apropiado        
        public bool EditMode { get; set; } = false;

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            PlanApiClient client = new PlanApiClient();

            if (this.ValidatePlan())
            {
                
                this.Plan.Descripcion = descripcionTextBox.Text;

                //El Detalle se esta llevando la responsabilidad de llamar al servicio
                //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                //en la Lista o tal vez en un Presenter o Controler

                var selectedId = (int)this.especialidadComboBoxInput.SelectedValue;

                this.Plan.Especialidad = (Especialidad)this.especialidades.FirstOrDefault(p => p.Id == selectedId);

                if (this.EditMode)
                {
                    await PlanApiClient.UpdateAsync(this.Plan);
                }
                else
                {
                    await PlanApiClient.AddAsync(this.Plan);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetPlan()
        {
            this.descripcionTextBox.Text = this.Plan.Descripcion;

            if (this.Plan.Especialidad != null)
            {
                this.especialidadComboBoxInput.SelectedIndex = this.plan.Especialidad.Id;
            }
        }

        private bool ValidatePlan()
        {
            bool isValid = true;

            errorProvider.SetError(especialidadComboBoxInput, string.Empty);
            errorProvider.SetError(descripcionTextBox, string.Empty);

            if (this.especialidadComboBoxInput.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(especialidadComboBoxInput, "Requerido");
            }


            if (this.descripcionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(descripcionTextBox, "Requerido");
            }



            return isValid;
        }

        private void IdEsepecialidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

