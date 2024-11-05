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
    public partial class RegistrarNotaLista : Form
    {
        public RegistrarNotaLista()
        {
            InitializeComponent();
        }

        private void AlumnoInscripcciones_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            RegistrarNotaDetalle registrarNotaDetalle = new RegistrarNotaDetalle();

            int id;

            id = this.SelectedItem().AlumnoInscripccionId;

            AlumnoInscripccion alumnoInscripccion = await AlumnoInscripccionApiClient.GetAsync(id);

            registrarNotaDetalle.EditMode = true;
            registrarNotaDetalle.AlumnoInscripccion = alumnoInscripccion;

            registrarNotaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }


        private async void GetAllAndLoad()
        {
            AlumnoInscripccionApiClient client = new AlumnoInscripccionApiClient();

            this.alumnoInscripccionesDataGridView.DataSource = null;
            IEnumerable<AlumnoInscripccion> alumnosEncontrados = await AlumnoInscripccionApiClient.GetAllAsync();

            this.alumnoInscripccionesDataGridView.DataSource = alumnosEncontrados.Where(a =>  a.Nota == 0).ToList();

            if (this.alumnoInscripccionesDataGridView.Rows.Count > 0)
            {
                this.alumnoInscripccionesDataGridView.Rows[0].Selected = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
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
