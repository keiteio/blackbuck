using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blackbuck
{
    class ApplicationContext
    {
        private static ApplicationContext instance;

        public TransparentForm Form { get; set; }
        public MainForm MainForm { get; set; }
        public MainContextMenu MainContextMenu { get; private set; }

        private ApplicationContext()
        {
            this.MainContextMenu = new MainContextMenu(new System.ComponentModel.Container());
        }


        public static ApplicationContext Instance
        {
            get {
                if (instance == null)
                {
                    instance = new ApplicationContext();
                }
                return instance;
            }
        }

        public void Exit()
        {
            this.MainForm.NotifyIcon.Dispose();
            Application.Exit();
        }
    }
}
