namespace WinAppStudentAdmin
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;


        /// <param name="disposing"
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            BotonAgregar = new Button();
            BotonVisualizar = new Button();
            BotonActualizar = new Button();
            BotonEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(378, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // BotonAgregar
            // 
            BotonAgregar.Location = new Point(102, 93);
            BotonAgregar.Name = "BotonAgregar";
            BotonAgregar.Size = new Size(174, 38);
            BotonAgregar.TabIndex = 1;
            BotonAgregar.Text = "Agregar Estudiante";
            BotonAgregar.UseVisualStyleBackColor = true;
            BotonAgregar.Click += BotonAgregar_Click_1;
            // 
            // BotonVisualizar
            // 
            BotonVisualizar.Location = new Point(102, 137);
            BotonVisualizar.Name = "BotonVisualizar";
            BotonVisualizar.Size = new Size(174, 36);
            BotonVisualizar.TabIndex = 2;
            BotonVisualizar.Text = "Mostrar Lista Estudiantes";
            BotonVisualizar.UseVisualStyleBackColor = true;
            BotonVisualizar.Click += BotonVisualizar_Click_1;
            // 
            // BotonActualizar
            // 
            BotonActualizar.Location = new Point(102, 179);
            BotonActualizar.Name = "BotonActualizar";
            BotonActualizar.Size = new Size(174, 36);
            BotonActualizar.TabIndex = 3;
            BotonActualizar.Text = "Actualizar Datos";
            BotonActualizar.UseVisualStyleBackColor = true;
            BotonActualizar.Click += BotonActualizar_Click_1;
            // 
            // BotonEliminar
            // 
            BotonEliminar.Location = new Point(102, 221);
            BotonEliminar.Name = "BotonEliminar";
            BotonEliminar.Size = new Size(174, 36);
            BotonEliminar.TabIndex = 4;
            BotonEliminar.Text = "Eliminar Estudiante";
            BotonEliminar.UseVisualStyleBackColor = true;
            BotonEliminar.Click += BotonEliminar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 53);
            label1.Name = "label1";
            label1.Size = new Size(214, 15);
            label1.TabIndex = 5;
            label1.Text = "PROGRAMA DE GESTION ESTUDIANTES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 308);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 6;
            label2.Text = "By Max Carrión";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 332);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BotonEliminar);
            Controls.Add(BotonActualizar);
            Controls.Add(BotonVisualizar);
            Controls.Add(BotonAgregar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Button BotonAgregar;
        private Button BotonVisualizar;
        private Button BotonActualizar;
        private Button BotonEliminar;
        private Label label1;
        private Label label2;
    }
}