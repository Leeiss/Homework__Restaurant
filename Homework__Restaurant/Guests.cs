using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Security.Policy;

namespace Homework__Restaurant
{
    internal class Guests
    {
        public string Name { get; set; }
        public int Table { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
        public string Event { get; set; }
    }
}
