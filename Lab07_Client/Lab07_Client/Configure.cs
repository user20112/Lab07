using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07_Client
{
    public partial class Configure : Form
    {
        public delegate void ConfigHandler(Settings obj);
        public static event ConfigHandler settings;
        public Configure()
        {
            InitializeComponent();
            loadComPortComboBox();
            loadBaudRateComboBox();
            loadParityComboBox();
            loadStopBitComboBox();
        
        }

        private void loadComPortComboBox()
        {
            this.portNames = SerialPort.GetPortNames();
            int count = 0;
            foreach (string name in portNames)
            {
                cb_com.Items.Add(name);
                count++;
            }
            cb_com.SelectedIndex = count - 1;
        }

        private void loadStopBitComboBox()
        {
            cb_stopBits.Items.Add("1 bit");
            cb_stopBits.Items.Add("1.5 bit");
            cb_stopBits.Items.Add("2 bit");
            cb_stopBits.Items.Add("none");
            cb_stopBits.SelectedIndex = 0;
        }

        private void loadParityComboBox()
        {
            cb_parity.Items.Add("none");
            cb_parity.Items.Add("odd");
            cb_parity.Items.Add("even");
            cb_parity.Items.Add("mark");
            cb_parity.Items.Add("space");
            cb_parity.SelectedIndex = 0;
        }

        private void loadBaudRateComboBox()
        {

            cb_baudRate.Items.Add("9600");
            cb_baudRate.Items.Add("4800");
            cb_baudRate.Items.Add("2400");
            cb_baudRate.Items.Add("1200");
            cb_baudRate.SelectedIndex = 1;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            SetSettings();
        }
    }
}
