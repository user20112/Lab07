using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Reflection;
using System.Drawing;

namespace Lab4
{
    public partial class ConfigureForm : Form
    {
        public PortForm mainForm;      //ParentForm.
        public ConfigureForm()
        {
            InitializeComponent();

            this.FormClosing += OnClose;

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
            BaudUpDown.Value = mainForm.SelectedPort.SelectedPort.BaudRate;
            DataBitsUpDown.Value = mainForm.SelectedPort.SelectedPort.DataBits;
            switch (mainForm.SelectedPort.SelectedPort.StopBits)
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
            mainForm.SelectedPort.SelectedPort.BaudRate = Convert.ToInt32(BaudUpDown.Value);
            mainForm.SelectedPort.SelectedPort.DataBits = Convert.ToInt32(DataBitsUpDown.Value);
            switch (StopUpDown.Value)
            {
                case 1:
                    mainForm.SelectedPort.SelectedPort.StopBits = StopBits.One;
                    break;
                case (Decimal)1.5:
                    mainForm.SelectedPort.SelectedPort.StopBits = StopBits.OnePointFive;
                    break;
                case 2:
                    mainForm.SelectedPort.SelectedPort.StopBits = StopBits.Two;
                    break;
            }
            this.Dispose();
        }
    }
}
