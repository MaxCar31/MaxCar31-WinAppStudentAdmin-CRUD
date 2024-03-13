namespace WinAppStudentAdmin
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void BotonAgregar_Click_1(object sender, EventArgs e)
        {
            FormCrear formCreateStudent = new FormCrear();
            formCreateStudent.StartPosition = FormStartPosition.CenterScreen;
            formCreateStudent.Show();
            this.Hide();
        }

        private void BotonVisualizar_Click_1(object sender, EventArgs e)
        {
            FormMostarLista formReadStudent = new FormMostarLista();
            formReadStudent.StartPosition = FormStartPosition.CenterScreen;
            formReadStudent.Show();
            this.Hide();
        }

        private void BotonActualizar_Click_1(object sender, EventArgs e)
        {
            FormActualizar formUpdateStudent = new FormActualizar();
            formUpdateStudent.StartPosition = FormStartPosition.CenterScreen;
            formUpdateStudent.Show();
            this.Hide();
        }

        private void BotonEliminar_Click_1(object sender, EventArgs e)
        {
            FormEliminar formDeleteStudent = new FormEliminar();
            formDeleteStudent.StartPosition = FormStartPosition.CenterScreen;
            formDeleteStudent.Show();
            this.Hide();
        }
    }
}