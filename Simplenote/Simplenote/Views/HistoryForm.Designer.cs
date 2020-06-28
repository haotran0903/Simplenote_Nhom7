namespace Simplenote.Views
{
    partial class HistoryForm
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
            this.btnRestore = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTag = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblContent = new System.Windows.Forms.Label();
            this.historyTb = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyTb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(191)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.btnRestore);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.timeLbl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.historyTb);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 614);
            this.panel1.TabIndex = 0;
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.White;
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.Enabled = false;
            this.btnRestore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(191)))), ((int)(((byte)(248)))));
            this.btnRestore.Location = new System.Drawing.Point(415, 123);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(119, 41);
            this.btnRestore.TabIndex = 9;
            this.btnRestore.Text = "Restore Note";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.lblTag);
            this.panel3.Location = new System.Drawing.Point(494, 199);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 403);
            this.panel3.TabIndex = 8;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblTag.ForeColor = System.Drawing.Color.White;
            this.lblTag.Location = new System.Drawing.Point(10, 14);
            this.lblTag.Margin = new System.Windows.Forms.Padding(0);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(0, 22);
            this.lblTag.TabIndex = 1;
            // 
            // timeLbl
            // 
            this.timeLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.timeLbl.ForeColor = System.Drawing.Color.White;
            this.timeLbl.Location = new System.Drawing.Point(87, 12);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(0);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(545, 45);
            this.timeLbl.TabIndex = 7;
            this.timeLbl.Text = "Lasted";
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(491, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tags";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Content";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.lblContent);
            this.panel2.Location = new System.Drawing.Point(12, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 403);
            this.panel2.TabIndex = 4;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblContent.ForeColor = System.Drawing.Color.White;
            this.lblContent.Location = new System.Drawing.Point(21, 14);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(0, 22);
            this.lblContent.TabIndex = 0;
            // 
            // historyTb
            // 
            this.historyTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(191)))), ((int)(((byte)(248)))));
            this.historyTb.LargeChange = 1;
            this.historyTb.Location = new System.Drawing.Point(11, 61);
            this.historyTb.Maximum = 11;
            this.historyTb.Name = "historyTb";
            this.historyTb.Size = new System.Drawing.Size(701, 56);
            this.historyTb.TabIndex = 1;
            this.historyTb.Scroll += new System.EventHandler(this.historyTb_Scroll);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(170, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 614);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyTb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar historyTb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Button btnRestore;
    }
}