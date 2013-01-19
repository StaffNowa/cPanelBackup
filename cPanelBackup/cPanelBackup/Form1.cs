using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cPanelBackup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // fill domain ComboBox
            foreach (string str in cPanelBackup.Backup.getDomainList())
            {
                domain_list.Items.Add(str);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cPanelBackup.Backup backup = new Backup();
            String postData = "dest=ftp&email_radio=1&email=" + backup.getEmail() + "&server=" + backup.getFtpHost() + "&user=" + backup.getFtpUser() + "&pass=" + backup.getFtpPass() + "&port=" + backup.getFtpPort() + "&rdir=" + backup.getFtpDir();
            backup.sendPostRequest(backup.getDomain(), 2082, postData);
        }
    }
}
