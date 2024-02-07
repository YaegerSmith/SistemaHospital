//Importar la biblioteca para conectar a la base de datos.
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DSDPRN3MOVE2302B1_U3_A1
{
    public partial class Form1 : Form
    {
        //Declaración de la variable de conexión a la base de datos.
        private MySqlConnection mysqlConnection;

        //Cadena de conexión a la base de datos.
        private string connectionString = "Server=127.0.0.1;Database=PRN3S2B123MOVE;User=root;Password=;";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Llama a la función para establecer la conexión cuando se carga el formulario.
            EstablecerConexion();

        }

        //Función para establecer la conexión a la base de datos.
        private void EstablecerConexion()
        {
            try
            {
                //Inicializa la conexión usando la cadena de conexión.
                mysqlConnection = new MySqlConnection(connectionString);

                //Abre la conexión a la base de datos.
                mysqlConnection.Open();

                //Si llega asta aquí sin errores, la conexión se ha establecido con éxito.
                MessageBox.Show("Conexión establecida con éxito a la base de datos.");
            }
            catch (Exception ex)
            {
                //Manejo de errores si la conexión falla, muestra un mensaje de error.
                MessageBox.Show("Error al establecer la conexión: " + ex.Message);
            }
        }

        //Función para cerrar la conexión a la base de datos.
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mysqlConnection != null && mysqlConnection.State == ConnectionState.Open)
            {
                //Cierra la conexión a la base de datos cuando se cierra el formulario.
                mysqlConnection.Close();
            }
        }

        //Botón para abrir la ventana el formulario del estado civil.
        private void button_EstadoCivil_MOVE_Click(object sender, EventArgs e)
        {
            //Crear una instancia del formulario Estado Civil.
            EstadoCivilFormMOVE estadoCivilForm = new EstadoCivilFormMOVE();

            //Mostrar el formulario.
            estadoCivilForm.Show();


        }

        //Botón para abrir la ventana del formulario de los médicos.
        private void button_Medicos_Click(object sender, EventArgs e)
        {
            //Crear una instancia del formulario Medicos.
            MedicosFormularioMOVE medicosFormularioMOVE = new MedicosFormularioMOVE();

            //Mostrar el formulario.
            medicosFormularioMOVE.Show();

        }

        //Botón para abrir la ventana del formulario de las especialidades.
        private void button_Especialidades_Click(object sender, EventArgs e)
        {
            //Crear una instancia del formulario Especialidades.
            FormularioEspecialidades formularioEspecialidades = new FormularioEspecialidades();

            //Mostrar el formulario.
            formularioEspecialidades.Show();
        }


        //Botón para abrir la ventana del formulario de importación.
        private void button_Importar_Click(object sender, EventArgs e)
        {
            //Crear una instancia del formulario de imporportación.
            ImportarTexto importarTexto = new ImportarTexto();
            
            //Mostrar el formulario.
            importarTexto.Show();

        }

        //Botón para abrir la ventana del formulario de pacientes.
        private void button_FormPacientes_Click(object sender, EventArgs e)
        {
          //Crear una instancia del formulario pacientes.
          FormPacientes formPacientes = new FormPacientes();
          //Mostrar el formulario.
           formPacientes.Show();
        }

        private void button_CambioMedico_Click(object sender, EventArgs e)
        {
            //Crear una instancia del formulario para cambiar de medico a un paciente.
            FormCambioMedico formCambioMedico = new FormCambioMedico();

            //Moistrar el formulario.
            formCambioMedico.Show();
        }
    }
}

