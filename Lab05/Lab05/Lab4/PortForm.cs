using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Lab4
{
    public partial class PortForm : Form
    {
        public StartupForm.PortData SelectedPort;
        public StartupForm MainForm;
        public PortForm(StartupForm.PortData selectedport, StartupForm mainForm)
        {
            InitializeComponent();
            RenameBox.Text = selectedport.DisplayName;
            MainForm = mainForm;
            SelectedPort = selectedport;
            SelectedPort.OpenPort();
            Startup();
        }
        void Startup()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            AsciiLabel.Text = "Ascii Box: " + SelectedPort.DisplayName;
            HexLabel.Text = "Hex Box: " + SelectedPort.DisplayName;
            this.FormClosing += OnClose;
            this.Text = SelectedPort.DisplayName;
            this.Icon = new Icon("Resources/Icon.ico");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SelectedPort.DataString = "";
            AsciiBox.Text = "";
            HexBox.Text = "";
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            SelectedPort.OpenPort();
            for (int y = 0; y < MainForm.DisplayView.Items.Count; y++)
            {
                if (SelectedPort.SelectedPort.PortName == MainForm.DisplayView.Items[y].SubItems[1].Text)
                {
                    MainForm.DisplayView.Items[y].SubItems[2].Text = "Open";
                    break;
                }
            }
        }
        public void OnClose(Object sender, FormClosingEventArgs e)
        {
            SelectedPort.ClosePort();
            for (int y = 0; y < MainForm.DisplayView.Items.Count; y++)
            {
                if (SelectedPort.SelectedPort.PortName == MainForm.DisplayView.Items[y].SubItems[1].Text)
                {
                    MainForm.DisplayView.Items[y].SubItems[2].Text = "Closed";
                    break;
                }
            }

            SyncPort();
            MainForm.OpenForms.Remove(this);
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            SelectedPort.ClosePort();
            for (int y = 0; y < MainForm.DisplayView.Items.Count; y++)
            {
                if (SelectedPort.SelectedPort.PortName == MainForm.DisplayView.Items[y].SubItems[1].Text)
                {
                    MainForm.DisplayView.Items[y].SubItems[2].Text = "Closed";
                    break;
                }
            }
        }

        private void ConfigurePortButton_Click(object sender, EventArgs e)
        {
            ConfigureForm ConfigureWindow = new ConfigureForm();
            ConfigureWindow.mainForm = this;
            ConfigureWindow.ShowDialog();
        }
        static public void UpdateBoxes(string portname, string Datastring, PortForm portform)
        {
            TextBox HexBox = (TextBox)portform.Controls.Find(portname + "HexBox", true)[0];
            TextBox AsciiBox = (TextBox)portform.Controls.Find(portname + "AsciiBox", true)[0];//clear the output and output first byte.
            HexBox.Text = BitConverter.ToString(new byte[] { Convert.ToByte(Datastring[0]) }) + " ";
            AsciiBox.Text = Datastring[0] + " ";
            for (int y = 1; y < Datastring.Length; y++)//oyutput rest of bytes.
            {
                AsciiBox.Text += Datastring[y] + " ";
                HexBox.Text += BitConverter.ToString(new byte[] { Convert.ToByte(Datastring[y]) }) + " ";//formats it as hex
            }
            AsciiBox.Text += Environment.NewLine;
            HexBox.Text += Environment.NewLine;//remember the endls
        }
        private void RenameButton_Click(object sender, EventArgs e)
        {
            SelectedPort.DisplayName = RenameBox.Text;
            SyncPort();
        }
        
        private void SyncPort()
        {
            MainForm.PassingPort = SelectedPort;
        }
    }
}
