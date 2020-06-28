using Simplenote.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Simplenote.Controllers
{
    public static class XMLController
    {
        public static void loadData(ref List<Note> NoteList, ref List<string> tags)
        {
            if (!File.Exists("Data.xml"))
            {
                return;
            }
            XmlDocument dataXML = new XmlDocument();
            try
            {
                dataXML.Load("Data.xml");
                XmlNodeList notelistXML = dataXML.SelectNodes("/Notes/Note");
                foreach (XmlNode noteXML in notelistXML)
                {
                    try
                    {
                        var note = new Note();
                        note.ContentText = noteXML.SelectSingleNode("Content").InnerText;
                        note.datecreated = DateTime.Parse(noteXML.SelectSingleNode("DateCreated").InnerText);
                        note.datemodified = DateTime.Parse(noteXML.SelectSingleNode("DateModified").InnerText);
                        note.check.Checked = bool.Parse(noteXML.SelectSingleNode("IsPinned").InnerText);
                        note.isDeleted = bool.Parse(noteXML.SelectSingleNode("IsDeleted").InnerText);
                        XmlNodeList tagsXML = noteXML.SelectNodes("Tags/tag");
                        foreach (XmlNode tagXML in tagsXML)
                            note.tags.Add(tagXML.InnerText);
                        XmlNodeList historiesXML = noteXML.SelectNodes("Histories/History");
                        foreach (XmlNode historyXML in historiesXML)
                        {
                            History history = new History();
                            history.ContentText = historyXML.SelectSingleNode("Content").InnerText;
                            history.time = DateTime.Parse(historyXML.SelectSingleNode("Time").InnerText);
                            history.Tags = new List<string>();
                            XmlNodeList historytagsXML = historyXML.SelectNodes("Tags/tag");
                            foreach (XmlNode tag in historytagsXML)
                                history.Tags.Add(tag.InnerText);
                            note.history.Add(history);
                        }
                        NoteList.Add(note);
                    }
                    catch { }
                }
                XmlNodeList taglistXML = dataXML.SelectNodes("/Notes/Tags/tag");
                foreach (XmlNode tagXML in taglistXML)
                    try
                    {
                        tags.Add(tagXML.InnerText);
                    }
                    catch { }
            }
            catch { }
        }
        public static void saveData(List<Note> NoteList, List<string> tags)
        {
            XDocument dataXML = new XDocument(new XElement("Notes"));
            foreach (Note note in NoteList)
            {
                XElement noteEle = new XElement("Note",
                    new XElement("Content", note.ContentText),
                    new XElement("DateCreated", note.datecreated),
                    new XElement("DateModified", note.datemodified),
                    new XElement("IsPinned", note.check.Checked),
                    new XElement("IsDeleted", note.isDeleted),
                    new XElement("Tags"),
                    new XElement("Histories"));
                foreach (string tag in note.tags)
                    noteEle.Element("Tags").Add(new XElement("tag", tag));
                foreach (History history in note.history)
                {
                    XElement historyEle = new XElement("History",
                        new XElement("Content", history.ContentText),
                        new XElement("Time", history.time),
                        new XElement("Tags"));
                    if (history.Tags != null)
                        foreach (string tag in history.Tags)
                            historyEle.Element("Tags").Add(new XElement("tag", tag));
                    noteEle.Element("Histories").Add(historyEle);
                }
                dataXML.Element("Notes").Add(noteEle);
            }
            XElement tagEle = new XElement("Tags");
            foreach (string tag in tags)
                tagEle.Add(new XElement("tag", tag));
            dataXML.Element("Notes").Add(tagEle);
            dataXML.Save("Data.xml");
        }
        public static void saveData(List<Note> NoteList, List<string> tags, string path)
        {
            XDocument dataXML = new XDocument(new XElement("Notes"));
            foreach (Note note in NoteList)
            {
                XElement noteEle = new XElement("Note",
                    new XElement("Content", note.ContentText),
                    new XElement("DateCreated", note.datecreated),
                    new XElement("DateModified", note.datemodified),
                    new XElement("IsPinned", note.check.Checked),
                    new XElement("IsDeleted", note.isDeleted),
                    new XElement("Tags"),
                    new XElement("Histories"));
                foreach (string tag in note.tags)
                    noteEle.Element("Tags").Add(new XElement("tag", tag));
                foreach (History history in note.history)
                {
                    XElement historyEle = new XElement("History",
                        new XElement("Content", history.ContentText),
                        new XElement("Time", history.time),
                        new XElement("Tags"));
                    if (history.Tags != null)
                        foreach (string tag in history.Tags)
                            historyEle.Element("Tags").Add(new XElement("tag", tag));
                    noteEle.Element("Histories").Add(historyEle);
                }
                dataXML.Element("Notes").Add(noteEle);
            }
            XElement tagEle = new XElement("Tags");
            foreach (string tag in tags)
                tagEle.Add(new XElement("tag", tag));
            dataXML.Element("Notes").Add(tagEle);
            dataXML.Save(Path.Combine(path, "Data.xml"));
        }
        public static List<Note> importXML(string path, ref List<string> tags)
        {
            List<Note> NoteList = new List<Note>();
            XmlDocument dataXML = new XmlDocument();
            try
            {
                dataXML.Load(path);
                XmlNodeList notelistXML = dataXML.SelectNodes("/Notes/Note");
                foreach (XmlNode noteXML in notelistXML)
                {
                    try
                    {
                        var note = new Note();
                        note.ContentText = noteXML.SelectSingleNode("Content").InnerText;
                        note.datecreated = DateTime.Parse(noteXML.SelectSingleNode("DateCreated").InnerText);
                        note.datemodified = DateTime.Parse(noteXML.SelectSingleNode("DateModified").InnerText);
                        note.check.Checked = bool.Parse(noteXML.SelectSingleNode("IsPinned").InnerText);
                        note.isDeleted = bool.Parse(noteXML.SelectSingleNode("IsDeleted").InnerText);
                        XmlNodeList tagsXML = noteXML.SelectNodes("Tags/tag");
                        foreach (XmlNode tagXML in tagsXML)
                            note.tags.Add(tagXML.InnerText);
                        NoteList.Add(note);
                    }
                    catch { }
                }
                XmlNodeList taglistXML = dataXML.SelectNodes("/Notes/Tags/tag");
                foreach (XmlNode tagXML in taglistXML)
                    try
                    {
                        tags.Add(tagXML.InnerText);
                    }
                    catch { }
            }
            catch
            {
                return new List<Note>();
            }
            return NoteList;
        }

    }
}
