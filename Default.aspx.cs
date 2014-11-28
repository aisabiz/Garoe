using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;


namespace Garoe

{
    public partial class _Default : System.Web.UI.Page

    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Display a Message Box
            //string display = "Hello World";
            //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);

            // Execute a command
            //string strCmdText;
            //strCmdText = "/C DIR";
            //System.Diagnostics.Process.Start("CMD.exe", strCmdText);

            //Execute a command hiding the CMD windows and passing arguments
            Process process = new Process();
            ProcessStartInfo startinfo = new ProcessStartInfo();

            //startinfo.WindowStyle = ProcessWindowStyle.Hidden;
            //startinfo.FileName = "cmd.exe";
            //startinfo.Arguments = "dir > dir.txt";
            //process.StartInfo = startinfo;
            //process.Start();


            //Execute a command PING passing arguments
            Process process2 = new Process();
            ProcessStartInfo startinfo2 = new ProcessStartInfo();

            startinfo2.WindowStyle = ProcessWindowStyle.Hidden;

            startinfo2.FileName = "C:\\PingLocalhost.cmd";
            process2.StartInfo = startinfo2;
            process2.Start();

            startinfo2.FileName = "C:\\PingStorage.cmd";
            process2.StartInfo = startinfo2;
            process2.Start();

        }
    }
}
