using Simplenote.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplenote.Views
{
    public partial class HistoryForm : Form
    {
        public History history;
        Note note;
        public HistoryForm(Note Note)
        {
            InitializeComponent();
            note = Note;
            historyTb.Maximum = note.history.Count;
            historyTb.Value = historyTb.Maximum;
            lblContent.Text = note.ContentText;
            string formTag = "";
            foreach (string noteTag in note.tags)
                formTag += noteTag + "\n";
            lblTag.Text = formTag;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void historyTb_Scroll(object sender, EventArgs e)
        {
            if (historyTb.Value == historyTb.Maximum)
            {
                timeLbl.Text = "Lasted";
                lblContent.Text = note.ContentText;
                string formTag = "";
                foreach (string noteTag in note.tags)
                    formTag += noteTag + "\n";
                lblTag.Text = formTag;
                btnRestore.Enabled = false;
            }
            else
            {
                timeLbl.Text = note.history[historyTb.Value].time.ToString();
                lblContent.Text = note.history[historyTb.Value].ContentText;
                string formTag = "";
                if (note.history[historyTb.Value].Tags != null)
                    foreach (string noteTag in note.history[historyTb.Value].Tags)
                        formTag += noteTag + "\n";
                lblTag.Text = formTag;
                btnRestore.Enabled = true;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            history = note.history[historyTb.Value];
            this.Close();
        }
    }
}
