using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuComponentLibrary.Models
{
    public class MenuItem
    {
        public string Text { get; set; }
        public string Icon { get; set; }
        public bool IsExpanded { get; set; }
        public IEnumerable<MenuItem>? MenuItems { get; set; }
    }
}
