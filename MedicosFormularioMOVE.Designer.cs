namespace DSDPRN3MOVE2302B1_U3_A1
{
    partial class MedicosFormularioMOVE
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label_ID_Medico = new System.Windows.Forms.Label();
            this.textBox_ID_Medico = new System.Windows.Forms.TextBox();
            this.label_NombreMedico = new System.Windows.Forms.Label();
            this.textBox_Nombre_Medico = new System.Windows.Forms.TextBox();
            this.label_Cedula_Medico = new System.Windows.Forms.Label();
            this.textBox_Cedula_Medico = new System.Windows.Forms.TextBox();
            this.label_Especialidad_Medico = new System.Windows.Forms.Label();
            this.textBox_Especialidad_Medico = new System.Windows.Forms.TextBox();
            this.dataGridView_Medicos = new System.Windows.Forms.DataGridView();
            this.button_Guardar_Medico = new System.Windows.Forms.Button();
            this.button_Eliminar_Medico = new System.Windows.Forms.Button();
            this.button_Actualizar_Medico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Medicos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Información de los Médicos.";
            // 
            // label_ID_Medico
            // 
            this.label_ID_Medico.AutoSize = true;
            this.label_ID_Medico.Location = new System.Drawing.Point(96, 102);
            this.label_ID_Medico.Name = "label_ID_Medico";
            this.label_ID_Medico.Size = new System.Drawing.Size(90, 16);
            this.label_ID_Medico.TabIndex = 1;
            this.label_ID_Medico.Text = "lD del Médico";
            // 
            // textBox_ID_Medico
            // 
            this.textBox_ID_Medico.Location = new System.Drawing.Point(221, 99);
            this.textBox_ID_Medico.Name = "textBox_ID_Medico";
            this.textBox_ID_Medico.Size = new System.Drawing.Size(192, 22);
            this.textBox_ID_Medico.TabIndex = 2;
            this.textBox_ID_Medico.TextChanged += new System.EventHandler(this.textBox_ID_Medico_TextChanged);
            // 
            // label_NombreMedico
            // 
            this.label_NombreMedico.AutoSize = true;
            this.label_NombreMedico.Location = new System.Drawing.Point(121, 153);
            this.label_NombreMedico.Name = "label_NombreMedico";
            this.label_NombreMedico.Size = new System.Drawing.Size(56, 16);
            this.label_NombreMedico.TabIndex = 3;
            this.label_NombreMedico.Text = "Nombre";
            // 
            // textBox_Nombre_Medico
            // 
            this.textBox_Nombre_Medico.Location = new System.Drawing.Point(221, 153);
            this.textBox_Nombre_Medico.Name = "textBox_Nombre_Medico";
            this.textBox_Nombre_Medico.Size = new System.Drawing.Size(192, 22);
            this.textBox_Nombre_Medico.TabIndex = 4;
            this.textBox_Nombre_Medico.TextChanged += new System.EventHandler(this.textBox_Nombre_Medico_TextChanged);
            // 
            // label_Cedula_Medico
            // 
            this.label_Cedula_Medico.AutoSize = true;
            this.label_Cedula_Medico.Location = new System.Drawing.Point(124, 207);
            this.label_Cedula_Medico.Name = "label_Cedula_Medico";
            this.label_Cedula_Medico.Size = new System.Drawing.Size(50, 16);
            this.label_Cedula_Medico.TabIndex = 5;
            this.label_Cedula_Medico.Text = "Cedula";
            // 
            // textBox_Cedula_Medico
            // 
            this.textBox_Cedula_Medico.Location = new System.Drawing.Point(221, 200);
            this.textBox_Cedula_Medico.Name = "textBox_Cedula_Medico";
            this.textBox_Cedula_Medico.Size = new System.Drawing.Size(192, 22);
            this.textBox_Cedula_Medico.TabIndex = 6;
            this.textBox_Cedula_Medico.TextChanged += new System.EventHandler(this.textBox_Cedula_Medico_TextChanged);
            // 
            // label_Especialidad_Medico
            // 
            this.label_Especialidad_Medico.AutoSize = true;
            this.label_Especialidad_Medico.Location = new System.Drawing.Point(75, 261);
            this.label_Especialidad_Medico.Name = "label_Especialidad_Medico";
            this.label_Especialidad_Medico.Size = new System.Drawing.Size(111, 16);
            this.label_Especialidad_Medico.TabIndex = 7;
            this.label_Especialidad_Medico.Text = "Especialidad (ID)";
            // 
            // textBox_Especialidad_Medico
            // 
            this.textBox_Especialidad_Medico.Location = new System.Drawing.Point(221, 261);
            this.textBox_Especialidad_Medico.Name = "textBox_Especialidad_Medico";
            this.textBox_Especialidad_Medico.Size = new System.Drawing.Size(192, 22);
            this.textBox_Especialidad_Medico.TabIndex = 8;
            this.textBox_Especialidad_Medico.TextChanged += new System.EventHandler(this.textBox_Especialidad_Medico_TextChanged);
            // 
            // dataGridView_Medicos
            // 
            this.dataGridView_Medicos.AllowUserToAddRows = false;
            this.dataGridView_Medicos.AllowUserToDeleteRows = false;
            this.dataGridView_Medicos.AllowUserToOrderColumns = true;
            this.dataGridView_Medicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Medicos.Location = new System.Drawing.Point(448, 69);
            this.dataGridView_Medicos.Name = "dataGridView_Medicos";
            this.dataGridView_Medicos.ReadOnly = true;
            this.dataGridView_Medicos.RowHeadersWidth = 51;
            this.dataGridView_Medicos.RowTemplate.Height = 24;
            this.dataGridView_Medicos.Size = new System.Drawing.Size(616, 269);
            this.dataGridView_Medicos.TabIndex = 9;
            this.dataGridView_Medicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Medicos_CellContentClick);
            // 
            // button_Guardar_Medico
            // 
            this.button_Guardar_Medico.Location = new System.Drawing.Point(98, 361);
            this.button_Guardar_Medico.Name = "button_Guardar_Medico";
            this.button_Guardar_Medico.Size = new System.Drawing.Size(88, 36);
            this.button_Guardar_Medico.TabIndex = 10;
            this.button_Guardar_Medico.Text = "Guardar";
            this.button_Guardar_Medico.UseVisualStyleBackColor = true;
            this.button_Guardar_Medico.Click += new System.EventHandler(this.button_Guardar_Medico_Click);
            // 
            // button_Eliminar_Medico
            // 
            this.button_Eliminar_Medico.Location = new System.Drawing.Point(225, 361);
            this.button_Eliminar_Medico.Name = "button_Eliminar_Medico";
            this.button_Eliminar_Medico.Size = new System.Drawing.Size(96, 35);
            this.button_Eliminar_Medico.TabIndex = 11;
            this.button_Eliminar_Medico.Text = "Eliminar";
            this.button_Eliminar_Medico.UseVisualStyleBackColor = true;
            this.button_Eliminar_Medico.Click += new System.EventHandler(this.button_Eliminar_Medico_Click);
            // 
            // button_Actualizar_Medico
            // 
            this.button_Actualizar_Medico.Location = new System.Drawing.Point(370, 361);
            this.button_Actualizar_Medico.Name = "button_Actualizar_Medico";
            this.button_Actualizar_Medico.Size = new System.Drawing.Size(87, 35);
            this.button_Actualizar_Medico.TabIndex = 12;
            this.button_Actualizar_Medico.Text = "Actualizar";
            this.button_Actualizar_Medico.UseVisualStyleBackColor = true;
            this.button_Actualizar_Medico.Click += new System.EventHandler(this.button_Actualizar_Medico_Click);
            // 
            // MedicosFormularioMOVE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 477);
            this.Controls.Add(this.button_Actualizar_Medico);
            this.Controls.Add(this.button_Eliminar_Medico);
            this.Controls.Add(this.button_Guardar_Medico);
            this.Controls.Add(this.dataGridView_Medicos);
            this.Controls.Add(this.textBox_Especialidad_Medico);
            this.Controls.Add(this.label_Especialidad_Medico);
            this.Controls.Add(this.textBox_Cedula_Medico);
            this.Controls.Add(this.label_Cedula_Medico);
            this.Controls.Add(this.textBox_Nombre_Medico);
            this.Controls.Add(this.label_NombreMedico);
            this.Controls.Add(this.textBox_ID_Medico);
            this.Controls.Add(this.label_ID_Medico);
            this.Controls.Add(this.label1);
            this.Name = "MedicosFormularioMOVE";
            this.Text = "Hospital-Médicos";
            this.Load += new System.EventHandler(this.MedicosFormularioMOVE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Medicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ID_Medico;
        private System.Windows.Forms.TextBox textBox_ID_Medico;
        private System.Windows.Forms.Label label_NombreMedico;
        private System.Windows.Forms.TextBox textBox_Nombre_Medico;
        private System.Windows.Forms.Label label_Cedula_Medico;
        private System.Windows.Forms.TextBox textBox_Cedula_Medico;
        private System.Windows.Forms.Label label_Especialidad_Medico;
        private System.Windows.Forms.TextBox textBox_Especialidad_Medico;
        private System.Windows.Forms.DataGridView dataGridView_Medicos;
        private System.Windows.Forms.Button button_Guardar_Medico;
        private System.Windows.Forms.Button button_Eliminar_Medico;
        private System.Windows.Forms.Button button_Actualizar_Medico;
    }
}