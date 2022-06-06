using MetroFramework.Forms;
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
    public partial class jsonOpen : MetroForm
    {
        PerfomanceStruct jsonResMonitor;
        public jsonOpen(Object jsonResMonitor)
        {
            InitializeComponent();
            this.jsonResMonitor = (PerfomanceStruct)jsonResMonitor;
            metroLabel1.Text = "CPU: " + this.jsonResMonitor.CpuPerformance + "%";
            metroLabel2.Text = "GPU: " + this.jsonResMonitor.GpuPerformance + "%";
            metroLabel3.Text = "MEM: " + this.jsonResMonitor.MemPerformance + "%";
            metroLabel4.Text = "FPS: " + this.jsonResMonitor.FpsCounter;
        }
    }
}
