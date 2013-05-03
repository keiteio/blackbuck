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
        ApplicationContext context;

        public MainForm()
        {
            this.context = ApplicationContext.Instance;

            InitializeComponent();

            this.components = new System.ComponentModel.Container();
            NotifyIcon.ContextMenuStrip = new MainContextMenu(this.components);
            NotifyIcon.Text = this.Text;

            this.context.MainForm = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NotifyIcon.Icon = new Icon(@"C:\Windows\System32\PerfCenterCpl.ico");

            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = false;
            this.Visible = false;

            RefreshForm(false);

            this.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
        }

        void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            NotifyIcon.Dispose();
        }

        void RefreshForm(bool transparent)
        {
            TransparentForm old_form = this.form;
            this.form = new TransparentForm(transparent);

            if (old_form != null)
            {
                this.form.Location = old_form.Location;
                this.form.ClientSize = old_form.ClientSize;
                this.form.Zoom = old_form.Zoom;
            }

            this.context.Form = this.form;
            this.form.Show();
        }

    }
}
