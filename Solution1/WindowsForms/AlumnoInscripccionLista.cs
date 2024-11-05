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
            AlumnoInscripcionesDetalle alumnoInscripcionDetalle = new AlumnoInscripcionesDetalle();

            AlumnoInscripcion alumnoInscripcionNuevo = new AlumnoInscripcion();

            alumnoInscripcionDetalle.AlumnoInscripcion = alumnoInscripcionNuevo;

            alumnoInscripcionDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            AlumnoInscripcionesDetalle alumnoInscripcionDetalle = new AlumnoInscripcionesDetalle();

            int id;

            id = this.SelectedItem().AlumnoInscripcionId;

            AlumnoInscripcion alumnoInscripcion = await AlumnoInscripcionApiClient.GetAsync(id);

            alumnoInscripcionDetalle.EditMode = true;
            alumnoInscripcionDetalle.AlumnoInscripcion = alumnoInscripcion;

            alumnoInscripcionDetalle.ShowDialog();

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

            this.alumnoInscripcionesDataGridView.DataSource = null;
            this.alumnoInscripcionesDataGridView.DataSource = await AlumnoInscripcionApiClient.GetAllAsync();

            if (this.alumnoInscripcionesDataGridView.Rows.Count > 0)
            {
                this.alumnoInscripcionesDataGridView.Rows[0].Selected = true;
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
            AlumnoInscripcion alumnoInscripcion;

            alumnoInscripcion = (AlumnoInscripcion)alumnoInscripcionesDataGridView.SelectedRows[0].DataBoundItem;

            return alumnoInscripcion;
        }

      

    }
}
