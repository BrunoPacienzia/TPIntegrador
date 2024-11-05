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
    public partial class MateriasDetalle : Form
    {
        IEnumerable<Plan> planes = [];

        private Materia materia;

        public Materia Materia
        {
            get { return materia; }
            set
            {
                materia = value;
                this.SetMateria();
            }
        }
        public MateriasDetalle()
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
            MateriaApiClient client = new MateriaApiClient();

            if (this.ValidateMateria())
            {
                this.Materia.Nombre = nombreTextBox.Text;
                this.Materia.Descripcion = descripcionTextBox.Text;
                this.Materia.HSSemanales = int.Parse(hsSemanalesTextBox.Text);
                this.Materia.HSTotales = int.Parse(hsTotalesTextBox.Text); ;

                var selectedId = (int)this.planComboBoxInput.SelectedValue;

                this.Materia.Plan = (Plan)this.planes.FirstOrDefault(p => p.PlanId == selectedId);
                //El Detalle se esta llevando la responsabilidad de llamar al servicio
                //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                //en la Lista o tal vez en un Presenter o Controler

                if (this.EditMode)
                {
                    await MateriaApiClient.UpdateAsync(this.Materia);
                }
                else
                {
                    await MateriaApiClient.AddAsync(this.Materia);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetMateria()
        {
            this.nombreTextBox.Text = this.Materia.Nombre;
            this.descripcionTextBox.Text = this.Materia.Descripcion;
            this.hsSemanalesTextBox.Text = this.Materia.HSSemanales.ToString();
            this.hsTotalesTextBox.Text = this.Materia.HSTotales.ToString();


            if (this.materia.Plan != null)
            {
                this.planComboBoxInput.SelectedIndex = this.materia.Plan.PlanId;
            }
        }

        private bool ValidateMateria()
        {
            bool isValid = true;

            errorProvider.SetError(nombreTextBox, string.Empty);

            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(nombreTextBox, "Requerido");
            }


            if (this.descripcionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(descripcionTextBox, "Requerido");
            }


            if (this.hsSemanalesTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(hsSemanalesTextBox, "Requerido");
            }

            if (this.hsTotalesTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(hsTotalesTextBox, "Requerido");
            }


            if (this.planComboBoxInput.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(planComboBoxInput, "Requerido");
            }

            return isValid;
        }


        private void hsSemanalesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void hsTotalesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }



    }
}
