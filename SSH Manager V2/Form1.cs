using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSH_Manager_V2
{
    public partial class Form1 : Form
    {
        LookupService ls = new LookupService("GeoIP.dat", LookupService.GEOIP_MEMORY_CACHE);
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            System.Net.ServicePointManager.Expect100Continue = false;
        }


        public static List<SSH> List = new List<SSH>();

        public static int DupCount;

        public List<SSH> List1 = new List<SSH>();

        public List<SSH> List2 = new List<SSH>();

        public List<SSH> ListIP = new List<SSH>();

        private void txtDir1_DragDrop(object sender, DragEventArgs e)
        {
            int i_ssh = 0;
            int i_er = 0;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                txtDir1.Text = files[0];
            }
            string[] txt = File.ReadAllLines(txtDir1.Text);
            List1 = new List<SSH>();
            foreach (string ssh in txt)
            {
                string[] ip = ssh.Split('|');
                if(IsValidIP(ip[0]))
                {
                    string code = ls.getCountry(ip[0].Trim()).getCode();
                    string name = ls.getCountry(ip[0].Trim()).getName();
                    i_ssh++;
                    List1.Add(new SSH { Ip = ip[0], User = ip[1], Pass = ip[2], Country = code, CountryName = name });
                }
                else
                {
                    i_er++;
                }
            }
            lbE1.Text = "Errors: " + i_er.ToString();
            lbR1.Text = "Results : " + i_ssh.ToString();
        }

        public static bool IsValidIP(string ipAddress)
        {
            IPAddress unused;
            return IPAddress.TryParse(ipAddress, out unused)
              &&
              (
                  unused.AddressFamily != AddressFamily.InterNetwork
                  ||
                  ipAddress.Count(c => c == '.') == 3
              );
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtDir1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List.Clear();
            List = List1;
            SSHInfo mau = new SSHInfo();
            mau.Show();
        }

        private void txtDir2_DragDrop(object sender, DragEventArgs e)
        {
            int i_ssh = 0;
            int i_er = 0;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                txtDir2.Text = files[0];
            }
            string[] txt = File.ReadAllLines(txtDir2.Text);
            List2 = new List<SSH>();
            foreach (string ssh in txt)
            {
                string[] ip = ssh.Split('|');
                if (IsValidIP(ip[0]))
                {
                    string code = ls.getCountry(ip[0].Trim()).getCode();
                    string name = ls.getCountry(ip[0].Trim()).getName();
                    i_ssh++;
                    List2.Add(new SSH {Ip = ip[0], User = ip[1], Pass = ip[2], Country = code, CountryName = name});
                }
                else
                {
                    i_er++;
                }
            }
            lbE2.Text = "Errors: " + i_er.ToString();
            lbR2.Text = "Results : " + i_ssh.ToString();
        }

        private void txtDir2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List.Clear();
            List = List2;
            SSHInfo mau = new SSHInfo();
            mau.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List.Clear();
            List<SSH> new_list = new List<SSH>();
            new_list = List1.DistinctBy(i => i.Ip).ToList();
            DupCount = List1.Count - new_list.Count;
            List = new_list;
            SSHInfo mau = new SSHInfo();
            mau.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List.Clear();
            List<SSH> new_list = new List<SSH>();
            new_list = List1;
            new_list.AddRange(List2);
            new_list = new_list.DistinctBy(i => i.Ip).ToList();
            DupCount = List1.Count - new_list.Count;
            List = new_list;
            SSHInfo mau = new SSHInfo();
            mau.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(rbEg.Checked)
            {
                List.Clear();
                string[] country = txtEg.Text.Split(',');
                List<code> code = country.Select(item => new code() { Country = item } ).ToList();
                var result = List1.Where( p => p.Country.Any(pi => code.Any( ci => ci.Country == p.Country)));
                List<SSH> hhh = new List<SSH>(result);
                List = hhh;
                SSHInfo mau = new SSHInfo();
                mau.ShowDialog();
            }
            if(rbEu.Checked)
            {
                List.Clear();
                string[] country = txtEu.Text.Split(',');
                List<code> code = country.Select(item => new code() { Country = item }).ToList();
                var result = List1.Where(p => p.Country.Any(pi => code.Any(ci => ci.Country == p.Country)));
                List<SSH> hhh = new List<SSH>(result);
                List = hhh;
                SSHInfo mau = new SSHInfo();
                mau.ShowDialog();
            }
            if(rbSp.Checked)
            {
                List.Clear();
                string[] country = txtSp.Text.Split(',');
                List<code> code = country.Select(item => new code() { Country = item }).ToList();
                var result = List1.Where(p => p.Country.Any(pi => code.Any(ci => ci.Country == p.Country)));
                List<SSH> hhh = new List<SSH>(result);
                List = hhh;
                SSHInfo mau = new SSHInfo();
                mau.ShowDialog();
            }
            if(rbAll.Checked)
            {
                List.Clear();
                string[] country = txtCAll.Text.Split(',');
                List<code> code = country.Select(item => new code() { Country = item }).ToList();
                var result = List1.Where(p => p.Country.Any(pi => code.Any(ci => ci.Country == p.Country)));
                List<SSH> hhh = new List<SSH>(result);
                List = hhh;
                SSHInfo mau = new SSHInfo();
                mau.ShowDialog();
            }
            if(rbEUUS.Checked)
            {
                List.Clear();
                string[] country = txtEUUS.Text.Split(',');
                List<code> code = country.Select(item => new code() { Country = item }).ToList();
                var result = List1.Where(p => p.Country.Any(pi => code.Any(ci => ci.Country == p.Country)));
                List<SSH> hhh = new List<SSH>(result);
                List = hhh;
                SSHInfo mau = new SSHInfo();
                mau.ShowDialog();
            }

            if (rbProper.Checked)
            {
                List.Clear();
                string[] country = txProper.Text.Split(',');
                List<code> code = country.Select(item => new code() { Country = item }).ToList();
                var result = List1.Where(p => p.Country.Any(pi => code.Any(ci => ci.Country == p.Country)));
                List<SSH> hhh = new List<SSH>(result);
                List = hhh;
                SSHInfo mau = new SSHInfo();
                mau.ShowDialog();
            }

        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            int i_ssh = 0;
            int i_er = 0;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                textBox1.Text = files[0];
            }
            string[] txt = File.ReadAllLines(textBox1.Text);
            ListIP = new List<SSH>();
            foreach (string ssh in txt)
            {
                if (IsValidIP(ssh))
                {
                    string code = ls.getCountry(ssh.Trim()).getCode();
                    string name = ls.getCountry(ssh.Trim()).getName();
                    i_ssh++;
                    ListIP.Add(new SSH { Ip = ssh, User = "None", Pass = "None", Country = code, CountryName = name });
                }
                else
                {
                    i_er++;
                }
            }
            lbIP.Text = i_ssh.ToString();

        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List.Clear();
            string[] country = txtCAll.Text.Split(',');
            List<code> code = country.Select(item => new code() { Country = item }).ToList();
            var result = ListIP.Where(p => p.Country.Any(pi => code.Any(ci => ci.Country == p.Country)));
            List<SSH> hhh = new List<SSH>(result);
            List = hhh;
            SSHInfo mau = new SSHInfo();
            mau.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List.Clear();
            List<SSH> new_list = new List<SSH>();
            new_list = ListIP.DistinctBy(i => i.Ip).ToList();
            DupCount = ListIP.Count - new_list.Count;
            List = new_list;
            SSHInfo mau = new SSHInfo();
            mau.ShowDialog();
        }

        private void btFilterExcept_Click(object sender, EventArgs e)
        {
            List = List1;
            SSHInfo mau = new SSHInfo();
            mau.ShowDialog();
        }


    
    
    
    }


    public static class ExtensionMethods
    {
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            var seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }
    }
}
