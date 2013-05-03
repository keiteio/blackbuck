using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blackbuck
{
    public partial class MainForm : Form
    {
        TransparentForm form;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            notifyIcon1.Icon = new Icon(@"C:\Windows\System32\PerfCenterCpl.ico");

            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = false;
            this.Visible = false;

            form = new TransparentForm();
            form.Show();
        }

    }
}
