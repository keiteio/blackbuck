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

        private ApplicationContext context;

        public bool Stay { get; set; }
        public bool FixZoom { get; set; }
        public bool FixOpacity { get; set; }
        public bool TransparentClick { get; private set; }

        public TransparentForm(bool transparent)
        {
            InitializeComponent();

            context = ApplicationContext.Instance;
            this.ContextMenuStrip = this.context.MainContextMenu; ;

            this.TransparentClick = transparent;

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
                if (!this.Stay && !IsModifierKeyPressed(Keys.Shift) && !IsModifierKeyPressed(Keys.Control))
                {
                    this.Left += e.X - mousePoint.X;
                    this.Top += e.Y - mousePoint.Y;
                }
                else if (!this.FixZoom && IsModifierKeyPressed(Keys.Control))
                {
                    this.Zoom = Math.Max(0.1f, this.Zoom + (value / 5000.0f));

                }
                else if (!this.FixOpacity && IsModifierKeyPressed(Keys.Shift))
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
                if (this.TransparentClick)
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

        public float Zoom
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

    }

}
