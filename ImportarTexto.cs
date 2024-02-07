//Bibliotecas.
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DSDPRN3MOVE2302B1_U3_A1
{
    public partial class ImportarTexto : Form
    {
        public ImportarTexto()
        {
            InitializeComponent();
        }

        private void ImportarTexto_Load(object sender, EventArgs e)
        {
            //Creación de la cadena de conexión.
            string connectionString = "server=127.0.0.1;user=root;password=;database=PRN3S2B123MOVE";

            //Crear la conexión y abrirla.
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            //Crear el comando con la consulta SQL para cargar datos de pacientes.
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM pacientes", conn);

            //Crear el adaptador y el DataTable para almacenar los datos.
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            //Llenar el DataTable con los datos de la base de datos y asignarlo al DataGridView.
            da.Fill(dt);
            dataGridView_Pacientes.DataSource = dt;

            //Cerrar la conexión.
            conn.Close();
        }

        private void dataGridView_Pacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //Botón para importar el archivo TXT.
        private void button_ImportarTXT_Click(object sender, EventArgs e)
        {
            //Crear un cuadro de diálogo para abrir archivos.
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //Establecer un filtro para limitar la selección a archivos de texto (.txt)
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";

            //Mostrar el cuadro de diálogo y esperar a que el usuario seleccione un archivo.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Si el usuario selecciona un archivo y hace clic en "Abrir",
                //obtener la ruta completa del archivo seleccionado.
                string filePath = openFileDialog.FileName;

                try
                {
                    //Leer todas las líneas del archivo de texto seleccionado.
                    string[] lines = File.ReadAllLines(filePath);

                    //Establecer la cadena de conexión a la base de datos.
                    string connectionString = "server=127.0.0.1;user=root;password=;database=PRN3S2B123MOVE";
                    MySqlConnection conn = new MySqlConnection(connectionString);
                    conn.Open();

                    //Variable para verificar si todas las líneas son válidas.
                    bool allLinesValid = true;

                    foreach (string line in lines)
                    {
                        //Eliminar espacios en blanco alrededor de la línea.
                        string trimmedLine = line.Trim();

                        //Dividir la línea en campos separados por comas.
                        string[] fields = trimmedLine.Split(',');

                        if (fields.Length != 11)
                        {
                            allLinesValid = false;
                            break;
                        }

                        //Validar cada campo antes de agregarlo a la base de datos.
                        if (!string.IsNullOrWhiteSpace(fields[0]) && !string.IsNullOrWhiteSpace(fields[1]) &&
                            !string.IsNullOrWhiteSpace(fields[2]) && !string.IsNullOrWhiteSpace(fields[3]) &&
                            !string.IsNullOrWhiteSpace(fields[4]) && !string.IsNullOrWhiteSpace(fields[5]) &&
                            int.TryParse(fields[6], out int edad) && !string.IsNullOrWhiteSpace(fields[7]) &&
                            !string.IsNullOrWhiteSpace(fields[8]) && int.TryParse(fields[9], out int estadoCivil) &&
                            int.TryParse(fields[10], out int idMedico))
                        {
                            //Crear una consulta SQL para insertar un nuevo registro en la tabla "pacientes".
                            string insertQuery = "INSERT INTO `pacientes` (`nombre`, `apellido_paterno`, `apellido_materno`, `direccion`, `telefono_fijo`, `celular`, `edad`, `sexo`, `email`, `estado_civil`, `id_medico`) " +
                                                 "VALUES (@nombre, @apellido_paterno, @apellido_materno, @direccion, @telefono_fijo, @celular, @edad, @sexo, @email, @estado_civil, @id_medico)";

                            MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn);
                            insertCommand.Parameters.AddWithValue("@nombre", fields[0]);
                            insertCommand.Parameters.AddWithValue("@apellido_paterno", fields[1]);
                            insertCommand.Parameters.AddWithValue("@apellido_materno", fields[2]);
                            insertCommand.Parameters.AddWithValue("@direccion", fields[3]);
                            insertCommand.Parameters.AddWithValue("@telefono_fijo", fields[4]);
                            insertCommand.Parameters.AddWithValue("@celular", fields[5]);
                            insertCommand.Parameters.AddWithValue("@edad", edad);
                            insertCommand.Parameters.AddWithValue("@sexo", fields[7]);
                            insertCommand.Parameters.AddWithValue("@email", fields[8]);
                            insertCommand.Parameters.AddWithValue("@estado_civil", estadoCivil);
                            insertCommand.Parameters.AddWithValue("@id_medico", idMedico);

                            //Ejecutar la consulta de inserción.
                            insertCommand.ExecuteNonQuery();
                        }
                        else
                        {
                            allLinesValid = false;
                            break;
                        }
                    }

                    if (allLinesValid)
                    {
                        //Cerrar la conexión.
                        conn.Close();

                        //Actualizar el DataGridView con los datos importados.
                        RefreshDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("El archivo TXT está mal formateado o contiene datos inválidos. Asegúrese de que cada línea tenga 11 campos válidos separados por comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al importar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Método para actualizar el DataGridView.
        private void RefreshDataGridView()
        {
            // Crear una nueva conexión y cargar los datos actualizados en el DataGridView.
            string connectionString = "server=127.0.0.1;user=root;password=;database=PRN3S2B123MOVE";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM pacientes", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_Pacientes.DataSource = dt;
            conn.Close();
        }
    }
}
