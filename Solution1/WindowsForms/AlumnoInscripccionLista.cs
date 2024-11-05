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
    public partial class AlumnoInscripcionLista : Form
    {
        public AlumnoInscripcionLista()
        {
            InitializeComponent();
        }

        private void AlumnoInscripciones_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            AlumnoInscripcionesDetalle alumnoInscripccionDetalle = new AlumnoInscripcionesDetalle();

            AlumnoInscripcion alumnoInscripccionNuevo = new AlumnoInscripcion();

            alumnoInscripccionDetalle.AlumnoInscripcion = alumnoInscripccionNuevo;

            alumnoInscripccionDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            AlumnoInscripcionesDetalle alumnoInscripccionDetalle = new AlumnoInscripcionesDetalle();

            int id;

            id = this.SelectedItem().AlumnoInscripcionId;

            AlumnoInscripcion alumnoInscripccion = await AlumnoInscripcionApiClient.GetAsync(id);

            alumnoInscripccionDetalle.EditMode = true;
            alumnoInscripccionDetalle.AlumnoInscripcion = alumnoInscripccion;

            alumnoInscripccionDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().AlumnoInscripcionId;
            await AlumnoInscripcionApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            AlumnoInscripcionApiClient client = new AlumnoInscripcionApiClient();

            this.alumnoInscripccionesDataGridView.DataSource = null;
            this.alumnoInscripccionesDataGridView.DataSource = await AlumnoInscripcionApiClient.GetAllAsync();

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

        private AlumnoInscripcion SelectedItem()
        {
            AlumnoInscripcion alumnoInscripccion;

            alumnoInscripccion = (AlumnoInscripcion)alumnoInscripccionesDataGridView.SelectedRows[0].DataBoundItem;

            return alumnoInscripccion;
        }

      

    }
}
