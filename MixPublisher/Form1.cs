using System;
using System.Windows.Forms;

namespace MixPublisher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(axWindowsMediaPlayer1.Ctlcontrols.currentPositionString);
        }
    }
}
