using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResCheker
{
    public partial class Form1 : Form
    {
        static PerfomanceStruct perfomance = new PerfomanceStruct();
        PerformanceMonitor monitor = new PerformanceMonitor(perfomance);


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            this.monitor.StartResCounting();

            label1.Text = "CPU" + " " + perfomance.CpuPerformance + " " + "%";
            label2.Text = "MEM" + " " + perfomance.MemPerformance + " " + "%";
            label3.Text = "GPU" + " " + perfomance.GpuPerformance + " " + "%";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.monitor.StartFPSCounting();
            label4.Text = "FPS" + " " + perfomance.FpsCounter;
        }
    }

}
