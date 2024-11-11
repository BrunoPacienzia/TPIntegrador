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
    public partial class ComisionesDetalle : Form
    {

        private Comision comision;
        IEnumerable<Plan> planes = [];

        public Comision Comision
        {
            get { return comision; }
            set
            {
                comision = value;
                this.SetComision();
            }
        }

        public ComisionesDetalle()
        {
            InitializeComponent();
            LoadTiposPlanes();
        }
        private async void LoadTiposPlanes()
        {
            IEnumerable<Plan> planes = await PlanApiClient.GetAllAsync();
            this.planes = planes;
            this.planComboBoxInput.DataSource = planes;
            this.planComboBoxInput.DisplayMember = "Descripcion";
            this.planComboBoxInput.ValueMember = "PlanId";
            this.planComboBoxInput.DropDownStyle = ComboBoxStyle.DropDownList;

        }


        //Probablemente un Enum seria mas apropiado        
        public bool EditMode { get; set; } = false;

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            ComisionApiClient client = new ComisionApiClient();

            if (this.ValidateComision())
            {
                this.Comision.Descripcion = descripcionTextBox.Text;
                this.Comision.AnioEspecialidad = int.Parse(anioEspecialidadTextBox.Text);

                var selectedId = (int)this.planComboBoxInput.SelectedValue;

                this.Comision.Plan = (Plan)this.planes.FirstOrDefault(p => p.PlanId == selectedId);

                //El Detalle se esta llevando la responsabilidad de llamar al servicio
                //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                //en la Lista o tal vez en un Presenter o Controler

                if (this.EditMode)
                {
                    await ComisionApiClient.UpdateAsync(this.Comision);
                }
                else
                {
                    await ComisionApiClient.AddAsync(this.Comision);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetComision()
        {
            this.descripcionTextBox.Text = this.Comision.Descripcion;
            this.anioEspecialidadTextBox.Text = this.Comision.AnioEspecialidad.ToString();

            if (this.comision.Plan != null)
            {
                this.planComboBoxInput.SelectedValue = this.comision.Plan.PlanId;
            }

            if(EditMode)
            {
                this.planComboBoxInput.Enabled = false;
            }
        }

        private bool ValidateComision()
        {
            bool isValid = true;


            if (this.anioEspecialidadTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(anioEspecialidadTextBox, "Requerido");
            }


            if (this.descripcionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(descripcionTextBox, "Requerido");
            }

            if (this.planComboBoxInput.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(planComboBoxInput, "Requerido");
            }

            return isValid;
        }

        private void anioEspecialidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void idPlanTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
