namespace WinAppStudentAdmin
{
    partial class FormActualizar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            dataGridViewStudents = new DataGridView();
            btnUpdate = new Button();
            textName = new TextBox();
            textAge = new TextBox();
            textGrade = new TextBox();
            BotonRegresar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(12, 26);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.Size = new Size(448, 416);
            dataGridViewStudents.TabIndex = 0;
            dataGridViewStudents.SelectionChanged += dataGridViewStudents_SelectionChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(511, 179);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 31);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // textName
            // 
            textName.Location = new Point(540, 58);
            textName.Name = "textName";
            textName.Size = new Size(172, 23);
            textName.TabIndex = 1;
            // 
            // textAge
            // 
            textAge.Location = new Point(540, 96);
            textAge.Name = "textAge";
            textAge.Size = new Size(172, 23);
            textAge.TabIndex = 2;
            // 
            // textGrade
            // 
            textGrade.Location = new Point(540, 136);
            textGrade.Name = "textGrade";
            textGrade.Size = new Size(172, 23);
            textGrade.TabIndex = 3;
            // 
            // BotonRegresar
            // 
            BotonRegresar.Location = new Point(627, 180);
            BotonRegresar.Name = "BotonRegresar";
            BotonRegresar.Size = new Size(84, 29);
            BotonRegresar.TabIndex = 9;
            BotonRegresar.Text = "Regresar ";
            BotonRegresar.UseVisualStyleBackColor = true;
            BotonRegresar.Click += BotonRegresar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(480, 61);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 10;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(480, 99);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 11;
            label2.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(475, 31);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 12;
            label3.Text = "Seleccione el estudiante ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(480, 139);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 13;
            label4.Text = "Paralelo";
            // 
            // FormActualizar
            // 
            ClientSize = new Size(733, 472);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BotonRegresar);
            Controls.Add(dataGridViewStudents);
            Controls.Add(textName);
            Controls.Add(textAge);
            Controls.Add(textGrade);
            Controls.Add(btnUpdate);
            Name = "FormActualizar";
          
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataGridViewStudents;
        private Button btnUpdate;
        private TextBox textName;
        private TextBox textAge;
        private TextBox textGrade;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion

        private Button BotonRegresar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}