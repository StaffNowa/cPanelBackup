using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Collections;

namespace cPanelBackup
{
    public partial class CP : Form
    {
        public CP()
        {
            InitializeComponent();
            
            string[,] loginData = new string[,] { };
            loginData = Backup.InitializeLoginData();

            /*var arr = ((IEnumerable)obj).Cast<object>()
                                 .Select(x => x.ToString())
                                 .ToArray();*/

            for (var i = 0; i < loginData.GetLength(0); i++)
            {
                DomainList.Items.Add(loginData[i, 0].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedServer = 0;
            selectedServer = DomainList.SelectedIndex;

            cPanelBackup.Backup backup = new Backup();
            backup.InitializeFtpData("ftp.domain.com", "ftp_login", "ftp_pass", 21);
            string postData = "dest=ftp&email_radio=1&email=info@domain.com&server=" + backup.FtpHost + "&user=" + backup.FtpUser + "&pass=" + backup.FtpPass + "&port=" + backup.FtpPort;
            backup.sendPostRequest(backup.Domain, 2082, postData, selectedServer);
        }
    }
}
