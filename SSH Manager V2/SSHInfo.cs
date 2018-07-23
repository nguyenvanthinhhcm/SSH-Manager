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

namespace SSH_Manager_V2
{
    public partial class SSHInfo : Form
    {
        public SSHInfo()
        {
            InitializeComponent();
        }

        public List<SSH> savelist = new List<SSH>();
        private void SSHInfo_Load(object sender, EventArgs e)
        {
            savelist = Form1.List;
            gidInfo.DataSource = savelist;
            gidInfo.Columns[3].Width = 50;
            gidInfo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txtssh.Text = gidInfo.Rows.Count.ToString();
            txtDup.Text = Form1.DupCount.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text File | *.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFile.FileName, (from i in savelist select i.Serialize()));

            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text File | *.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFile.FileName, (from i in savelist select i.SeriaIP()));

            }
            Close();
        }


    }



}
