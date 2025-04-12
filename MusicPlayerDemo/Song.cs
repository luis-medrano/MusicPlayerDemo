using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerDemo
{
    public class Song
    {
        private string _album;
        public string Album
        {
            get { return _album; }
            set { this._album = value; }
        }
        private string _title;
        public string Title
        {
            get { return _title; }
            set { this._title = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { this._description = value; }
        }
        private string _genre;
        public string Genre
        {
            get { return _genre; }
            set { this._genre = value; }
        }

        public double amount;

        public Song(string album, string title, string description, string genre)
        {
            _album = album;
            _title = title;
            _description = description;
            _genre = genre;
        }

        public double getAmount(double amount)
        {
            if (amount < 0)
            {
                throw new Exception("Error");
            }
            return amount;
        }
    }
}
