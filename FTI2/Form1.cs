using System;
using System.Data;
using System.Data.SqlClient;
using System.Management;
using System.Windows.Forms;

namespace FTI2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            var searcher = new ManagementObjectSearcher("root\\CIMV2","SELECT Name, PercentProcessorTime FROM Win32_PerfFormattedData_PerfProc_Process");

            foreach (var o in searcher.Get())
            {
                var pVal = (ManagementObject) o;
                object col1 = pVal["Name"]?.ToString();
                object col2 = pVal["PercentProcessorTime"]?.ToString();


                dataGridView1.Rows.Add(new object[] { col1, col2});
            }


        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
