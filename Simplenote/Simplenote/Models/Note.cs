using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Simplenote.Models
{
    public class Note : Panel
    {
        private string contentText;
        public RadioButton check;
        private Label header;
        private Label content;
        public List<string> tags;
        public List<History> history;
        public bool isDeleted;
        public DateTime datemodified { get; set; }
        public DateTime datecreated { get; set; }
        public string ContentText
        {
            get { return contentText; }
            set
            {
                if (contentText == value)
                    return;
                datecreated = DateTime.Now;
                datemodified = DateTime.Now;
                contentText = value;
                string trim = contentText.Trim();
                if (contentText == "")
                {
                    header.Text = "New Note...";
                    content.Text = "";
                }
                else
                {
                    List<String> tmp = trim.Split('\n').ToList();
                    header.Text = tmp[0];
                    tmp.Remove(tmp[0]);
                    content.Text = string.Join(" ", tmp).Trim();
                }
            }
        }
        public string NoteName
        {
            get { return header.Text; }
            set { }
        }
        public Note()
        {
            //init
            check = new RadioButton();
            header = new Label();
            content = new Label();
            tags = new List<string>();
            history = new List<History>();
            datemodified = DateTime.Now;
            isDeleted = false;
            ContentText = "";
            NoteName = "";
            //check
            check.Width = 40;
            check.Dock = DockStyle.Left;
            check.CheckAlign = ContentAlignment.MiddleCenter;
            check.Click += Check_Click;
            check.AutoCheck = false;
            //header
            header.Dock = DockStyle.Fill;
            header.Text = "New Note...";
            header.Font = new System.Drawing.Font("Consolas", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            header.TextAlign = ContentAlignment.MiddleLeft;
            header.AutoEllipsis = true;
            header.UseCompatibleTextRendering = true;
            header.ForeColor = SystemColors.ControlDarkDark;
            header.Height = 40;
            header.Enabled = false;
            //content
            content.Dock = DockStyle.Fill;
            content.Text = "";
            content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            content.TextAlign = ContentAlignment.TopLeft;
            content.AutoEllipsis = true;
            header.UseCompatibleTextRendering = true;
            content.ForeColor = SystemColors.ControlDarkDark;
            content.TextChanged += Content_TextChanged;
            content.Enabled = false;
            //panel
            this.Cursor = Cursors.Hand;
            this.Width = 400;
            this.Height = 55;
            this.Margin = new Padding(0, 1, 0, 0);
            this.Padding = new Padding(0, 0, 0, 1);
            this.DoubleBuffered = true;
            this.Controls.Add(header);
            this.Controls.Add(check);
        }

        private void Check_Click(object sender, EventArgs e)
        {
            var button = (RadioButton)sender;
            button.Checked = !button.Checked;
        }

        private void Content_TextChanged(object sender, EventArgs e)
        {
            if (content.Text != "" && !this.Controls.Contains(content))
            {
                this.Controls.Clear();
                header.Dock = DockStyle.Top;
                this.Controls.Add(content);
                this.Controls.Add(header);
                this.Controls.Add(check);
                this.Height = 75;
                header.TextAlign = ContentAlignment.BottomLeft;
                return;
            }
            else if (content.Text == "" && this.Controls.Contains(content))
            {
                this.Controls.Clear();
                header.Dock = DockStyle.Fill;
                this.Controls.Add(header);
                this.Controls.Add(check);
                this.Height = 55;
                header.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Pen pen = new Pen(Color.LightGray, 2);
            e.Graphics.DrawLine(pen, 40, this.Height, this.Width, this.Height);
        }
    }
}
