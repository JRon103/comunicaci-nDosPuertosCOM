using System.IO.Ports;
namespace PuertoSerie
{
    public partial class frmSerie : Form
    {

        // Instancias de los puertos seriales
        SerialPort spArduino = new SerialPort();
        SerialPort spBluetooth = new SerialPort();
        public frmSerie()
        {
            InitializeComponent();
        }

        private void frmSerie_Load(object sender, EventArgs e)
        {
            string[] puertos = SerialPort.GetPortNames();
            //cmbPuertos.DataSource = SerialPort.GetPortNames();
            // Actualiza las opciones de los combobox al cargar el formulario
            // Asigna una copia de los puertos a cada ComboBox
            cmbPuertos.DataSource = new List<string>(puertos);        // Para el Arduino
            comboBoxBluetooth.DataSource = new List<string>(puertos); // Para el HC-05 (Bluetooth)

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (spArduino.IsOpen)
            {
                try
                {
                    spArduino.WriteLine(txtEnviar.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error enviando datos al Arduino: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("El puerto del Arduino no está abierto.");
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica y cierra el puerto del Arduino si ya está abierto
                if (spArduino.IsOpen)
                {
                    spArduino.Close();
                }
                spArduino.PortName = cmbPuertos.Text;
                spArduino.BaudRate = 9600;
                spArduino.Open();
                MessageBox.Show("Conectado al Arduino");

                // Verifica y cierra el puerto del Bluetooth si ya está abierto
                if (spBluetooth.IsOpen)
                {
                    spBluetooth.Close();
                }
                spBluetooth.PortName = comboBoxBluetooth.Text;
                spBluetooth.BaudRate = 9600;
                spBluetooth.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
                spBluetooth.Open();
                MessageBox.Show("Conectado al Bluetooth");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Error: Acceso denegado al puerto " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error conectando los puertos: " + ex.Message);
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Lee el dato desde el puerto Bluetooth
            try
            {
                string inData = spBluetooth.ReadLine();
                // Actualiza el richTextBox recibirBluetooth en el hilo de la interfaz gráfica
                recibirBluetooth.Invoke(new MethodInvoker(delegate
                {
                    recibirBluetooth.AppendText(inData + Environment.NewLine);
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error recibiendo datos desde Bluetooth: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Actualiza las opciones de los combobox
            string[] puertos = SerialPort.GetPortNames();
            cmbPuertos.DataSource = puertos;  // Para Arduino
            comboBoxBluetooth.DataSource = puertos;  // Para Bluetooth
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cierra los puertos abiertos
            if (spArduino.IsOpen) spArduino.Close();
            if (spBluetooth.IsOpen) spBluetooth.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
