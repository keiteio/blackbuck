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
            this.context.Form.Stay = (false == this.context.Form.Stay);
        }

        private void FixZoom_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.context.Form.FixZoom = (false == this.context.Form.FixZoom);
        }

        private void FixOpscity_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.context.Form.FixOpacity = (false == this.context.Form.FixOpacity);
        }


        private void SavePosition(int num)
        {
            if (context.Form != null)
            {
                switch (num)
                {
                    case 1:
                        {
                            Properties.Settings.Default.Save1Position = this.context.Form.Location;
                            Properties.Settings.Default.Save1Zoom = this.context.Form.Zoom;
                            break;
                        }
                    case 2:
                        {
                            Properties.Settings.Default.Save2Position = this.context.Form.Location;
                            Properties.Settings.Default.Save2Zoom = this.context.Form.Zoom;
                            break;
                        }
                    case 3:
                        {
                            Properties.Settings.Default.Save3Position = this.context.Form.Location;
                            Properties.Settings.Default.Save3Zoom = this.context.Form.Zoom;
                            break;
                        }
                    case 4:
                        {
                            Properties.Settings.Default.Save4Position = this.context.Form.Location;
                            Properties.Settings.Default.Save4Zoom = this.context.Form.Zoom;
                            break;
                        }
                    case 5:
                        {
                            Properties.Settings.Default.Save5Position = this.context.Form.Location;
                            Properties.Settings.Default.Save5Zoom = this.context.Form.Zoom;
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
            Properties.Settings.Default.Reload();
            switch (num)
            {
                case 1:
                    {
                        this.context.Form.Location = Properties.Settings.Default.Save1Position;
                        this.context.Form.Zoom = Properties.Settings.Default.Save1Zoom;
                        break;
                    }
                case 2:
                    {
                        this.context.Form.Location = Properties.Settings.Default.Save2Position;
                        this.context.Form.Zoom = Properties.Settings.Default.Save2Zoom;
                        break;
                    }
                case 3:
                    {
                        this.context.Form.Location = Properties.Settings.Default.Save3Position;
                        this.context.Form.Zoom = Properties.Settings.Default.Save3Zoom;
                        break;
                    }
                case 4:
                    {
                        this.context.Form.Location = Properties.Settings.Default.Save4Position;
                        this.context.Form.Zoom = Properties.Settings.Default.Save4Zoom;
                        break;
                    }
                case 5:
                    {
                        this.context.Form.Location = Properties.Settings.Default.Save5Position;
                        this.context.Form.Zoom = Properties.Settings.Default.Save5Zoom;
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
            this.context.Exit();
        }

    }
}
