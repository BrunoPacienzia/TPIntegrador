using Domain.Model;

namespace WindowsForms
{
    public partial class MateriasLista : Form
    {
        public MateriasLista()
        {
            InitializeComponent();
        }


        private void Materias_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            MateriasDetalle materiaDetalle = new MateriasDetalle();

            Materia materiaNuevo = new Materia();

            materiaDetalle.Materia = materiaNuevo;

            materiaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            MateriasDetalle materiaDetalle = new MateriasDetalle();

            int id;

            id = this.SelectedItem().MateriaId;

            Materia materia = await MateriaApiClient.GetAsync(id);

            materiaDetalle.EditMode = true;
            materiaDetalle.Materia = materia;

            materiaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().MateriaId;
            await MateriaApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            MateriaApiClient client = new MateriaApiClient();

            this.materiasDataGridView.DataSource = null;
            this.materiasDataGridView.DataSource = await MateriaApiClient.GetAllAsync();

            if (this.materiasDataGridView.Rows.Count > 0)
            {
                this.materiasDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private Materia SelectedItem()
        {
            Materia materia;

            materia = (Materia)materiasDataGridView.SelectedRows[0].DataBoundItem;

            return materia;
        }

    }
}
