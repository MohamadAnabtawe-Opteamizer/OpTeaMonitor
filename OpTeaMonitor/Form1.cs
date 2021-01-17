using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpTeaMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String machineName = System.Environment.MachineName;
            RAM.MachineName = machineName;
            CPU.MachineName = machineName;
            GPU.MachineName = machineName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = CPU.NextValue();
            float dram = RAM.NextValue();
            float fgpu = 10;// GPU.NextValue();

            circularProgressBarCPU.Value = (int)fcpu;
            circularProgressBarCPU.Text = string.Format("{0:0.00}%", fcpu);

            circularProgressBarRAM.Value = (int)dram;
            circularProgressBarRAM.Text = string.Format("{0:0.00}%", dram);            
            
            circularProgressBarGPU.Value = (int)fgpu;
            circularProgressBarGPU.Text = string.Format("{0:0.00}%", fgpu);
        }
    }
}
