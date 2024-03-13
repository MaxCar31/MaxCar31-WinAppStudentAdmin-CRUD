using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace WinAppStudentAdmin
{
    public partial class FormCrear : Form
    {
        private StudentsDBClass context;

        public FormCrear()
        {
            InitializeComponent();
        }

        private void FormCreateStudent_Load(object sender, EventArgs e)
        {
            PopulateStudents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            string grade = txtGrade.Text;

            context = new StudentsDBClass();

            var newStudent = new Student
            {
                Name = name,
                Age = age,
                Grade = grade
            };

            context.Students.Add(newStudent);
            context.SaveChanges();

            MessageBox.Show("Estudiante añadido correctamente");

            // Limpiar los campos después de agregar el estudiante
            txtName.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtGrade.Text = string.Empty;

            PopulateStudents();
        }

        private void PopulateStudents()
        {
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


        private void BotonRegresar_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.StartPosition = FormStartPosition.CenterScreen;
            form1.Show();
            this.Hide();
        }
    }
}
