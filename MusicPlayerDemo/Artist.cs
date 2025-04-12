using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerDemo
{
    public class Artist
    {
        public string name { get; set; }
        public string genre { get; set; }
        public string album { get; set; }
        public string recordLabel { get; set; }

        public int GrammyAward { get; set; }

        public Artist(string name, string genre, string album, string recordLabel, int GrammyAward)
        {
            this.name = name;
            this.genre = genre;
            this.album = album;
            this.recordLabel = recordLabel;
            this.GrammyAward = GrammyAward;
        }
    }
}
