namespace DSDPRN3MOVE2302B1_U3_A1
{
    partial class FormularioEspecialidades
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
            this.label_ID_Especialidad = new System.Windows.Forms.Label();
            this.textBox_ID_Especialidad = new System.Windows.Forms.TextBox();
            this.textBox_Nombre_Especialidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Especialidades = new System.Windows.Forms.DataGridView();
            this.button_Guardar_Esp = new System.Windows.Forms.Button();
            this.button_Eliminar_Esp = new System.Windows.Forms.Button();
            this.button_Actualizar_Esp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Especialidades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Especialidades.";
            // 
            // label_ID_Especialidad
            // 
            this.label_ID_Especialidad.AutoSize = true;
            this.label_ID_Especialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID_Especialidad.Location = new System.Drawing.Point(24, 104);
            this.label_ID_Especialidad.Name = "label_ID_Especialidad";
            this.label_ID_Especialidad.Size = new System.Drawing.Size(142, 18);
            this.label_ID_Especialidad.TabIndex = 1;
            this.label_ID_Especialidad.Text = "ID de la especialidad";
            // 
            // textBox_ID_Especialidad
            // 
            this.textBox_ID_Especialidad.Location = new System.Drawing.Point(186, 104);
            this.textBox_ID_Especialidad.Name = "textBox_ID_Especialidad";
            this.textBox_ID_Especialidad.Size = new System.Drawing.Size(144, 22);
            this.textBox_ID_Especialidad.TabIndex = 2;
            this.textBox_ID_Especialidad.TextChanged += new System.EventHandler(this.textBox_ID_Especialidad_TextChanged);
            // 
            // textBox_Nombre_Especialidad
            // 
            this.textBox_Nombre_Especialidad.Location = new System.Drawing.Point(186, 154);
            this.textBox_Nombre_Especialidad.Name = "textBox_Nombre_Especialidad";
            this.textBox_Nombre_Especialidad.Size = new System.Drawing.Size(212, 22);
            this.textBox_Nombre_Especialidad.TabIndex = 3;
            this.textBox_Nombre_Especialidad.TextChanged += new System.EventHandler(this.textBox_Nombre_Especialidad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Especialidad";
            // 
            // dataGridView_Especialidades
            // 
            this.dataGridView_Especialidades.AllowUserToAddRows = false;
            this.dataGridView_Especialidades.AllowUserToDeleteRows = false;
            this.dataGridView_Especialidades.AllowUserToOrderColumns = true;
            this.dataGridView_Especialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Especialidades.Location = new System.Drawing.Point(448, 104);
            this.dataGridView_Especialidades.Name = "dataGridView_Especialidades";
            this.dataGridView_Especialidades.ReadOnly = true;
            this.dataGridView_Especialidades.RowHeadersWidth = 51;
            this.dataGridView_Especialidades.RowTemplate.Height = 24;
            this.dataGridView_Especialidades.Size = new System.Drawing.Size(366, 210);
            this.dataGridView_Especialidades.TabIndex = 5;
            this.dataGridView_Especialidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Especialidades_CellContentClick);
            // 
            // button_Guardar_Esp
            // 
            this.button_Guardar_Esp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Guardar_Esp.Location = new System.Drawing.Point(27, 312);
            this.button_Guardar_Esp.Name = "button_Guardar_Esp";
            this.button_Guardar_Esp.Size = new System.Drawing.Size(87, 39);
            this.button_Guardar_Esp.TabIndex = 6;
            this.button_Guardar_Esp.Text = "Guardar";
            this.button_Guardar_Esp.UseVisualStyleBackColor = true;
            this.button_Guardar_Esp.Click += new System.EventHandler(this.button_Guardar_Esp_Click);
            // 
            // button_Eliminar_Esp
            // 
            this.button_Eliminar_Esp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Eliminar_Esp.Location = new System.Drawing.Point(145, 313);
            this.button_Eliminar_Esp.Name = "button_Eliminar_Esp";
            this.button_Eliminar_Esp.Size = new System.Drawing.Size(82, 39);
            this.button_Eliminar_Esp.TabIndex = 7;
            this.button_Eliminar_Esp.Text = "Eliminar";
            this.button_Eliminar_Esp.UseVisualStyleBackColor = true;
            this.button_Eliminar_Esp.Click += new System.EventHandler(this.button_Eliminar_Esp_Click);
            // 
            // button_Actualizar_Esp
            // 
            this.button_Actualizar_Esp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Actualizar_Esp.Location = new System.Drawing.Point(262, 311);
            this.button_Actualizar_Esp.Name = "button_Actualizar_Esp";
            this.button_Actualizar_Esp.Size = new System.Drawing.Size(97, 40);
            this.button_Actualizar_Esp.TabIndex = 8;
            this.button_Actualizar_Esp.Text = "Actualizar";
            this.button_Actualizar_Esp.UseVisualStyleBackColor = true;
            this.button_Actualizar_Esp.Click += new System.EventHandler(this.button_Actualizar_Esp_Click);
            // 
            // FormularioEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 455);
            this.Controls.Add(this.button_Actualizar_Esp);
            this.Controls.Add(this.button_Eliminar_Esp);
            this.Controls.Add(this.button_Guardar_Esp);
            this.Controls.Add(this.dataGridView_Especialidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Nombre_Especialidad);
            this.Controls.Add(this.textBox_ID_Especialidad);
            this.Controls.Add(this.label_ID_Especialidad);
            this.Controls.Add(this.label1);
            this.Name = "FormularioEspecialidades";
            this.Text = "Hospital-Especialidades";
            this.Load += new System.EventHandler(this.FormularioEspecialidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Especialidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ID_Especialidad;
        private System.Windows.Forms.TextBox textBox_ID_Especialidad;
        private System.Windows.Forms.TextBox textBox_Nombre_Especialidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Especialidades;
        private System.Windows.Forms.Button button_Guardar_Esp;
        private System.Windows.Forms.Button button_Eliminar_Esp;
        private System.Windows.Forms.Button button_Actualizar_Esp;
    }
}