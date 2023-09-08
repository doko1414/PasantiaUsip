using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.InputFiles;

namespace RegistroVisitantes
{
    public partial class Form1 : Form
    {
        private List<string> registros = new List<string>();
        private List<Administrador> administradores = new List<Administrador>();
        private Administrador administradorLogueado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = textNombre.Text;
            string apellido = textApellido.Text;
            string contacto = textContacto.Text;
            string motivo = richTextBoxMotivo.Text;

            string registro = $"Nombre: {nombre}, Apellido: {apellido}, Contacto: {contacto}, Motivo: {motivo}";

            registros.Add(registro);

            LimpiarCampos();
        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            GenerarInformePDF();
            // Abre un cuadro de diálogo de guardado de archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
            saveFileDialog.FileName = "InformeDiario.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaGuardar = saveFileDialog.FileName;

                // Mueve el archivo generado al destino seleccionado por el usuario
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

            // Agregar registros al documento
            foreach (string registro in registros)
            {
                doc.Add(new Paragraph(registro));
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

            // Buscar el administrador por nombre de usuario y contraseña
            administradorLogueado = administradores.Find(admin =>
                admin.NombreUsuario == nombreUsuario && admin.Contraseña == contraseña);

            if (administradorLogueado != null)
            {
                // Iniciar sesión exitosa
                MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ocultar la pestaña de inicio de sesión
                tabControl1.TabPages.Remove(login);

                // Mostrar la pestaña de registro de administradores
                tabControl1.TabPages.Add(RegistroPers);
                tabControl1.SelectedTab = RegistroPers; // Opcionalmente, seleccionar la pestaña de registro

                // También puedes ocultar/deshabilitar otras pestañas según sea necesario.
                // Ejemplo:
                // tabControl1.TabPages.Remove(OtraPestaña);
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // Validar que no falten campos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(celular) || string.IsNullOrWhiteSpace(nombreUsuario) ||
                string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear un nuevo administrador
            Administrador nuevoAdmin = new Administrador(nombre, apellido, celular, nombreUsuario, contraseña);
            administradores.Add(nuevoAdmin);

            // Limpiar los campos después de registrar
            LimpiarCamposRegistro();

            // Vuelve a mostrar la pestaña de inicio de sesión y oculta la de registro de administradores
            tabControl1.TabPages.Remove(RegistroAdmin); // Oculta la pestaña de registro
            tabControl1.TabPages.Insert(0, login); // Muestra la pestaña de inicio de sesión en la posición 0 (primera pestaña visible)
        }
        private void LimpiarCamposRegistro()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCelular.Clear();
            txtNombreUsuario.Clear();
            txtContraseña.Clear();
        }

        private async void enviar_Click(object sender, EventArgs e)
        {
            /*try
            {
                // Reemplaza 'YOUR_BOT_TOKEN' con el token de tu bot de Telegram
                var botToken = "6445372079:AAERg1I_iT076sgAiWbszVekXpRsVpQAaSA";

                // Reemplaza 'CHAT_ID' con el ID del chat al que deseas enviar el archivo
                var chatId = 1212994856;

                // Inicializa el cliente de Telegram Bot
                var botClient = new TelegramBotClient(botToken);

                // Ruta al archivo que deseas enviar
                string archivoInforme = "InformeDiario.pdf";

                using (var stream = System.IO.File.Open(archivoInforme, FileMode.Open))
                {
                    var fileName = Path.GetFileName(archivoInforme);

                    // Crea un objeto InputOnlineFile con el archivo y su nombre
                    var inputFile = new InputOnlineFile(stream, fileName);

                    // Envía el archivo al chat
                    await botClient.SendDocumentAsync(chatId, inputFile);

                    // El archivo se envió correctamente
                    MessageBox.Show("Informe enviado correctamente a través de Telegram.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el informe a través de Telegram: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            await enviarMensajeAsync();
        }
        private async Task enviarMensajeAsync()
        {
            try
            {
                // Paso 1: Reemplaza 'YOUR_BOT_TOKEN' con el token de tu bot de Telegram
                var botToken = "5926810973:AAH5j5EfLX49I_D5Z70UHIRGjDjl8SPssog";

                // Paso 2: Reemplaza 'CHAT_ID' con el ID del chat al que deseas enviar el archivo
                var chatId = 1212994856; // Asegúrate de que este sea el ID correcto

                // Paso 3: Inicializa el cliente de Telegram Bot
                var botClient = new TelegramBotClient(botToken);

                // Paso 4: Ruta al archivo que deseas enviar
                string archivoInforme = "InformeDiario.pdf";

                // Paso 5: Abre el archivo en modo lectura
                using (var stream = System.IO.File.Open(archivoInforme, FileMode.Open))
                {
                    var fileName = Path.GetFileName(archivoInforme);

                    // Paso 6: Crea un objeto InputOnlineFile con el archivo y su nombre
                    var inputFile = new InputOnlineFile(stream, fileName);

                    // Paso 7: Envía el archivo al chat
                    await botClient.SendDocumentAsync(chatId, inputFile);

                    // Paso 8: El archivo se envió correctamente
                    MessageBox.Show("Informe enviado correctamente a través de Telegram.");
                }
            }
            catch (Exception ex)
            {
                // Paso 9: Maneja cualquier error que pueda ocurrir
                MessageBox.Show("Error al enviar el informe a través de Telegram: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
