using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace errorIsError
{
    public partial class KoizumiExe : Form
    {
        public KoizumiExe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            System.Media.SystemSounds.Hand.Play();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmd = "";
            string[] args = Environment.GetCommandLineArgs();
            for (int i = 1; i < args.Length; i++)
            {
                if (1 < i)
                {
                    cmd += " ";
                }
                cmd += "\"" + args[i] + "\"";
            }
            System.Diagnostics.Process.Start(Application.ExecutablePath, cmd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cmd = "";
            string[] args = Environment.GetCommandLineArgs();
            for (int i = 1; i < args.Length; i++)
            {
                if (1 < i)
                {
                    cmd += " ";
                }
                cmd += "\"" + args[i] + "\"";
            }
            System.Diagnostics.Process.Start(Application.ExecutablePath, cmd);
        }
    }
}
