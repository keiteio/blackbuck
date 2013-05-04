using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace Blackbuck
{
    public partial class MainContextMenu
    {
        private void FixPosition_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationContext ctx = ApplicationContext.Instance;
            ctx.Form.Stay = (false == ctx.Form.Stay);
        }

        private void FixZoom_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationContext ctx = ApplicationContext.Instance;
            ctx.Form.FixZoom = (false == ctx.Form.FixZoom);
        }

        private void FixOpscity_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationContext ctx = ApplicationContext.Instance;
            ctx.Form.FixOpacity = (false == ctx.Form.FixOpacity);
        }

        private void Transparent_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationContext ctx = ApplicationContext.Instance;
            ctx.MainForm.RefreshForm(false == ctx.Form.TransparentClick);
            this.Transparent_ToolStripMenuItem.Checked = ctx.Form.TransparentClick;
        }

        private void SavePosition(int num)
        {
            ApplicationContext ctx = ApplicationContext.Instance;
            if (ctx.Form != null)
            {
                switch (num)
                {
                    case 1:
                        {
                            Properties.Settings.Default.Save1Position = ctx.Form.Location;
                            Properties.Settings.Default.Save1Zoom = ctx.Form.Zoom;
                            break;
                        }
                    case 2:
                        {
                            Properties.Settings.Default.Save2Position = ctx.Form.Location;
                            Properties.Settings.Default.Save2Zoom = ctx.Form.Zoom;
                            break;
                        }
                    case 3:
                        {
                            Properties.Settings.Default.Save3Position = ctx.Form.Location;
                            Properties.Settings.Default.Save3Zoom = ctx.Form.Zoom;
                            break;
                        }
                    case 4:
                        {
                            Properties.Settings.Default.Save4Position = ctx.Form.Location;
                            Properties.Settings.Default.Save4Zoom = ctx.Form.Zoom;
                            break;
                        }
                    case 5:
                        {
                            Properties.Settings.Default.Save5Position = ctx.Form.Location;
                            Properties.Settings.Default.Save5Zoom = ctx.Form.Zoom;
                            break;
                        }

                }
                Properties.Settings.Default.Save();
            }
        }

        private void Save1_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePosition(1);
        }

        private void Save2_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePosition(2);
        }

        private void Save3_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePosition(3);
        }

        private void Save4_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePosition(4);
        }

        private void Save5_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePosition(5);
        }

        private void LoadPosition(int num)
        {
            ApplicationContext ctx = ApplicationContext.Instance;
            Properties.Settings.Default.Reload();
            switch (num)
            {
                case 1:
                    {
                        ctx.Form.Location = Properties.Settings.Default.Save1Position;
                        ctx.Form.Zoom = Properties.Settings.Default.Save1Zoom;
                        break;
                    }
                case 2:
                    {
                        ctx.Form.Location = Properties.Settings.Default.Save2Position;
                        ctx.Form.Zoom = Properties.Settings.Default.Save2Zoom;
                        break;
                    }
                case 3:
                    {
                        ctx.Form.Location = Properties.Settings.Default.Save3Position;
                        ctx.Form.Zoom = Properties.Settings.Default.Save3Zoom;
                        break;
                    }
                case 4:
                    {
                        ctx.Form.Location = Properties.Settings.Default.Save4Position;
                        ctx.Form.Zoom = Properties.Settings.Default.Save4Zoom;
                        break;
                    }
                case 5:
                    {
                        ctx.Form.Location = Properties.Settings.Default.Save5Position;
                        ctx.Form.Zoom = Properties.Settings.Default.Save5Zoom;
                        break;
                    }
            }
        }

        private void Load1_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPosition(1);
        }

        private void Load2_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPosition(2);
        }

        private void Load3_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPosition(3);
        }

        private void Load4_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPosition(4);
        }

        private void Load5_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPosition(5);
        }

        private void Close_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationContext.Instance.Exit();
        }

    }
}
