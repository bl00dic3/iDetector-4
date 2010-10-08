
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;

namespace iDetector4
{

    public partial class Form1 : Form
    {


        /* Stuff to declare :) */
        public string ExitRecovery = "\nHold HOME and POWER button for 10 seconds to reboot into iPhone OS again.";


        /* Startup */
        public Form1()
        {
            InitializeComponent();
        }

        /* New or old Bootrom? :) */
        private void Button1_Click(object sender, EventArgs e)
        {

            Button1.Enabled = false;
            Button1.Text = "Searching for DFU...";

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PnPDevice");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                txtConsole.Text += queryObj; //(queryObj("SystemElement"));
            }

            
            /* Go, Go, Go, iBoot! :) */

            if (txtConsole.Text.Contains("CPID:8920")) {

                if (txtConsole.Text.Contains( "[IBOOT-359.3]"))
                    MessageBox.Show("Your iPhone 3G[S] contains the Old Bootrom." + ExitRecovery);

                if (txtConsole.Text.Contains("[IBOOT-359.3.2]"))
                    MessageBox.Show("Your iPhone 3G[S] contains the New Bootrom." + ExitRecovery);

            } if ( txtConsole.Text.Contains("CPID:8720")) {

                if (txtConsole.Text.Contains("[IBOOT-240.5.1]"))
                    MessageBox.Show("Your iPod Touch 2G contains the New Bootrom.\nPeople may consider this as an iPod Touch 3G - 8GB Model");

		        if (txtConsole.Text.Contains("[IBOOT-240]"))
			        MessageBox.Show("Your iPod Touch 2G contains the Old Bootrom." + ExitRecovery);

            }  else {
                MessageBox.Show("Another device other than a 3GS or iPod Touch 2G was detected!");

            }

            /* Reset so user can do it all over again :) */
            resetProgram();

        }

        public void resetProgram()
        {
            Button1.Text = "New or old Bootrom?";
            txtConsole.Text = "";
            Button1.Enabled = true;
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.youtube.com/watch?v=bITIiGswjFI");
        }


    }
}
