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
    public partial class AlumnoInscripccionLista : Form
    {
        public AlumnoInscripccionLista()
        {
            InitializeComponent();
        }

        private void AlumnoInscripcciones_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            AlumnoInscripccionesDetalle alumnoInscripccionDetalle = new AlumnoInscripccionesDetalle();

            AlumnoInscripccion alumnoInscripccionNuevo = new AlumnoInscripccion();

            alumnoInscripccionDetalle.AlumnoInscripccion = alumnoInscripccionNuevo;

            alumnoInscripccionDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            AlumnoInscripccionesDetalle alumnoInscripccionDetalle = new AlumnoInscripccionesDetalle();

            int id;

            id = this.SelectedItem().Id;

            AlumnoInscripccion alumnoInscripccion = await AlumnoInscripccionApiClient.GetAsync(id);

            alumnoInscripccionDetalle.EditMode = true;
            alumnoInscripccionDetalle.AlumnoInscripccion = alumnoInscripccion;

            alumnoInscripccionDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().Id;
            await AlumnoInscripccionApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            AlumnoInscripccionApiClient client = new AlumnoInscripccionApiClient();

            this.alumnoInscripccionesDataGridView.DataSource = null;
            this.alumnoInscripccionesDataGridView.DataSource = await AlumnoInscripccionApiClient.GetAllAsync();

            if (this.alumnoInscripccionesDataGridView.Rows.Count > 0)
            {
                this.alumnoInscripccionesDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private AlumnoInscripccion SelectedItem()
        {
            AlumnoInscripccion alumnoInscripccion;

            alumnoInscripccion = (AlumnoInscripccion)alumnoInscripccionesDataGridView.SelectedRows[0].DataBoundItem;

            return alumnoInscripccion;
        }

      

    }
}
