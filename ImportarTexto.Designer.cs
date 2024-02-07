namespace DSDPRN3MOVE2302B1_U3_A1
{
    partial class ImportarTexto
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
            this.dataGridView_Pacientes = new System.Windows.Forms.DataGridView();
            this.button_ImportarTXT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Importación de archivo de texto.";
            // 
            // dataGridView_Pacientes
            // 
            this.dataGridView_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Pacientes.Location = new System.Drawing.Point(43, 111);
            this.dataGridView_Pacientes.Name = "dataGridView_Pacientes";
            this.dataGridView_Pacientes.RowHeadersWidth = 51;
            this.dataGridView_Pacientes.RowTemplate.Height = 24;
            this.dataGridView_Pacientes.Size = new System.Drawing.Size(1067, 196);
            this.dataGridView_Pacientes.TabIndex = 1;
            this.dataGridView_Pacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Pacientes_CellContentClick);
            // 
            // button_ImportarTXT
            // 
            this.button_ImportarTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ImportarTXT.Location = new System.Drawing.Point(485, 383);
            this.button_ImportarTXT.Name = "button_ImportarTXT";
            this.button_ImportarTXT.Size = new System.Drawing.Size(97, 33);
            this.button_ImportarTXT.TabIndex = 2;
            this.button_ImportarTXT.Text = "Importar";
            this.button_ImportarTXT.UseVisualStyleBackColor = true;
            this.button_ImportarTXT.Click += new System.EventHandler(this.button_ImportarTXT_Click);
            // 
            // ImportarTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 610);
            this.Controls.Add(this.button_ImportarTXT);
            this.Controls.Add(this.dataGridView_Pacientes);
            this.Controls.Add(this.label1);
            this.Name = "ImportarTexto";
            this.Text = "Hospital-Importar";
            this.Load += new System.EventHandler(this.ImportarTexto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Pacientes;
        private System.Windows.Forms.Button button_ImportarTXT;
    }
}