//Bibliotecas.
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DSDPRN3MOVE2302B1_U3_A1
{
    public partial class EstadoCivilFormMOVE : Form
    {
        public EstadoCivilFormMOVE()
        {
            InitializeComponent();

            // Suscribe el evento KeyPress al TextBox textBox1_ID_EstadoCivil.
            textBox1_ID_EstadoCivil.KeyPress += new KeyPressEventHandler(textBox1_ID_EstadoCivil_KeyPress);
        }

        private void textBox1_ID_EstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número ni la tecla Backspace.
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Cancela la entrada del usuario si no es un número ni Backspace.
                e.Handled = true;
            }
        }


        private void EstadoCivil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EstadoCivilFormMOVE_Load(object sender, EventArgs e)
        {
            // Configura la cadena de conexión a la base de datos MySQL.
            string connectionString = "Server=127.0.0.1;Database=PRN3S2B123MOVE;Uid=root;Pwd=;";

            // Crea una conexión a la base de datos.
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                // Abre la conexión a la base de datos.
                connection.Open();

                // Crea una consulta SQL para seleccionar el ID del paciente y su estado civil desde la tabla pacientes.
                string query = "SELECT id_paciente, estado_civil FROM pacientes";

                // Crea un adaptador de datos y un DataTable para almacenar los resultados.
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                // Llena el DataTable con los datos de la base de datos.
                adapter.Fill(dataTable);

                // Enlaza los datos al DataGridView
                EstadoCivil.DataSource = dataTable;

                // Cierra la conexión.
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar datos: " + ex.Message);
            }
            finally
            {
                // Asegúrate de cerrar la conexión en caso de excepción.
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void textBox1_ID_EstadoCivil_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_EstadoCivil_TextChanged(object sender, EventArgs e)
        {
            // Obtén el texto del TextBox.
            string input = textBox_EstadoCivil.Text;

            // Verifica si el texto tiene un solo carácter y si ese carácter es uno de los números válidos.
            if (input.Length == 1 && "12345".Contains(input))
            {
                // El valor es válido.
                // No se hace nada aquí, ya que el valor es correcto.
            }
            else
            {
                // El valor no es válido, así que se limpia el TextBox.
                textBox_EstadoCivil.Clear();
                MessageBox.Show("Estado civil debe ser un número válido (1, 2, 3, 4 o 5).");
            }
        }


        //Botón para guardar.
        private void button1_EstadoCivil_Guardar_Click(object sender, EventArgs e)
        {
            //Obtén el ID del paciente y el estado civil desde los TextBox.
            int idPaciente;
            int estadoCivil;

            if (int.TryParse(textBox1_ID_EstadoCivil.Text, out idPaciente) && int.TryParse(textBox_EstadoCivil.Text, out estadoCivil))
            {
                //Configura la cadena de conexión a la base de datos MySQL.
                string connectionString = "Server=127.0.0.1;Database=PRN3S2B123MOVE;Uid=root;Pwd=;";

                //Crea una conexión a la base de datos.
                MySqlConnection connection = new MySqlConnection(connectionString);

                try
                {
                    //Abre la conexión a la base de datos.
                    connection.Open();

                    // Crea una consulta SQL para insertar el ID del paciente y el estado civil en la tabla pacientes.
                    string insertQuery = "INSERT INTO pacientes (id_paciente, estado_civil) VALUES (@idPaciente, @estadoCivil)";
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);

                    //Agrega los parámetros para la consulta.
                    command.Parameters.AddWithValue("@idPaciente", idPaciente);
                    command.Parameters.AddWithValue("@estadoCivil", estadoCivil);

                    //Ejecuta la consulta.
                    command.ExecuteNonQuery();

                    //Actualiza el DataGridView.
                    EstadoCivilFormMOVE_Load(sender, e);

                    //Limpia los TextBox después de la inserción.
                    textBox1_ID_EstadoCivil.Clear();
                    textBox_EstadoCivil.Clear();

                    MessageBox.Show("Datos guardados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar datos: " + ex.Message);
                }
                finally
                {
                    //Asegurarse de cerrar la conexión en caso de excepción.
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("ID del paciente y estado civil deben ser números válidos.");
            }
        }

        //Botón para eliminar.
        private void button2_EstadoCivil_Eliminar_Click(object sender, EventArgs e)
        {
            //Obtén el ID del paciente desde el TextBox.
            int idPaciente;

            if (int.TryParse(textBox1_ID_EstadoCivil.Text, out idPaciente))
            {
                //Configura la cadena de conexión a la base de datos MySQL.
                string connectionString = "Server=127.0.0.1;Database=PRN3S2B123MOVE;Uid=root;Pwd=;";

                //Crea una conexión a la base de datos.
                MySqlConnection connection = new MySqlConnection(connectionString);

                try
                {
                    //Abre la conexión a la base de datos.
                    connection.Open();

                    //Crea una consulta SQL para eliminar el paciente de la tabla pacientes.
                    string deleteQuery = "DELETE FROM pacientes WHERE id_paciente = @idPaciente";
                    MySqlCommand command = new MySqlCommand(deleteQuery, connection);

                    //Agrega el parámetro para la consulta.
                    command.Parameters.AddWithValue("@idPaciente", idPaciente);

                    //Ejecuta la consulta.
                    command.ExecuteNonQuery();

                    //Actualiza el DataGridView
                    EstadoCivilFormMOVE_Load(sender, e);

                    //Limpia el TextBox después de la eliminación.
                    textBox1_ID_EstadoCivil.Clear();

                    MessageBox.Show("Paciente eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar paciente: " + ex.Message);
                }
                finally
                {
                    //Asegurarse de cerrar la conexión en caso de excepción.
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("ID del paciente debe ser un número válido.");
            }
        }

        //Botón para actualizar.
        private void button3_EstadoCivil_Actualizar_Click(object sender, EventArgs e)
        {
            //Obtén el ID del paciente y el estado civil desde los TextBox.
            int idPaciente;
            int estadoCivil;

            if (int.TryParse(textBox1_ID_EstadoCivil.Text, out idPaciente) && int.TryParse(textBox_EstadoCivil.Text, out estadoCivil))
            {
                //Configura la cadena de conexión a la base de datos MySQL.
                string connectionString = "Server=127.0.0.1;Database=PRN3S2B123MOVE;Uid=root;Pwd=;";

                //Crea una conexión a la base de datos.
                MySqlConnection connection = new MySqlConnection(connectionString);

                try
                {
                    //Abre la conexión a la base de datos.
                    connection.Open();

                    //Crea una consulta SQL para actualizar el estado civil del paciente en la tabla pacientes.
                    string updateQuery = "UPDATE pacientes SET estado_civil = @estadoCivil WHERE id_paciente = @idPaciente";
                    MySqlCommand command = new MySqlCommand(updateQuery, connection);

                    //Agrega los parámetros para la consulta.
                    command.Parameters.AddWithValue("@idPaciente", idPaciente);
                    command.Parameters.AddWithValue("@estadoCivil", estadoCivil);

                    //Ejecuta la consulta.
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Datos actualizados correctamente.");

                        //Actualiza el DataGridView.
                        EstadoCivilFormMOVE_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún paciente con el ID proporcionado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar datos: " + ex.Message);
                }
                finally
                {
                    //Asegurarse de cerrar la conexión en caso de excepción.
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("ID del paciente y estado civil deben ser números válidos.");
            }
        }
    }
}
