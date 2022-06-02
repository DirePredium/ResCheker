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
    public partial class JsonForm : Form
    {
        TestResMonitor jsonResMonitor;
        public JsonForm(Object jsonResMonitor)
        {
            InitializeComponent();
            this.jsonResMonitor = (TestResMonitor)jsonResMonitor;
            label1.Text += " " + this.jsonResMonitor.CpuPer;
            label2.Text += " " + this.jsonResMonitor.FpsCou;
            label3.Text += " " + this.jsonResMonitor.MemPer;
            label4.Text += " " + this.jsonResMonitor.FpsCou;
        }
    }
}
