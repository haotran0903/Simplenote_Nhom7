using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplenote.Models
{
    class TextBoxWithWatermark : TextBox
    {
        private Label Watermark;
        public string watermark
        {
            get { return Watermark.Text; }
            set { Watermark.Text = value; }
        }
        public TextBoxWithWatermark()
        {
            Watermark = new Label();
            Watermark.Enabled = false;
            Watermark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Watermark.Location = new System.Drawing.Point(3, 1);
            this.Controls.Add(Watermark);
            this.SizeChanged += TextBoxWithWatermark_SizeChanged;
            this.Margin = new Padding(5, 5, 5, 5);
            this.TextChanged += TextBoxWithWatermark_TextChanged;
        }

        private void TextBoxWithWatermark_TextChanged(object sender, EventArgs e)
        {
            if (this.Text == "")
                Watermark.Visible = true;
            else
                Watermark.Visible = false;
        }

        private void TextBoxWithWatermark_SizeChanged(object sender, EventArgs e)
        {
            Watermark.Width = this.Width - 4;
            Watermark.Height = this.Height - 2;
        }
    }
}
