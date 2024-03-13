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
    public partial class FormActualizar : Form
    {
        public FormActualizar()
        {
            InitializeComponent();
            PopulateStudents();
        }
        private int selectedStudentId;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStudentId != 0)
            {
                string newName = textName.Text;
                int newAge = Convert.ToInt32(textAge.Text);
                string newGrade = textGrade.Text;

                using (var context = new StudentsDBClass())
                {
                    var student = context.Students.Find(selectedStudentId);

                    if (student != null)
                    {
                        student.Name = newName;
                        student.Age = newAge;
                        student.Grade = newGrade;

                        context.SaveChanges();

                        MessageBox.Show("Datos actualizados correctamente");

                        PopulateStudents();
                    }
                }
            }
        }

        private void PopulateStudents()
        {
            using (var context = new StudentsDBClass())
            {
                var students = context.Students.ToList();

                dataGridViewStudents.Rows.Clear();
                dataGridViewStudents.Columns.Clear();

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
                string name = (string)dataGridViewStudents.SelectedRows[0].Cells["Name"].Value;
                int age = (int)dataGridViewStudents.SelectedRows[0].Cells["Age"].Value;
                string grade = (string)dataGridViewStudents.SelectedRows[0].Cells["Grade"].Value;

                textName.Text = name;
                textAge.Text = age.ToString();
                textGrade.Text = grade;
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
