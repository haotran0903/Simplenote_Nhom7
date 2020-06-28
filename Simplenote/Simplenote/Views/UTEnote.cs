using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Simplenote.Models;
using Simplenote.Controllers;
using System.IO.Compression;


namespace Simplenote.Views
{
    public partial class UTEnote : Form
    {
        private Note currentNote;
        private bool isMenuToggled;
        private bool isInfoToggled;
        private bool isSidebarToggled;
        private List<string> tags;
        private List<Note> NoteList;
        private string sort;
        private string currentTag
        {
            get { return txtSearch.watermark; }
            set
            {
                txtSearch.watermark = value;
                if (value == "Delete")
                {
                    btnAdd.Visible = false;
                    txtMain.ReadOnly = true;
                }
                else
                {
                    btnAdd.Visible = true;
                    txtMain.ReadOnly = false;
                }
                DisplayNote();
            }
        }
        private bool IsSidebarToggled
        {
            get { return isSidebarToggled; }
            set
            {
                if (value == false)
                {
                    isSidebarToggled = false;
                    pnlLeft.Width = 0;
                    lblToggleBtn.Location = new Point(0, 88);
                    btnSidebar.BackgroundImage = Properties.Resources.right_arrow;
                    focusModeToolStripMenuItem.Checked = true;
                }
                if (value == true)
                {
                    isSidebarToggled = true;
                    pnlLeft.Width = 400;
                    lblToggleBtn.Location = new Point(377, 88);
                    btnSidebar.BackgroundImage = Properties.Resources.image;
                    focusModeToolStripMenuItem.Checked = false;
                }
            }
        }
        public UTEnote()
        {
            InitializeComponent();
            txtTag.watermark = "Add a tag...";
            sort = "created";
            isMenuToggled = false;
            isInfoToggled = false;
            IsSidebarToggled = true;
            tags = new List<string>();
            txtSearch.watermark = "All Notes";
            NoteList = new List<Note>();
            ToolStripRadioButtonMenuItem datemod = new ToolStripRadioButtonMenuItem("Date modified");
            ToolStripRadioButtonMenuItem datecreate = new ToolStripRadioButtonMenuItem("Date created");
            ToolStripRadioButtonMenuItem alphabetical = new ToolStripRadioButtonMenuItem("Alphabetical");
            datecreate.Checked = true;
            datemod.Click += Datemod_Click;
            datecreate.Click += Datecreate_Click;
            alphabetical.Click += Alphabetical_Click;
            sortTypeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { datemod, datecreate, alphabetical });
        }

        private void UTEnote_Load(object sender, EventArgs e)
        {
            XMLController.loadData(ref NoteList, ref tags);
            foreach (Note note in NoteList)
            {
                note.Click += Note_Click;
                note.check.CheckedChanged += Check_CheckedChanged;
            }
            DisplayNote();
        }
        private void Alphabetical_Click(object sender, EventArgs e)
        {
            sort = "alphabet";
            DisplayNote();
        }

        private void Datecreate_Click(object sender, EventArgs e)
        {
            sort = "created";
            DisplayNote();
        }

