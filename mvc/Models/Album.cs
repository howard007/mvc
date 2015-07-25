using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string title { get;set; }
        public virtual List<Artist> Artists { get; set; }
    }
}