namespace WinAppStudentAdmin
{
    partial class FormEliminar
    {

        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private DataGridView dataGridViewStudents;
        private Button btnDelete;



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewStudents = new DataGridView();
            btnDelete = new Button();
            BotonRegresar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AllowUserToAddRows = false;
            dataGridViewStudents.AllowUserToDeleteRows = false;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(22, 26);
            dataGridViewStudents.MultiSelect = false;
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.ReadOnly = true;
            dataGridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStudents.Size = new Size(448, 393);
            dataGridViewStudents.TabIndex = 0;
            dataGridViewStudents.SelectionChanged += dataGridViewStudents_SelectionChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(476, 60);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 28);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // BotonRegresar
            // 
            BotonRegresar.Location = new Point(578, 60);
            BotonRegresar.Name = "BotonRegresar";
            BotonRegresar.Size = new Size(96, 28);
            BotonRegresar.TabIndex = 9;
            BotonRegresar.Text = "Regresar ";
            BotonRegresar.UseVisualStyleBackColor = true;
            BotonRegresar.Click += BotonRegresar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(476, 29);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 10;
            label1.Text = "Seleccione el estudiante";
            // 
            // FormEliminar
            // 
            ClientSize = new Size(686, 434);
            Controls.Add(label1);
            Controls.Add(BotonRegresar);
            Controls.Add(btnDelete);
            Controls.Add(dataGridViewStudents);
            Name = "FormEliminar";
            Text = "Student Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button BotonRegresar;
        private Label label1;
    }
}