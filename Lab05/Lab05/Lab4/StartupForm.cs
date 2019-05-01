using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Drawing;

namespace Lab4
{
    public partial class StartupForm : Form
    {
        Random random = new Random();
        public StartupForm ThisForm;
        public SerialPort SelectedPort = new SerialPort();//public so it can be edited from ConfigureForm.
        public List<PortData> Ports = new List<PortData>();
        public List<PortForm> OpenForms = new List<PortForm>();
        public ListView DisplayView;
        public PortData PassingPort
        {
            get
            {
                return Ports[0];
            }

            set
            {
                for (int x = 0; x < Ports.Count; x++)
                {
                    if (value.DisplayName == Ports[x].DisplayName || value.SelectedPort.PortName == Ports[x].SelectedPort.PortName)
                    {
                        for (int y = 0; y < PortListView.Items.Count; y++)
                        {
                            if (value.SelectedPort.PortName == PortListView.Items[y].SubItems[1].Text)
                            {
                                PortListView.Items[y].SubItems[0].Text = value.DisplayName;
                                break;
                            }
                        }

                        Ports[x] = value;
                    }
                }
            }
        }
        public char GetFreeName()
        {
            char name = 'A';
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            name = chars[random.Next(chars.Length)];
            for (int y = 0; y < PortListView.Items.Count; y++)
            {
                for (int x = 0; x < PortListView.Items[y].Text.Length; x++)
                {
                    if (name == PortListView.Items[y].SubItems[1].Text[x])
                    {
                        name = GetFreeName();
                    }

                }
            }
            return name;
        }
        public PortData FindPort(string name)
        {
            foreach (PortData port in Ports)
            {
                if (port.DisplayName == name)
                    return port;
            }
            return default(PortData);
        }
        public StartupForm()
        {
            InitializeComponent();
            Startup();
        }
        void Startup()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            PortListView.View = View.Details;
            PortListView.DoubleClick += PortListViewDoubleClick;
            GetAllPorts();
            this.FormClosing += OnClose;
            ThisForm = this;
            DisplayView = PortListView;
            this.Icon = new Icon("Resources/Icon.ico");
        }
        public void Broadcast(string data)
        {
            foreach (PortData port in Ports)
            {
                port.SelectedPort.Write(data);
            }
        }
        private void PortListViewDoubleClick(object sender, EventArgs e)
        {
            var Sender = PortListView.SelectedItems[0].SubItems[0];
            try
            {
                foreach (PortData port in Ports)
                {
                    if (port.DisplayName == Sender.Text)
                    {

                        if (port.SelectedPort.IsOpen)
                        {

                            MessageBox.Show("access denied, Is something else using it ? Port: " + port.DisplayName);
                        }
                        else
                        {
                            bool x = false;
                            foreach (PortForm form in OpenForms)
                            {
                                if (form.SelectedPort.DisplayName == port.DisplayName)
                                {
                                    x = true;
                                }
                            }
                            if (x)
                            {
                                MessageBox.Show("Already open in another form. if this is a mistake restart the program.");
                            }
                            else
                            {

                                InitialConfigureForm InitialConfigureForm = new InitialConfigureForm(this, port);
                                InitialConfigureForm.ShowDialog();
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        public void OnClose(Object sender, FormClosingEventArgs e)
        {
            for (int x = OpenForms.Count; x > 0; x--)
            {
                OpenForms[x - 1].Close();
            }
            foreach (PortForm OpenForm in OpenForms)
            {
                OpenForm.Close();
            }
        }

        public void GetAllPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            int x = 0;
            foreach (string port in ports)
            {
                PortData Port = new PortData(new SerialPort(port, 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One), null);
                PortListView.Items.Add(new ListViewItem(new String[3] { "", port, "Closed" }));
                Ports.Add(Port);
                x++;
            }
            SelectedPort = Ports[0].SelectedPort;
        }

        public class PortData
        {
            public string DisplayName;
            public string DataString = "";
            public SerialPort SelectedPort;
            public PortForm portform;
            public string receivedMessage = "";
            public string HexBoxstring = "";
            public string AsciiBoxstring = "";
            public PortData(SerialPort serialport, PortForm MainForm)
            {
                SelectedPort = serialport;
                portform = MainForm;
                DisplayName = "";
            }
            public void ClosePort()
            {
                if (SelectedPort.IsOpen)
                {
                    SelectedPort.Close();
                    SelectedPort.DataReceived -= new System.IO.Ports.SerialDataReceivedEventHandler(DataRecieved);
                }
            }
            public void OpenPort()
            {
                if (!SelectedPort.IsOpen)
                {
                    try
                    {
                        SelectedPort.Open();
                        SelectedPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(DataRecieved);
                    }
                    catch (System.UnauthorizedAccessException)
                    {
                        MessageBox.Show("access denied, Is something else using it ? Port: " + SelectedPort.PortName);
                    }

                }
            }
            void DataRecieved(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
            {
                int header = SelectedPort.ReadByte();
                string packet = "";
                char Destination = 'a';
                int Size = 0;
                if (header == 1)
                {
                    packet += (char)1;
                    Destination = (char)SelectedPort.ReadByte();
                    packet += Destination;
                    packet += (char)SelectedPort.ReadByte();
                    Size += SelectedPort.ReadByte();
                    packet += (char)Size;
                    while (Size > 0)
                    {
                        packet += (char)SelectedPort.ReadByte();
                        Size--;
                    }
                    packet+= SelectedPort.ReadByte();
                    foreach (PortData port in portform.MainForm.Ports)
                    {
                        for (int x=0;x<port.DisplayName.Length;x++)
                        {
                            if (Destination==port.DisplayName[x])
                            {
                                port.SelectedPort.Write(packet);
                                PortForm.UpdateBoxes(DisplayName, packet, portform);
                            }
                        }
                    }
                }
                else
                {
                    if (header == 5)//on enquire
                    {
                        char NewHost = portform.MainForm.GetFreeName();
                        SelectedPort.Write("" +NewHost );
                        DisplayName += NewHost;
                        PortForm.UpdateBoxes(DisplayName, "Assigned"+NewHost, portform);
                    }
                    else
                    {
                        if (header == 7)//on List From server
                        {
                            int size = SelectedPort.ReadByte();
                            DisplayName = "" + (char)SelectedPort.ReadByte();
                            size--;
                            while (size > 0)
                            {
                                DisplayName += (char)SelectedPort.ReadByte();
                                size--;
                            }
                            PortForm.UpdateBoxes(DisplayName, "Rewrote table" + DisplayName, portform);
                        }
                        else
                        {
                            if (header == 2)//Request List
                            {
                                int Length = 0;
                                string List = "";
                                foreach (PortData port in portform.MainForm.Ports)
                                {
                                    if(port.DisplayName!=DisplayName)
                                    {
                                        Length += port.DisplayName.Length;
                                        List += port.DisplayName;
                                    }
                                }
                                SelectedPort.Write((char)7 + (char)Length + List);
                                PortForm.UpdateBoxes(DisplayName, "Sent table" + List, portform);
                            }
                        }
                    }


                }
            }
        }

    }
}
