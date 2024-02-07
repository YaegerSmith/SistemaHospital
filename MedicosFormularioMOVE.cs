//Bibliotecas.
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DSDPRN3MOVE2302B1_U3_A1
{
    public partial class MedicosFormularioMOVE : Form
    {
        public MedicosFormularioMOVE()
        {
            InitializeComponent();

            //Suscribir el controlador de eventos KeyPress al textBox_ID_Medico.
            textBox_ID_Medico.KeyPress += new KeyPressEventHandler(textBox_ID_Medico_KeyPress);

            // Agrega el evento TextChanged al textBox_Nombre_Medico
            textBox_Nombre_Medico.TextChanged += TextBox_Nombre_Medico_TextChanged;
        }

        private void TextBox_Nombre_Medico_TextChanged(object sender, EventArgs e)
        {
            // Validación de caracteres especiales y longitud máxima
            string nombreMedico = textBox_Nombre_Medico.Text;

            // Verifica si el texto contiene caracteres especiales
            if (!Regex.IsMatch(nombreMedico, "^[a-zA-Z0-9 ]*$"))
            {
                MessageBox.Show("El nombre del médico no debe contener caracteres especiales.");
                textBox_Nombre_Medico.Text = ""; // Limpia el campo
                return;
            }

            // Verifica si la longitud supera los 20 caracteres
            if (nombreMedico.Length > 20)
            {
                MessageBox.Show("El nombre del médico no puede tener más de 20 caracteres.");
                textBox_Nombre_Medico.Text = nombreMedico.Substring(0, 20); // Trunca a 20 caracteres
            }
        }


        private void textBox_ID_Medico_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número ni la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Suprimir la tecla que no sea un número ni retroceso
            }
        }



        private void MedicosFormularioMOVE_Load(object sender, EventArgs e)
        {
            //Establecer la cadena de conexión a la base de datos.
            string connectionString = "Server=127.0.0.1;Database=PRN3S2B123MOVE;Uid=root;Pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //Consulta SQL para seleccionar los datos de la tabla medicos.
                    string query = "SELECT id_medico, nombre_completo, cedula, id_especialidad FROM medicos";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            //Asignar los datos al DataGridView
                            dataGridView_Medicos.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }

        private void dataGridView_Medicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Botón para guardar.
        private void button_Guardar_Medico_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            int idMedico = int.Parse(textBox_ID_Medico.Text);
            string nombreMedico = textBox_Nombre_Medico.Text;
            int cedulaMedico = int.Parse(textBox_Cedula_Medico.Text);
            int idEspecialidadMedico = int.Parse(textBox_Especialidad_Medico.Text);

            //Cadena de conexión a la base de datos.
            string connectionString = "Server=127.0.0.1;Database=PRN3S2B123MOVE;Uid=root;Pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //Consulta SQL para insertar un nuevo médico.
                    string insertQuery = "INSERT INTO medicos (id_medico, nombre_completo, cedula, id_especialidad) " +
                                          "VALUES (@idMedico, @nombreMedico, @cedulaMedico, @idEspecialidadMedico)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@idMedico", idMedico);
                        cmd.Parameters.AddWithValue("@nombreMedico", nombreMedico);
                        cmd.Parameters.AddWithValue("@cedulaMedico", cedulaMedico);
                        cmd.Parameters.AddWithValue("@idEspecialidadMedico", idEspecialidadMedico);

                        cmd.ExecuteNonQuery();
                    }

                    //Refrescar los datos en el DataGridView.
                    string selectQuery = "SELECT id_medico, nombre_completo, cedula, id_especialidad FROM medicos";
                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView_Medicos.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar datos: " + ex.Message);
                }
            }

        }

            private void textBox_ID_Medico_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Nombre_Medico_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Cedula_Medico_TextChanged(object sender, EventArgs e)
        {
            // Verificar si el texto contiene caracteres no numéricos
            if (!int.TryParse(textBox_Cedula_Medico.Text, out _))
            {
                MessageBox.Show("La cédula del médico debe ser un número entero.");
                textBox_Cedula_Medico.Text = ""; // Limpia el campo
            }
        }

private void textBox_Especialidad_Medico_TextChanged(object sender, EventArgs e)
{
    // Verificar si el texto contiene caracteres no numéricos
    if (!int.TryParse(textBox_Especialidad_Medico.Text, out _))
    {
        MessageBox.Show("La especialidad del médico debe ser un número entero.");
        textBox_Especialidad_Medico.Text = ""; // Limpia el campo
    }
}

        //Botón para eliminar.
        private void button_Eliminar_Medico_Click(object sender, EventArgs e)
        {
            // Obtener el valor del id_medico que se desea eliminar
            int idMedicoEliminar = int.Parse(textBox_ID_Medico.Text);

            // Cadena de conexión a la base de datos
            string connectionString = "Server=127.0.0.1;Database=PRN3S2B123MOVE;Uid=root;Pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta SQL para eliminar el médico por su id_medico
                    string deleteQuery = "DELETE FROM medicos WHERE id_medico = @idMedicoEliminar";

                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@idMedicoEliminar", idMedicoEliminar);
                        cmd.ExecuteNonQuery();
                    }

                    // Refrescar los datos en el DataGridView después de eliminar
                    string selectQuery = "SELECT id_medico, nombre_completo, cedula, id_especialidad FROM medicos";
                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView_Medicos.DataSource = dataTable;
                        }
                    }

                    //Limpiar los TextBox después de eliminar
                    textBox_ID_Medico.Clear();
                    textBox_Nombre_Medico.Clear();
                    textBox_Cedula_Medico.Clear();
                    textBox_Especialidad_Medico.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el médico: " + ex.Message);
                }
            }
        }

        //Botón para actualizar.
        private void button_Actualizar_Medico_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            int idMedico = int.Parse(textBox_ID_Medico.Text);
            string nombreMedico = textBox_Nombre_Medico.Text;
            int cedulaMedico = int.Parse(textBox_Cedula_Medico.Text);
            int idEspecialidadMedico = int.Parse(textBox_Especialidad_Medico.Text);

            // Cadena de conexión a la base de datos
            string connectionString = "Server=127.0.0.1;Database=PRN3S2B123MOVE;Uid=root;Pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta SQL para actualizar el médico por su id_medico
                    string updateQuery = "UPDATE medicos SET nombre_completo = @nombreMedico, cedula = @cedulaMedico, " +
                                         "id_especialidad = @idEspecialidadMedico WHERE id_medico = @idMedico";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@idMedico", idMedico);
                        cmd.Parameters.AddWithValue("@nombreMedico", nombreMedico);
                        cmd.Parameters.AddWithValue("@cedulaMedico", cedulaMedico);
                        cmd.Parameters.AddWithValue("@idEspecialidadMedico", idEspecialidadMedico);

                        cmd.ExecuteNonQuery();
                    }

                    // Refrescar los datos en el DataGridView después de actualizar
                    string selectQuery = "SELECT id_medico, nombre_completo, cedula, id_especialidad FROM medicos";
                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView_Medicos.DataSource = dataTable;
                        }
                    }

                    MessageBox.Show("Los datos del médico han sido actualizados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar datos: " + ex.Message);
                }
            }
        }
    }
}
