namespace Simplenote.Views
{
    partial class Help
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 597);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.picHelp);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(1113, 595);
            this.panel3.TabIndex = 1;
            // 
            // picHelp
            // 
            this.picHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHelp.Dock = System.Windows.Forms.DockStyle.Right;
            this.picHelp.Image = global::Simplenote.Properties.Resources._1_fixed;
            this.picHelp.Location = new System.Drawing.Point(212, 10);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(891, 575);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHelp.TabIndex = 1;
            this.picHelp.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.lbl1);
            this.flowLayoutPanel1.Controls.Add(this.lbl2);
            this.flowLayoutPanel1.Controls.Add(this.lbl3);
            this.flowLayoutPanel1.Controls.Add(this.lbl4);
            this.flowLayoutPanel1.Controls.Add(this.lbl5);
            this.flowLayoutPanel1.Controls.Add(this.lbl6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(199, 575);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(0, 0);
            this.lbl1.Margin = new System.Windows.Forms.Padding(0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(198, 35);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Giao diện chính";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            this.lbl1.MouseEnter += new System.EventHandler(this.lblColor_MouseEnter);
            this.lbl1.MouseLeave += new System.EventHandler(this.lblColor_MouseLeave);
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(0, 35);
            this.lbl2.Margin = new System.Windows.Forms.Padding(0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(198, 35);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Thanh menu";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            this.lbl2.MouseEnter += new System.EventHandler(this.lblColor_MouseEnter);
            this.lbl2.MouseLeave += new System.EventHandler(this.lblColor_MouseLeave);
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(0, 70);
            this.lbl3.Margin = new System.Windows.Forms.Padding(0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(198, 35);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Thùng rác";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            this.lbl3.MouseEnter += new System.EventHandler(this.lblColor_MouseEnter);
            this.lbl3.MouseLeave += new System.EventHandler(this.lblColor_MouseLeave);
            // 
            // lbl4
            // 
            this.lbl4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(0, 105);
            this.lbl4.Margin = new System.Windows.Forms.Padding(0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(198, 35);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Lịch sử";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl4.Click += new System.EventHandler(this.lbl4_Click);
            this.lbl4.MouseEnter += new System.EventHandler(this.lblColor_MouseEnter);
            this.lbl4.MouseLeave += new System.EventHandler(this.lblColor_MouseLeave);
            // 
            // lbl5
            // 
            this.lbl5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(0, 140);
            this.lbl5.Margin = new System.Windows.Forms.Padding(0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(198, 35);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "Khung info";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl5.Click += new System.EventHandler(this.lbl5_Click);
            this.lbl5.MouseEnter += new System.EventHandler(this.lblColor_MouseEnter);
            this.lbl5.MouseLeave += new System.EventHandler(this.lblColor_MouseLeave);
            // 
            // lbl6
            // 
            this.lbl6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(0, 175);
            this.lbl6.Margin = new System.Windows.Forms.Padding(0);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(198, 35);
            this.lbl6.TabIndex = 5;
            this.lbl6.Text = "Thanh công cụ";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl6.Click += new System.EventHandler(this.lbl6_Click);
            this.lbl6.MouseEnter += new System.EventHandler(this.lblColor_MouseEnter);
            this.lbl6.MouseLeave += new System.EventHandler(this.lblColor_MouseLeave);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1115, 597);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Help";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Help";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picHelp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
    }
}