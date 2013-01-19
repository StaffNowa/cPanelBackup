using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cPanelBackup
{
    class Backup
    {

        private String domain = "";
        private String username = "";
        private String password = "";
        private String email = "";

        private String ftp_host = "";
        private String ftp_username = "";
        private String ftp_password = "";
        private int ftp_port = 21;
        private String ftp_dir = "";
        
        private String login_uri;
        private String post_login_uri;

        static String[] domain_list = { "" };
        String cookieHeader;

        public String getDomain()
        {
            return this.domain;
        }

        public String getUsername()
        {
            return this.username;
        }

        public String getPassword()
        {
            return this.password;
        }

        public String getEmail()
        {
            return this.email;
        }

        public String getPostLoginUri()
        {
            return this.post_login_uri;
        }

        public void setPostLoginUri(String post_login)
        {
            this.post_login_uri = post_login;
        }

        public static string[] getDomainList()
        {
            return domain_list;
        }

        public String getCookie()
        {
            return this.cookieHeader;
        }

        public void setCookie(String cookieHeader)
        {
            this.cookieHeader = cookieHeader;
        }

        public String getFtpHost()
        {
            return this.ftp_host;
        }

        public String getFtpUser()
        {
            return this.ftp_username;
        }

        public String getFtpPass()
        {
            return this.ftp_password;
        }

        public int getFtpPort()
        {
            return this.ftp_port;
        }

        public String getFtpDir()
        {
            return this.ftp_dir;
        }

        public void sendPostRequest(string uri, int port = 80, String postData = "")
        {
            try
            {
                String result = "";
                login_uri = "http://" + uri + ":" + port + "/frontend/x3/backup/dofullbackup.html";
                MessageBox.Show(login_uri);
                var cookies = new CookieContainer();
                var request = (HttpWebRequest)WebRequest.Create(login_uri);
                request.CookieContainer = cookies;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.AllowAutoRedirect = false;

                string authInfo = getUsername() + ":" + getPassword();
                authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
                request.Headers["Authorization"] = "Basic " + authInfo;

                using (var requestStream = request.GetRequestStream())
                using (var writer = new StreamWriter(requestStream))
                {
                    writer.Write(postData);
                }

                using (var responseStream = request.GetResponse().GetResponseStream())
                using (var reader = new StreamReader(responseStream))
                {
                    result = reader.ReadToEnd();
                    int start = result.IndexOf("<h1>Full Backup");
                    int end = result.IndexOf("</h1>");

                    // save needed string
                    MessageBox.Show(result.Substring(start + 4, end - start - 4));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }  
    }
}
