using System.Xml.Linq;

namespace WinAppStudentAdmin
{
    partial class FormCrear
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAdd;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtGrade;
        private DataGridView dataGridViewStudents;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnAdd = new Button();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtGrade = new TextBox();
            dataGridViewStudents = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BotonRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(497, 192);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 28);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(559, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(165, 23);
            txtName.TabIndex = 1;
          
            // 
            // txtAge
            // 
            txtAge.Location = new Point(559, 81);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(165, 23);
            txtAge.TabIndex = 2;
           
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(559, 132);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(165, 23);
            txtGrade.TabIndex = 3;
           
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(25, 27);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.Size = new Size(448, 401);
            dataGridViewStudents.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(497, 33);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombres";
        
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(497, 84);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 6;
            label2.Text = "Edad";
        
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(497, 135);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 7;
            label3.Text = "Paralelo";
          
            // 
            // BotonRegresar
            // 
            BotonRegresar.Location = new Point(601, 192);
            BotonRegresar.Name = "BotonRegresar";
            BotonRegresar.Size = new Size(84, 28);
            BotonRegresar.TabIndex = 8;
            BotonRegresar.Text = "Regresar ";
            BotonRegresar.UseVisualStyleBackColor = true;
            BotonRegresar.Click += BotonRegresar_Click_1;
            // 
            // FormCrear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 441);
            Controls.Add(BotonRegresar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewStudents);
            Controls.Add(txtGrade);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(btnAdd);
            Name = "FormCrear";
            Text = "Create Student";
            Load += FormCreateStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Button BotonRegresar;
    }
}