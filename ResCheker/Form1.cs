using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using MetroFramework.Forms;

namespace ResCheker
{
    public partial class Form1 : MetroForm
    {
        static PerfomanceStruct perfomance = new PerfomanceStruct();
        PerformanceMonitor monitor = new PerformanceMonitor(perfomance);


        public Form1()
        {
            InitializeComponent();
        }

        private void GetHardWareInfo(string key, ListView list)
        {
            list.Items.Clear();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + key);

            try
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    ListViewGroup listViewGroup;

                    try
                    {
                        listViewGroup = list.Groups.Add(obj["Name"].ToString(), obj["Name"].ToString());
                    }
                    catch (Exception ex)
                    {
                        listViewGroup = list.Groups.Add(obj.ToString(), obj.ToString());
                    }

                    if (obj.Properties.Count == 0)
                    {
                        MessageBox.Show("Не удалось получить информацию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    foreach (PropertyData data in obj.Properties)
                    {
                        ListViewItem item = new ListViewItem(listViewGroup);

                        if (list.Items.Count % 2 != 0)
                        {
                            item.BackColor = Color.White;
                        }
                        else
                        {
                            item.BackColor = Color.WhiteSmoke;
                        }

                        item.Text = data.Name;

                        if(data.Value != null && !string.IsNullOrEmpty(data.Value.ToString()))
                        {
                            switch (data.Value.GetType().ToString())
                            {
                                case "System.String[]":
                                    string[] stringData = data.Value as string[];

                                    string resStr1 = String.Empty;

                                    foreach (string s in stringData)
                                    {
                                        resStr1 += $"{s} ";
                                    }

                                    item.SubItems.Add(resStr1);
                                    break;
                                case "System.UInt16[]":
                                    ushort[] uShortData = data.Value as ushort[];

                                    string resStr2 = String.Empty;

                                    foreach (ushort u in uShortData)
                                    {
                                        resStr2 += $"{Convert.ToString(u)} ";
                                    }

                                    item.SubItems.Add(resStr2);
                                    break;
                                default:

                                    item.SubItems.Add(data.Value.ToString());
                                    break;
                            }

                            list.Items.Add(item);
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = string.Empty;

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Процессор":
                    key = "Win32_Processor";
                    break;
                case "Видеокарта":
                    key = "Win32_VideoController";
                    break;
                case "Чипсет":
                    key = "Win32_IDEController";
                    break;
                case "Батарея":
                    key = "Win32_Battery";
                    break;
                case "Биос":
                    key = "Win32_BIOS";
                    break;
                case "Оперативная память":
                    key = "Win32_PhysicalMemory";
                    break;
                case "Кэш":
                    key = "Win32_CacheMemory";
                    break;
                case "USB":
                    key = "Win32_USBController";
                    break;
                case "Диск":
                    key = "Win32_DiskDrive";
                    break;
                case "Логические диски":
                    key = "Win32_LogicalDisk";
                    break;
                case "Клавиатура":
                    key = "Win32_Keyboard";
                    break;
                case "Сеть":
                    key = "Win32_NetworkAdapter";
                    break;
                case "Пользователи":
                    key = "Win32_Account";
                    break;
                default:
                    key = "Win32_Processor";
                    break;

            }
            GetHardWareInfo(key, listView1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.monitor.StartResCounting();

            metroProgressBar1.Value = perfomance.CpuPerformance;
            metroProgressBar2.Value = perfomance.MemPerformance;
            metroProgressBar3.Value = perfomance.GpuPerformance;
            metroLabel2.Text = perfomance.CpuPerformance + " " + "%";
            metroLabel3.Text = perfomance.MemPerformance + " " + "%";
            metroLabel6.Text = perfomance.GpuPerformance + " " + "%";
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.monitor.StartFPSCounting();
            metroLabel7.Text = "FPS" + " " + perfomance.FpsCounter;
        }
    }

}
