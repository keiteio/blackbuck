using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Blackbuck
{
    public partial class TransparentForm : Form
    {
        string[] FileExtentions = new string[] { ".jpg", ".jpeg", ".png" };

        private System.Drawing.Point mousePoint;
        private int oldMouseX;
        private int oldMouseY;

        private float zoom = 1.0f;

        bool stay = false;
        bool fixZoom = false;
        bool fixOpacity = false;
        bool transparent = false;

        public TransparentForm()
        {
            InitializeComponent();

            this.Zoom = 1.0f;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        void Form1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// マウスが押された時に呼び出されるイベント
        /// </summary>
        void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                mousePoint = new System.Drawing.Point(e.X, e.Y);
            }
        }

        /// <summary>
        /// マウスが動かされた時に呼び出されるイベント
        /// </summary>
        void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int deltaX = e.X - oldMouseX;
            int deltaY = e.Y - oldMouseY;

            float value = 0;
            if (deltaX > deltaY)
            {
                value = deltaX;
            }
            else
            {
                value = deltaY;
            }

            if (e.Button == MouseButtons.Left)
            {
                if (!this.stay && !IsModifierKeyPressed(Keys.Shift) && !IsModifierKeyPressed(Keys.Control))
                {
                    this.Left += e.X - mousePoint.X;
                    this.Top += e.Y - mousePoint.Y;
                }
                else if (!this.fixZoom && IsModifierKeyPressed(Keys.Control))
                {
                    this.Zoom = Math.Max(0.1f, this.Zoom + (value / 5000.0f));

                }
                else if (!this.fixOpacity && IsModifierKeyPressed(Keys.Shift))
                {
                    this.Opacity = Math.Max(0.1, this.Opacity + (value / 1000.0));
                }
            }

            oldMouseX = e.X;
            oldMouseY = e.Y;

            this.Invalidate();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                if (this.transparent)
                {
                    createParams.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                }
                return createParams;
            }
        }

        bool IsModifierKeyPressed(Keys key)
        {
            return (Control.ModifierKeys & key) == key;
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            string[] fileNameArray = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (!e.Data.GetDataPresent(System.Windows.Forms.DataFormats.FileDrop))
            {
                /* ファイル以外のドラッグは受け入れない */
                e.Effect = DragDropEffects.None;
                return;
            }

            if (fileNameArray.Length > 1)
            {
                /* 複数ファイルのドラッグは受け入れない */
                e.Effect = DragDropEffects.None;
                return;
            }

            if (!IsShowableFile(fileNameArray[0]))
            {
                /* 拡張子が.txt以外は受け入れない */
                e.Effect = DragDropEffects.None;
                return;
            }

            /* 上記以外は受け入れる */
            e.Effect = DragDropEffects.All;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileNameArray = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string fileName = fileNameArray[0];

            this.UseWaitCursor = true;
            Image img = Image.FromFile(fileName);
            this.UseWaitCursor = false;

            this.BackgroundImage = img;

            this.Zoom = 1.0f;
        }

        bool IsShowableFile(string filepath)
        {
            foreach(string ext in FileExtentions){
                if (Path.GetExtension(filepath).ToLower() == ext)
                {
                    return true;
                }
            }
            return false;
        }

        private void Close_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private float Zoom
        {
            get
            {
                return zoom;
            }

            set
            {
                if (this.BackgroundImage != null)
                {
                    int w = (int)(this.BackgroundImage.Width * value);
                    int h = (int)(this.BackgroundImage.Height * value);
                    Size newSize = new Size(w, h);
                    this.ClientSize = newSize;
                }
                zoom = value;
            }
        }

        private void FixPosition_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.stay = (false == this.stay);
        }

        private void FixZoom_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fixZoom = (false == this.fixZoom);
        }

        private void FixOpscity_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fixOpacity = (false == this.fixOpacity);
        }

        private void SavePosition(int num)
        {
            switch (num)
            {
                case 1:
                    {
                        Properties.Settings.Default.Save1Position = this.Location;
                        Properties.Settings.Default.Save1Zoom = this.Zoom;
                        break;
                    }
                case 2:
                    {
                        Properties.Settings.Default.Save2Position = this.Location;
                        Properties.Settings.Default.Save2Zoom = this.Zoom;
                        break;
                    }
                case 3:
                    {
                        Properties.Settings.Default.Save3Position = this.Location;
                        Properties.Settings.Default.Save3Zoom = this.Zoom;
                        break;
                    }
                case 4:
                    {
                        Properties.Settings.Default.Save4Position = this.Location;
                        Properties.Settings.Default.Save4Zoom = this.Zoom;
                        break;
                    }
                case 5:
                    {
                        Properties.Settings.Default.Save5Position = this.Location;
                        Properties.Settings.Default.Save5Zoom = this.Zoom;
                        break;
                    }

            }
            Properties.Settings.Default.Save();
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
                        this.Location = Properties.Settings.Default.Save1Position;
                        this.Zoom = Properties.Settings.Default.Save1Zoom;
                        break;
                    }
                case 2:
                    {
                        this.Location = Properties.Settings.Default.Save2Position;
                        this.Zoom = Properties.Settings.Default.Save2Zoom;
                        break;
                    }
                case 3:
                    {
                        this.Location = Properties.Settings.Default.Save3Position;
                        this.Zoom = Properties.Settings.Default.Save3Zoom;
                        break;
                    }
                case 4:
                    {
                        this.Location = Properties.Settings.Default.Save4Position;
                        this.Zoom = Properties.Settings.Default.Save4Zoom;
                        break;
                    }
                case 5:
                    {
                        this.Location = Properties.Settings.Default.Save5Position;
                        this.Zoom = Properties.Settings.Default.Save5Zoom;
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

        private void Transparent_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.transparent = (false == this.transparent);
        }

    }

}
