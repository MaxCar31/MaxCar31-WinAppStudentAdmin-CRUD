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

namespace WinAppStudentAdmin
{
    public partial class FormMostarLista : Form
    {
        private StudentsDBClass context;
        public FormMostarLista()
        {
            InitializeComponent();
        }

        private void FormReadStudent_Load(object sender, EventArgs e)
        {
            context = new StudentsDBClass();
            context.Students.Load();
            dataGridView1.DataSource = context.Students.Local.ToBindingList();
        }
        private void FormReadStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            context.Dispose();
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
