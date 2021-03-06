﻿using System;
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

            NotifyIcon.ContextMenuStrip = this.context.MainContextMenu;
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

        public void RefreshForm(bool transparent)
        {
            TransparentForm old_form = this.form;
            this.form = new TransparentForm(transparent);
            this.context.Form = this.form;
            this.form.Show();

            if (old_form != null)
            {
                float zoom = old_form.Zoom;
                this.form.BackgroundImage = old_form.BackgroundImage;
                this.form.BackgroundImageLayout = old_form.BackgroundImageLayout;
                this.form.Location = old_form.Location;
                this.form.ClientSize = old_form.ClientSize;
                this.form.Opacity = old_form.Opacity < 1.0f ? old_form.Opacity : 0.9f;
                this.form.Zoom = zoom;
                this.form.FixOpacity = old_form.FixOpacity;
                this.form.FixZoom = old_form.FixZoom;
                old_form.Close();
                old_form.Dispose();
            }

        }

    }
}
