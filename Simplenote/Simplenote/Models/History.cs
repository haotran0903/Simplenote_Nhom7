using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplenote.Models
{
    public class History
    {
        public string ContentText { get; set; }
        public List<string> Tags { get; set; }
        public DateTime time { get; set; }
    }
}
