namespace DSDPRN3MOVE2302B1_U3_A1
{
    partial class FormCambioMedico
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
            this.dataGridView_CambioMedico = new System.Windows.Forms.DataGridView();
            this.button_BuscarPaciente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_NombrePaciente = new System.Windows.Forms.TextBox();
            this.comboBox_MedicosDis = new System.Windows.Forms.ComboBox();
            this.label_MedicosDis = new System.Windows.Forms.Label();
            this.button_CambiarMedico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CambioMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cambio de Medico a un Paciente";
            // 
            // dataGridView_CambioMedico
            // 
            this.dataGridView_CambioMedico.AllowUserToAddRows = false;
            this.dataGridView_CambioMedico.AllowUserToDeleteRows = false;
            this.dataGridView_CambioMedico.AllowUserToOrderColumns = true;
            this.dataGridView_CambioMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CambioMedico.Location = new System.Drawing.Point(64, 252);
            this.dataGridView_CambioMedico.Name = "dataGridView_CambioMedico";
            this.dataGridView_CambioMedico.ReadOnly = true;
            this.dataGridView_CambioMedico.RowHeadersWidth = 51;
            this.dataGridView_CambioMedico.RowTemplate.Height = 24;
            this.dataGridView_CambioMedico.Size = new System.Drawing.Size(975, 284);
            this.dataGridView_CambioMedico.TabIndex = 1;
            this.dataGridView_CambioMedico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CambioMedico_CellContentClick);
            // 
            // button_BuscarPaciente
            // 
            this.button_BuscarPaciente.Location = new System.Drawing.Point(306, 166);
            this.button_BuscarPaciente.Name = "button_BuscarPaciente";
            this.button_BuscarPaciente.Size = new System.Drawing.Size(126, 43);
            this.button_BuscarPaciente.TabIndex = 2;
            this.button_BuscarPaciente.Text = "Buscar Paciente";
            this.button_BuscarPaciente.UseVisualStyleBackColor = true;
            this.button_BuscarPaciente.Click += new System.EventHandler(this.button_BuscarPaciente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del Paciente";
            // 
            // textBox_NombrePaciente
            // 
            this.textBox_NombrePaciente.Location = new System.Drawing.Point(248, 91);
            this.textBox_NombrePaciente.Name = "textBox_NombrePaciente";
            this.textBox_NombrePaciente.Size = new System.Drawing.Size(247, 22);
            this.textBox_NombrePaciente.TabIndex = 4;
            this.textBox_NombrePaciente.TextChanged += new System.EventHandler(this.textBox_NombrePaciente_TextChanged);
            // 
            // comboBox_MedicosDis
            // 
            this.comboBox_MedicosDis.FormattingEnabled = true;
            this.comboBox_MedicosDis.Location = new System.Drawing.Point(714, 89);
            this.comboBox_MedicosDis.Name = "comboBox_MedicosDis";
            this.comboBox_MedicosDis.Size = new System.Drawing.Size(295, 24);
            this.comboBox_MedicosDis.TabIndex = 5;
            this.comboBox_MedicosDis.SelectedIndexChanged += new System.EventHandler(this.comboBox_MedicosDis_SelectedIndexChanged);
            // 
            // label_MedicosDis
            // 
            this.label_MedicosDis.AutoSize = true;
            this.label_MedicosDis.Location = new System.Drawing.Point(552, 91);
            this.label_MedicosDis.Name = "label_MedicosDis";
            this.label_MedicosDis.Size = new System.Drawing.Size(134, 16);
            this.label_MedicosDis.TabIndex = 6;
            this.label_MedicosDis.Text = "Medicos Disponibles";
            // 
            // button_CambiarMedico
            // 
            this.button_CambiarMedico.Location = new System.Drawing.Point(798, 166);
            this.button_CambiarMedico.Name = "button_CambiarMedico";
            this.button_CambiarMedico.Size = new System.Drawing.Size(107, 55);
            this.button_CambiarMedico.TabIndex = 7;
            this.button_CambiarMedico.Text = "Cambiar de Medico";
            this.button_CambiarMedico.UseVisualStyleBackColor = true;
            this.button_CambiarMedico.Click += new System.EventHandler(this.button_CambiarMedico_Click);
            // 
            // FormCambioMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 609);
            this.Controls.Add(this.button_CambiarMedico);
            this.Controls.Add(this.label_MedicosDis);
            this.Controls.Add(this.comboBox_MedicosDis);
            this.Controls.Add(this.textBox_NombrePaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_BuscarPaciente);
            this.Controls.Add(this.dataGridView_CambioMedico);
            this.Controls.Add(this.label1);
            this.Name = "FormCambioMedico";
            this.Text = "Hospital-Cambio de Medico";
            this.Load += new System.EventHandler(this.FormCambioMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CambioMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_CambioMedico;
        private System.Windows.Forms.Button button_BuscarPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_NombrePaciente;
        private System.Windows.Forms.ComboBox comboBox_MedicosDis;
        private System.Windows.Forms.Label label_MedicosDis;
        private System.Windows.Forms.Button button_CambiarMedico;
    }
}