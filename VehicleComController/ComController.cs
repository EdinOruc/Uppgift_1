using System.IO.Ports;

namespace VehicleComController
{
    public static class ComController

    {
        static void Main(string[] args)
        {
            // Test if input arguments were suplied.
            if (string.IsNullOrEmpty(args[0]))
            {
                Console.WriteLine("Please enter a port name as an argument.");
                return;
            }

            // Set up the serial port to read from
            SerialPort serialPortControlUnits = new()
            {
                PortName = args[0], // COM port as an argument
                BaudRate = 9600,
                Parity = Parity.None,
                DataBits = 8,
                StopBits = StopBits.One,
                Handshake = Handshake.None
            };

            // Attach event handler for when data is received
            serialPortControlUnits.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            try
            {
                serialPortControlUnits.Open();
                Console.WriteLine("Controller is ready to receive data from Aux...");

                // Keep the application alive to continue receiving data
                Console.WriteLine("Press  any key to close the application.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                if (serialPortControlUnits.IsOpen)
                    serialPortControlUnits.Close();
            }
        }

        // Event handler for when data is received from the serial port
        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;

                // Read the incoming data
                string data = sp.ReadExisting();
                Console.WriteLine($"Received: {data}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error receiving data: {ex.Message}");
            }
        }
    }
}