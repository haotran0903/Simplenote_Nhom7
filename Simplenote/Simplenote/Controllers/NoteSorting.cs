using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simplenote.Views;
using Simplenote.Models;

namespace Simplenote.Controllers
{
    public static class NoteSorting
    {
        private static List<Note> getNotes(List<Note> list, string sort)
        {
            List<Note> sortedList = new List<Note>();
            switch (sort)
            {
                case "created":
                    sortedList = list.OrderBy(x => !x.check.Checked).ToList();
                    return sortedList;
                case "modified":
                    sortedList = list.OrderBy(x => !x.check.Checked).ThenByDescending(x => x.datemodified).ToList();
                    return sortedList;
                case "alphabet":
                    sortedList = list.OrderBy(x => !x.check.Checked).ThenBy(x => x.NoteName != "New Note...")
                        .ThenBy(x => x.NoteName).ToList();
                    return sortedList;
            }
            return null;
        }
        public static List<Note> getAllNotes(List<Note> list, string sort)
        {
            return getNotes(list, sort).Where(x => x.isDeleted == false).ToList();
        }

        public static List<Note> getDeletedNotes(List<Note> list, string sort)
        {
            return getNotes(list, sort).Where(x => x.isDeleted == true).ToList();
        }
        public static List<Note> getNotesWithTag(List<Note> list, string sort, string tag)
        {
            return getNotes(list, sort).Where(x => x.tags.Contains(tag) && x.isDeleted == false).ToList();
        }
        public static int getNoteIndex(List<Note> list, Note note, string sort, string tag = null)
        {
            if (tag != null)
                return getNotesWithTag(list, sort, tag).IndexOf(note);
            else
                return getAllNotes(list, sort).IndexOf(note);
        }
    }
}