        private void Datemod_Click(object sender, EventArgs e)
        {
            sort = "modified";
            DisplayNote();
        }
        #region animation
        //Mo menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
            pnlMain.Enabled = false;
            flowTagOnMenu.Controls.Clear();
            if (tags.Count > 0)
            {
                if (!sortToolStripMenuItem.Checked)
                {
                    foreach (string tag in tags)
                    {
                        Label lblTag = CreateTagOnMenu();
                        lblTag.Text = tag;
                        flowTagOnMenu.Controls.Add(lblTag);
                    }
                }
                else
                {
                    List<string> sortedTags = tags.OrderBy(x => x).ToList();
                    foreach (string tag in sortedTags)
                    {
                        Label lblTag = CreateTagOnMenu();
                        lblTag.Text = tag;
                        flowTagOnMenu.Controls.Add(lblTag);
                    }
                }
            }
            if (currentTag == "All Notes")
                btnAllNotes.ForeColor = Color.FromArgb(164, 194, 247);
            else btnAllNotes.ForeColor = Color.Black;
            if (currentTag == "Delete")
                btnTrashOnMenu.ForeColor = Color.FromArgb(164, 194, 247);
            else btnTrashOnMenu.ForeColor = Color.Black;
            if (currentTag != "All Notes" && currentTag != "Delete")
            {
                foreach (Label lbl in flowTagOnMenu.Controls)
                    if (lbl.Text == currentTag)
                    {
                        lbl.ForeColor = Color.FromArgb(164, 194, 247);
                        break;
                    }
            }
            else
                foreach (Label lbl in flowTagOnMenu.Controls)
                    lbl.ForeColor = Color.Black;
        }
        private Label CreateTagOnMenu()
        {
            Label tag = new Label();
            tag.Click += Label_Click;
            tag.Cursor = Cursors.Hand;
            tag.Margin = new Padding(25, 1, 10, 15);
            tag.Height = 32;
            tag.Width = 235;
            tag.Font = new Font("Consolas", 11);
            tag.TextAlign = ContentAlignment.MiddleLeft;
            //
            Button deleteTag = new Button();
            deleteTag.Margin = new Padding(0, 1, 0, 1);
            deleteTag.Dock = DockStyle.Right;
            deleteTag.Size = new Size(32, 32);
            deleteTag.Click += DeleteTag_Click;
            deleteTag.BackgroundImage = Properties.Resources.error;
            deleteTag.FlatStyle = FlatStyle.Flat;
            deleteTag.BackgroundImageLayout = ImageLayout.Stretch;
            deleteTag.FlatAppearance.BorderSize = 0;
            deleteTag.Visible = true;

            tag.Controls.Add(deleteTag);
            return tag;
        }

        private void Tag_MouseLeave(object sender, EventArgs e)
        {
            if ((sender as Label).ClientRectangle.Contains((sender as Label).PointToClient(Cursor.Position)))
            {
                return;
            }
            (sender as Label).Controls[0].Visible = false;
        }

        private void Tag_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).Controls[0].Visible = true;
        }

        private void DeleteTag_Click(object sender, EventArgs e)
        {
            Label tag = (sender as Button).Parent as Label;
            tags.Remove(tag.Text);
            foreach (Note note in NoteList)
                note.tags.Remove(tag.Text);
            foreach (Control lbl in flowTag.Controls)
                if (lbl is Label && lbl.Text == tag.Text)
                {
                    lbl.Dispose();
                    break;
                }
            if (tag.Text == currentTag)
            {
                currentTag = "All Notes";
                btnAllNotes.ForeColor = Color.FromArgb(164, 194, 247);
            }
            tag.Dispose();
        }

        private void Label_Click(object sender, EventArgs e)
        {
            currentTag = (sender as Label).Text;
            timerMenu.Start();
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (!isMenuToggled)
            {
                pnlMenu.Width += 45;
                if (pnlMenu.Width == 270)
                {
                    isMenuToggled = true;
                    timerMenu.Stop();
                    return;
                }
            }
            else
            {
                pnlMenu.Width -= 45;
                if (pnlMenu.Width == 0)
                {
                    pnlMain.Enabled = true;
                    isMenuToggled = false;
                    timerMenu.Stop();
                    return;
                }
            }
        }
        //Mo info
        private void btnInfo_Click(object sender, EventArgs e)
        {
            timerInfo.Start();
            pnlMain.Enabled = false;
            lblModified.Text = currentNote.datemodified.ToString();
            lblCharCount.Text = txtMain.Text.Length.ToString() + " characters";
            int words = txtMain.Text.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries).Count();
            lblWordCount.Text = words.ToString() + " words";
            pinCheckbox.Checked = currentNote.check.Checked;
        }
        private void timerInfo_Tick(object sender, EventArgs e)
        {
            if (!isInfoToggled)
            {
                pnlInfo.Width += 55;
                if (pnlInfo.Width == 330)
                {
                    isInfoToggled = true;
                    timerInfo.Stop();
                    return;
                }
            }
            else
            {
                pnlInfo.Width -= 55;
                if (pnlInfo.Width == 0)
                {
                    pnlMain.Enabled = true;
                    isInfoToggled = false;
                    timerInfo.Stop();
                    return;
                }
            }
        }
        //Dong
        private void Form1_Click(object sender, EventArgs e)
        {
            if (isMenuToggled)
                timerMenu.Start();
            if (isInfoToggled)
                timerInfo.Start();
        }
        #endregion
        #region draw border
        //Vertical line - top
        private void pnlSubmenu2_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(164, 194, 247), 2);
            e.Graphics.DrawLine(pen, 0, 0, 0, pnlSubmenu2.Height);
        }
        //Horizontal line - left
        private void flowNoteList_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(164, 194, 247), 2);
            e.Graphics.DrawLine(pen, 0, 0, flowNoteList.Width, 0);
            e.Graphics.DrawLine(pen, 0, 0, 0, flowNoteList.Height);
        }
        //Horizontal line - right & Vertical line - bottom
        private void pnlText_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(164, 194, 247), 2);
            //Horizontal
            e.Graphics.DrawLine(pen, 0, 0, pnlText.Width, 0);
            //Vertical
            e.Graphics.DrawLine(pen, 0, 0, 0, pnlText.Height);
        }
        private void pnlDelete_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(164, 194, 247), 2);
            e.Graphics.DrawLine(pen, 0, 0, 0, pnlDelete.Height);
        }
        //Border menu
        private void pnlSubmenu1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(164, 194, 247), 2);
            e.Graphics.DrawLine(pen, 0, 0, 0, pnlSubmenu1.Height);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(164, 194, 247), 2);
            e.Graphics.DrawLine(pen, 0, 0, panel2.Width, 0);
        }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(164, 194, 247), 2);
            e.Graphics.DrawLine(pen, 0, 0, panel7.Width, 0);
        }
        //Border info
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(164, 194, 247), 2);
            e.Graphics.DrawLine(pen, 0, 0, 0, panel4.Height);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(164, 194, 247), 2);
            e.Graphics.DrawLine(pen, 0, 0, 0, panel5.Height);
            e.Graphics.DrawLine(pen, 0, 0, panel5.Width, 0);

        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(164, 194, 247), 2);
            e.Graphics.DrawLine(pen, 0, 0, 0, panel6.Height);
            e.Graphics.DrawLine(pen, 0, 0, panel6.Width, 0);
        }
        #endregion
        #region Tooltip
        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            lblNewNoteBtn.BringToFront();
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            lblNewNoteBtn.SendToBack();
        }

        private void btnMenu_MouseHover(object sender, EventArgs e)
        {
            lblMenuBtn.BringToFront();
        }

        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            lblMenuBtn.SendToBack();
        }

        private void btnSidebar_MouseHover(object sender, EventArgs e)
        {
            lblToggleBtn.BringToFront();
        }

        private void btnSidebar_MouseLeave(object sender, EventArgs e)
        {
            lblToggleBtn.SendToBack();
        }

        private void btnHistory_MouseHover(object sender, EventArgs e)
        {
            lblHistoryBtn.BringToFront();
        }

        private void btnHistory_MouseLeave(object sender, EventArgs e)
        {
            lblHistoryBtn.SendToBack();
        }

        private void btnShare_MouseHover(object sender, EventArgs e)
        {
            lblSaveBtn.BringToFront();
        }

        private void btnShare_MouseLeave(object sender, EventArgs e)
        {
            lblSaveBtn.SendToBack();
        }

        private void btnTrash_MouseHover(object sender, EventArgs e)
        {
            lblTrashBtn.BringToFront();
        }

        private void btnTrash_MouseLeave(object sender, EventArgs e)
        {
            lblTrashBtn.SendToBack();
        }

        private void btnInfo_MouseHover(object sender, EventArgs e)
        {
            lblInfoBtn.BringToFront();
        }

        private void btnInfo_MouseLeave(object sender, EventArgs e)
        {
            lblInfoBtn.SendToBack();
        }
        #endregion
        #region Edit
        private void searchNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.SelectAll();
        }
        #endregion
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            timerInfo.Start();
        }

        private void btnSidebar_Click(object sender, EventArgs e)
        {
            IsSidebarToggled = !IsSidebarToggled;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
                txtSearch.Text = "";
            Note note = new Note();
            NoteList.Insert(0, note);
            note.Click += Note_Click;
            note.check.CheckedChanged += Check_CheckedChanged;
            if (txtSearch.watermark != "All Notes" && txtSearch.watermark != "Delete")
                note.tags.Add(currentTag);
            if (flowNoteList.Controls.Contains(lblNoNote))
                flowNoteList.Controls.Remove(lblNoNote);
            flowNoteList.Controls.Add(note);
            note.BringToFront();
            if (currentTag == "All Notes")
                flowNoteList.Controls.SetChildIndex(note,
                    NoteSorting.getNoteIndex(NoteList, note, sort));
            else
                flowNoteList.Controls.SetChildIndex(note,
                    NoteSorting.getNoteIndex(NoteList, note, sort, currentTag));
            NoteClick(note);
            txtMain.Visible = true;
            flowTag.Visible = true;
            foreach (Control control in pnlSubmenu2.Controls)
                control.Visible = true;
            pnlDelete.Visible = false;
        }

        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            DisplayNote();
        }

        private void DisplayNote()
        {
            flowNoteList.Controls.Clear();
            List<Note> displayList;
            switch (currentTag)
            {
                case "All Notes":
                    displayList = NoteSorting.getAllNotes(NoteList, sort)
                        .Where(x => x.ContentText.Contains(txtSearch.Text)).ToList();
                    break;
                case "Delete":
                    displayList = NoteSorting.getDeletedNotes(NoteList, sort)
                        .Where(x => x.ContentText.Contains(txtSearch.Text)).ToList();
                    break;
                default:
                    displayList = NoteSorting.getNotesWithTag(NoteList, sort, currentTag)
                        .Where(x => x.ContentText.Contains(txtSearch.Text)).ToList();
                    break;
            }
            foreach (var note in displayList)
                flowNoteList.Controls.Add(note);
            if (displayList.Count == 0)
            {
                txtMain.Visible = false;
                if (!flowNoteList.Controls.Contains(lblNoNote))
                    flowNoteList.Controls.Add(lblNoNote);
            }
            if (displayList.Count > 0)
            {
                if (!txtMain.Visible)
                {
                    txtMain.Visible = true;
                    flowTag.Visible = true;
                    if (currentTag != "Delete")
                    {
                        foreach (Control control in pnlSubmenu2.Controls)
                            control.Visible = true;
                        pnlDelete.Visible = false;
                    }
                    else
                    {
                        foreach (Control control in pnlSubmenu2.Controls)
                            control.Visible = false;
                        pnlDelete.Visible = true;
                    }

                }
                NoteClick(flowNoteList.Controls[0] as Note);
            }
        }
        private void Note_Click(object sender, EventArgs e)
        {
            NoteClick(sender as Note);
        }
        private void NoteClick(Note note)
        {
            if (currentNote != null)
                currentNote.BackColor = Color.White;
            currentNote = note;
            currentNote.BackColor = Color.FromArgb(156, 191, 248);
            txtMain.Text = currentNote.ContentText;
            txtTag.Text = "";
            this.Text = "UTENote";
            if (!txtSearch.Focused)
            {
                txtMain.Focus();
                txtMain.SelectionStart = txtMain.Text.Length;
            }
            flowTag.Controls.Clear();
            flowTag.Controls.Add(txtTag);
            if (txtSearch.Text != "")
            {
                txtMain.Text = currentNote.ContentText;
                txtMain.Select(txtMain.Text.IndexOf(txtSearch.Text), txtSearch.Text.Length);
                txtMain.SelectionBackColor = Color.Yellow;
                txtMain.SelectionStart = txtMain.Text.Length;
            }
            foreach (string text in currentNote.tags)
            {
                Label tag = new Label();
                tag.Text = text;
                tag.Click += Tag_Click;
                tag.BackColor = Color.FromArgb(156, 191, 248);
                tag.AutoSize = true;
                tag.Margin = new Padding(2, 2, 2, 2);
                tag.Font = new Font("Consolas", 9.5f); ;
                tag.Cursor = Cursors.Hand;
                flowTag.Controls.Add(tag);
                flowTag.Controls.SetChildIndex(tag, flowTag.Controls.Count - 2);
                flowTag.ScrollControlIntoView(txtTag);
            }
        }
        private void richText_TextChanged(object sender, EventArgs e)
        {
            if (currentNote.ContentText == null)
            {
                currentNote.ContentText = txtMain.Text;
                return;
            }
            this.Text = "*UTENote";
            if (currentNote.ContentText.Trim().Split('\n').ToList()[0] !=
                txtMain.Text.Trim().Split('\n').ToList()[0])
                move();
            currentNote.ContentText = txtMain.Text;
            if (txtSearch.Text != "" && txtMain.Focused)
                txtSearch.Text = "";
        }
        private void move()
        {
            if (sort != "created")
            {
                int index = NoteSorting.getNoteIndex(NoteList, currentNote, sort);
                flowNoteList.Controls.SetChildIndex(currentNote, index);
            }
        }
        private void btnTrash_Click(object sender, EventArgs e)
        {
            if (currentNote == null)
                return;
            if (currentNote.ContentText.Trim() != "" || currentNote.tags.Any())
            {
                currentNote.isDeleted = true;
                flowNoteList.Controls.Remove(currentNote);
                if (!flowNoteList.Controls.Contains(lblNoNote) && flowNoteList.Controls.Count > 0)
                    NoteClick(flowNoteList.Controls[0] as Note);
            }
            else
            {
                flowNoteList.Controls.Remove(currentNote);
                NoteList.Remove(currentNote);
                currentNote.Dispose();
                if (!flowNoteList.Controls.Contains(lblNoNote) && flowNoteList.Controls.Count > 0)
                    NoteClick(flowNoteList.Controls[0] as Note);
            }
        }

        private void flowNoteList_ControlAdded(object sender, ControlEventArgs e)
        {
            if (flowNoteList.VerticalScroll.Visible == true)
                foreach (Control control in flowNoteList.Controls)
                    control.Width = 379;
        }

        private void flowNoteList_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (flowNoteList.VerticalScroll.Visible == false)
                foreach (Control control in flowNoteList.Controls)
                    control.Width = 400;
            if (flowNoteList.Controls.Count == 0 && txtMain.Visible)
            {
                flowNoteList.Controls.Add(lblNoNote);
                txtMain.Visible = false;
                flowTag.Visible = false;
                foreach (Control control in pnlSubmenu2.Controls)
                    control.Visible = false;
                pnlDelete.Visible = false;
            }
        }

        private void helpSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com");
        }

        private void flowNoteList_SizeChanged(object sender, EventArgs e)
        {
            lblNoNote.Width = flowNoteList.Width - 2;
            lblNoNote.Height = flowNoteList.Height - 2;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (pinCheckbox.Checked)
            {
                pinCheckbox.BackgroundImage = Properties.Resources.ON;
                currentNote.check.Checked = true;
            }
            else
            {
                pinCheckbox.BackgroundImage = Properties.Resources.OFF;
                currentNote.check.Checked = false;
            }
        }
        #region View
        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtMain.Visible == false || Math.Round(txtMain.ZoomFactor, 1) == 2)
                return;
            txtMain.ZoomFactor += 0.1f;
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtMain.Visible == false || Math.Round(txtMain.ZoomFactor, 1) == 0.7)
                return;
            txtMain.ZoomFactor -= 0.1f;
        }

        private void actualSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.ZoomFactor = 1;
        }

        private void focusModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsSidebarToggled = !IsSidebarToggled;
        }

        private void toggleFullscreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle != FormBorderStyle.None)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                return;
            }
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
        }
        #endregion

        private void txtTag_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTag.Width = 110;
                var Tags = txtTag.Text.Trim()
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (string text in Tags)
                {
                    if (currentNote.tags.Contains(text))
                        continue;
                    Label tag = new Label();
                    tag.Text = text;
                    tag.Click += Tag_Click;
                    tag.BackColor = Color.FromArgb(156, 191, 248);
                    tag.AutoSize = true;
                    tag.Margin = new Padding(2, 2, 2, 2);
                    tag.Font = new Font("Consolas", 9.5f);
                    if (!tags.Contains(text))
                        tags.Add(text);
                    tag.Cursor = Cursors.Hand;
                    flowTag.Controls.Add(tag);
                    flowTag.Controls.SetChildIndex(tag, flowTag.Controls.Count - 2);
                    txtTag.Text = "";
                    currentNote.tags.Add(text);
                    flowTag.ScrollControlIntoView(txtTag);
                    this.Text = "*UTENote";
                }
                txtTag.Text = "";
            }
        }

        private void Tag_Click(object sender, EventArgs e)
        {
            var label = sender as Label;
            flowTag.Controls.Remove(label);
            currentNote.tags.Remove(label.Text);
            if (currentTag == label.Text)
            {
                flowNoteList.Controls.Remove(currentNote);
                if (!flowNoteList.Controls.Contains(lblNoNote) && flowNoteList.Controls.Count > 0)
                    NoteClick(flowNoteList.Controls[0] as Note);
            }
            label.Dispose();
        }

        private void txtTag_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(txtTag.Text, txtTag.Font);
            if (size.Width < 110 || size.Width > 800)
                return;
            txtTag.Width = size.Width;
        }

        private void flowTag_Click(object sender, EventArgs e)
        {
            txtTag.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DisplayNote();
            if (txtMain.Visible)
                if (txtSearch.Text != "")
                {
                    txtMain.Text = currentNote.ContentText;
                    txtMain.Select(txtMain.Text.IndexOf(txtSearch.Text), txtSearch.Text.Length);
                    txtMain.SelectionBackColor = Color.Yellow;
                    txtMain.SelectionStart = txtMain.Text.Length;
                }
                else
                    txtMain.Text = currentNote.ContentText;
            if (flowNoteList.Controls.Count == 0)
                flowNoteList.Controls.Add(lblNoNote);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentTag = "All Notes";
            timerMenu.Start();

        }

        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
        }

        private void richText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                txtMain.Text += (string)Clipboard.GetData("Text");
                e.Handled = true;
            }
        }

        private void btnTrashTag_Click(object sender, EventArgs e)
        {
            currentTag = "Delete";
            timerMenu.Start();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (currentNote == null)
                return;
            currentNote.isDeleted = false;
            flowNoteList.Controls.Remove(currentNote);
            if (!flowNoteList.Controls.Contains(lblNoNote) && flowNoteList.Controls.Count > 0)
                NoteClick(flowNoteList.Controls[0] as Note);
        }

        private void btnDeleteForever_Click(object sender, EventArgs e)
        {
            if (currentNote == null)
                return;
            flowNoteList.Controls.Remove(currentNote);
            NoteList.Remove(currentNote);
            currentNote.Dispose();
            if (!flowNoteList.Controls.Contains(lblNoNote) && flowNoteList.Controls.Count > 0)
                NoteClick(flowNoteList.Controls[0] as Note);
        }

        private void importNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ImportForm importForm = new ImportForm())
            {
                importForm.FormClosed += ImportForm_FormClosed;
                importForm.StartPosition = FormStartPosition.CenterParent;
                importForm.ShowDialog();
            }
        }

        private void ImportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ImportForm form = sender as ImportForm;
            if (form.NoteList.Count > 0)
            {
                foreach (Note note in form.NoteList)
                {
                    NoteList.Add(note);
                    note.Click += Note_Click;
                    note.check.CheckedChanged += Check_CheckedChanged;
                }
                NoteList = NoteList.OrderByDescending(x => x.datecreated).ToList();
                currentTag = "All Notes";
            }
            if (form.tags.Count != 0)
                foreach (string tag in form.tags)
                    if (!tags.Contains(tag))
                        tags.Add(tag);
            form.Dispose();
            form = null;
        }

        private void exportNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export.ExportNotes(NoteList, tags);
        }
        bool checkSavable()
        {
            if (txtMain.Text == "" && currentNote.tags.Count == 0)
                return false;
            if (currentNote.history.Count > 0 && currentNote.history.Last().ContentText == currentNote.ContentText
                && currentNote.history.Last().Tags.SequenceEqual(currentNote.tags))
                return false;
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Text = "UTENote";
            if (!checkSavable())
                return;
            History history = new History();
            history.ContentText = txtMain.Text;
            history.Tags = new List<string>();
            foreach (string tag in currentNote.tags)
                history.Tags.Add(tag);
            history.time = DateTime.Now;
            if (currentNote.history.Count == 10)
            {
                currentNote.history.RemoveAt(0);
                currentNote.history.Add(history);
            }
            else
                currentNote.history.Add(history);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm(currentNote);
            historyForm.FormClosed += HistoryForm_FormClosed;
            historyForm.StartPosition = FormStartPosition.CenterParent;
            historyForm.ShowDialog();
        }

        private void HistoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HistoryForm historyForm = sender as HistoryForm;
            if (historyForm.history != null)
            {
                btnSave.PerformClick();
                currentNote.ContentText = historyForm.history.ContentText;
                currentNote.tags = new List<string>();
                foreach (string tag in historyForm.history.Tags)
                    currentNote.tags.Add(tag);
                NoteClick(currentNote);
            }
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            while (btnDeleteForever.Visible == true)
            {
                btnDeleteForever.PerformClick();
            }
        }

        private void btnRestoreAll_Click(object sender, EventArgs e)
        {
            while (btnRestore.Visible == true)
            {
                btnRestore.PerformClick();
            }
        }

        private void txtTagSearch_TextChanged(object sender, EventArgs e)
        {

            List<Control> searchTag = flowTagOnMenu.Controls.OfType<Control>()
                .Where(x => x.Text.Contains(txtTagSearch.Text)).ToList();
            List<Control> nosearchTag = flowTagOnMenu.Controls.OfType<Control>().Except(searchTag).ToList();
            foreach (Control control in searchTag)
                control.Visible = true;
            foreach (Control control in nosearchTag)
                control.Visible = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentNote != null)
                btnSave.PerformClick();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Help helpForm = new Help())
            {
                helpForm.ShowDialog();
            }
            
        }

        private void UTEnote_FormClosing(object sender, FormClosingEventArgs e)
        {
            XMLController.saveData(NoteList, tags);
        }

        private void flowTagList_ControlAdded(object sender, ControlEventArgs e)
        {
            if (flowTagOnMenu.VerticalScroll.Visible == true)
                foreach (Control control in flowTagOnMenu.Controls)
                    control.Width = 210;
        }

        private void flowTagList_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (flowTagOnMenu.VerticalScroll.Visible == false)
                foreach (Control control in flowTagOnMenu.Controls)
                    control.Width = 235;
        }
    }
}
