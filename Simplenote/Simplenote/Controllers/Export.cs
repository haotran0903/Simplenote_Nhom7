using Simplenote.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplenote.Controllers
{
    public static class Export
    {
        public static void ExportNotes(List<Note> NoteList, List<string> tags)
        {

            using (FolderBrowserDialog fbd = new FolderBrowserDialog())        
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string savePath = Path.Combine(fbd.SelectedPath, "notes.zip");
                    if (File.Exists(savePath))
                    {
                        if (MessageBox.Show("notes.zip already exists.\nDo you want to replace it?"
                            , "Confirm Save As", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            File.Delete(savePath);
                        else
                            return;
                    }
                    string tempFolder = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                    Directory.CreateDirectory(tempFolder);
                    Directory.CreateDirectory(Path.Combine(tempFolder, "source"));
                    XMLController.saveData(NoteList, tags, Path.Combine(tempFolder, "source"));
                    foreach (Note note in NoteList)
                    {
                        if (note.ContentText.Trim() == "")
                            continue;
                        if (note.isDeleted)
                        {
                            if (!Directory.Exists(Path.Combine(tempFolder, "trash")))
                                Directory.CreateDirectory(Path.Combine(tempFolder, "trash"));
                            string fileName = note.NoteName.Replace("\r\n", "").Replace("\r", "").Replace("\n", "")
                                .Replace(@"\", "").Replace(@"/", "").Replace(@":", "").Replace(@"*", "").Replace(@"?", "")
                                .Replace("\"", "").Replace(@"<", "").Replace(@">", "").Replace(@"|", "");
                            string textPath = Path.Combine(tempFolder, "trash", fileName + ".txt");
                            for (int i = 1; ; i++)
                            {
                                if (!File.Exists(textPath))
                                    break;
                                textPath = Path.Combine(tempFolder, "trash", fileName + "(" + i + ")" + ".txt");
                            }
                            using (StreamWriter file = File.CreateText(textPath))
                            {
                                file.Write(note.ContentText);
                            }

                        }
                        else
                        {
                            string fileName = note.NoteName.Replace("\r\n", "").Replace("\r", "").Replace("\n", "")
                                .Replace(@"\", "").Replace(@"/", "").Replace(@":", "").Replace(@"*", "").Replace(@"?", "")
                                .Replace("\"", "").Replace(@"<", "").Replace(@">", "").Replace(@"|", "");
                            string textPath = Path.Combine(tempFolder, fileName + ".txt");

                            for (int i = 1; ; i++)
                            {
                                if (!File.Exists(textPath))
                                    break;
                                textPath = Path.Combine(tempFolder, fileName + "(" + i + ")" + ".txt");
                            }
                            using (StreamWriter file = File.CreateText(textPath))
                            {
                                file.Write(note.ContentText);
                            }
                        }
                    }
                    ZipFile.CreateFromDirectory(tempFolder, savePath);
                    Directory.Delete(tempFolder, true);
                }
            }
        }
    }
}
