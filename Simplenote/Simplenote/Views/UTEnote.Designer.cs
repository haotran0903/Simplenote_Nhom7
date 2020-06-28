using Simplenote.Models;

namespace Simplenote.Views
{
    partial class UTEnote
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UTEnote));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowTagOnMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTrashOnMenu = new System.Windows.Forms.Button();
            this.btnAllNotes = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.lblModified = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseInfo = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlSubmenu2 = new System.Windows.Forms.Panel();
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.btnRestoreAll = new System.Windows.Forms.Button();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.btnDeleteForever = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.flowNoteList = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNoNote = new System.Windows.Forms.Label();
            this.pnlSubmenu1 = new System.Windows.Forms.Panel();
            this.lblNewNoteBtn = new System.Windows.Forms.Label();
            this.lblMenuBtn = new System.Windows.Forms.Label();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.timerInfo = new System.Windows.Forms.Timer(this.components);
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.searchNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.focusModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.toggleFullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblToggleBtn = new System.Windows.Forms.Label();
            this.lblHistoryBtn = new System.Windows.Forms.Label();
            this.lblSaveBtn = new System.Windows.Forms.Label();
            this.lblTrashBtn = new System.Windows.Forms.Label();
            this.lblInfoBtn = new System.Windows.Forms.Label();
            this.pnlText = new System.Windows.Forms.Panel();
            this.txtMain = new System.Windows.Forms.RichTextBox();
            this.flowTag = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTrash = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnSidebar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pinCheckbox = new System.Windows.Forms.CheckBox();
            this.txtTag = new Simplenote.Models.TextBoxWithWatermark();
            this.txtSearch = new Simplenote.Models.TextBoxWithWatermark();
            this.txtTagSearch = new Simplenote.Models.TextBoxWithWatermark();
            this.pnlMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlSubmenu2.SuspendLayout();
            this.pnlDelete.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.flowNoteList.SuspendLayout();
            this.pnlSubmenu1.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.pnlText.SuspendLayout();
            this.flowTag.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.panel3);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 30);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(0, 848);
            this.pnlMenu.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.flowTagOnMenu);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 661);
            this.panel3.TabIndex = 2;
            // 
            // flowTagOnMenu
            // 
            this.flowTagOnMenu.AutoScroll = true;
            this.flowTagOnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowTagOnMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowTagOnMenu.Location = new System.Drawing.Point(0, 60);
            this.flowTagOnMenu.Name = "flowTagOnMenu";
            this.flowTagOnMenu.Size = new System.Drawing.Size(0, 601);
            this.flowTagOnMenu.TabIndex = 1;
            this.flowTagOnMenu.WrapContents = false;
            this.flowTagOnMenu.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flowTagList_ControlAdded);
            this.flowTagOnMenu.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flowTagList_ControlRemoved);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(1);
            this.panel7.Size = new System.Drawing.Size(0, 60);
            this.panel7.TabIndex = 0;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(1, 1);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(0, 58);
            this.label4.TabIndex = 0;
            this.label4.Text = "TAGS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtTagSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 821);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 27);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnTrashOnMenu);
            this.panel1.Controls.Add(this.btnAllNotes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 160);
            this.panel1.TabIndex = 0;
            // 
            // btnTrashOnMenu
            // 
            this.btnTrashOnMenu.BackColor = System.Drawing.Color.White;
            this.btnTrashOnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrashOnMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTrashOnMenu.FlatAppearance.BorderSize = 0;
            this.btnTrashOnMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnTrashOnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTrashOnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTrashOnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrashOnMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnTrashOnMenu.Location = new System.Drawing.Point(15, 93);
            this.btnTrashOnMenu.Name = "btnTrashOnMenu";
            this.btnTrashOnMenu.Size = new System.Drawing.Size(240, 45);
            this.btnTrashOnMenu.TabIndex = 1;
            this.btnTrashOnMenu.Text = "Trash";
            this.btnTrashOnMenu.UseVisualStyleBackColor = false;
            this.btnTrashOnMenu.Click += new System.EventHandler(this.btnTrashTag_Click);
            // 
            // btnAllNotes
            // 
            this.btnAllNotes.BackColor = System.Drawing.Color.White;
            this.btnAllNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllNotes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAllNotes.FlatAppearance.BorderSize = 0;
            this.btnAllNotes.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAllNotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAllNotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAllNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllNotes.Location = new System.Drawing.Point(15, 20);
            this.btnAllNotes.Name = "btnAllNotes";
            this.btnAllNotes.Size = new System.Drawing.Size(240, 45);
            this.btnAllNotes.TabIndex = 0;
            this.btnAllNotes.Text = "All Notes";
            this.btnAllNotes.UseVisualStyleBackColor = false;
            this.btnAllNotes.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.Controls.Add(this.panel6);
            this.pnlInfo.Controls.Add(this.panel5);
            this.pnlInfo.Controls.Add(this.panel4);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfo.Location = new System.Drawing.Point(1280, 30);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Padding = new System.Windows.Forms.Padding(1);
            this.pnlInfo.Size = new System.Drawing.Size(0, 848);
            this.pnlInfo.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(1, 384);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 463);
            this.panel6.TabIndex = 2;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pinCheckbox);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(1, 299);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 85);
            this.panel5.TabIndex = 1;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(15, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pin to top";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblCharCount);
            this.panel4.Controls.Add(this.lblWordCount);
            this.panel4.Controls.Add(this.lblModified);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnCloseInfo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 298);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lblCharCount
            // 
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCharCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCharCount.Location = new System.Drawing.Point(15, 245);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(102, 23);
            this.lblCharCount.TabIndex = 5;
            this.lblCharCount.Text = "0 characters";
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWordCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWordCount.Location = new System.Drawing.Point(15, 180);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(69, 23);
            this.lblWordCount.TabIndex = 4;
            this.lblWordCount.Text = "0 words";
            // 
            // lblModified
            // 
            this.lblModified.AutoSize = true;
            this.lblModified.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblModified.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblModified.Location = new System.Drawing.Point(15, 98);
            this.lblModified.Name = "lblModified";
            this.lblModified.Size = new System.Drawing.Size(166, 23);
            this.lblModified.TabIndex = 3;
            this.lblModified.Text = "Apr 25, 2020 1:56PM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modified";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "INFO";
            // 
            // btnCloseInfo
            // 
            this.btnCloseInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseInfo.FlatAppearance.BorderSize = 0;
            this.btnCloseInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseInfo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(194)))), ((int)(((byte)(247)))));
            this.btnCloseInfo.Location = new System.Drawing.Point(286, 18);
            this.btnCloseInfo.Name = "btnCloseInfo";
            this.btnCloseInfo.Size = new System.Drawing.Size(32, 32);
            this.btnCloseInfo.TabIndex = 0;
            this.btnCloseInfo.Text = "X";
            this.btnCloseInfo.UseVisualStyleBackColor = true;
            this.btnCloseInfo.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pnlRight);
            this.pnlMain.Controls.Add(this.pnlLeft);
            this.pnlMain.Controls.Add(this.lblNewNoteBtn);
            this.pnlMain.Controls.Add(this.lblMenuBtn);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 30);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1280, 848);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlText);
            this.pnlRight.Controls.Add(this.pnlSubmenu2);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(400, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(880, 848);
            this.pnlRight.TabIndex = 3;
            // 
            // pnlSubmenu2
            // 
            this.pnlSubmenu2.Controls.Add(this.btnTrash);
            this.pnlSubmenu2.Controls.Add(this.btnHistory);
            this.pnlSubmenu2.Controls.Add(this.pnlDelete);
            this.pnlSubmenu2.Controls.Add(this.btnSave);
            this.pnlSubmenu2.Controls.Add(this.btnInfo);
            this.pnlSubmenu2.Controls.Add(this.btnSidebar);
            this.pnlSubmenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenu2.Location = new System.Drawing.Point(0, 0);
            this.pnlSubmenu2.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSubmenu2.Name = "pnlSubmenu2";
            this.pnlSubmenu2.Size = new System.Drawing.Size(880, 68);
            this.pnlSubmenu2.TabIndex = 0;
            this.pnlSubmenu2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSubmenu2_Paint);
            // 
            // pnlDelete
            // 
            this.pnlDelete.Controls.Add(this.btnRestoreAll);
            this.pnlDelete.Controls.Add(this.btnEmpty);
            this.pnlDelete.Controls.Add(this.btnDeleteForever);
            this.pnlDelete.Controls.Add(this.btnRestore);
            this.pnlDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDelete.Location = new System.Drawing.Point(0, 0);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(880, 68);
            this.pnlDelete.TabIndex = 8;
            this.pnlDelete.Visible = false;
            this.pnlDelete.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDelete_Paint);
            // 
            // btnRestoreAll
            // 
            this.btnRestoreAll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRestoreAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnRestoreAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestoreAll.FlatAppearance.BorderSize = 0;
            this.btnRestoreAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnRestoreAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnRestoreAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnRestoreAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreAll.ForeColor = System.Drawing.Color.White;
            this.btnRestoreAll.Location = new System.Drawing.Point(554, 17);
            this.btnRestoreAll.Name = "btnRestoreAll";
            this.btnRestoreAll.Size = new System.Drawing.Size(150, 32);
            this.btnRestoreAll.TabIndex = 3;
            this.btnRestoreAll.Text = "Restore All Note";
            this.btnRestoreAll.UseVisualStyleBackColor = false;
            this.btnRestoreAll.Click += new System.EventHandler(this.btnRestoreAll_Click);
            // 
            // btnEmpty
            // 
            this.btnEmpty.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEmpty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(84)))));
            this.btnEmpty.FlatAppearance.BorderSize = 3;
            this.btnEmpty.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEmpty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEmpty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(140)))));
            this.btnEmpty.Location = new System.Drawing.Point(220, 17);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(150, 32);
            this.btnEmpty.TabIndex = 2;
            this.btnEmpty.Text = "Empty Trash";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // btnDeleteForever
            // 
            this.btnDeleteForever.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeleteForever.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteForever.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(84)))));
            this.btnDeleteForever.FlatAppearance.BorderSize = 3;
            this.btnDeleteForever.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDeleteForever.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDeleteForever.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDeleteForever.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteForever.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteForever.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(140)))));
            this.btnDeleteForever.Location = new System.Drawing.Point(387, 17);
            this.btnDeleteForever.Name = "btnDeleteForever";
            this.btnDeleteForever.Size = new System.Drawing.Size(150, 32);
            this.btnDeleteForever.TabIndex = 1;
            this.btnDeleteForever.Text = "Delete Forever";
            this.btnDeleteForever.UseVisualStyleBackColor = true;
            this.btnDeleteForever.Click += new System.EventHandler(this.btnDeleteForever_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnRestore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(113)))), ((int)(((byte)(177)))));
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Location = new System.Drawing.Point(718, 17);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(150, 32);
            this.btnRestore.TabIndex = 0;
            this.btnRestore.Text = "Restore Note";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.flowNoteList);
            this.pnlLeft.Controls.Add(this.pnlSubmenu1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(400, 848);
            this.pnlLeft.TabIndex = 2;
            // 
            // flowNoteList
            // 
            this.flowNoteList.AutoScroll = true;
            this.flowNoteList.Controls.Add(this.lblNoNote);
            this.flowNoteList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowNoteList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowNoteList.Location = new System.Drawing.Point(0, 68);
            this.flowNoteList.Margin = new System.Windows.Forms.Padding(0);
            this.flowNoteList.Name = "flowNoteList";
            this.flowNoteList.Padding = new System.Windows.Forms.Padding(1);
            this.flowNoteList.Size = new System.Drawing.Size(400, 780);
            this.flowNoteList.TabIndex = 1;
            this.flowNoteList.WrapContents = false;
            this.flowNoteList.SizeChanged += new System.EventHandler(this.flowNoteList_SizeChanged);
            this.flowNoteList.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flowNoteList_ControlAdded);
            this.flowNoteList.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flowNoteList_ControlRemoved);
            this.flowNoteList.Paint += new System.Windows.Forms.PaintEventHandler(this.flowNoteList_Paint);
            // 
            // lblNoNote
            // 
            this.lblNoNote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNoNote.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(194)))), ((int)(((byte)(247)))));
            this.lblNoNote.Location = new System.Drawing.Point(2, 2);
            this.lblNoNote.Margin = new System.Windows.Forms.Padding(1);
            this.lblNoNote.Name = "lblNoNote";
            this.lblNoNote.Size = new System.Drawing.Size(398, 778);
            this.lblNoNote.TabIndex = 0;
            this.lblNoNote.Text = "No Notes";
            this.lblNoNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSubmenu1
            // 
            this.pnlSubmenu1.Controls.Add(this.txtSearch);
            this.pnlSubmenu1.Controls.Add(this.btnAdd);
            this.pnlSubmenu1.Controls.Add(this.btnMenu);
            this.pnlSubmenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenu1.Location = new System.Drawing.Point(0, 0);
            this.pnlSubmenu1.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSubmenu1.Name = "pnlSubmenu1";
            this.pnlSubmenu1.Size = new System.Drawing.Size(400, 68);
            this.pnlSubmenu1.TabIndex = 0;
            this.pnlSubmenu1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSubmenu1_Paint);
            // 
            // lblNewNoteBtn
            // 
            this.lblNewNoteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.lblNewNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNewNoteBtn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewNoteBtn.ForeColor = System.Drawing.Color.White;
            this.lblNewNoteBtn.Location = new System.Drawing.Point(330, 60);
            this.lblNewNoteBtn.Name = "lblNewNoteBtn";
            this.lblNewNoteBtn.Size = new System.Drawing.Size(78, 23);
            this.lblNewNoteBtn.TabIndex = 3;
            this.lblNewNoteBtn.Text = "New Note";
            this.lblNewNoteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMenuBtn
            // 
            this.lblMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.lblMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMenuBtn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuBtn.ForeColor = System.Drawing.Color.White;
            this.lblMenuBtn.Location = new System.Drawing.Point(0, 60);
            this.lblMenuBtn.Name = "lblMenuBtn";
            this.lblMenuBtn.Size = new System.Drawing.Size(65, 23);
            this.lblMenuBtn.TabIndex = 8;
            this.lblMenuBtn.Text = "Menu";
            this.lblMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 1;
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // timerInfo
            // 
            this.timerInfo.Interval = 1;
            this.timerInfo.Tick += new System.EventHandler(this.timerInfo_Tick);
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.White;
            this.menuMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuMain.Size = new System.Drawing.Size(1280, 30);
            this.menuMain.TabIndex = 3;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNoteToolStripMenuItem,
            this.toolStripSeparator1,
            this.importNotesToolStripMenuItem,
            this.exportNotesToolStripMenuItem,
            this.toolStripMenuItem4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newNoteToolStripMenuItem
            // 
            this.newNoteToolStripMenuItem.Name = "newNoteToolStripMenuItem";
            this.newNoteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newNoteToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.newNoteToolStripMenuItem.Text = "New Note";
            this.newNoteToolStripMenuItem.Click += new System.EventHandler(this.newNoteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(274, 6);
            // 
            // importNotesToolStripMenuItem
            // 
            this.importNotesToolStripMenuItem.Name = "importNotesToolStripMenuItem";
            this.importNotesToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.importNotesToolStripMenuItem.Text = "Import Notes...";
            this.importNotesToolStripMenuItem.Click += new System.EventHandler(this.importNotesToolStripMenuItem_Click);
            // 
            // exportNotesToolStripMenuItem
            // 
            this.exportNotesToolStripMenuItem.Name = "exportNotesToolStripMenuItem";
            this.exportNotesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.exportNotesToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.exportNotesToolStripMenuItem.Text = "Export Notes...";
            this.exportNotesToolStripMenuItem.Click += new System.EventHandler(this.exportNotesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(274, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem7,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem8,
            this.searchNotesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(234, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(234, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(234, 6);
            // 
            // searchNotesToolStripMenuItem
            // 
            this.searchNotesToolStripMenuItem.Name = "searchNotesToolStripMenuItem";
            this.searchNotesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.searchNotesToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.searchNotesToolStripMenuItem.Text = "Search Notes...";
            this.searchNotesToolStripMenuItem.Click += new System.EventHandler(this.searchNotesToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortTypeToolStripMenuItem,
            this.tagsToolStripMenuItem,
            this.toolStripMenuItem9,
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.actualSizeToolStripMenuItem,
            this.toolStripMenuItem10,
            this.focusModeToolStripMenuItem,
            this.toolStripMenuItem11,
            this.toggleFullscreenToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // sortTypeToolStripMenuItem
            // 
            this.sortTypeToolStripMenuItem.Name = "sortTypeToolStripMenuItem";
            this.sortTypeToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.sortTypeToolStripMenuItem.Text = "Sort Type";
            // 
            // tagsToolStripMenuItem
            // 
            this.tagsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem});
            this.tagsToolStripMenuItem.Name = "tagsToolStripMenuItem";
            this.tagsToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.tagsToolStripMenuItem.Text = "Tags";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.CheckOnClick = true;
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.sortToolStripMenuItem.Text = "Sort Alphabetically";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(258, 6);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D9)));
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D8)));
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // actualSizeToolStripMenuItem
            // 
            this.actualSizeToolStripMenuItem.Name = "actualSizeToolStripMenuItem";
            this.actualSizeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.actualSizeToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.actualSizeToolStripMenuItem.Text = "Actual Size";
            this.actualSizeToolStripMenuItem.Click += new System.EventHandler(this.actualSizeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(258, 6);
            // 
            // focusModeToolStripMenuItem
            // 
            this.focusModeToolStripMenuItem.CheckOnClick = true;
            this.focusModeToolStripMenuItem.Name = "focusModeToolStripMenuItem";
            this.focusModeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.focusModeToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.focusModeToolStripMenuItem.Text = "Focus Mode";
            this.focusModeToolStripMenuItem.Click += new System.EventHandler(this.focusModeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(258, 6);
            // 
            // toggleFullscreenToolStripMenuItem
            // 
            this.toggleFullscreenToolStripMenuItem.Name = "toggleFullscreenToolStripMenuItem";
            this.toggleFullscreenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.toggleFullscreenToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.toggleFullscreenToolStripMenuItem.Text = "Toggle Full Screen";
            this.toggleFullscreenToolStripMenuItem.Click += new System.EventHandler(this.toggleFullscreenToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // lblToggleBtn
            // 
            this.lblToggleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.lblToggleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblToggleBtn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToggleBtn.ForeColor = System.Drawing.Color.White;
            this.lblToggleBtn.Location = new System.Drawing.Point(377, 88);
            this.lblToggleBtn.Name = "lblToggleBtn";
            this.lblToggleBtn.Size = new System.Drawing.Size(125, 23);
            this.lblToggleBtn.TabIndex = 9;
            this.lblToggleBtn.Text = "Toggle Sidebar";
            this.lblToggleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHistoryBtn
            // 
            this.lblHistoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHistoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.lblHistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHistoryBtn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryBtn.ForeColor = System.Drawing.Color.White;
            this.lblHistoryBtn.Location = new System.Drawing.Point(1045, 88);
            this.lblHistoryBtn.Name = "lblHistoryBtn";
            this.lblHistoryBtn.Size = new System.Drawing.Size(80, 23);
            this.lblHistoryBtn.TabIndex = 10;
            this.lblHistoryBtn.Text = "History";
            this.lblHistoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaveBtn
            // 
            this.lblSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.lblSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSaveBtn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveBtn.ForeColor = System.Drawing.Color.White;
            this.lblSaveBtn.Location = new System.Drawing.Point(1112, 88);
            this.lblSaveBtn.Name = "lblSaveBtn";
            this.lblSaveBtn.Size = new System.Drawing.Size(60, 23);
            this.lblSaveBtn.TabIndex = 11;
            this.lblSaveBtn.Text = "Save";
            this.lblSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrashBtn
            // 
            this.lblTrashBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrashBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.lblTrashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTrashBtn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrashBtn.ForeColor = System.Drawing.Color.White;
            this.lblTrashBtn.Location = new System.Drawing.Point(1163, 88);
            this.lblTrashBtn.Name = "lblTrashBtn";
            this.lblTrashBtn.Size = new System.Drawing.Size(60, 23);
            this.lblTrashBtn.TabIndex = 12;
            this.lblTrashBtn.Text = "Trash";
            this.lblTrashBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfoBtn
            // 
            this.lblInfoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.lblInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfoBtn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoBtn.ForeColor = System.Drawing.Color.White;
            this.lblInfoBtn.Location = new System.Drawing.Point(1217, 88);
            this.lblInfoBtn.Name = "lblInfoBtn";
            this.lblInfoBtn.Size = new System.Drawing.Size(56, 23);
            this.lblInfoBtn.TabIndex = 13;
            this.lblInfoBtn.Text = "Info";
            this.lblInfoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlText
            // 
            this.pnlText.BackgroundImage = global::Simplenote.Properties.Resources.pencil;
            this.pnlText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlText.Controls.Add(this.txtMain);
            this.pnlText.Controls.Add(this.flowTag);
            this.pnlText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlText.Location = new System.Drawing.Point(0, 68);
            this.pnlText.Margin = new System.Windows.Forms.Padding(0);
            this.pnlText.Name = "pnlText";
            this.pnlText.Padding = new System.Windows.Forms.Padding(30, 30, 30, 10);
            this.pnlText.Size = new System.Drawing.Size(880, 780);
            this.pnlText.TabIndex = 1;
            this.pnlText.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlText_Paint);
            // 
            // txtMain
            // 
            this.txtMain.BackColor = System.Drawing.Color.White;
            this.txtMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMain.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMain.HideSelection = false;
            this.txtMain.Location = new System.Drawing.Point(30, 30);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(820, 710);
            this.txtMain.TabIndex = 2;
            this.txtMain.Text = "";
            this.txtMain.Visible = false;
            this.txtMain.TextChanged += new System.EventHandler(this.richText_TextChanged);
            this.txtMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richText_KeyDown);
            // 
            // flowTag
            // 
            this.flowTag.AutoScroll = true;
            this.flowTag.AutoSize = true;
            this.flowTag.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowTag.BackColor = System.Drawing.Color.White;
            this.flowTag.Controls.Add(this.txtTag);
            this.flowTag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.flowTag.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowTag.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowTag.Location = new System.Drawing.Point(30, 740);
            this.flowTag.Margin = new System.Windows.Forms.Padding(0);
            this.flowTag.MaximumSize = new System.Drawing.Size(0, 90);
            this.flowTag.Name = "flowTag";
            this.flowTag.Padding = new System.Windows.Forms.Padding(5);
            this.flowTag.Size = new System.Drawing.Size(820, 30);
            this.flowTag.TabIndex = 1;
            this.flowTag.Visible = false;
            this.flowTag.Click += new System.EventHandler(this.flowTag_Click);
            // 
            // btnTrash
            // 
            this.btnTrash.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTrash.BackColor = System.Drawing.Color.Transparent;
            this.btnTrash.BackgroundImage = global::Simplenote.Properties.Resources.delete__1_;
            this.btnTrash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTrash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrash.FlatAppearance.BorderSize = 0;
            this.btnTrash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTrash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrash.Location = new System.Drawing.Point(776, 18);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Size = new System.Drawing.Size(32, 32);
            this.btnTrash.TabIndex = 7;
            this.btnTrash.UseVisualStyleBackColor = false;
            this.btnTrash.Visible = false;
            this.btnTrash.Click += new System.EventHandler(this.btnTrash_Click);
            this.btnTrash.MouseLeave += new System.EventHandler(this.btnTrash_MouseLeave);
            this.btnTrash.MouseHover += new System.EventHandler(this.btnTrash_MouseHover);
            // 
            // btnHistory
            // 
            this.btnHistory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.BackgroundImage = global::Simplenote.Properties.Resources.history;
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Location = new System.Drawing.Point(672, 18);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(32, 32);
            this.btnHistory.TabIndex = 6;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Visible = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            this.btnHistory.MouseLeave += new System.EventHandler(this.btnHistory_MouseLeave);
            this.btnHistory.MouseHover += new System.EventHandler(this.btnHistory_MouseHover);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::Simplenote.Properties.Resources.save_file;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(724, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 32);
            this.btnSave.TabIndex = 5;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnShare_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btnShare_MouseHover);
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BackgroundImage = global::Simplenote.Properties.Resources.information;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(828, 18);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(32, 32);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Visible = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            this.btnInfo.MouseLeave += new System.EventHandler(this.btnInfo_MouseLeave);
            this.btnInfo.MouseHover += new System.EventHandler(this.btnInfo_MouseHover);
            // 
            // btnSidebar
            // 
            this.btnSidebar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSidebar.BackColor = System.Drawing.Color.Transparent;
            this.btnSidebar.BackgroundImage = global::Simplenote.Properties.Resources.image;
            this.btnSidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSidebar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSidebar.FlatAppearance.BorderSize = 0;
            this.btnSidebar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSidebar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSidebar.Location = new System.Drawing.Point(10, 18);
            this.btnSidebar.Name = "btnSidebar";
            this.btnSidebar.Size = new System.Drawing.Size(56, 32);
            this.btnSidebar.TabIndex = 3;
            this.btnSidebar.UseVisualStyleBackColor = false;
            this.btnSidebar.Visible = false;
            this.btnSidebar.Click += new System.EventHandler(this.btnSidebar_Click);
            this.btnSidebar.MouseLeave += new System.EventHandler(this.btnSidebar_MouseLeave);
            this.btnSidebar.MouseHover += new System.EventHandler(this.btnSidebar_MouseHover);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = global::Simplenote.Properties.Resources.plus;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(354, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.BackgroundImage = global::Simplenote.Properties.Resources.menu__2_;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(14, 18);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(32, 32);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnMenu.MouseLeave += new System.EventHandler(this.btnMenu_MouseLeave);
            this.btnMenu.MouseHover += new System.EventHandler(this.btnMenu_MouseHover);
            // 
            // pinCheckbox
            // 
            this.pinCheckbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.pinCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.pinCheckbox.BackgroundImage = global::Simplenote.Properties.Resources.OFF;
            this.pinCheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pinCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pinCheckbox.FlatAppearance.BorderSize = 0;
            this.pinCheckbox.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.pinCheckbox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.pinCheckbox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.pinCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pinCheckbox.Location = new System.Drawing.Point(260, 24);
            this.pinCheckbox.Name = "pinCheckbox";
            this.pinCheckbox.Size = new System.Drawing.Size(37, 37);
            this.pinCheckbox.TabIndex = 1;
            this.pinCheckbox.UseVisualStyleBackColor = false;
            this.pinCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtTag
            // 
            this.txtTag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTag.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTag.Location = new System.Drawing.Point(6, 6);
            this.txtTag.Margin = new System.Windows.Forms.Padding(1);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(110, 18);
            this.txtTag.TabIndex = 0;
            this.txtTag.watermark = "";
            this.txtTag.TextChanged += new System.EventHandler(this.txtTag_TextChanged);
            this.txtTag.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTag_KeyUp);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(60, 19);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 27);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.watermark = "";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtTagSearch
            // 
            this.txtTagSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTagSearch.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtTagSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTagSearch.Location = new System.Drawing.Point(0, 0);
            this.txtTagSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtTagSearch.Name = "txtTagSearch";
            this.txtTagSearch.Size = new System.Drawing.Size(0, 27);
            this.txtTagSearch.TabIndex = 0;
            this.txtTagSearch.watermark = "Search Tag";
            this.txtTagSearch.TextChanged += new System.EventHandler(this.txtTagSearch_TextChanged);
            // 
            // UTEnote
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 878);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.lblToggleBtn);
            this.Controls.Add(this.lblHistoryBtn);
            this.Controls.Add(this.lblSaveBtn);
            this.Controls.Add(this.lblTrashBtn);
            this.Controls.Add(this.lblInfoBtn);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.MinimumSize = new System.Drawing.Size(940, 620);
            this.Name = "UTEnote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTEnote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UTEnote_FormClosing);
            this.Load += new System.EventHandler(this.UTEnote_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.pnlMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlSubmenu2.ResumeLayout(false);
            this.pnlDelete.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.flowNoteList.ResumeLayout(false);
            this.pnlSubmenu1.ResumeLayout(false);
            this.pnlSubmenu1.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.pnlText.ResumeLayout(false);
            this.pnlText.PerformLayout();
            this.flowTag.ResumeLayout(false);
            this.flowTag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.Timer timerInfo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAllNotes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlSubmenu1;
        private System.Windows.Forms.FlowLayoutPanel flowNoteList;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlSubmenu2;
        private System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel flowTag;
        private System.Windows.Forms.Button btnCloseInfo;
        private System.Windows.Forms.RichTextBox txtMain;
        private TextBoxWithWatermark txtSearch;
        private System.Windows.Forms.Button btnSidebar;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnTrash;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem sortTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem searchNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem focusModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toggleFullscreenToolStripMenuItem;
        private System.Windows.Forms.Label lblNoNote;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCharCount;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Label lblModified;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowTagOnMenu;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox pinCheckbox;
        private System.Windows.Forms.Label lblNewNoteBtn;
        private System.Windows.Forms.Label lblMenuBtn;
        private System.Windows.Forms.Label lblToggleBtn;
        private System.Windows.Forms.Label lblHistoryBtn;
        private System.Windows.Forms.Label lblSaveBtn;
        private System.Windows.Forms.Label lblTrashBtn;
        private System.Windows.Forms.Label lblInfoBtn;
        private TextBoxWithWatermark txtTag;
        private System.Windows.Forms.Button btnTrashOnMenu;
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.Button btnDeleteForever;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.Button btnRestoreAll;
        private TextBoxWithWatermark txtTagSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

