using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResCheker
{
    public partial class Form1 : Form
    {

        static FileHandlerJson fileHandler;
        public Form1()
        {
            InitializeComponent();
            fileHandler = new FileHandlerJson();
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "dat files |*.json";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                TestResMonitor monitorStruct = new TestResMonitor();
                monitorStruct.CpuPer = 56786;
                monitorStruct.MemPer = 568560;
                monitorStruct.GpuPer = 967560;
                monitorStruct.FpsCou = 656555;
                fileHandler.SaveRes<TestResMonitor>(saveFileDialog.FileName, monitorStruct);
            }
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TestResMonitor testRM = fileHandler.ReadRes<TestResMonitor>(openFileDialog.FileName);
                textBox1.Text = testRM.CpuPer + " " + testRM.FpsCou + " " + testRM.MemPer+" " + testRM.FpsCou + " ";
            }
        }
    }
}
