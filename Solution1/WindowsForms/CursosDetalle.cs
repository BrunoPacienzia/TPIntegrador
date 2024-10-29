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
    public partial class CursosDetalle : Form
    {

        private Curso curso;
        IEnumerable<Comision> comisiones = [];
        IEnumerable<Materia> materias = [];
        public Curso Curso
        {
            get { return curso; }
            set
            {
                curso = value;
                this.SetCurso();
            }
        }

        public CursosDetalle()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private async void LoadComboBox()
        {
            IEnumerable<Comision> comisiones = await ComisionApiClient.GetAllAsync();
            this.comisiones = comisiones;
            this.comisionComboBoxInput.DataSource = comisiones;
            this.comisionComboBoxInput.DisplayMember = "Descripcion";
            this.comisionComboBoxInput.ValueMember = "Id";

            this.comisionComboBoxInput.DropDownStyle = ComboBoxStyle.DropDownList;

            IEnumerable<Materia> materias = await MateriaApiClient.GetAllAsync();
            this.materias = materias;
            this.materiaComboBoxInput.DataSource = materias;
            this.materiaComboBoxInput.DisplayMember = "Descripcion";
            this.materiaComboBoxInput.ValueMember = "Id";

            this.materiaComboBoxInput.DropDownStyle = ComboBoxStyle.DropDownList;

        }




        //Probablemente un Enum seria mas apropiado        
        public bool EditMode { get; set; } = false;

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            CursoApiClient client = new CursoApiClient();

            if (this.ValidateCurso())
            {
                this.Curso.Descripcion = descripcionTextBox.Text;
                this.Curso.Cupo = int.Parse(cupoTextBox.Text);
                this.Curso.AnioCalendario = int.Parse(anioCalendarioTextBox.Text);

                var selectedComisionId = (int)this.comisionComboBoxInput.SelectedValue;

                this.Curso.Comision = (Comision)this.comisiones.FirstOrDefault(p => p.Id == selectedComisionId);

                var selectedMateriaId = (int)this.materiaComboBoxInput.SelectedValue;

                this.Curso.Materia = (Materia)this.materias.FirstOrDefault(p => p.Id == selectedMateriaId);
                //El Detalle se esta llevando la responsabilidad de llamar al servicio
                //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                //en la Lista o tal vez en un Presenter o Controler

                if (this.EditMode)
                {
                    await CursoApiClient.UpdateAsync(this.Curso);
                }
                else
                {
                    await CursoApiClient.AddAsync(this.Curso);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetCurso()
        {
            this.descripcionTextBox.Text = this.Curso.Descripcion;
            this.cupoTextBox.Text = this.Curso.Cupo.ToString();
            this.anioCalendarioTextBox.Text = this.Curso.AnioCalendario.ToString();

            if (this.Curso.Comision != null)
            {
                this.comisionComboBoxInput.SelectedIndex = this.curso.Comision.Id;
            }

            if (this.Curso.Materia != null)
            {
                this.materiaComboBoxInput.SelectedIndex = this.curso.Materia.Id;
            }
        }

        private bool ValidateCurso()
        {
            bool isValid = true;


            if (this.descripcionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(descripcionTextBox, "Requerido");
            }



            if (this.comisionComboBoxInput.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(comisionComboBoxInput, "Requerido");
            }



            if (this.materiaComboBoxInput.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(materiaComboBoxInput, "Requerido");
            }


            if (this.cupoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(cupoTextBox, "Requerido");
            }

            if (this.anioCalendarioTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(anioCalendarioTextBox, "Requerido");
            }

            return isValid;
        }

        private void anioCalendarioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void idMateriaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void idComisionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cupoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

