using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinAppStudentAdmin
{
    public partial class FormEliminar : Form
    {

        private int selectedStudentId;

        public FormEliminar()
        {
            InitializeComponent();
            PopulateStudents();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {


            if (selectedStudentId != 0)
            {
                using (var context = new StudentsDBClass())
                {
                    var student = context.Students.Find(selectedStudentId);

                    if (student != null)
                    {
                        context.Students.Remove(student);
                        context.SaveChanges();

                        MessageBox.Show("Estudiante eliminado Correctamente");

                        PopulateStudents();
                    }
                }
            }

        }

        private void PopulateStudents()
        {
            dataGridViewStudents.Columns.Clear(); // Limpiar las columnas existentes

            using (var context = new StudentsDBClass())
            {
                var students = context.Students.ToList();

                dataGridViewStudents.Rows.Clear();

                // Agregar las columnas al DataGridView
                dataGridViewStudents.Columns.Add("Id", "ID");
                dataGridViewStudents.Columns.Add("Name", "Name");
                dataGridViewStudents.Columns.Add("Age", "Age");
                dataGridViewStudents.Columns.Add("Grade", "Grade");

                foreach (var student in students)
                {
                    dataGridViewStudents.Rows.Add(student.Id, student.Name, student.Age, student.Grade);
                }
            }
        }

        private void dataGridViewStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                selectedStudentId = (int)dataGridViewStudents.SelectedRows[0].Cells["Id"].Value;
            }
        }

    
        private void BotonRegresar_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.StartPosition = FormStartPosition.CenterScreen;
            form1.Show();
            this.Hide();
        }
    }
}
