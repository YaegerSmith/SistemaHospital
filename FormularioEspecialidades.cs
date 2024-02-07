//Bibliotecas.
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DSDPRN3MOVE2302B1_U3_A1
{
    public partial class FormularioEspecialidades : Form
    {
        public FormularioEspecialidades()
        {
            InitializeComponent();
            //Evento KeyPress al textBox_ID_Especialidad
            textBox_ID_Especialidad.KeyPress += textBox_ID_Especialidad_KeyPress;
        }

        private void textBox_ID_Especialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número o una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Bloquear la entrada
                e.Handled = true;
            }
        }

        private void textBox_Nombre_Especialidad_TextChanged(object sender, EventArgs e)
        {
            // Verificar si la longitud del texto en el textBox es mayor que 20.
            if (textBox_Nombre_Especialidad.Text.Length > 20)
            {
                // Si es mayor, recortar el texto para que tenga solo 20 caracteres.
                textBox_Nombre_Especialidad.Text = textBox_Nombre_Especialidad.Text.Substring(0, 20);

                // Establecer el cursor al final del texto.
                textBox_Nombre_Especialidad.SelectionStart = textBox_Nombre_Especialidad.Text.Length;

                // Mostrar un mensaje de advertencia al usuario.
                MessageBox.Show("El nombre de especialidad no puede tener más de 20 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormularioEspecialidades_Load(object sender, EventArgs e)
        {
            //Establecer la cadena de conexión a la base de datos.
            string connectionString = "Server=127.0.0.1;Database=PRN3S2B123MOVE;Uid=root;Pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //Consulta SQL para seleccionar los datos de la tabla especialidades.
                    string query = "SELECT id_especialidad, nombre_especialidad FROM especialidades";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            //Asignar los datos al DataGridView.
                            dataGridView_Especialidades.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }

        private void textBox_ID_Especialidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_Especialidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Botón para guardar.
        private void button_Guardar_Esp_Click(object sender, EventArgs e)
        {
            //Obtener los valores de los TextBox.
            int idEspecialidad = int.Parse(textBox_ID_Especialidad.Text);
            string nombreEspecialidad = textBox_Nombre_Especialidad.Text;

            //Cadena de conexión a la base de datos.
            string connectionString = "Server=127.0.0.1;Database=PRN3S2B123MOVE;Uid=root;Pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //Consulta SQL para insertar una nueva especialidad.
                    string insertQuery = "INSERT INTO especialidades (id_especialidad, nombre_especialidad) " +
                                          "VALUES (@idEspecialidad, @nombreEspecialidad)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@idEspecialidad", idEspecialidad);
                        cmd.Parameters.AddWithValue("@nombreEspecialidad", nombreEspecialidad);

                        cmd.ExecuteNonQuery();
                    }

                    //Refrescar los datos en el DataGridView después de guardar.
                    string selectQuery = "SELECT id_especialidad, nombre_especialidad FROM especialidades";
                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView_Especialidades.DataSource = dataTable;
                        }
                    }
                    //Mensaje que se guardo correctamente.
                    MessageBox.Show("La especialidad ha sido guardada correctamente.");
                }
                //Mensaje de error.
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la especialidad: " + ex.Message);
                }
            }
        }
        //Botón para eliminar.
        private void button_Eliminar_Esp_Click(object sender, EventArgs e)
        {
            //Verificar si se ha seleccionado una fila en el DataGridView.
            if (dataGridView_Especialidades.SelectedRows.Count > 0)
            {
                //Obtener el ID de la especialidad seleccionada.
                int idEspecialidadSeleccionada = Convert.ToInt32(dataGridView_Especialidades.SelectedRows[0].Cells["id_especialidad"].Value);

                //Cadena de conexión a la base de datos.
                string connectionString = "Server=127.0.0.1;Database=PRN3S2B123MOVE;Uid=root;Pwd=;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        //Consulta SQL para eliminar la especialidad por su ID.
                        string deleteQuery = "DELETE FROM especialidades WHERE id_especialidad = @idEspecialidad";

                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@idEspecialidad", idEspecialidadSeleccionada);
                            cmd.ExecuteNonQuery();
                        }

                        //Refrescar los datos en el DataGridView después de eliminar.
                        string selectQuery = "SELECT id_especialidad, nombre_especialidad FROM especialidades";
                        using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                        {
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                            {
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);
                                dataGridView_Especialidades.DataSource = dataTable;
                            }
                        }
                        //Mensaje que se guardo correctamente.
                        MessageBox.Show("La especialidad ha sido eliminada correctamente.");
                    }
                    //Mensaje de error.
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la especialidad: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }

        //Botón para actualizar.
        private void button_Actualizar_Esp_Click(object sender, EventArgs e)
        {
            //Obtener los valores de los TextBox.
            int idEspecialidad = int.Parse(textBox_ID_Especialidad.Text);
            string nombreEspecialidad = textBox_Nombre_Especialidad.Text;

            //Cadena de conexión a la base de datos.
            string connectionString = "Server=127.0.0.1;Database=PRN3S2B123MOVE;Uid=root;Pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //Consulta SQL para actualizar la especialidad por su ID.
                    string updateQuery = "UPDATE especialidades SET nombre_especialidad = @nombreEspecialidad " +
                                         "WHERE id_especialidad = @idEspecialidad";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@idEspecialidad", idEspecialidad);
                        cmd.Parameters.AddWithValue("@nombreEspecialidad", nombreEspecialidad);

                        cmd.ExecuteNonQuery();
                    }

                    //Refrescar los datos en el DataGridView después de actualizar.
                    string selectQuery = "SELECT id_especialidad, nombre_especialidad FROM especialidades";
                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView_Especialidades.DataSource = dataTable;
                        }
                    }
                    //Mensaje que se guardo correctamente.
                    MessageBox.Show("La especialidad ha sido actualizada correctamente.");
                }
                //Mensaje de error.
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la especialidad: " + ex.Message);
                }
            }
        }


    }
}

