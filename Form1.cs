using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace SerialCommunication
{
    public partial class WagaTest : Form
    {

       // bool isConnected = false;
        String[] ports;
        private static SerialPort _port;
        bool isSerialOpened = false;
        string arduinoData;


        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr hwnd);

        public static void PasteToApplication(string appName)
        {
            var proc = Process.GetProcessesByName(appName).FirstOrDefault();
            if (proc != null)
            {
                var handle = proc.MainWindowHandle;
                SetForegroundWindow(handle);
                SendKeys.Send("^v");
            }
        }

        public WagaTest()
        {
            InitializeComponent();
            getAvailablePorts();

            foreach (string port in ports)
            {
                portList.Items.Add(port);
                if (ports[0] != null)
                {
                    portList.SelectedItem = ports[0];
                }
            }

            lConnection.Text = "DISCONNECTED";
            lConnection.ForeColor = Color.IndianRed;

            lWaga.Text = "";


        }





        private void getAvailablePorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            if (!isSerialOpened)
            {

                _port = new SerialPort(portList.SelectedItem.ToString(), 4800);
                _port.Open();

                _port.DataReceived += _port_DataReceived;

                ConnectionButton.Text = "Disconnect";
                lConnection.Text = "CONNECTED";
                lConnection.ForeColor = Color.LimeGreen;

                isSerialOpened = true;

            }
            else
            {
                _port.Close();
                isSerialOpened = false;
                ConnectionButton.Text = "Connect";

                lConnection.Text = "DISCONNECTED";
                lConnection.ForeColor = Color.IndianRed;

                lWaga.Text = "";

            }


        }

        void _port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            arduinoData = _port.ReadLine();
            this.Invoke(new EventHandler(displaydata_event));

        }

        private void displaydata_event(object sender, EventArgs e)
        {
            lWaga.Text = arduinoData;
            System.Windows.Forms.Clipboard.SetText(arduinoData);
            System.Windows.Forms.Clipboard.GetText();
            PasteToApplication("Excel");
        }
    }
}
