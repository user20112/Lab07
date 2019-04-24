using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Reflection;
using System.Drawing;

namespace Lab4
{
    public partial class InitialConfigureForm : Form
    {
        public StartupForm mainForm;      //ParentForm.
        StartupForm.PortData Port;
        public InitialConfigureForm(StartupForm MainForm, StartupForm.PortData port)
        {
            mainForm = MainForm;
            Port = port;
            InitializeComponent();
            this.Icon = new Icon("Resources/Icon.ico");
        }
        public void OnClose(Object sender, FormClosingEventArgs e)
        {
            DoneButton_Click(null, null);
        }

        private void ConfigureForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            BaudUpDown.Value = Port.SelectedPort.BaudRate;
            DataBitsUpDown.Value = Port.SelectedPort.DataBits;
            switch (Port.SelectedPort.StopBits)
            {
                case StopBits.One:
                    StopUpDown.Value = 1;
                    break;
                case StopBits.OnePointFive:
                    StopUpDown.Value = (Decimal)1.5;
                    break;
                case StopBits.Two:
                    StopUpDown.Value = 2;
                    break;
            }
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {

            PortForm PortForm = new PortForm(Port,mainForm);
            PortForm.Show();
            Close();
        }
    }
}
