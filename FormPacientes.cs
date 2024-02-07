//Bibliotecas.
using System;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DSDPRN3MOVE2302B1_U3_A1
{
    public partial class FormPacientes : Form
    {
        //Cadena de conexión a la base de datos.
        private string connectionString = "Server=127.0.0.1;Database=PRN3S2B123MOVE;Uid=root;Pwd=;";


        private int currentPage = 1;
        private int pageSize = 5;

        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;

        private int CalculateTotalPages()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string countQuery = "SELECT COUNT(*) FROM pacientes";
                    using (MySqlCommand countCmd = new MySqlCommand(countQuery, connection))
                    {
                        int totalRecords = Convert.ToInt32(countCmd.ExecuteScalar());
                        int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                        return totalPages;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el número total de páginas: " + ex.Message);
                return 0;
            }
        }



        public FormPacientes()
        {
            InitializeComponent();
            textBox_Direccion.KeyPress += new KeyPressEventHandler(textBox_Direccion_KeyPress);
            // Agregar un control ErrorProvider al formulario.
            errorProvider1 = new ErrorProvider();
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink; // Opcional, controla el parpadeo del icono de error.

            // Inicializa el segundo ErrorProvider.
            errorProvider2 = new ErrorProvider();
            errorProvider2.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            // Suscribir el evento KeyPress para validar el textBox_Edad
            textBox_Edad.KeyPress += textBox_Edad_KeyPress;

            // Suscribir el evento KeyPress para validar el textBox_Sexo
            textBox_Sexo.KeyPress += textBox_Sexo_KeyPress;

            textBox_EstadoCivil.Validating += textBox_EstadoCivil_Validating;

            textBox_IdMedico.Leave += textBox_IdMedico_Leave; // Asociar el evento Leave al TextBox

            // Suscribir el evento KeyPress para validar el textBox_IdPaciente
            textBox_IdPaciente.KeyPress += textBox_IdPaciente_KeyPress;

        }
        private void textBox_IdPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número o la tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; // No permitir el carácter
                MessageBox.Show("Por favor, ingrese solo números enteros en el ID del paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_Sexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es "M" o "H" y no es la tecla Backspace
            if (e.KeyChar != 'M' && e.KeyChar != 'H' && e.KeyChar != 8)
            {
                e.Handled = true; // No permitir el carácter
            }

            // Verificar la longitud actual del texto en el textBox_Sexo
            if (textBox_Sexo.Text.Length >= 1 && e.KeyChar != 8)
            {
                e.Handled = true; // No permitir más caracteres si ya hay 1 carácter
            }
        }
        private void textBox_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificar si la tecla presionada no es una letra, número, #, espacio o Backspace.
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '#' && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                //Cancelar la entrada de la tecla en el TextBox.
                e.Handled = true;
            }
        }



        private void LoadPatients(int page)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    int offset = (page - 1) * pageSize;

                    string query = "SELECT * FROM pacientes LIMIT @pageSize OFFSET @offset";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@pageSize", pageSize);
                        cmd.Parameters.AddWithValue("@offset", offset);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            dataGridView_Pacientes.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }


        private void dataGridView_Pacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_EstadoCivil_Validating(object sender, CancelEventArgs e)
        {
            string estadoCivilInput = textBox_EstadoCivil.Text.Trim();

            // Verificar si la longitud del texto es 1 y si el carácter es válido (1, 2, 3, 4 o 5).
            if (estadoCivilInput.Length != 1 || !IsEstadoCivilValid(estadoCivilInput[0]))
            {
                e.Cancel = true; // Cancelar la validación.
                MessageBox.Show("El estado civil debe ser un solo dígito entre 1 y 5.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_EstadoCivil.SelectAll(); // Seleccionar todo el texto para que el usuario lo corrija.
            }
        }

        // Método para verificar si el carácter es válido.
        private bool IsEstadoCivilValid(char c)
        {
            return c >= '1' && c <= '5';
        }

        private void FormPacientes_Load(object sender, EventArgs e)
        {
            LoadPatients(currentPage);
            try
            {


                //Crear una conexión a la base de datos.
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    //Consulta SQL para seleccionar todos los registros de la tabla pacientes.
                    string query = "SELECT * FROM pacientes";

                    //Crear un comando SQL.
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        //Crear un adaptador MySQL para recuperar datos.
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            //Crear una tabla de datos para almacenar los resultados.
                            DataTable table = new DataTable();

                            //Llenar la tabla con los datos del adaptador.
                            adapter.Fill(table);

                            //Enlazar la tabla de datos al DataGridView.
                            dataGridView_Pacientes.DataSource = table;

                            int totalPages = CalculateTotalPages();
                            for (int i = 1; i <= totalPages; i++)
                            {
                                comboBox_Pag.Items.Add("Página " + i);
                            }
                            comboBox_Pag.SelectedIndex = 0; // Establecer la selección inicial en la primera página.


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //Manejar errores en caso de que ocurran.
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void button_EliminarPaciente_Click(object sender, EventArgs e)
        {
            //Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridView_Pacientes.SelectedRows.Count > 0)
            {
                //Obtener la fila seleccionada.
                DataGridViewRow selectedRow = dataGridView_Pacientes.SelectedRows[0];

                //Obtener el ID del paciente que se va a eliminar.
                int idPaciente = Convert.ToInt32(selectedRow.Cells["id_paciente"].Value);

                //Mostrar un cuadro de diálogo de confirmación al usuario.
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar a este paciente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                //Si el usuario confirma la eliminación.
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        //Crear una conexión a la base de datos.
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();

                            //Consulta SQL para eliminar al paciente por su ID
                            string query = "DELETE FROM pacientes WHERE id_paciente = @idPaciente";

                            //Crear un comando SQL con parámetros.
                            using (MySqlCommand cmd = new MySqlCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("@idPaciente", idPaciente);

                                //Ejecutar la consulta para eliminar al paciente.
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    //Actualizar el DataGridView para reflejar los cambios.
                                    FormPacientes_Load(sender, e);

                                    MessageBox.Show("Paciente eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo eliminar al paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        //Manejar errores en caso de que ocurran.
                        MessageBox.Show("Error al eliminar el paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un paciente antes de intentar eliminarlo.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox_IdPaciente_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {
            // Obtén el texto ingresado en el textBox_Nombre
            string nombre = textBox_Nombre.Text;

            // Define una expresión regular para permitir solo letras y espacios
            Regex regex = new Regex("^[A-Za-z ]*$");

            // Verifica si el texto cumple con la expresión regular
            if (!regex.IsMatch(nombre))
            {
                MessageBox.Show("El nombre no debe contener caracteres especiales ni números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Si se encuentra un carácter no permitido, limpia el textBox_Nombre
                textBox_Nombre.Text = string.Empty;
            }
        }


        private void textBox_ApellidoPaterno_TextChanged(object sender, EventArgs e)
        {
            // Obtén el texto ingresado en el textBox
            string apellido_Paterno = textBox_ApellidoPaterno.Text;

            // Define una expresión regular para permitir solo letras y espacios
            Regex regex = new Regex("^[A-Za-z ]*$");

            // Verifica si el texto cumple con la expresión regular
            if (!regex.IsMatch(apellido_Paterno))
            {
                MessageBox.Show("El apellido no debe contener caracteres especiales ni números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Si se encuentra un carácter no permitido, limpia el textBox
                textBox_ApellidoPaterno.Text = string.Empty;

            }

        }

        private void textBox_ApellidoMaterno_TextChanged(object sender, EventArgs e)
        {
            // Obtén el texto ingresado en el textBox
            string apellido_Materno = textBox_ApellidoMaterno.Text;

            // Define una expresión regular para permitir solo letras y espacios
            Regex regex = new Regex("^[A-Za-z ]*$");

            // Verifica si el texto cumple con la expresión regular
            if (!regex.IsMatch(apellido_Materno))
            {
                MessageBox.Show("El apellido no debe contener caracteres especiales ni números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Si se encuentra un carácter no permitido, limpia el textBox
                textBox_ApellidoMaterno.Text = string.Empty;

            }

        }

        private void textBox_Direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Telefono_TextChanged(object sender, EventArgs e)
        {
            // Verificar la longitud del número de teléfono.
            if (textBox_Telefono.Text.Length != 10)
            {
                // Mostrar un mensaje de error.
                errorProvider1.SetError(textBox_Telefono, "El número de teléfono debe tener 10 caracteres.");
            }
            else
            {
                // Borrar el mensaje de error si la longitud es válida.
                errorProvider1.Clear();
            }
        }

        private void textBox_IdMedico_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_EstadoCivil_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {
            string email = textBox_Email.Text;

            if (email.Length < 6 || email.Length > 50)
            {
                // Si la longitud del email está fuera del rango permitido, muestra un mensaje de error.
                errorProvider1.SetError(textBox_Email, "El email debe tener entre 6 y 50 caracteres.");
            }
            else
            {
                // Si la longitud es válida, limpia el mensaje de error.
                errorProvider1.Clear();
            }
        }

        private void textBox_Sexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Edad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número o la tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; // No permitir el carácter
            }

            // Verificar la longitud actual del texto en el textBox_Edad
            string edadText = textBox_Edad.Text;
            if (edadText.Length >= 2 && e.KeyChar != 8)
            {
                e.Handled = true; // No permitir más caracteres si ya hay 2 dígitos
            }
        }


        private void textBox_Celular_TextChanged(object sender, EventArgs e)
        {
            // Verificar la longitud del número de celular.
            if (textBox_Celular.Text.Length != 10)
            {
                // Mostrar un mensaje de error.
                errorProvider2.SetError(textBox_Celular, "El número de celular debe tener 10 caracteres.");
            }
            else
            {
                // Borrar el mensaje de error si la longitud es válida.
                errorProvider2.Clear();
            }
        }


        private void button_GuardarPaciente_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string nombre = textBox_Nombre.Text;
            string apellidoPaterno = textBox_ApellidoPaterno.Text;
            string apellidoMaterno = textBox_ApellidoMaterno.Text;
            string direccion = textBox_Direccion.Text;
            string telefono = textBox_Telefono.Text;
            string celular = textBox_Celular.Text;
            int edad = Convert.ToInt32(textBox_Edad.Text);
            string sexo = textBox_Sexo.Text;
            string email = textBox_Email.Text;
            int estadoCivil = Convert.ToInt32(textBox_EstadoCivil.Text);
            int idMedico = Convert.ToInt32(textBox_IdMedico.Text);

            try
            {
                // Crear una conexión a la base de datos.
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para insertar un nuevo paciente.
                    string query = "INSERT INTO pacientes (nombre, apellido_paterno, apellido_materno, direccion, telefono_fijo, celular, edad, sexo, email, estado_civil, id_medico) " +
                                   "VALUES (@nombre, @apellidoPaterno, @apellidoMaterno, @direccion, @telefono, @celular, @edad, @sexo, @email, @estadoCivil, @idMedico)";

                    // Crear un comando SQL con parámetros.
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@apellidoPaterno", apellidoPaterno);
                        cmd.Parameters.AddWithValue("@apellidoMaterno", apellidoMaterno);
                        cmd.Parameters.AddWithValue("@direccion", direccion);
                        cmd.Parameters.AddWithValue("@telefono", telefono);
                        cmd.Parameters.AddWithValue("@celular", celular);
                        cmd.Parameters.AddWithValue("@edad", edad);
                        cmd.Parameters.AddWithValue("@sexo", sexo);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@estadoCivil", estadoCivil);
                        cmd.Parameters.AddWithValue("@idMedico", idMedico);

                        // Ejecutar la consulta para insertar al paciente.
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Actualizar el DataGridView para reflejar los cambios.
                            FormPacientes_Load(sender, e);

                            MessageBox.Show("Paciente insertado correctamente.", "Inserción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo insertar al paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar errores en caso de que ocurran.
                MessageBox.Show("Error al insertar el paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_ActualizarPaciente_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridView_Pacientes.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada.
                DataGridViewRow selectedRow = dataGridView_Pacientes.SelectedRows[0];

                // Obtener el ID del paciente que se va a actualizar.
                int idPaciente = Convert.ToInt32(selectedRow.Cells["id_paciente"].Value);

                // Obtener los nuevos valores de los TextBox
                string nombre = textBox_Nombre.Text;
                string apellidoPaterno = textBox_ApellidoPaterno.Text;
                string apellidoMaterno = textBox_ApellidoMaterno.Text;
                string direccion = textBox_Direccion.Text;
                string telefono = textBox_Telefono.Text;
                string celular = textBox_Celular.Text;
                int edad = Convert.ToInt32(textBox_Edad.Text);
                string sexo = textBox_Sexo.Text;
                string email = textBox_Email.Text;
                int estadoCivil = Convert.ToInt32(textBox_EstadoCivil.Text);
                int idMedico = Convert.ToInt32(textBox_IdMedico.Text);

                try
                {
                    // Crear una conexión a la base de datos.
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Consulta SQL para actualizar los datos del paciente.
                        string query = "UPDATE pacientes " +
                                       "SET nombre = @nombre, apellido_paterno = @apellidoPaterno, apellido_materno = @apellidoMaterno, " +
                                       "direccion = @direccion, telefono_fijo = @telefono, celular = @celular, " +
                                       "edad = @edad, sexo = @sexo, email = @email, estado_civil = @estadoCivil, id_medico = @idMedico " +
                                       "WHERE id_paciente = @idPaciente";

                        // Crear un comando SQL con parámetros.
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@nombre", nombre);
                            cmd.Parameters.AddWithValue("@apellidoPaterno", apellidoPaterno);
                            cmd.Parameters.AddWithValue("@apellidoMaterno", apellidoMaterno);
                            cmd.Parameters.AddWithValue("@direccion", direccion);
                            cmd.Parameters.AddWithValue("@telefono", telefono);
                            cmd.Parameters.AddWithValue("@celular", celular);
                            cmd.Parameters.AddWithValue("@edad", edad);
                            cmd.Parameters.AddWithValue("@sexo", sexo);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@estadoCivil", estadoCivil);
                            cmd.Parameters.AddWithValue("@idMedico", idMedico);
                            cmd.Parameters.AddWithValue("@idPaciente", idPaciente);

                            // Ejecutar la consulta para actualizar al paciente.
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Actualizar el DataGridView para reflejar los cambios.
                                FormPacientes_Load(sender, e);

                                MessageBox.Show("Paciente actualizado correctamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo actualizar al paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar errores en caso de que ocurran.
                    MessageBox.Show("Error al actualizar el paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un paciente antes de intentar actualizarlo.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBox_Pag_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = comboBox_Pag.SelectedIndex + 1;
            LoadPatients(currentPage);

        }

        private void textBox_IdMedico_Leave(object sender, EventArgs e)
        {
            int idMedico;
            if (int.TryParse(textBox_IdMedico.Text, out idMedico))
            {
                if (!MedicoExists(idMedico))
                {
                    MessageBox.Show("El ID del médico ingresado no existe en la tabla médicos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_IdMedico.Clear(); // Limpiar el TextBox si el ID no existe.
                    textBox_IdMedico.Focus(); // Devolver el foco al TextBox.
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido para el ID del médico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_IdMedico.Clear(); // Limpiar el TextBox si el ID no es válido.
                textBox_IdMedico.Focus(); // Devolver el foco al TextBox.
            }
        }

        private bool MedicoExists(int idMedico)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM medicos WHERE id_medico = @idMedico";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idMedico", idMedico);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar la existencia del ID del médico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}




