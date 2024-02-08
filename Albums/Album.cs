using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albums
{
    /// <summary>
    /// A class of "Information Holder" objects that represent 
    /// simple Albums by aggregating their basic properties.
    /// </summary>
    public class Album
    {
        public int AlbumId { get; set; }

        public string BandOrArtistName { get; set; }

        public string Title { get; set; }

        public int? YearProduced { get; set; }

        public override string ToString()
        {
            if (YearProduced == null)
                return Title;
            else
                return $"{Title} ({YearProduced})";
        }
    }
}
