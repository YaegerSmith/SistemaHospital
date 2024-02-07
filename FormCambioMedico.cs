using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace DSDPRN3MOVE2302B1_U3_A1
{
    public partial class FormCambioMedico : Form
    {

        public FormCambioMedico()
        {
            InitializeComponent();
        }

        private void FormCambioMedico_Load(object sender, EventArgs e)
        {
            // Cadena de conexión a la base de datos
            string connectionString = "Server=127.0.0.1;Database=PRN3S2B123MOVE;Uid=root;Pwd=;";

            // Crear la conexión
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Consulta SQL para seleccionar todos los registros de la tabla "pacientes"
                    string query = "SELECT * FROM pacientes";

                    // Crear un adaptador de datos y un DataSet
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();

                    // Llenar el DataSet con los datos de la tabla "pacientes"
                    adapter.Fill(dataSet, "pacientes");

                    // Enlazar el DataGridView con el DataSet
                    dataGridView_CambioMedico.DataSource = dataSet.Tables["pacientes"];

                    // Cargar los nombres de los médicos en el ComboBox
                    CargarNombresMedicos(connection);
                }
                catch (Exception ex)
                {
                    // Manejar cualquier excepción que pueda ocurrir durante la conexión o consulta
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void CargarNombresMedicos(MySqlConnection connection)
        {
            try
            {
                // Consulta SQL para seleccionar todos los nombres de médicos
                string query = "SELECT nombre_completo FROM medicos";

                // Crear un comando para ejecutar la consulta
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Crear un lector de datos para obtener los resultados
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    // Limpiar el ComboBox antes de agregar nuevos elementos
                    comboBox_MedicosDis.Items.Clear();

                    // Leer los nombres de los médicos y agregarlos al ComboBox
                    while (reader.Read())
                    {
                        string nombreMedico = reader.GetString(0); // El 0 representa la primera columna (nombre_completo)
                        comboBox_MedicosDis.Items.Add(nombreMedico);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la conexión o consulta
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void dataGridView_CambioMedico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_NombrePaciente_TextChanged(object sender, EventArgs e)
        {
        

        }


        private void button_BuscarPaciente_Click(object sender, EventArgs e)
        {
            string nombrePaciente = textBox_NombrePaciente.Text.Trim();

            // Verificar la longitud mínima y máxima
            if (nombrePaciente.Length < 3 || nombrePaciente.Length > 100)
            {
                MessageBox.Show("El nombre del paciente debe tener entre 3 y 100 caracteres.");
                textBox_NombrePaciente.Text = ""; // Limpiar el TextBox
                return;
            }

            // Utilizar una expresión regular para verificar si el nombre contiene solo letras y espacios
            if (!Regex.IsMatch(nombrePaciente, "^[a-zA-Z ]+$"))
            {
                MessageBox.Show("El nombre del paciente no debe contener caracteres especiales ni números.");
                textBox_NombrePaciente.Text = ""; // Limpiar el TextBox
                return;
            }


            if (!string.IsNullOrEmpty(nombrePaciente))
            {
                // Cadena de conexión a la base de datos
                string connectionString = "Server=127.0.0.1;Database=PRN3S2B123MOVE;Uid=root;Pwd=;";

                // Crear la conexión
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        // Abrir la conexión
                        connection.Open();

                        // Consulta SQL para buscar pacientes por nombre
                        string query = "SELECT * FROM pacientes WHERE nombre LIKE @nombre";

                        // Crear un adaptador de datos y un DataSet
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                        adapter.SelectCommand.Parameters.AddWithValue("@nombre", "%" + nombrePaciente + "%"); // Buscar coincidencias parciales
                        DataSet dataSet = new DataSet();

                        // Llenar el DataSet con los datos de los pacientes filtrados
                        adapter.Fill(dataSet, "pacientes");

                        // Enlazar el DataGridView con el DataSet
                        dataGridView_CambioMedico.DataSource = dataSet.Tables["pacientes"];
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier excepción que pueda ocurrir durante la conexión o consulta
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre de paciente para buscar.");
            }
        }

        private void comboBox_MedicosDis_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string nombreMedicoSeleccionado = comboBox_MedicosDis.SelectedItem.ToString();
          
        }

        private void button_CambiarMedico_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un paciente y un médico
            if (dataGridView_CambioMedico.SelectedRows.Count > 0 && comboBox_MedicosDis.SelectedItem != null)
            {
                // Obtener el ID del paciente seleccionado en el DataGridView
                int idPacienteSeleccionado = Convert.ToInt32(dataGridView_CambioMedico.SelectedRows[0].Cells["id_paciente"].Value);

                // Obtener el nombre del médico seleccionado en el ComboBox
                string nombreMedicoSeleccionado = comboBox_MedicosDis.SelectedItem.ToString();

                // Obtener el ID del médico correspondiente al nombre seleccionado
                int idMedicoSeleccionado = ObtenerIdMedicoPorNombre(nombreMedicoSeleccionado);

                if (idMedicoSeleccionado != -1)
                {
                    // Cadena de conexión a la base de datos
                    string connectionString = "Server=127.0.0.1;Database=PRN3S2B123MOVE;Uid=root;Pwd=;";

                    // Crear la conexión
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            // Abrir la conexión
                            connection.Open();

                            // Consulta SQL para actualizar el médico del paciente
                            string query = "UPDATE pacientes SET id_medico = @idMedico WHERE id_paciente = @idPaciente";

                            // Crear un comando para ejecutar la consulta
                            MySqlCommand cmd = new MySqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@idMedico", idMedicoSeleccionado);
                            cmd.Parameters.AddWithValue("@idPaciente", idPacienteSeleccionado);

                            // Ejecutar la consulta de actualización
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Actualizar el DataGridView para reflejar los cambios
                                string queryActualizar = "SELECT * FROM pacientes";
                                MySqlDataAdapter adapterActualizar = new MySqlDataAdapter(queryActualizar, connection);
                                DataSet dataSetActualizar = new DataSet();
                                adapterActualizar.Fill(dataSetActualizar, "pacientes");
                                dataGridView_CambioMedico.DataSource = dataSetActualizar.Tables["pacientes"];
                            }
                            else
                            {
                                MessageBox.Show("No se pudo cambiar el médico del paciente.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró un médico con el nombre seleccionado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un paciente y un médico.");
            }
        }
        // Método para obtener el ID del médico por su nombre
        private int ObtenerIdMedicoPorNombre(string nombreMedico)
        {
            int idMedico = -1;

            // Cadena de conexión a la base de datos
            string connectionString = "Server=127.0.0.1;Database=PRN3S2B123MOVE;Uid=root;Pwd=;";

            // Crear la conexión
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Consulta SQL para buscar el ID del médico por nombre
                    string query = "SELECT id_medico FROM medicos WHERE nombre_completo = @nombreMedico";

                    // Crear un comando para ejecutar la consulta
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nombreMedico", nombreMedico);

                    // Ejecutar la consulta y obtener el ID del médico
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        idMedico = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return idMedico;
        }

    }
}
