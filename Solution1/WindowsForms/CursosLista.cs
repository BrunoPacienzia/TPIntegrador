using Domain.Model;


namespace WindowsForms
{
    public partial class CursosLista : Form
    {
        public CursosLista()
        {
            InitializeComponent();
        }


        private void Cursos_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            CursosDetalle cursoDetalle = new CursosDetalle();

            Curso cursoNuevo = new Curso();


            cursoDetalle.Curso = cursoNuevo;

            cursoDetalle.ShowDialog();

            this.GetAllAndLoad();


            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            CursosDetalle cursoDetalle = new CursosDetalle();

            int id;

            id = this.SelectedItem().Id;

            Curso curso = await CursoApiClient.GetAsync(id);

            cursoDetalle.EditMode = true;
            cursoDetalle.Curso = curso;

            cursoDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().Id;
            await CursoApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            CursoApiClient client = new CursoApiClient();

            this.cursosDataGridView.DataSource = null;
            this.cursosDataGridView.DataSource = await CursoApiClient.GetAllAsync();

            if (this.cursosDataGridView.Rows.Count > 0)
            {
                this.cursosDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private Curso SelectedItem()
        {
            Curso curso;

            curso = (Curso)cursosDataGridView.SelectedRows[0].DataBoundItem;

            return curso;
        }
    }
}
