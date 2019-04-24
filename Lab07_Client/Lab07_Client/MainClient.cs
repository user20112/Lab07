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
    public partial class SerialChat : Form
    {
        Configure cfg = new Configure();

        public SerialChat()
        {
            InitializeComponent();
        }

        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {

            cfg.ShowDialog();
        }
    }
}
