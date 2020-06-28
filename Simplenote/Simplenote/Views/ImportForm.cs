using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simplenote.Models;
using Simplenote.Controllers;

namespace Simplenote.Views
{
    public partial class ImportForm : Form
    {
        public List<Note> NoteList;
        public List<string> tags;
        public ImportForm()
        {
            NoteList = new List<Note>();
            tags = new List<string>();
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xmlBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open XML file";
                dlg.Filter = "XML files|*.xml";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string file = dlg.FileName;
                    try
                    {
                        NoteList = XMLController.importXML(file, ref tags);
                    }
                    catch
                    {
                    }
                    label2.Visible = false;
                    panel3.Visible = false;
                    if (NoteList.Count == 0)
                    {
                        lblMessage.Text = "Tệp trống hoặc bị hỏng!";
                        lblMessage.ForeColor = Color.FromArgb(255, 128, 128);
                    }
                    else
                    {
                        lblMessage.Text = "Đã thêm " + NoteList.Count + " note!";
                        lblMessage.ForeColor = SystemColors.ControlDarkDark;
                    }
                }
            }
        }

        private void txtBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open text file";
                dlg.Filter = "TXT files|*.txt";
                dlg.Multiselect = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (String file in dlg.FileNames)
                    {
                        try
                        {
                            using (StreamReader stream = new StreamReader(file))
                            {
                                Note note = new Note();
                                string filename = Path.GetFileNameWithoutExtension(file).Trim();
                                string text = stream.ReadToEnd();
                                if (new StringReader(text).ReadLine().Trim() == filename)
                                    note.ContentText = text;
                                else
                                    note.ContentText = filename + "\n" + text;
                                NoteList.Add(note);
                            }
                        }
                        catch
                        {
                        }
                        label2.Visible = false;
                        panel3.Visible = false;
                        if (NoteList.Count == 0)
                        {
                            lblMessage.Text = "Tệp bị hỏng!";
                            lblMessage.ForeColor = Color.FromArgb(255, 128, 128);
                        }
                        else
                        {
                            lblMessage.Text = "Đã thêm " + NoteList.Count + " note!";
                            lblMessage.ForeColor = SystemColors.ControlDarkDark;
                        }
                    }
                }
            }
        }
    }
}
