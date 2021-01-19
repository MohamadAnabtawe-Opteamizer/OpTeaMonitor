using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpTeaMonitor
{
    public partial class mainFrame : Form
    {
        public mainFrame()
        {
            InitializeComponent();
            String machineName = System.Environment.MachineName;
            RAM.MachineName = machineName;
            CPU.MachineName = machineName;
            GPU.MachineName = machineName;
            PerformanceCounterCategory catGPU = new PerformanceCounterCategory("NVIDIA GPU");
            String[] gpuInstanceNames = catGPU.GetInstanceNames();
            int gpuCount = gpuInstanceNames.Length;
            GPU.InstanceName = gpuInstanceNames[0];
            ManagementObjectSearcher processorObject = new ManagementObjectSearcher("select * from Win32_Processor");

            foreach (ManagementObject obj in processorObject.Get())
            {
                cpuName.Text = obj["Name"].ToString();
                cpuSpeed.Text = cpuName.Text.Substring(cpuName.Text.Length - 7);
                cpuCores.Text = obj["NumberOfCores"].ToString();
                cpuLogicalProcessors.Text = obj["NumberOfLogicalProcessors"].ToString();
            }

            ManagementObjectSearcher gpuObject = new ManagementObjectSearcher("select * from Win32_VideoController");
            foreach (ManagementObject obj in gpuObject.Get())
            {
                gpuName.Text = obj["Name"].ToString();
                gpuDriverVersion.Text = obj["DriverVersion"].ToString();
                gpuDriverDate.Text = obj["DriverDate"].ToString().Substring(6, 2) + "/" + obj["DriverDate"].ToString().Substring(4, 2) + "/" + obj["DriverDate"].ToString().Substring(0, 4);
                gpuProcessor.Text = obj["VideoProcessor"].ToString();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = CPU.NextValue();
            circularProgressBarCPU.Value = (int)fcpu;
            circularProgressBarCPU.Text = string.Format("{0:0.00}%", fcpu);

            float fram = RAM.NextValue();
            circularProgressBarRAM.Value = (int)fram;
            circularProgressBarRAM.Text = string.Format("{0:0.00}%", fram);            
            
            float fgpu = GPU.NextValue();
            circularProgressBarGPU.Value = (int)fgpu;
            circularProgressBarGPU.Text = string.Format("{0:0.00}%", fgpu);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
