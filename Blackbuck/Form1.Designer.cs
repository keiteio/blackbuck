namespace Blackbuck
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FixPosition_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FixZoom_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FixOpscity_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SavePosition_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save1_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save2_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save3_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save4_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save5_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadPosition_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Load1_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Load2_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Load3_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Load4_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Load5_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Close_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Transparent_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FixPosition_ToolStripMenuItem,
            this.FixZoom_ToolStripMenuItem,
            this.FixOpscity_ToolStripMenuItem,
            this.Transparent_ToolStripMenuItem,
            this.toolStripSeparator2,
            this.SavePosition_ToolStripMenuItem,
            this.LoadPosition_ToolStripMenuItem,
            this.toolStripSeparator1,
            this.Close_ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 192);
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
            this.Transparent_ToolStripMenuItem.Click += new System.EventHandler(this.Transparent_ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(594, 456);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Close_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FixPosition_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SavePosition_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save1_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save2_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save3_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save4_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save5_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadPosition_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Load1_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Load2_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Load3_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Load4_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Load5_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem FixZoom_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FixOpscity_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Transparent_ToolStripMenuItem;
    }
}

