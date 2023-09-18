using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Http;
using System.IO;
using System.Net;
using System.Net.Mail;
using iTextSharp.text.xml;

namespace RegistroVisitantes
{
    public partial class Form1 : Form
    {
        // Configuración de la cuenta de correo electrónico de Gmail
        const string emailFrom = "javierlarasolis1414@gmail.com";
        const string emailTo =  "javierlarasolis79@gmail.com";
        const string password = "javierlarasolis7922";
        const string smtpServer = "smtp.gmail.com";
        const int smtpPort = 587;
        private SqlConnection sqlConnection;
        private string connectionString = "Server=LAPTOP-J687O61R;Database=RegistroVisitantesDb;Integrated Security=True;";
        private Administrador administradorLogueado;
        // Ruta del archivo PDF a enviar
        string filePath = @"C:\Users\Hp\OneDrive\Escritorio\informes\InformeDiario.pdf";


        public Form1()
        {
            InitializeComponent();
          //  _botClient = new TelegramBotClient("5926810973:AAH5j5EfLX49I_D5Z70UHIRGjDjl8SPssog");
            sqlConnection = new SqlConnection(connectionString);
            enviar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = textNombre.Text;
            string apellido = textApellido.Text;
            string contacto = textContacto.Text;
            string motivo = richTextBoxMotivo.Text;

            // Insertar el registro en la base de datos
            string query = "INSERT INTO Registros (Nombre, Apellido, Contacto, Motivo, Fecha) " +
                           "VALUES (@Nombre, @Apellido, @Contacto, @Motivo, @Fecha)";

            using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Contacto", contacto);
                cmd.Parameters.AddWithValue("@Motivo", motivo);
                cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);

                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            MessageBox.Show("Datos guardados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            GenerarInformePDF();

            // Mueve el archivo generado al destino seleccionado por el usuario
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
            saveFileDialog.FileName = "InformeDiario.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaGuardar = saveFileDialog.FileName;

                // Mueve el archivo PDF generado al destino seleccionado por el usuario
                System.IO.File.Move("InformeDiario.pdf", rutaGuardar);

                MessageBox.Show("Informe PDF generado y descargado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void GenerarInformePDF()
        {
            // Crear un documento PDF
            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            string nombreArchivo = "InformeDiario.pdf";
            PdfWriter.GetInstance(doc, new System.IO.FileStream(nombreArchivo, System.IO.FileMode.Create));
            doc.Open();

            // Consulta SQL para obtener los registros desde la base de datos
            string query = "SELECT Nombre, Apellido, Contacto, Motivo, Fecha FROM Registros";

            using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string nombre = reader.GetString(0);
                    string apellido = reader.GetString(1);
                    string contacto = reader.GetString(2);
                    string motivo = reader.GetString(3);
                    DateTime fecha = reader.GetDateTime(4);

                    string registro = $"Nombre: {nombre}, Apellido: {apellido}, Contacto: {contacto}, Motivo: {motivo}, Fecha: {fecha}";
                    doc.Add(new Paragraph(registro));
                }

                reader.Close();
                sqlConnection.Close();
            }

            // Cerrar el documento
            doc.Close();
        }
        private void LimpiarCampos()
        {
            textNombre.Clear();
            textApellido.Clear();
            textContacto.Clear();
            richTextBoxMotivo.Clear();
        }

        private void button1_Click(object sender, EventArgs e)//Iniciar Sesion
        {
            string nombreUsuario = txtNombreUsuarioLogin.Text;
            string contraseña = txtContraseñaLogin.Text;

            // Consulta SQL para autenticar al administrador
            string query = "SELECT Id, Nombre, Apellido, Celular, NombreUsuario, Contraseña " +
                           "FROM Administradores " +
                           "WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña";

            using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    administradorLogueado = new Administrador
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        Celular = reader.GetString(3),
                        NombreUsuario = reader.GetString(4),
                        Contraseña = reader.GetString(5)
                    };
                    MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tabControl1.TabPages.Remove(login);
                    tabControl1.TabPages.Add(RegistroPers);
                    tabControl1.SelectedTab = RegistroPers; 
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
                sqlConnection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)//boton registrarse en tabcontrol login
        {
            if (RegistroAdmin.Parent == null)
            {
                // Muestra la pestaña de registro de administradores
                tabControl1.TabPages.Insert(0, RegistroAdmin); // Inserta en el índice 0 para que sea la primera pestaña visible
            }

            // Oculta las otras pestañas si es necesario, por ejemplo, ocultar la de inicio de sesión
            if (login.Parent != null)
            {
                tabControl1.TabPages.Remove(login);
            }

            if (RegistroPers.Parent != null)
            {
                tabControl1.TabPages.Remove(RegistroPers);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string celular = txtCelular.Text;
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Validar que no falten campos (puedes hacerlo aquí o en el formulario)
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(celular) || string.IsNullOrWhiteSpace(nombreUsuario) ||
                string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insertar el administrador en la base de datos
            string query = "INSERT INTO Administradores (Nombre, Apellido, Celular, NombreUsuario, Contraseña) " +
                           "VALUES (@Nombre, @Apellido, @Celular, @NombreUsuario, @Contraseña)";

            using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Celular", celular);
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            // Vuelve a mostrar la pestaña de inicio de sesión y oculta la de registro de administradores
            tabControl1.TabPages.Remove(RegistroAdmin); // Oculta la pestaña de registro
            tabControl1.TabPages.Insert(0, login); // Muestra la pestaña de inicio de sesión en la posición 0 (primera pestaña visible)

            LimpiarCamposRegistro();
        }
        private void LimpiarCamposRegistro()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCelular.Clear();
            txtNombreUsuario.Clear();
            txtContraseña.Clear();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una nueva instancia de MailMessage
                MailMessage message = new MailMessage();

                // Configurar el remitente y el destinatario
                message.From = new MailAddress(emailFrom);
                message.To.Add(new MailAddress(emailTo));

                // Agregar el asunto y el cuerpo del mensaje
                message.Subject = "Envío de archivo PDF";
                message.Body = "Se ha adjuntado el archivo PDF";

                // Agregar el archivo PDF como adjunto
                Attachment attachment = new Attachment(File.OpenRead(filePath), "application/pdf");
                attachment.Name = "InformeDiario.pdf"; // Nombre del archivo adjunto en el correo
                message.Attachments.Add(attachment);

                // Utilizar la clase SmtpClient para enviar el correo electrónico a través de Gmail
                SmtpClient client = new SmtpClient(smtpServer, smtpPort);
                client.Credentials = new NetworkCredential(emailFrom, password);
                client.EnableSsl = true;
                client.Send(message);

                MessageBox.Show("El archivo PDF se ha enviado con éxito.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("No se pudo enviar");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = login;
            tabControl1.TabPages.Remove(RegistroAdmin);
            tabControl1.TabPages.Remove(RegistroPers);
        }
    }
}
