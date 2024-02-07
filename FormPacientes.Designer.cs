namespace DSDPRN3MOVE2302B1_U3_A1
{
    partial class FormPacientes
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
            this.dataGridView_Pacientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_EliminarPaciente = new System.Windows.Forms.Button();
            this.button_ActualizarPaciente = new System.Windows.Forms.Button();
            this.button_GuardarPaciente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_IdPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_ApellidoPaterno = new System.Windows.Forms.TextBox();
            this.textBox_ApellidoMaterno = new System.Windows.Forms.TextBox();
            this.textBox_Direccion = new System.Windows.Forms.TextBox();
            this.textBox_Telefono = new System.Windows.Forms.TextBox();
            this.textBox_Celular = new System.Windows.Forms.TextBox();
            this.textBox_Edad = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_EstadoCivil = new System.Windows.Forms.TextBox();
            this.textBox_IdMedico = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_Sexo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox_Pag = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Pacientes
            // 
            this.dataGridView_Pacientes.AllowUserToAddRows = false;
            this.dataGridView_Pacientes.AllowUserToDeleteRows = false;
            this.dataGridView_Pacientes.AllowUserToOrderColumns = true;
            this.dataGridView_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Pacientes.Location = new System.Drawing.Point(12, 81);
            this.dataGridView_Pacientes.Name = "dataGridView_Pacientes";
            this.dataGridView_Pacientes.ReadOnly = true;
            this.dataGridView_Pacientes.RowHeadersWidth = 51;
            this.dataGridView_Pacientes.RowTemplate.Height = 24;
            this.dataGridView_Pacientes.Size = new System.Drawing.Size(1045, 207);
            this.dataGridView_Pacientes.TabIndex = 0;
            this.dataGridView_Pacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Pacientes_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pacientes del Hospital";
            // 
            // button_EliminarPaciente
            // 
            this.button_EliminarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EliminarPaciente.Location = new System.Drawing.Point(321, 725);
            this.button_EliminarPaciente.Name = "button_EliminarPaciente";
            this.button_EliminarPaciente.Size = new System.Drawing.Size(118, 36);
            this.button_EliminarPaciente.TabIndex = 2;
            this.button_EliminarPaciente.Text = "Eliminar";
            this.button_EliminarPaciente.UseVisualStyleBackColor = true;
            this.button_EliminarPaciente.Click += new System.EventHandler(this.button_EliminarPaciente_Click);
            // 
            // button_ActualizarPaciente
            // 
            this.button_ActualizarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ActualizarPaciente.Location = new System.Drawing.Point(642, 720);
            this.button_ActualizarPaciente.Name = "button_ActualizarPaciente";
            this.button_ActualizarPaciente.Size = new System.Drawing.Size(107, 41);
            this.button_ActualizarPaciente.TabIndex = 3;
            this.button_ActualizarPaciente.Text = "Actualizar";
            this.button_ActualizarPaciente.UseVisualStyleBackColor = true;
            this.button_ActualizarPaciente.Click += new System.EventHandler(this.button_ActualizarPaciente_Click);
            // 
            // button_GuardarPaciente
            // 
            this.button_GuardarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GuardarPaciente.Location = new System.Drawing.Point(489, 725);
            this.button_GuardarPaciente.Name = "button_GuardarPaciente";
            this.button_GuardarPaciente.Size = new System.Drawing.Size(105, 41);
            this.button_GuardarPaciente.TabIndex = 4;
            this.button_GuardarPaciente.Text = "Guardar";
            this.button_GuardarPaciente.UseVisualStyleBackColor = true;
            this.button_GuardarPaciente.Click += new System.EventHandler(this.button_GuardarPaciente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID del Paciente";
            // 
            // textBox_IdPaciente
            // 
            this.textBox_IdPaciente.Location = new System.Drawing.Point(274, 375);
            this.textBox_IdPaciente.Name = "textBox_IdPaciente";
            this.textBox_IdPaciente.Size = new System.Drawing.Size(222, 22);
            this.textBox_IdPaciente.TabIndex = 6;
            this.textBox_IdPaciente.TextChanged += new System.EventHandler(this.textBox_IdPaciente_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido Paterno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Apellido Materno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 576);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 624);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Télefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(627, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Celular";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(628, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Edad";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(627, 527);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(41, 16);
            this.label.TabIndex = 14;
            this.label.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(607, 576);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Estado Civil";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(274, 425);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(222, 22);
            this.textBox_Nombre.TabIndex = 16;
            this.textBox_Nombre.TextChanged += new System.EventHandler(this.textBox_Nombre_TextChanged);
            // 
            // textBox_ApellidoPaterno
            // 
            this.textBox_ApellidoPaterno.Location = new System.Drawing.Point(274, 481);
            this.textBox_ApellidoPaterno.Name = "textBox_ApellidoPaterno";
            this.textBox_ApellidoPaterno.Size = new System.Drawing.Size(222, 22);
            this.textBox_ApellidoPaterno.TabIndex = 17;
            this.textBox_ApellidoPaterno.TextChanged += new System.EventHandler(this.textBox_ApellidoPaterno_TextChanged);
            // 
            // textBox_ApellidoMaterno
            // 
            this.textBox_ApellidoMaterno.Location = new System.Drawing.Point(274, 527);
            this.textBox_ApellidoMaterno.Name = "textBox_ApellidoMaterno";
            this.textBox_ApellidoMaterno.Size = new System.Drawing.Size(222, 22);
            this.textBox_ApellidoMaterno.TabIndex = 18;
            this.textBox_ApellidoMaterno.TextChanged += new System.EventHandler(this.textBox_ApellidoMaterno_TextChanged);
            // 
            // textBox_Direccion
            // 
            this.textBox_Direccion.Location = new System.Drawing.Point(274, 576);
            this.textBox_Direccion.Name = "textBox_Direccion";
            this.textBox_Direccion.Size = new System.Drawing.Size(282, 22);
            this.textBox_Direccion.TabIndex = 19;
            this.textBox_Direccion.TextChanged += new System.EventHandler(this.textBox_Direccion_TextChanged);
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Location = new System.Drawing.Point(274, 624);
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.Size = new System.Drawing.Size(282, 22);
            this.textBox_Telefono.TabIndex = 20;
            this.textBox_Telefono.TextChanged += new System.EventHandler(this.textBox_Telefono_TextChanged);
            // 
            // textBox_Celular
            // 
            this.textBox_Celular.Location = new System.Drawing.Point(716, 375);
            this.textBox_Celular.Name = "textBox_Celular";
            this.textBox_Celular.Size = new System.Drawing.Size(282, 22);
            this.textBox_Celular.TabIndex = 21;
            this.textBox_Celular.TextChanged += new System.EventHandler(this.textBox_Celular_TextChanged);
            // 
            // textBox_Edad
            // 
            this.textBox_Edad.Location = new System.Drawing.Point(716, 425);
            this.textBox_Edad.Name = "textBox_Edad";
            this.textBox_Edad.Size = new System.Drawing.Size(282, 22);
            this.textBox_Edad.TabIndex = 22;
            this.textBox_Edad.TextChanged += new System.EventHandler(this.textBox_Edad_TextChanged);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(716, 521);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(282, 22);
            this.textBox_Email.TabIndex = 23;
            this.textBox_Email.TextChanged += new System.EventHandler(this.textBox_Email_TextChanged);
            // 
            // textBox_EstadoCivil
            // 
            this.textBox_EstadoCivil.Location = new System.Drawing.Point(716, 570);
            this.textBox_EstadoCivil.Name = "textBox_EstadoCivil";
            this.textBox_EstadoCivil.Size = new System.Drawing.Size(282, 22);
            this.textBox_EstadoCivil.TabIndex = 24;
            this.textBox_EstadoCivil.TextChanged += new System.EventHandler(this.textBox_EstadoCivil_TextChanged);
            // 
            // textBox_IdMedico
            // 
            this.textBox_IdMedico.Location = new System.Drawing.Point(716, 618);
            this.textBox_IdMedico.Name = "textBox_IdMedico";
            this.textBox_IdMedico.Size = new System.Drawing.Size(222, 22);
            this.textBox_IdMedico.TabIndex = 25;
            this.textBox_IdMedico.TextChanged += new System.EventHandler(this.textBox_IdMedico_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(595, 624);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "ID del Medico";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(627, 484);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Sexo";
            // 
            // textBox_Sexo
            // 
            this.textBox_Sexo.Location = new System.Drawing.Point(716, 475);
            this.textBox_Sexo.Name = "textBox_Sexo";
            this.textBox_Sexo.Size = new System.Drawing.Size(282, 22);
            this.textBox_Sexo.TabIndex = 28;
            this.textBox_Sexo.TextChanged += new System.EventHandler(this.textBox_Sexo_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(427, 309);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Paginas";
            // 
            // comboBox_Pag
            // 
            this.comboBox_Pag.FormattingEnabled = true;
            this.comboBox_Pag.Location = new System.Drawing.Point(528, 309);
            this.comboBox_Pag.Name = "comboBox_Pag";
            this.comboBox_Pag.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Pag.TabIndex = 30;
            this.comboBox_Pag.SelectedIndexChanged += new System.EventHandler(this.comboBox_Pag_SelectedIndexChanged);
            // 
            // FormPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 799);
            this.Controls.Add(this.comboBox_Pag);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_Sexo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_IdMedico);
            this.Controls.Add(this.textBox_EstadoCivil);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_Edad);
            this.Controls.Add(this.textBox_Celular);
            this.Controls.Add(this.textBox_Telefono);
            this.Controls.Add(this.textBox_Direccion);
            this.Controls.Add(this.textBox_ApellidoMaterno);
            this.Controls.Add(this.textBox_ApellidoPaterno);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_IdPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_GuardarPaciente);
            this.Controls.Add(this.button_ActualizarPaciente);
            this.Controls.Add(this.button_EliminarPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Pacientes);
            this.Name = "FormPacientes";
            this.Text = "Hospital-Pacientes";
            this.Load += new System.EventHandler(this.FormPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Pacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_EliminarPaciente;
        private System.Windows.Forms.Button button_ActualizarPaciente;
        private System.Windows.Forms.Button button_GuardarPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_IdPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_ApellidoPaterno;
        private System.Windows.Forms.TextBox textBox_ApellidoMaterno;
        private System.Windows.Forms.TextBox textBox_Direccion;
        private System.Windows.Forms.TextBox textBox_Telefono;
        private System.Windows.Forms.TextBox textBox_Celular;
        private System.Windows.Forms.TextBox textBox_Edad;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_EstadoCivil;
        private System.Windows.Forms.TextBox textBox_IdMedico;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_Sexo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox_Pag;
    }
}