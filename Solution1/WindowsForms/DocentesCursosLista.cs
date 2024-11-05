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
    public partial class DocentesCursosLista : Form
    {
        public DocentesCursosLista()
        {
            InitializeComponent();
        }


        private void DocentesCursos_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            DocentesCursosDetalle docenteCursoDetalle = new DocentesCursosDetalle();

            DocenteCurso docenteCursoNuevo = new DocenteCurso();

            docenteCursoDetalle.DocenteCurso = docenteCursoNuevo;

            docenteCursoDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            DocentesCursosDetalle docenteCursoDetalle = new DocentesCursosDetalle();

            int id;

            id = this.SelectedItem().DocenteCursoId;

            DocenteCurso docenteCurso = await DocenteCursoApiClient.GetAsync(id);

            docenteCursoDetalle.EditMode = true;
            docenteCursoDetalle.DocenteCurso = docenteCurso;

            docenteCursoDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().DocenteCursoId;
            await DocenteCursoApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            DocenteCursoApiClient client = new DocenteCursoApiClient();

            this.docentesCursosDataGridView.DataSource = null;
            this.docentesCursosDataGridView.DataSource = await DocenteCursoApiClient.GetAllAsync();

            if (this.docentesCursosDataGridView.Rows.Count > 0)
            {
                this.docentesCursosDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private DocenteCurso SelectedItem()
        {
            DocenteCurso docenteCurso;

            docenteCurso = (DocenteCurso)docentesCursosDataGridView.SelectedRows[0].DataBoundItem;

            return docenteCurso;
        }

    }
}
