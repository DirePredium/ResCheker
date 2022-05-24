﻿using System;
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
            SaveFileDialog savefile1 = new SaveFileDialog();
            savefile1.Filter = "dat files |*.json";
            savefile1.FilterIndex = 2;
            savefile1.RestoreDirectory = true;
            if (savefile1.ShowDialog() == DialogResult.OK)
            {
                TestResMonitor monitorStruct = new TestResMonitor();
                monitorStruct.CpuPer = 56786;
                monitorStruct.MemPer = 568560;
                monitorStruct.GpuPer = 967560;
                monitorStruct.FpsCou = 656555;
                fileHandler.SaveRes<TestResMonitor>(savefile1.FileName, monitorStruct);
            }
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                TestResMonitor testRM = fileHandler.ReadRes<TestResMonitor>(openfile.FileName);
                textBox1.Text = testRM.CpuPer + " " + testRM.FpsCou + " " + testRM.MemPer+" " + testRM.FpsCou + " ";
            }
        }
    }
}
