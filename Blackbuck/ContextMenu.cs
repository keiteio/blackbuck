using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace Blackbuck
{
    public partial class MainContextMenu : ContextMenuStrip
    {
        ApplicationContext context;
        private static MainContextMenu instances;

        ToolStripItem NumericUpDown_ToolStripMenuItem;
        ToolStripMenuItem FixPosition_ToolStripMenuItem;
        ToolStripMenuItem FixZoom_ToolStripMenuItem;
        ToolStripMenuItem FixOpscity_ToolStripMenuItem;
        ToolStripMenuItem Transparent_ToolStripMenuItem;
        ToolStripSeparator toolStripSeparator2;
        ToolStripMenuItem SavePosition_ToolStripMenuItem;
        ToolStripMenuItem LoadPosition_ToolStripMenuItem;
        ToolStripSeparator toolStripSeparator1;
        ToolStripMenuItem Close_ToolStripMenuItem;
        ToolStripMenuItem Save1_ToolStripMenuItem;
        ToolStripMenuItem Save2_ToolStripMenuItem;
        ToolStripMenuItem Save3_ToolStripMenuItem;
        ToolStripMenuItem Save4_ToolStripMenuItem;
        ToolStripMenuItem Save5_ToolStripMenuItem;
        ToolStripMenuItem Load1_ToolStripMenuItem;
        ToolStripMenuItem Load2_ToolStripMenuItem;
        ToolStripMenuItem Load3_ToolStripMenuItem;
        ToolStripMenuItem Load4_ToolStripMenuItem;
        ToolStripMenuItem Load5_ToolStripMenuItem;

        public MainContextMenu(IContainer container)
            : base(container)
        {
            this.context = ApplicationContext.Instance;

            this.FixPosition_ToolStripMenuItem = new ToolStripMenuItem();
            this.FixZoom_ToolStripMenuItem = new ToolStripMenuItem();
            this.FixOpscity_ToolStripMenuItem = new ToolStripMenuItem();
            this.Transparent_ToolStripMenuItem = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.SavePosition_ToolStripMenuItem = new ToolStripMenuItem();
            this.LoadPosition_ToolStripMenuItem = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.Close_ToolStripMenuItem = new ToolStripMenuItem();
            this.Save1_ToolStripMenuItem = new ToolStripMenuItem();
            this.Save2_ToolStripMenuItem = new ToolStripMenuItem();
            this.Save3_ToolStripMenuItem = new ToolStripMenuItem();
            this.Save4_ToolStripMenuItem = new ToolStripMenuItem();
            this.Save5_ToolStripMenuItem = new ToolStripMenuItem();
            this.Load1_ToolStripMenuItem = new ToolStripMenuItem();
            this.Load2_ToolStripMenuItem = new ToolStripMenuItem();
            this.Load3_ToolStripMenuItem = new ToolStripMenuItem();
            this.Load4_ToolStripMenuItem = new ToolStripMenuItem();
            this.Load5_ToolStripMenuItem = new ToolStripMenuItem();
            this.FixPosition_ToolStripMenuItem = new ToolStripMenuItem();
            this.FixPosition_ToolStripMenuItem = new ToolStripMenuItem();

            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.NumericUpDown_ToolStripMenuItem,
                this.FixPosition_ToolStripMenuItem,
                this.FixZoom_ToolStripMenuItem,
                this.FixOpscity_ToolStripMenuItem,
                this.Transparent_ToolStripMenuItem,
                this.toolStripSeparator2,
                this.SavePosition_ToolStripMenuItem,
                this.LoadPosition_ToolStripMenuItem,
                this.toolStripSeparator1,
                this.Close_ToolStripMenuItem
            });
            this.Name = "contextMenuStrip1";
            this.Size = new System.Drawing.Size(179, 192);

            // 
            // FixPosition_ToolStripMenuItem
            // 
            this.FixPosition_ToolStripMenuItem.CheckOnClick = true;
            this.FixPosition_ToolStripMenuItem.Name = "FixPosition_ToolStripMenuItem";
            this.FixPosition_ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.FixPosition_ToolStripMenuItem.Text = "位置を固定(&S)";
            this.FixPosition_ToolStripMenuItem.Click += new System.EventHandler(this.FixPosition_ToolStripMenuItem_Click);
            // 
            // FixZoom_ToolStripMenuItem
            // 
            this.FixZoom_ToolStripMenuItem.CheckOnClick = true;
            this.FixZoom_ToolStripMenuItem.Name = "FixZoom_ToolStripMenuItem";
            this.FixZoom_ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.FixZoom_ToolStripMenuItem.Text = "サイズを固定(&Z)";
            this.FixZoom_ToolStripMenuItem.Click += new System.EventHandler(this.FixZoom_ToolStripMenuItem_Click);
            // 
            // FixOpscity_ToolStripMenuItem
            // 
            this.FixOpscity_ToolStripMenuItem.CheckOnClick = true;
            this.FixOpscity_ToolStripMenuItem.Name = "FixOpscity_ToolStripMenuItem";
            this.FixOpscity_ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.FixOpscity_ToolStripMenuItem.Text = "不透明度を固定(&X)";
            this.FixOpscity_ToolStripMenuItem.Click += new System.EventHandler(this.FixOpscity_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
            // 
            // SavePosition_ToolStripMenuItem
            // 
            this.SavePosition_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save1_ToolStripMenuItem,
            this.Save2_ToolStripMenuItem,
            this.Save3_ToolStripMenuItem,
            this.Save4_ToolStripMenuItem,
            this.Save5_ToolStripMenuItem});
            this.SavePosition_ToolStripMenuItem.Name = "SavePosition_ToolStripMenuItem";
            this.SavePosition_ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.SavePosition_ToolStripMenuItem.Text = "位置/サイズを記録";
            // 
            // Save1_ToolStripMenuItem
            // 
            this.Save1_ToolStripMenuItem.Name = "Save1_ToolStripMenuItem";
            this.Save1_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Save1_ToolStripMenuItem.Text = "記録１(&1)";
            this.Save1_ToolStripMenuItem.Click += new System.EventHandler(this.Save1_ToolStripMenuItem_Click);
            // 
            // Save2_ToolStripMenuItem
            // 
            this.Save2_ToolStripMenuItem.Name = "Save2_ToolStripMenuItem";
            this.Save2_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Save2_ToolStripMenuItem.Text = "記録２(&2)";
            this.Save2_ToolStripMenuItem.Click += new System.EventHandler(this.Save2_ToolStripMenuItem_Click);
            // 
            // Save3_ToolStripMenuItem
            // 
            this.Save3_ToolStripMenuItem.Name = "Save3_ToolStripMenuItem";
            this.Save3_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Save3_ToolStripMenuItem.Text = "記録３(&3)";
            this.Save3_ToolStripMenuItem.Click += new System.EventHandler(this.Save3_ToolStripMenuItem_Click);
            // 
            // Save4_ToolStripMenuItem
            // 
            this.Save4_ToolStripMenuItem.Name = "Save4_ToolStripMenuItem";
            this.Save4_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Save4_ToolStripMenuItem.Text = "記録４(&4)";
            this.Save4_ToolStripMenuItem.Click += new System.EventHandler(this.Save4_ToolStripMenuItem_Click);
            // 
            // Save5_ToolStripMenuItem
            // 
            this.Save5_ToolStripMenuItem.Name = "Save5_ToolStripMenuItem";
            this.Save5_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Save5_ToolStripMenuItem.Text = "記録５(&5)";
            this.Save5_ToolStripMenuItem.Click += new System.EventHandler(this.Save5_ToolStripMenuItem_Click);
            // 
            // LoadPosition_ToolStripMenuItem
            // 
            this.LoadPosition_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Load1_ToolStripMenuItem,
            this.Load2_ToolStripMenuItem,
            this.Load3_ToolStripMenuItem,
            this.Load4_ToolStripMenuItem,
            this.Load5_ToolStripMenuItem});
            this.LoadPosition_ToolStripMenuItem.Name = "LoadPosition_ToolStripMenuItem";
            this.LoadPosition_ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.LoadPosition_ToolStripMenuItem.Text = "位置/サイズを呼出";
            // 
            // Load1_ToolStripMenuItem
            // 
            this.Load1_ToolStripMenuItem.Name = "Load1_ToolStripMenuItem";
            this.Load1_ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.Load1_ToolStripMenuItem.Text = "記録１(&1)";
            this.Load1_ToolStripMenuItem.Click += new System.EventHandler(this.Load1_ToolStripMenuItem_Click);
            // 
            // Load2_ToolStripMenuItem
            // 
            this.Load2_ToolStripMenuItem.Name = "Load2_ToolStripMenuItem";
            this.Load2_ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.Load2_ToolStripMenuItem.Text = "記録２(&2)";
            this.Load2_ToolStripMenuItem.Click += new System.EventHandler(this.Load2_ToolStripMenuItem_Click);
            // 
            // Load3_ToolStripMenuItem
            // 
            this.Load3_ToolStripMenuItem.Name = "Load3_ToolStripMenuItem";
            this.Load3_ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.Load3_ToolStripMenuItem.Text = "記録３(&3)";
            this.Load3_ToolStripMenuItem.Click += new System.EventHandler(this.Load3_ToolStripMenuItem_Click);
            // 
            // Load4_ToolStripMenuItem
            // 
            this.Load4_ToolStripMenuItem.Name = "Load4_ToolStripMenuItem";
            this.Load4_ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.Load4_ToolStripMenuItem.Text = "記録４(&4)";
            this.Load4_ToolStripMenuItem.Click += new System.EventHandler(this.Load4_ToolStripMenuItem_Click);
            // 
            // Load5_ToolStripMenuItem
            // 
            this.Load5_ToolStripMenuItem.Name = "Load5_ToolStripMenuItem";
            this.Load5_ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.Load5_ToolStripMenuItem.Text = "記録５(&5)";
            this.Load5_ToolStripMenuItem.Click += new System.EventHandler(this.Load5_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // Close_ToolStripMenuItem
            // 
            this.Close_ToolStripMenuItem.Name = "Close_ToolStripMenuItem";
            this.Close_ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.Close_ToolStripMenuItem.Text = "終了(&X)";
            this.Close_ToolStripMenuItem.Click += new System.EventHandler(this.Close_ToolStripMenuItem_Click);
            // 
            // Transparent_ToolStripMenuItem
            // 
            this.Transparent_ToolStripMenuItem.CheckOnClick = true;
            this.Transparent_ToolStripMenuItem.Name = "Transparent_ToolStripMenuItem";
            this.Transparent_ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.Transparent_ToolStripMenuItem.Text = "クリックを透過";
            // this.Transparent_ToolStripMenuItem.Click += new System.EventHandler(this.Transparent_ToolStripMenuItem_Click);
        }
    }
}
