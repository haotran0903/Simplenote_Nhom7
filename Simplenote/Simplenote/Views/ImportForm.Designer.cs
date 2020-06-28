namespace Simplenote.Views
{
    partial class ImportForm
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
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBtn = new System.Windows.Forms.Button();
            this.xmlBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCloseForm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 65);
            this.panel1.TabIndex = 0;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCloseForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(194)))), ((int)(((byte)(247)))));
            this.btnCloseForm.Location = new System.Drawing.Point(321, 11);
            this.btnCloseForm.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(89, 41);
            this.btnCloseForm.TabIndex = 1;
            this.btnCloseForm.Text = "Cancel";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(147, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Import Notes";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblMessage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 213);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtBtn);
            this.panel3.Controls.Add(this.xmlBtn);
            this.panel3.Location = new System.Drawing.Point(34, 68);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 100);
            this.panel3.TabIndex = 1;
            // 
            // txtBtn
            // 
            this.txtBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtBtn.Location = new System.Drawing.Point(0, 50);
            this.txtBtn.Margin = new System.Windows.Forms.Padding(0);
            this.txtBtn.Name = "txtBtn";
            this.txtBtn.Size = new System.Drawing.Size(360, 50);
            this.txtBtn.TabIndex = 1;
            this.txtBtn.Text = "Plain text files";
            this.txtBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtBtn.UseVisualStyleBackColor = true;
            this.txtBtn.Click += new System.EventHandler(this.txtBtn_Click);
            // 
            // xmlBtn
            // 
            this.xmlBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xmlBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.xmlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xmlBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xmlBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.xmlBtn.Location = new System.Drawing.Point(0, 0);
            this.xmlBtn.Margin = new System.Windows.Forms.Padding(0);
            this.xmlBtn.Name = "xmlBtn";
            this.xmlBtn.Size = new System.Drawing.Size(360, 50);
            this.xmlBtn.TabIndex = 0;
            this.xmlBtn.Text = "XML file";
            this.xmlBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xmlBtn.UseVisualStyleBackColor = true;
            this.xmlBtn.Click += new System.EventHandler(this.xmlBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(30, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "IMPORT FORM";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblMessage.Location = new System.Drawing.Point(30, 79);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(360, 25);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Tệp trống hoặc bị hỏng.";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 278);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button txtBtn;
        private System.Windows.Forms.Button xmlBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMessage;
    }
}