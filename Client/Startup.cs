using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MultiplayerButton_Click(object sender, EventArgs e)
        {
            new ConnectionForm().Show();
            Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new MapSelection(false).Show();

        }
    }
}
