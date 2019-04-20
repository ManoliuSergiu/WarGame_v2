using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Client
{
    public partial class ConnectionForm : Form
    {
        public static Label label;
        public static ConnectionForm form;
        public static bool style = false;
        public ConnectionForm()
        {
            InitializeComponent();
            form = this;
            
        }

       
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(portTextBox.Text, out int result))
            {
                if (IPAddress.TryParse(ipTextbox.Text, out IPAddress ip))
                {
                    bool check = Engine.ConnectToServer(ip, result);
                    if (check)
                    {
                        new MapSelection(true).Show();
                        Close();
                    }
                }
                else
                {
                    ipTextbox.Text = "Invalid IP";
                }
            }
            else
            {
                portTextBox.Text = "Invalid Port";
            }
        }

   
        private void ConnectionForm_Load(object sender, EventArgs e)
        {

        }

    }
}
