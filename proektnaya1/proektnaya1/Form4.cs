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

namespace proektnaya1488
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "text (*.txt)|*.txt";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 ew = ActiveMdiChild as Form5;
            if (ew == null) return;
            ew.ssave();

            MessageBox.Show("etot kal robit," +
                "vrodi2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 ew = ActiveMdiChild as Form5;
            if (ew == null) return;
            ew.Save();

            MessageBox.Show("etot kal robit," +
               "vrodi2");

        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
