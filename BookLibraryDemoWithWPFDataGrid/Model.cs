using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryDemoWithWPFDataGrid
{
    public class Book
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string Genre { get; set; }
        public int PublishedYear { get; set; }
        public bool IsAvailable { get; set; }
        public string ReturnTimeline { get; set; }
    }

}
